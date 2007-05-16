using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fleischmann.AdvancedProxy
{
	public partial class ProxyNamePromptDialog : Form
	{
		private List<ProxySetting> _proxyList;
		private bool _nameError;
		public ProxyNamePromptDialog(List<ProxySetting> proxyList)
		{
			InitializeComponent();
			_proxyList = proxyList;
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtName.Text))
			{
				proxyNameErrorProvider.SetError(txtName, "Must contain the the name of the new proxy configuration.");
				btnOK.Enabled = false;
			}
			else if (DuplicateName())
			{
				proxyNameErrorProvider.SetError(txtName, "A proxy configuration with this name already exists.");
				btnOK.Enabled = false;
			}
			else
			{
				proxyNameErrorProvider.SetError(txtName, "");
				btnOK.Enabled = true;
			}
		}

		private bool DuplicateName()
		{
			_nameError = false;
			foreach (ProxySetting proxy in _proxyList)
			{
				if (proxy.Name.Trim().ToLower() == this.txtName.Text.Trim().ToLower())
				{
					_nameError = true;
				}
			}
			return _nameError;
		}

	}
}