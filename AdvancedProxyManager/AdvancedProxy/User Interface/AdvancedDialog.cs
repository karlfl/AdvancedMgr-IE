using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fleischmann.AdvancedProxy
{
	/// <summary>
	/// Copyright karl fleischmann 2006-2007
	/// </summary>
	public partial class AdvancedDialog : Form
	{
		private bool cancelClose = false;
		private bool formLoading = false;

		#region Constructors
		public ProxySetting ActiveProxy;
		public AdvancedDialog()
		{
			InitializeComponent();
			ActiveProxy = new ProxySetting();
		}

		public AdvancedDialog(ProxySetting proxy)
		{
			InitializeComponent();
			this.ActiveProxy = proxy;
		}
		
		#endregion

		#region Form Load Even
		private void AdvancedDialog_Load(object sender, EventArgs e)
		{
			loadForm();
		}

		private void loadForm()
		{
			formLoading = true;

			if (ActiveProxy.UseSameProxyServerForAllProtocols)
			{
				this.txtHttpAddress.Text = ActiveProxy.UseProxyServerAddress;
				this.txtHttpPort.Text = ActiveProxy.UseProxyServerPort;
				this.txtSecureAddress.Text = ActiveProxy.UseProxyServerAddress;
				this.txtSecurePort.Text = ActiveProxy.UseProxyServerPort;
				this.txtFTPAddress.Text = ActiveProxy.UseProxyServerAddress;
				this.txtFTPPort.Text = ActiveProxy.UseProxyServerPort;
				this.txtGopherAddress.Text = ActiveProxy.UseProxyServerAddress;
				this.txtGopherPort.Text = ActiveProxy.UseProxyServerPort;
			}
			else
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
			}
			this.ckbSameProxyForAll.Checked = ActiveProxy.UseSameProxyServerForAllProtocols;

			//emable the proxy text boxes based on the opposite of the UseSame... flag
			EnableTextBoxes(!ActiveProxy.UseSameProxyServerForAllProtocols);

			this.txtExcludeAddresses.Text = ActiveProxy.ExcludeAddressesFromProxy;

			this.Text += ActiveProxy.Name + " - " + this.Text;

			formLoading = false;
		}
		#endregion

		#region Form Closing Event
		private void AdvancedDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			//pick up when another action has canceled the automatic close.
			if (cancelClose)
			{
				e.Cancel = true;
				//reset it
				cancelClose = false;
			}
		}
		
		#endregion

		#region On Changed Events
		private void ckbSameProxyForAll_CheckedChanged(object sender, EventArgs e)
		{
			//ignore action during form load
			if (formLoading)
			{
				return;
			}

			if (ckbSameProxyForAll.Checked)
			{
				SetAllToHTTPAddressText();
				SetAllToHTTPPortText();

				EnableTextBoxes(false);
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

				EnableTextBoxes(true);
			}

		}

		private void txtHttpAddress_TextChanged(object sender, EventArgs e)
		{
			//ignore actions during form load
			if (formLoading)
			{
				return;
			}

			if (this.ckbSameProxyForAll.Checked)
			{
				ActiveProxy.UseProxyServerAddress = txtHttpAddress.Text;
				SetAllToHTTPAddressText();
			}
		}

		private void txtHttpPort_TextChanged(object sender, EventArgs e)
		{
			//ignore actions during form load
			if (formLoading)
			{
				return;
			}

			if (ckbSameProxyForAll.Checked)
			{
				ActiveProxy.UseProxyServerPort = txtHttpPort.Text;
				SetAllToHTTPPortText();
			}

		} 
		#endregion

		#region Button Events
		private void btnOK_Click(object sender, EventArgs e)
		{
			//Check for empty proxy addresses
			if (string.IsNullOrEmpty(this.txtHttpAddress.Text) &&
				string.IsNullOrEmpty(this.txtSecureAddress.Text) &&
				string.IsNullOrEmpty(this.txtFTPAddress.Text) &&
				string.IsNullOrEmpty(this.txtGopherAddress.Text) &&
				string.IsNullOrEmpty(this.txtSocksAddress.Text))
			{
				DialogResult result = MessageBox.Show("The settings for the proxy server you've chosen to use are blank.  This will prevent access to the Internet.  Do you want to turn off the proxy connection?", "Invalid Proxy Server", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
				if (result == DialogResult.Yes)
				{
					ActiveProxy.UseProxyServer = false;
				}
				else if (result == DialogResult.Cancel)
				{
					cancelClose = true;
					return;
				}
			}

			if (ckbSameProxyForAll.Checked)
			{
				ActiveProxy.UseProxyServerAddress = this.txtHttpAddress.Text;
				ActiveProxy.UseProxyServerPort = this.txtHttpPort.Text;
			}
			else
			{
				ActiveProxy.UseProxyServerAddress = string.Empty;
				ActiveProxy.UseProxyServerPort = string.Empty;
			}

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
		} 
		#endregion

		#region Support Methods
		private void SetAllToHTTPAddressText()
		{
			//set them all to the current HTTP values;
			this.txtSecureAddress.Text = this.txtHttpAddress.Text;
			this.txtFTPAddress.Text = this.txtHttpAddress.Text;
			this.txtGopherAddress.Text = this.txtHttpAddress.Text;
		}

		private void SetAllToHTTPPortText()
		{
			this.txtSecurePort.Text = this.txtHttpPort.Text;
			this.txtFTPPort.Text = this.txtHttpPort.Text;
			this.txtGopherPort.Text = this.txtHttpPort.Text;
		}

		private void EnableTextBoxes(bool enabled)
		{
			this.txtSecureAddress.Enabled = enabled;
			this.txtSecurePort.Enabled = enabled;
			this.txtFTPAddress.Enabled = enabled;
			this.txtFTPPort.Enabled = enabled;
			this.txtGopherAddress.Enabled = enabled;
			this.txtGopherPort.Enabled = enabled;
			this.txtSocksAddress.Enabled = enabled;
			this.txtSocksPort.Enabled = enabled;
		} 
		#endregion

	}
}