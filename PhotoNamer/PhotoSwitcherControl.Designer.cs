using System;
using System.ComponentModel;
namespace PhotoNamer
{
	partial class PhotoSwitcherControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.inputDirLbl = new System.Windows.Forms.Label();
			this.outputDirLbl = new System.Windows.Forms.Label();
			this.charCountLbl = new System.Windows.Forms.Label();
			this.paramsPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.resultLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.renameButton = new System.Windows.Forms.Button();
			this.fileExistsWarningCheckBox = new System.Windows.Forms.CheckBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.inputDirLbl);
			this.flowLayoutPanel3.Controls.Add(this.outputDirLbl);
			this.flowLayoutPanel3.Controls.Add(this.charCountLbl);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(794, 44);
			this.flowLayoutPanel3.TabIndex = 5;
			// 
			// inputDirLbl
			// 
			this.inputDirLbl.AutoSize = true;
			this.inputDirLbl.Location = new System.Drawing.Point(3, 0);
			this.inputDirLbl.Name = "inputDirLbl";
			this.inputDirLbl.Size = new System.Drawing.Size(35, 13);
			this.inputDirLbl.TabIndex = 0;
			this.inputDirLbl.Text = "label2";
			// 
			// outputDirLbl
			// 
			this.outputDirLbl.AutoSize = true;
			this.outputDirLbl.Location = new System.Drawing.Point(3, 13);
			this.outputDirLbl.Name = "outputDirLbl";
			this.outputDirLbl.Size = new System.Drawing.Size(35, 13);
			this.outputDirLbl.TabIndex = 1;
			this.outputDirLbl.Text = "label3";
			// 
			// charCountLbl
			// 
			this.charCountLbl.AutoSize = true;
			this.charCountLbl.Location = new System.Drawing.Point(3, 26);
			this.charCountLbl.Name = "charCountLbl";
			this.charCountLbl.Size = new System.Drawing.Size(35, 13);
			this.charCountLbl.TabIndex = 2;
			this.charCountLbl.Text = "label4";
			// 
			// paramsPanel2
			// 
			this.paramsPanel2.AutoScroll = true;
			this.paramsPanel2.AutoSize = true;
			this.paramsPanel2.ColumnCount = 2;
			this.paramsPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
			this.paramsPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
			this.paramsPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.paramsPanel2.Location = new System.Drawing.Point(803, 53);
			this.paramsPanel2.Name = "paramsPanel2";
			this.paramsPanel2.Size = new System.Drawing.Size(294, 594);
			this.paramsPanel2.TabIndex = 4;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 653);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 124);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 658F));
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.resultLabel, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(791, 124);
			this.tableLayoutPanel3.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "New Name: ";
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultLabel.Location = new System.Drawing.Point(136, 15);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(652, 25);
			this.resultLabel.TabIndex = 3;
			this.resultLabel.Text = "label1";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel2, 2);
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.renameButton, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.fileExistsWarningCheckBox, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(785, 78);
			this.tableLayoutPanel2.TabIndex = 6;
			// 
			// renameButton
			// 
			this.renameButton.AutoSize = true;
			this.renameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.renameButton.Location = new System.Drawing.Point(3, 3);
			this.renameButton.Name = "renameButton";
			this.renameButton.Size = new System.Drawing.Size(254, 28);
			this.renameButton.TabIndex = 2;
			this.renameButton.Text = "Rename and proceed to next photo.";
			this.renameButton.UseVisualStyleBackColor = true;
			this.renameButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// fileExistsWarningCheckBox
			// 
			this.fileExistsWarningCheckBox.AutoSize = true;
			this.fileExistsWarningCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fileExistsWarningCheckBox.ForeColor = System.Drawing.Color.Brown;
			this.fileExistsWarningCheckBox.Location = new System.Drawing.Point(263, 3);
			this.fileExistsWarningCheckBox.Name = "fileExistsWarningCheckBox";
			this.fileExistsWarningCheckBox.Size = new System.Drawing.Size(375, 30);
			this.fileExistsWarningCheckBox.TabIndex = 4;
			this.fileExistsWarningCheckBox.Text = "This file name name already exists in the output directory. \n Check this checkbox" +
    " if you are sure you want to overwrite it.";
			this.fileExistsWarningCheckBox.UseVisualStyleBackColor = true;
			this.fileExistsWarningCheckBox.CheckedChanged += new System.EventHandler(this.fileExistsWarningCheckBox_CheckedChanged);
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pictureBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(3, 53);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(794, 594);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.pictureBox.UseWaitCursor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 800F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.paramsPanel2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 780);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// PhotoSwitcherControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximumSize = new System.Drawing.Size(1100, 780);
			this.MinimumSize = new System.Drawing.Size(1100, 780);
			this.Name = "PhotoSwitcherControl";
			this.Size = new System.Drawing.Size(1100, 780);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Label inputDirLbl;
		private System.Windows.Forms.Label outputDirLbl;
		private System.Windows.Forms.Label charCountLbl;
		private System.Windows.Forms.TableLayoutPanel paramsPanel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button renameButton;
		private System.Windows.Forms.CheckBox fileExistsWarningCheckBox;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;

	}
}
