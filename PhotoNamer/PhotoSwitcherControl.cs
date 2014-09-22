using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;
using System.Media;

namespace PhotoNamer
{
	public partial class PhotoSwitcherControl : UserControl
	{
		private const int MAX_CHARS = 260;

		private FileInfo[] imageFiles = null;

		//The index starts at -1 because it is incrememented when the load is called.
		private int curIndex = -1;

		private DirectoryInfo inputDir;
		private DirectoryInfo outputDir;
		private List<Tuple<string, string>> parameters;
		private String[] originalParamValues; 
		private string delimitor;
		private PhotoNamer.StartingControl.AppendType appendOldName;

		//That is a hack to deal with C# behavior that I don't understand.
		private Exception loadError;

		//Keep track of the textboxes so that their values can be reset
		//when the user goes onto the next photo.
		private TextBox[] paramTextBoxes;

		public PhotoSwitcherControl(
			DirectoryInfo inputDir,
			DirectoryInfo outputDir,
			List<Tuple<String, String>> parameters,
			String delimitor,
			PhotoNamer.StartingControl.AppendType appendOldName)
		{
			InitializeComponent();

			this.inputDir = inputDir;
			this.outputDir = outputDir;
			this.parameters = parameters;
			this.delimitor = delimitor;
			this.appendOldName = appendOldName;
			this.originalParamValues = parameters.Select((x) => x.Item2).ToArray();

			this.AutoSize = true;
			this.Dock = DockStyle.Fill;
			this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

			this.inputDirLbl.Text = "Input Directory: " + this.inputDir.FullName;
			this.outputDirLbl.Text = "Output Directory: " + this.outputDir.FullName;

			this.resultLabel.Paint += resultLabel_Paint;

			//Add a listener to the picture box that will check if the load failed
			//when the user tries to go to the next image.
			this.pictureBox.LoadCompleted += imageDoneLoading;

			//set up the parameter fields GUI.
			this.paramsPanel2.RowCount = parameters.Count;
			this.paramsPanel2.AutoScroll = true;
			this.paramTextBoxes = new TextBox[parameters.Count];
			for (int i = 0; i < parameters.Count; i++)
			{
				Label label = new Label();
				label.Text = parameters[i].Item1;

				TextBox textBox = new TextBox();
				textBox.Text = parameters[i].Item2;
				textBox.GotFocus += textBox_GotFocus;
				textBox.MouseUp += textBox_MouseUp;
				textBox.TextChanged += textBox_TextChanged;
				textBox.Tag = i;
				textBox.Width = 150;
				textBox.KeyPress += textBoxKeyPressed;

				this.paramTextBoxes[i] = textBox;

				this.paramsPanel2.Controls.Add(label, 0, i);
				this.paramsPanel2.Controls.Add(textBox, 1, i);
			}

			foreach (RowStyle row in this.paramsPanel2.RowStyles)
			{
				row.Height = 30;
			}

			this.imageFiles = this.inputDir.GetFiles()
				.Where(f => StartingControl.ACCEPTABLE_EXTENSIONS.Contains(f.Extension.ToLower()))
				.ToArray();
			this.loadNextImage();

			chooseToShowOverwriteWarning();
		}

		private void textBoxKeyPressed(object sender, KeyPressEventArgs e)
		{
			if ( !Char.IsControl(e.KeyChar) )
			{
				//Don't allow the user to enter invalid characters.
				if (Path.GetInvalidFileNameChars().Contains(e.KeyChar) ||
					Path.GetInvalidPathChars().Contains(e.KeyChar))
				{
					e.Handled = true;
					SystemSounds.Beep.Play();
				}
				//Don't allow the user to enter more characters than the max length for a file name
				else if (this.resultLabel.Text.Length + 1 > MAX_CHARS)
				{
					e.Handled = true;
					SystemSounds.Beep.Play();
				}
			}
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			TextBox senderTextBox = ((TextBox) sender);
			int textBoxIndex = (int) senderTextBox.Tag;
			
			Tuple<String, String> newParamTuple =new Tuple<string,string>
					(this.parameters[textBoxIndex].Item1, senderTextBox.Text);

			this.parameters[textBoxIndex] = newParamTuple;

			updateResultString();

			chooseToShowOverwriteWarning();
		}

		private void textBox_GotFocus(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox) sender;

			// Select all text only if the mouse isn't down.
			// This makes tabbing to the textbox give focus.
			if (MouseButtons == MouseButtons.None)
			{
				textBox.SelectAll();
			}
		}

		void textBox_MouseUp(object sender, MouseEventArgs e)
		{
			TextBox textBox = (TextBox)sender;

			// Web browsers like Google Chrome select the text on mouse up.
			// They only do it if the textbox isn't already focused,
			// and if the user hasn't selected all text.
			if (textBox.SelectionLength == 0)
			{
				textBox.SelectAll();
			}
		}

		private void updateResultString()
		{
			Debug.Assert( this.parameters.Count > 0);

			StringBuilder resultString = new StringBuilder();

			if (appendOldName == StartingControl.AppendType.Start)
			{
				resultString.Append(Path.GetFileNameWithoutExtension(this.imageFiles[this.curIndex].FullName));

				if (this.parameters[0].Item2.Length > 0)
				{
					resultString.Append(this.delimitor);
				}
			}

			resultString.Append(this.parameters[0].Item2);

			for (int i = 1; i < this.parameters.Count(); i++)
			{
				String value = this.parameters[i].Item2;
				if (value != null && value.Count() > 0)
				{
					if (resultString.Length > 0)
					{
						//Don't add delimitor if the String is still empty.
						resultString.Append(this.delimitor);
					}
					resultString.Append(this.parameters[i].Item2);
				}
			}


			if (appendOldName == StartingControl.AppendType.End)
			{
				if (resultString.Length > 0)
				{
					//Don't add delimitor if the String is still empty.
					resultString.Append(this.delimitor);
				}
				resultString.Append(Path.GetFileNameWithoutExtension(this.imageFiles[this.curIndex].FullName));
			}

			resultString.Append(this.imageFiles[this.curIndex].Extension);

			this.resultLabel.Text = resultString.ToString();

			//Finally, check if the result string is too long, and update
			//the length label.
			this.charCountLbl.Text = "Number of characters in new file name: " + resultString.Length + " / " + MAX_CHARS;
			if (resultString.Length >= MAX_CHARS)
			{
				this.charCountLbl.ForeColor = Color.Brown;
			}
			else
			{
				this.charCountLbl.ForeColor = Color.Black;
			}
		}

		private void resultLabel_Paint(Object sender, PaintEventArgs e)
		{
			float fontSize = fontSizeFromComponentSize(e.Graphics, new Size(550, 40), this.resultLabel.Font, this.resultLabel.Text);
			Font f = new Font("Microsoft Sans Serif", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultLabel.Font = f;
		}

		public static float fontSizeFromComponentSize(Graphics graphics, Size size, Font font, string str)
		{
			SizeF stringSize = graphics.MeasureString(str, font);
			float wRatio = size.Width / stringSize.Width;
			float hRatio = size.Height / stringSize.Height;
			float ratio = Math.Min(hRatio, wRatio);
			return font.Size * ratio;
		}

		private void loadNextImage()
		{
			if (this.imageFiles != null)
			{
				this.curIndex++;
				if (this.curIndex < this.imageFiles.Count())
				{
					this.paramTextBoxes[0].Focus();
					this.updateResultString();
					this.resetParamValues();

					//Make the check box invisible. When the copy of the last
					//file is finished, it will choose whether to reactivate the
					//checkbox or not.
					this.fileExistsWarningCheckBox.Checked = false;
					this.fileExistsWarningCheckBox.Visible = false;

					this.pictureBox.Image = null;
					this.pictureBox.LoadAsync(this.imageFiles[this.curIndex].FullName);
				}
				else
				{
					this.ParentForm.Visible = false;
					
					DialogResult result = MessageBox.Show("All images have been renamed successfully. Would you like to rename some more images?",
									"Renaming Completed", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						this.ParentForm.Visible = true;
						MainForm mainForm = (MainForm) this.ParentForm;
						mainForm.restartApplication();
					}
					else
					{
						Application.Exit();						
					}
				}
			}
		}

		private void imageDoneLoading(Object sender, AsyncCompletedEventArgs args)
		{
			//If there was an error loading the image, give the user
			//a warning, and go to the next image.
			if (args.Error != null && args.Error != this.loadError)
			{
				Debug.Print(args.Error.ToString());
				StringBuilder errorString = new StringBuilder();
				errorString.Append("Warning: The file '");
				errorString.Append(this.imageFiles[this.curIndex].FullName);
				errorString.Append("' has disappeared. Did you delete it?");
				errorString.Append(" This file will be skipped.");
				MessageBox.Show(errorString.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.loadNextImage();
				this.loadError = args.Error;
			}

			this.pictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
			//this.pictureBox.ResetCursor();
		}

		private void chooseToShowOverwriteWarning()
		{
			String targetName = this.resultLabel.Text;
			bool fileAlreadyExists = File.Exists(this.getFullTargetPath());

			this.fileExistsWarningCheckBox.Visible = fileAlreadyExists;
			this.renameButton.Enabled = !fileAlreadyExists || this.fileExistsWarningCheckBox.Checked;		
		}

		/**
		 * Returns the full path of the file that should be created.
		 */
		private String getFullTargetPath()
		{
			StringBuilder fullPath = new StringBuilder();
			fullPath.Append(this.outputDir.FullName);
			fullPath.Append("\\\\");
			fullPath.Append(this.resultLabel.Text);
			return fullPath.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int imageIndex = this.curIndex;

			//The current location of the file
			FileInfo originalFile = this.imageFiles[imageIndex];
			String originalFilePath = originalFile.FullName;

			//The destination locationo of the file.
			String targetFilePath = getFullTargetPath();

			BackgroundWorker bw = new BackgroundWorker();
			bw.DoWork += new DoWorkEventHandler(
			delegate(object o, DoWorkEventArgs args)
			{
				try
				{
					//Do the copy.
					File.Copy(originalFilePath, targetFilePath, true);
				}
				catch (DirectoryNotFoundException ex)
				{
					//If there is an error mvoving the file, notify the user
					//and quit the application.
					String message = "Oops! It was not possible to copy the file '" +
					originalFilePath + "' to '" +
					targetFilePath +
					"' because the output directory no longer exists. Restart this app to resume renaming.";

					MessageBox.Show(message);

					//Quit the application
					Application.Exit();
				}

			});
			bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
			delegate(object o, RunWorkerCompletedEventArgs args)
			{
				this.chooseToShowOverwriteWarning();
			});

			bw.RunWorkerAsync();

			this.loadNextImage();
		}

		private void fileExistsWarningCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.chooseToShowOverwriteWarning();
		}

		private void resetParamValues()
		{
			foreach (TextBox textBox in this.paramTextBoxes)
			{
				int index = (int)textBox.Tag;
				textBox.Text = this.originalParamValues[index];
			}
		}
	}
}
