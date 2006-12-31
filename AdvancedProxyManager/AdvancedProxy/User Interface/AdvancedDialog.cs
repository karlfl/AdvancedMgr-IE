using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace fleischmann.advancedproxy
{
	/// <summary>
	/// Copyright karl fleischmann 2006
	/// </summary>
	public partial class AdvancedDialog : Form
	{
		public Proxy ActiveProxy;
		public AdvancedDialog()
		{
			InitializeComponent();
			ActiveProxy = new Proxy();
		}

		public AdvancedDialog(Proxy proxy)
		{
			InitializeComponent();
			this.ActiveProxy = proxy;
		}

		private void ckbSameProxyForAll_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled;
			if (ckbSameProxyForAll.Checked)
			{
				//set them all to the current HTTP values;
				this.txtSecureAddress.Text = this.txtHttpAddress.Text;
				this.txtSecurePort.Text = this.txtHttpPort.Text;
				this.txtFTPAddress.Text = this.txtHttpAddress.Text;
				this.txtFTPPort.Text = this.txtHttpPort.Text;
				this.txtGopherAddress.Text = this.txtHttpAddress.Text;
				this.txtGopherPort.Text = this.txtHttpPort.Text;
				this.txtSocksAddress.Text = this.txtHttpAddress.Text;
				this.txtSocksPort.Text = this.txtHttpPort.Text;

				enabled = false;
			}
			else
			{
				//reset to the active values;
				this.txtHttpAddress.Text = ActiveProxy.HTTPProxyAddress;
				this.txtHttpPort.Text = ActiveProxy.HTTPProxyPort.ToString();
				this.txtSecureAddress.Text = ActiveProxy.SecureProxyAddress;
				this.txtSecurePort.Text = ActiveProxy.SecureProxyPort.ToString();
				this.txtFTPAddress.Text = ActiveProxy.FTPProxyAddress;
				this.txtFTPPort.Text = ActiveProxy.FTPProxyPort.ToString();
				this.txtGopherAddress.Text = ActiveProxy.GopherProxyAddress;
				this.txtGopherPort.Text = ActiveProxy.GopherProxyPort.ToString();
				this.txtSocksAddress.Text = ActiveProxy.SocksProxyAddress;
				this.txtSocksPort.Text = ActiveProxy.SocksProxyPort.ToString();

				enabled = false;
			}

			this.txtSecureAddress.Enabled = enabled;
			this.txtSecurePort.Enabled = enabled;
			this.txtFTPAddress.Enabled = enabled;
			this.txtFTPPort.Enabled = enabled;
			this.txtGopherAddress.Enabled = enabled;
			this.txtGopherPort.Enabled = enabled;
			this.txtSocksAddress.Enabled = enabled;
			this.txtSocksPort.Enabled = enabled;
		}

		private void AdvancedDialog_Load(object sender, EventArgs e)
		{
			this.txtHttpAddress.Text = ActiveProxy.HTTPProxyAddress;
			this.txtHttpPort.Text = ActiveProxy.HTTPProxyPort;
			this.txtSecureAddress.Text = ActiveProxy.SecureProxyAddress;
			this.txtSecurePort.Text = ActiveProxy.SecureProxyPort;
			this.txtFTPAddress.Text = ActiveProxy.FTPProxyAddress;
			this.txtFTPPort.Text = ActiveProxy.FTPProxyPort;
			this.txtGopherAddress.Text = ActiveProxy.GopherProxyAddress;
			this.txtGopherPort.Text = ActiveProxy.GopherProxyPort;
			this.txtSocksAddress.Text = ActiveProxy.SocksProxyAddress;
			this.txtSocksPort.Text = ActiveProxy.SocksProxyPort;
			this.ckbSameProxyForAll.Checked = ActiveProxy.UseSameProxyServerForAllProtocols;
			this.txtExcludeAddresses.Text = ActiveProxy.ExcludeAddressesFromProxy;

			this.Text = ActiveProxy.Name + "-" + this.Text;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			ActiveProxy.HTTPProxyAddress = this.txtHttpAddress.Text;
			ActiveProxy.HTTPProxyPort = this.txtHttpPort.Text;
			ActiveProxy.SecureProxyAddress = this.txtSecureAddress.Text;
			ActiveProxy.SecureProxyPort = this.txtSecurePort.Text;
			ActiveProxy.FTPProxyAddress = this.txtFTPAddress.Text;
			ActiveProxy.FTPProxyPort = this.txtFTPPort.Text;
			ActiveProxy.GopherProxyAddress = this.txtGopherAddress.Text;
			ActiveProxy.GopherProxyPort = this.txtGopherPort.Text;
			ActiveProxy.SocksProxyAddress = this.txtSocksAddress.Text;
			ActiveProxy.SocksProxyPort = this.txtSocksPort.Text;
			ActiveProxy.UseSameProxyServerForAllProtocols = this.ckbSameProxyForAll.Checked;
			ActiveProxy.ExcludeAddressesFromProxy = this.txtExcludeAddresses.Text;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}