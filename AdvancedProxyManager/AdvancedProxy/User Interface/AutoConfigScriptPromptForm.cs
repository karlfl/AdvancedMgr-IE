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

		/// <summary>
		/// Handles the Load event of the AutoConfigScriptPromptForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void AutoConfigScriptPromptForm_Load(object sender, EventArgs e)
		{
			//validate address url on the load so the error icon will appear initially
			validTxtAddress();
		}

		/// <summary>
		/// Handles the KeyPress event of the txtAddress control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.Windows.Forms.KeyPressEventArgs"/> instance containing the event data.</param>
		private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				btnOK.PerformClick();
			}
		}

		/// <summary>
		/// Handles the TextChanged event of the txtAddress control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void txtAddress_TextChanged(object sender, EventArgs e)
		{
			validTxtAddress();
		}

		/// <summary>
		/// Valids the txtAddress control
		/// Uses the ErrorProvider to flag controls with error icons.
		/// </summary>
		/// <returns>a boolean indicating txtAddress contains a valid value</returns>
		private bool validTxtAddress()
		{
			if (string.IsNullOrEmpty(txtAddress.Text))
			{
				scriptURLErrorProvider.SetError(txtAddress, "Must contain the URL of the automatic configuration script");
				return false;
			}
			else
			{
				scriptURLErrorProvider.SetError(txtAddress, "");
				return true;
			}
		}

		/// <summary>
		/// Handles the Click event of the btnOK control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void btnOK_Click(object sender, EventArgs e)
		{
			//Don't allow them to continue without a url in the address.
			if (!validTxtAddress())
			{
				return;
			}
			else
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}
	}
}