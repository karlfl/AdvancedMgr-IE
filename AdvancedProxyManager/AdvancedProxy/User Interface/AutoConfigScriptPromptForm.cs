using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fleischmann.AdvancedProxy
{
	public partial class AutoConfigScriptPromptForm : Form
	{
		public AutoConfigScriptPromptForm()
		{
			InitializeComponent();
		}

		private void AutoConfigScriptPromptForm_Load(object sender, EventArgs e)
		{

		}

		private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				btnOK.PerformClick();
			}
		}
	}
}