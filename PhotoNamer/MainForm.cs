using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoNamer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

	        startApplication();
        }

	    public void restartApplication()
	    {
			this.Controls.Remove(this.photoSwitcherControl);
			this.photoSwitcherControl = null;

			Debug.Assert(this.Controls.Count == 0);

			this.ClientSize = new System.Drawing.Size(490, 600);

			this.startApplication();
	    }

	    public void startApplication()
	    {
			this.startingControl1 = new PhotoNamer.StartingControl();
			this.SuspendLayout();
			// 
			// startingControl1
			// 
			this.startingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.startingControl1.Location = new System.Drawing.Point(0, 0);
			this.startingControl1.Name = "startingControl1";
			this.startingControl1.TabIndex = 0;
			this.startingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));


			this.Controls.Add(this.startingControl1);
			this.startingControl1.startBtn.Click += new System.EventHandler(this.startBtn_Click);
	    }

		private void startBtn_Click(object sender, EventArgs e)
		{
			this.Controls.Remove(this.startingControl1);

			Debug.Assert(this.Controls.Count == 0);

			//this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
			this.photoSwitcherControl = new PhotoSwitcherControl(
				this.startingControl1.originDir,
				this.startingControl1.destDir,
				this.startingControl1.paramaters,
				this.startingControl1.delimitor(),
				this.startingControl1.appendOldName);
			this.Size = this.photoSwitcherControl.Size;

			this.startingControl1.Dispose();
			this.startingControl1 = null;

			this.Controls.Add(this.photoSwitcherControl);
		}
    }
}
