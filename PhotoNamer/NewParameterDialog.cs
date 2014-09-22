using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoNamer
{
	public partial class NewParameterDialog : Form
	{
		public String newParamName { get; private set; }
		public String newParamValue { get; private set; }

		public NewParameterDialog() : this("", "")
		{
		}

		public NewParameterDialog(String newParamName, String newParamValue)
		{
			InitializeComponent();

			this.newParamName = newParamName;
			this.newParamValue = newParamValue;

			this.newParamNameField.Text = newParamName;
			this.newParamValueField.Text = newParamValue;

			this.newParamValueField.KeyPress += delegate(object sender, KeyPressEventArgs e)
			{
				//Don't allow the user to enter invalid characters.
				if (!Char.IsControl(e.KeyChar) &&
					(Path.GetInvalidFileNameChars().Contains(e.KeyChar) ||
					Path.GetInvalidPathChars().Contains(e.KeyChar)))
				{
					e.Handled = true;
				}
			};
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			//this.Close();
		}

		private void okBtn_Click(object sender, EventArgs e)
		{

		}

		private void newParamNameField_TextChanged(object sender, EventArgs e)
		{
			this.newParamName = this.newParamNameField.Text;
		}

		private void newParamValueField_TextChanged(object sender, EventArgs e)
		{
			this.newParamValue = this.newParamValueField.Text;
		}
	}
}
