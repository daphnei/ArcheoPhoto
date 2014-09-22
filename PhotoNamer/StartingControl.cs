using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Media;

namespace PhotoNamer
{
	public partial class StartingControl : UserControl
	{
		public static String[] DEFAULT_PARAMETERS = {"Sitio", "Zona", "Fecha", "Unidad", "Rasgo", "Nivel", "Descripcion"};
		public static String TO_END = "To End";
		public static String TO_START = "To Start";
		public static String NEITHER = "Neither";
		public static String[] ACCEPTABLE_EXTENSIONS = {".jpg", ".png"};

		public enum AppendType
		{
			Start,
			End,
			None
		};

		/**
		 * Each paramater in the list is a tuple consisting of the paramater's name
		 * and the parameter's default value.
		 * 
		 * TODO: This list is redundant and could be removed.
		 */
		public List<Tuple<String, String>> paramaters { get; private set; }

		public DirectoryInfo originDir { get; private set; }
		public DirectoryInfo destDir { get; private set; }

		public AppendType appendOldName { get; private set; }

		public StartingControl()
		{
			this.originDir = null;
			this.destDir = null;
			this.paramaters = new List<Tuple<String, String>>();

			InitializeComponent();

			loadSavedSettings();

			setupParamatersListView();
			this.paramsListView.KeyDown += listViewKeyDown;

			this.delimitorTextBox.KeyPress += textBoxKeyPressed;

			chooseToEnableStartButton();

			//Decide whether to enable the param edit button
			this.editParamBtn.Enabled = this.paramsListView.SelectedItems.Count >= 1;
		}

		private void loadSavedSettings()
		{
			String savedInputDir = Properties.Settings.Default.inputDirectory;
			String savedOutputDir = Properties.Settings.Default.outputDirectory;
			String[] savedParams = Properties.Settings.Default.parameters;
			String[] savedParamValues = Properties.Settings.Default.parameterValues;
			String savedOriginalNameLoc = Properties.Settings.Default.originalNameLoc;

			if (savedInputDir != null && Directory.Exists(savedInputDir))
			{
				this.chooseInputFolderDialog.SelectedPath = savedInputDir;
				this.originDir = new DirectoryInfo(savedInputDir);
				this.chooseInputLbl.Text = this.originDir.FullName;
			}
			else
			{
				String myPicturesDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				this.chooseInputFolderDialog.SelectedPath = myPicturesDir;
				this.originDir = new DirectoryInfo(myPicturesDir);
				this.chooseInputLbl.Text = this.originDir.FullName;
			}

			if (savedOutputDir != null && Directory.Exists(savedOutputDir))
			{
				this.chooseOutputFolderDialog.SelectedPath = savedOutputDir;
				this.destDir = new DirectoryInfo(savedOutputDir);
				this.chooseOutputLbl.Text = this.destDir.FullName;
			}
			else
			{
				String myPicturesDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				this.chooseOutputFolderDialog.SelectedPath = myPicturesDir;
				this.destDir = new DirectoryInfo(myPicturesDir);
				this.chooseOutputLbl.Text = this.destDir.FullName;
			}

			if (savedOriginalNameLoc != null)
			{
				if (savedOriginalNameLoc.Equals(TO_START))
					this.toStartRadioBtn.Select();
				else if (savedOriginalNameLoc.Equals(TO_END))
					this.toEndradioBtn.Select();
				else
					this.noneRadioBtn.Select();
			}
			else
			{
				this.noneRadioBtn.Select();
			}

			if (savedParams == null || savedParams.Length == 0 || savedParamValues == null || savedParamValues.Length == 0)
			{
				//load in the default list of params
				foreach (String param in DEFAULT_PARAMETERS)
				{
					this.paramaters.Add(new Tuple<String, String>(param, ""));
				}
			}
			else
			{
				//There should be a 1 to 1 mapping of parameters and their values.
				Debug.Assert(savedParams.Count() == savedParamValues.Count());

				//load in the saved params if there are any
				for (int i = 0; i < savedParams.Count(); i++)
				{
					this.paramaters.Add(new Tuple<String, String>(savedParams[i], savedParamValues[i]));
				}
			}
		}

		/**
		 *  Render all of the parameters into the table they should be shown in.
		 */

		private void setupParamatersListView()
		{
			this.paramsListView.Items.Clear();

			for (int i = 0; i < paramaters.Count(); i++)
			{
				//Item1, the param name, goes into the first column,
				//Item2, the param default value, goes into the second value.
				ListViewItem lv = new ListViewItem(paramaters[i].Item1);
				lv.SubItems.Add(paramaters[i].Item2);
				this.paramsListView.Items.Add(lv);
			}

			this.paramsListView.Columns[0].Width = this.paramsListView.Width/2;
			this.paramsListView.Columns[1].Width = this.paramsListView.Width/2;
		}

		/**
		 *  Key down on the parameters list view.
		 */

		private void listViewKeyDown(object sender, KeyEventArgs args)
		{
			if (args.KeyCode == Keys.Delete)
			{
				deleteSelectedFromListView();

				// Bypass the control's default handling; 
				// otherwise, remove to pass the event to the default control handler.
				args.Handled = true;
			}
		}


		private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void deletedSelectedBtn_Click(object sender, EventArgs e)
		{
			deleteSelectedFromListView();
		}

		private void addParamBtn_Click(object sender, EventArgs e)
		{
			NewParameterDialog dialog = new NewParameterDialog();
			//this.Enabled = false;

			DialogResult result = dialog.ShowDialog(this.FindForm());

			if (result == DialogResult.OK)
			{
				//If the user pressed OK, then add the entry for the new parameter
				this.paramaters.Add(new Tuple<String, String>(dialog.newParamName, dialog.newParamValue));

				//update the ListView to show the new paramater,
				ListViewItem lv = new ListViewItem(dialog.newParamName);
				lv.SubItems.Add(dialog.newParamValue);
				this.paramsListView.Items.Add(lv);

				//save the new paramater in the properties.
				Properties.Settings.Default.parameters = paramaters.Select((tuple) => tuple.Item1).ToArray();
				Properties.Settings.Default.parameterValues = paramaters.Select((tuple) => tuple.Item2).ToArray();
				Properties.Settings.Default.Save();

				chooseToEnableStartButton();
			}
		}

		/**
		 *  Delete the selected items from the parameters list view.
		 */

		private void deleteSelectedFromListView()
		{
			foreach (ListViewItem listViewItem in this.paramsListView.SelectedItems)
			{
				int index = listViewItem.Index;
				listViewItem.Remove();
				this.paramaters.RemoveAt(index);
			}

			Properties.Settings.Default.parameters = paramaters.Select((tuple) => tuple.Item1).ToArray();
			Properties.Settings.Default.parameterValues = paramaters.Select((tuple) => tuple.Item2).ToArray();
			Properties.Settings.Default.Save();

			chooseToEnableStartButton();
		}

		private void chooseInputBtn_Click(object sender, EventArgs e)
		{
			if (chooseInputFolderDialog.ShowDialog() == DialogResult.OK)
			{
				String path = chooseInputFolderDialog.SelectedPath;
				this.originDir = new DirectoryInfo(path);
				this.chooseInputLbl.Text = this.originDir.FullName;

				Properties.Settings.Default.inputDirectory = this.originDir.FullName;
				Properties.Settings.Default.Save();

				chooseToEnableStartButton();
			}
		}

		private void chooseOutputBtn_Click(object sender, EventArgs e)
		{
			if (chooseOutputFolderDialog.ShowDialog() == DialogResult.OK)
			{
				String path = chooseOutputFolderDialog.SelectedPath;
				this.destDir = new DirectoryInfo(path);
				this.chooseOutputLbl.Text = this.destDir.FullName;

				Properties.Settings.Default.outputDirectory = this.destDir.FullName;
				Properties.Settings.Default.Save();

				chooseToEnableStartButton();
			}
		}

		private void chooseToEnableStartButton()
		{
			bool atLeastOneParam = this.paramaters.Count > 0;
			bool dirsNotTheSame = !this.originDir.FullName.Equals(this.destDir.FullName);
			bool originDirHasAtLeastOneImageFile = (this.originDir.GetFiles()
				.Where(f => StartingControl.ACCEPTABLE_EXTENSIONS.Contains(f.Extension.ToLower()))
				.Count()) > 0;

			this.warningLabel.Text = "";
			if (!atLeastOneParam)
			{
				this.warningLabel.Text = "Please add at least one parameter to the parameters list; otherwise, this app won't be useful.\n\n";
			}
			if (!dirsNotTheSame)
			{
				this.warningLabel.Text += "Please change you output directory to be different from your input directory, " +
				                          "Overwriting files is dangerous!\n\n";
			}
			if (!originDirHasAtLeastOneImageFile)
			{
				this.warningLabel.Text +=
					"The chosen input directory does not have any image files in it. Please choose a directory " +
					"that contains either .png or .jpg files.\n\n";
			}


			bool enable = dirsNotTheSame && atLeastOneParam && originDirHasAtLeastOneImageFile;
			this.startBtn.Enabled = enable;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Reset the parameters
			this.paramaters.Clear();
			this.paramaters.AddRange(DEFAULT_PARAMETERS.Select((item) => new Tuple<String, String>(item, "")));

			//Not going to bother resetting the input/output directories for now.

			setupParamatersListView();

			this.delimitorTextBox.Text = "_";
			this.noneRadioBtn.Select();

			Properties.Settings.Default.parameters = this.paramaters.Select((item) => item.Item1).ToArray();
			Properties.Settings.Default.parameterValues = this.paramaters.Select((item) => item.Item2).ToArray();
			Properties.Settings.Default.Save();

			chooseToEnableStartButton();
		}

		private void appendOldName_CheckedChanged(object sender, EventArgs e)
		{
			//TODO: Is there some fancy way to do this using actions like in Java? Use Tags!
			if (sender == this.toStartRadioBtn)
			{
				this.appendOldName = AppendType.Start;
				Properties.Settings.Default.originalNameLoc = TO_START;
			}
			else if (sender == this.toEndradioBtn)
			{
				this.appendOldName = AppendType.End;
				Properties.Settings.Default.originalNameLoc = TO_END;
			}
			else if (sender == this.noneRadioBtn)
			{
				this.appendOldName = AppendType.None;
				Properties.Settings.Default.originalNameLoc = NEITHER;
			}
			Properties.Settings.Default.Save();
		}

		public String delimitor()
		{
			return this.delimitorTextBox.Text;
		}

		private void delimitorTextBox_TextChanged(object sender, EventArgs e)
		{
			if (this.delimitorTextBox.Text.Length > 0)
			{
				chooseToEnableStartButton();
			}
		}

		private void delimitorTextBox_FocusedLost(object sender, EventArgs e)
		{
			if (this.delimitorTextBox.Text.Length == 0)
			{
				this.delimitorTextBox.Text = "_";
			}
		}

		private void paramsListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			//The order of the parameters might have changed. Make sure our model is up to date.
			bool needToUpdatePreferences = false;
			for (int index = 0; index < this.paramsListView.Items.Count; index++)
			{
				ListViewItem listViewItem = this.paramsListView.Items[index];

				//If the value at this index has changed, update the model, and set a flag
				//saying we need to rewrite the preferences file to disk
				if (!listViewItem.Text.Equals(this.paramaters[index].Item1))
				{
					needToUpdatePreferences = true;

					String param = listViewItem.Text;
					String value = listViewItem.SubItems[1].Text;
					this.paramaters[index] = new Tuple<string, string>(param, value);
					Properties.Settings.Default.parameters[index] = param;
					Properties.Settings.Default.parameterValues[index] = value;
				}
			}

			if (needToUpdatePreferences)
			{
				Properties.Settings.Default.Save();
			}

			//Also decide whether to enable the selection button
			this.editParamBtn.Enabled = this.paramsListView.SelectedItems.Count >= 1;
		}

		private void editParamBtn_Click(object sender, EventArgs e)
		{
			ListViewItem selItem = this.paramsListView.SelectedItems[0];
			String param = selItem.Text;
			String value = selItem.SubItems[1].Text;

			int selIndex = selItem.Index;

			NewParameterDialog dialog = new NewParameterDialog(param, value);

			DialogResult result = dialog.ShowDialog(this.FindForm());

			if (result == DialogResult.OK)
			{
				ListViewItem newItem = new ListViewItem(dialog.newParamName);
				newItem.SubItems.Add(dialog.newParamValue);
				this.paramsListView.Items[selIndex] = newItem;

				//Update the parameters list.
				this.paramaters[selIndex] = new Tuple<string, string>(dialog.newParamName, dialog.newParamValue);

				//Update the preferences.
				Properties.Settings.Default.parameters[selIndex] = dialog.newParamName;
				Properties.Settings.Default.parameterValues[selIndex] = dialog.newParamValue;
				Properties.Settings.Default.Save();
			}
		}

		private void textBoxKeyPressed(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsControl(e.KeyChar))
			{
				//Don't allow the user to enter invalid characters.
				if (Path.GetInvalidFileNameChars().Contains(e.KeyChar) ||
				    Path.GetInvalidPathChars().Contains(e.KeyChar))
				{
					e.Handled = true;
					SystemSounds.Beep.Play();
				}
			}
		}
	}
}
