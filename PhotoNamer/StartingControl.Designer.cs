using System.Windows.Forms;

namespace PhotoNamer
{
    partial class StartingControl
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
			this.components = new System.ComponentModel.Container();
			this.explanationText = new System.Windows.Forms.Label();
			this.chooseInputBtn = new System.Windows.Forms.Button();
			this.chooseOutputBtn = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.paramsListView = new PhotoNamer.ListViewEx();
			this.header1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.header2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.toStartRadioBtn = new System.Windows.Forms.RadioButton();
			this.toEndradioBtn = new System.Windows.Forms.RadioButton();
			this.noneRadioBtn = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.delimitorTextBox = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.addParamBtn = new System.Windows.Forms.Button();
			this.deletedSelectedBtn = new System.Windows.Forms.Button();
			this.editParamBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.chooseInputLbl = new PhotoNamer.LabelEllipsis();
			this.chooseOutputLbl = new PhotoNamer.LabelEllipsis();
			this.startBtn = new System.Windows.Forms.Button();
			this.warningLabel = new System.Windows.Forms.Label();
			this.chooseInputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.chooseOutputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// explanationText
			// 
			this.explanationText.AutoSize = true;
			this.explanationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.explanationText.Location = new System.Drawing.Point(3, 0);
			this.explanationText.Name = "explanationText";
			this.explanationText.Size = new System.Drawing.Size(468, 29);
			this.explanationText.TabIndex = 0;
			this.explanationText.Text = "Welcome to the excavation photo renamer.";
			// 
			// chooseInputBtn
			// 
			this.chooseInputBtn.AutoSize = true;
			this.chooseInputBtn.Location = new System.Drawing.Point(3, 3);
			this.chooseInputBtn.Name = "chooseInputBtn";
			this.chooseInputBtn.Size = new System.Drawing.Size(140, 23);
			this.chooseInputBtn.TabIndex = 2;
			this.chooseInputBtn.Text = "Choose an input directory:";
			this.chooseInputBtn.UseVisualStyleBackColor = true;
			this.chooseInputBtn.Click += new System.EventHandler(this.chooseInputBtn_Click);
			// 
			// chooseOutputBtn
			// 
			this.chooseOutputBtn.AutoSize = true;
			this.chooseOutputBtn.Location = new System.Drawing.Point(3, 32);
			this.chooseOutputBtn.Name = "chooseOutputBtn";
			this.chooseOutputBtn.Size = new System.Drawing.Size(147, 23);
			this.chooseOutputBtn.TabIndex = 3;
			this.chooseOutputBtn.Text = "Choose an output directory:";
			this.chooseOutputBtn.UseVisualStyleBackColor = true;
			this.chooseOutputBtn.Click += new System.EventHandler(this.chooseOutputBtn_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.explanationText, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1004, 581);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.button1, 1, 6);
			this.tableLayoutPanel3.Controls.Add(this.chooseOutputBtn, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.chooseInputBtn, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.paramsListView, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel1, 1, 4);
			this.tableLayoutPanel3.Controls.Add(this.label3, 0, 5);
			this.tableLayoutPanel3.Controls.Add(this.delimitorTextBox, 1, 5);
			this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.chooseInputLbl, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.chooseOutputLbl, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.startBtn, 0, 6);
			this.tableLayoutPanel3.Controls.Add(this.warningLabel, 0, 7);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 32);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 8;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(998, 522);
			this.tableLayoutPanel3.TabIndex = 1;
			this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(253, 335);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 23);
			this.button1.TabIndex = 15;
			this.button1.Text = "Restore Defaults Settings.";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// paramsListView
			// 
			this.paramsListView.AllowDrop = true;
			this.paramsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.header1,
            this.header2});
			this.paramsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.paramsListView.FullRowSelect = true;
			this.paramsListView.HideSelection = false;
			this.paramsListView.LineAfter = -1;
			this.paramsListView.LineBefore = -1;
			this.paramsListView.Location = new System.Drawing.Point(3, 74);
			this.paramsListView.Name = "paramsListView";
			this.paramsListView.Size = new System.Drawing.Size(244, 200);
			this.paramsListView.TabIndex = 0;
			this.paramsListView.UseCompatibleStateImageBehavior = false;
			this.paramsListView.View = System.Windows.Forms.View.Details;
			this.paramsListView.SelectedIndexChanged += new System.EventHandler(this.paramsListView_SelectedIndexChanged);
			// 
			// header1
			// 
			this.header1.Text = "Parameter";
			// 
			// header2
			// 
			this.header2.Text = "Default Value";
			this.header2.Width = 144;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.tableLayoutPanel3.SetColumnSpan(this.label1, 2);
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(992, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Choose or reorder the naming parameters:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 277);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(244, 29);
			this.label2.TabIndex = 5;
			this.label2.Text = "Append the original file name?";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.toStartRadioBtn);
			this.flowLayoutPanel1.Controls.Add(this.toEndradioBtn);
			this.flowLayoutPanel1.Controls.Add(this.noneRadioBtn);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(253, 280);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(742, 23);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// toStartRadioBtn
			// 
			this.toStartRadioBtn.AutoSize = true;
			this.toStartRadioBtn.Location = new System.Drawing.Point(3, 3);
			this.toStartRadioBtn.Name = "toStartRadioBtn";
			this.toStartRadioBtn.Size = new System.Drawing.Size(63, 17);
			this.toStartRadioBtn.TabIndex = 1;
			this.toStartRadioBtn.TabStop = true;
			this.toStartRadioBtn.Text = "To Start";
			this.toStartRadioBtn.UseVisualStyleBackColor = true;
			this.toStartRadioBtn.CheckedChanged += new System.EventHandler(this.appendOldName_CheckedChanged);
			// 
			// toEndradioBtn
			// 
			this.toEndradioBtn.AutoSize = true;
			this.toEndradioBtn.Location = new System.Drawing.Point(72, 3);
			this.toEndradioBtn.Name = "toEndradioBtn";
			this.toEndradioBtn.Size = new System.Drawing.Size(60, 17);
			this.toEndradioBtn.TabIndex = 0;
			this.toEndradioBtn.TabStop = true;
			this.toEndradioBtn.Text = "To End";
			this.toEndradioBtn.UseVisualStyleBackColor = true;
			this.toEndradioBtn.CheckedChanged += new System.EventHandler(this.appendOldName_CheckedChanged);
			// 
			// noneRadioBtn
			// 
			this.noneRadioBtn.AutoSize = true;
			this.noneRadioBtn.Location = new System.Drawing.Point(138, 3);
			this.noneRadioBtn.Name = "noneRadioBtn";
			this.noneRadioBtn.Size = new System.Drawing.Size(59, 17);
			this.noneRadioBtn.TabIndex = 2;
			this.noneRadioBtn.TabStop = true;
			this.noneRadioBtn.Text = "Neither";
			this.noneRadioBtn.UseVisualStyleBackColor = true;
			this.noneRadioBtn.CheckedChanged += new System.EventHandler(this.appendOldName_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 306);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(244, 26);
			this.label3.TabIndex = 7;
			this.label3.Text = "Separation character:";
			// 
			// delimitorTextBox
			// 
			this.delimitorTextBox.Location = new System.Drawing.Point(253, 309);
			this.delimitorTextBox.MaxLength = 1;
			this.delimitorTextBox.Name = "delimitorTextBox";
			this.delimitorTextBox.Size = new System.Drawing.Size(22, 20);
			this.delimitorTextBox.TabIndex = 8;
			this.delimitorTextBox.Text = "_";
			this.delimitorTextBox.TextChanged += new System.EventHandler(this.delimitorTextBox_TextChanged);
			this.delimitorTextBox.LostFocus += new System.EventHandler(this.delimitorTextBox_FocusedLost);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.addParamBtn);
			this.flowLayoutPanel2.Controls.Add(this.deletedSelectedBtn);
			this.flowLayoutPanel2.Controls.Add(this.editParamBtn);
			this.flowLayoutPanel2.Controls.Add(this.label4);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(253, 74);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(742, 200);
			this.flowLayoutPanel2.TabIndex = 9;
			// 
			// addParamBtn
			// 
			this.addParamBtn.AutoSize = true;
			this.addParamBtn.Location = new System.Drawing.Point(3, 3);
			this.addParamBtn.Name = "addParamBtn";
			this.addParamBtn.Size = new System.Drawing.Size(98, 23);
			this.addParamBtn.TabIndex = 1;
			this.addParamBtn.Text = "Add a parameter.";
			this.addParamBtn.UseVisualStyleBackColor = true;
			this.addParamBtn.Click += new System.EventHandler(this.addParamBtn_Click);
			// 
			// deletedSelectedBtn
			// 
			this.deletedSelectedBtn.AutoSize = true;
			this.deletedSelectedBtn.Location = new System.Drawing.Point(3, 32);
			this.deletedSelectedBtn.Name = "deletedSelectedBtn";
			this.deletedSelectedBtn.Size = new System.Drawing.Size(149, 23);
			this.deletedSelectedBtn.TabIndex = 0;
			this.deletedSelectedBtn.Text = "Delete selected parameters.";
			this.deletedSelectedBtn.UseVisualStyleBackColor = true;
			this.deletedSelectedBtn.Click += new System.EventHandler(this.deletedSelectedBtn_Click);
			// 
			// editParamBtn
			// 
			this.editParamBtn.AutoSize = true;
			this.editParamBtn.Location = new System.Drawing.Point(3, 61);
			this.editParamBtn.Name = "editParamBtn";
			this.editParamBtn.Size = new System.Drawing.Size(131, 23);
			this.editParamBtn.TabIndex = 3;
			this.editParamBtn.Text = "Edit selected parameter.";
			this.editParamBtn.UseVisualStyleBackColor = true;
			this.editParamBtn.Click += new System.EventHandler(this.editParamBtn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(224, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Tip: You can drag parameters to reorder them.";
			// 
			// chooseInputLbl
			// 
			this.chooseInputLbl.AutoEllipsis = ((PhotoNamer.EllipsisFormat)((PhotoNamer.EllipsisFormat.End | PhotoNamer.EllipsisFormat.Start)));
			this.chooseInputLbl.Dock = System.Windows.Forms.DockStyle.Left;
			this.chooseInputLbl.Location = new System.Drawing.Point(253, 0);
			this.chooseInputLbl.Name = "chooseInputLbl";
			this.chooseInputLbl.Size = new System.Drawing.Size(230, 29);
			this.chooseInputLbl.TabIndex = 10;
			// 
			// chooseOutputLbl
			// 
			this.chooseOutputLbl.AutoEllipsis = ((PhotoNamer.EllipsisFormat)((PhotoNamer.EllipsisFormat.End | PhotoNamer.EllipsisFormat.Start)));
			this.chooseOutputLbl.Dock = System.Windows.Forms.DockStyle.Left;
			this.chooseOutputLbl.Location = new System.Drawing.Point(253, 29);
			this.chooseOutputLbl.Name = "chooseOutputLbl";
			this.chooseOutputLbl.Size = new System.Drawing.Size(230, 29);
			this.chooseOutputLbl.TabIndex = 11;
			// 
			// startBtn
			// 
			this.startBtn.AutoSize = true;
			this.startBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startBtn.Location = new System.Drawing.Point(0, 332);
			this.startBtn.Margin = new System.Windows.Forms.Padding(0);
			this.startBtn.Name = "startBtn";
			this.startBtn.Padding = new System.Windows.Forms.Padding(4);
			this.startBtn.Size = new System.Drawing.Size(250, 55);
			this.startBtn.TabIndex = 12;
			this.startBtn.Text = "Start Renaming.";
			this.startBtn.UseVisualStyleBackColor = true;
			// 
			// warningLabel
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.warningLabel, 2);
			this.warningLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.warningLabel.ForeColor = System.Drawing.Color.Brown;
			this.warningLabel.Location = new System.Drawing.Point(3, 387);
			this.warningLabel.MaximumSize = new System.Drawing.Size(460, 1000);
			this.warningLabel.MinimumSize = new System.Drawing.Size(460, 50);
			this.warningLabel.Name = "warningLabel";
			this.warningLabel.Size = new System.Drawing.Size(460, 135);
			this.warningLabel.TabIndex = 13;
			// 
			// chooseInputFolderDialog
			// 
			this.chooseInputFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// chooseOutputFolderDialog
			// 
			this.chooseOutputFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// StartingControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.AutoSize = true;
			this.Controls.Add(this.tableLayoutPanel2);
			this.Name = "StartingControl";
			this.Size = new System.Drawing.Size(1004, 581);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label explanationText;
        private System.Windows.Forms.Button chooseInputBtn;
        private System.Windows.Forms.Button chooseOutputBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private ListViewEx paramsListView;
		private ColumnHeader header1;
		private ColumnHeader header2;
		private Label label1;
		private Label label2;
		private FlowLayoutPanel flowLayoutPanel1;
		private RadioButton toEndradioBtn;
		private RadioButton toStartRadioBtn;
		private RadioButton noneRadioBtn;
		private Label label3;
		private TextBox delimitorTextBox;
		private FlowLayoutPanel flowLayoutPanel2;
		private Button deletedSelectedBtn;
		private Button addParamBtn;
		private FolderBrowserDialog chooseInputFolderDialog;
		private LabelEllipsis chooseInputLbl;
		private FolderBrowserDialog chooseOutputFolderDialog;
		private LabelEllipsis chooseOutputLbl;
		private Label warningLabel;
		private ContextMenuStrip contextMenuStrip1;
		private Button button1;
		public Button startBtn;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private Label label4;
		private Button editParamBtn;


    }
}
