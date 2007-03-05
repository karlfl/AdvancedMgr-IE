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
	public partial class LanSettingDialog : Form
	{
		private ProxySetting activeProxy;
		public ProxySetting ActiveProxy
		{
			get { return activeProxy; }
			set { activeProxy = value; }
		}

		#region Constructors
		public LanSettingDialog()
		{
			InitializeComponent();
			activeProxy = new ProxySetting();
		}

		public LanSettingDialog(ProxySetting proxy)
		{
			InitializeComponent();
			activeProxy = proxy;
		} 
		#endregion

		#region Form Load Event
		private void LanSettingDialog_Load(object sender, EventArgs e)
		{
			this.ckbAutoDetectSettings.Checked = activeProxy.AutoDetectSettings;
			this.ckbUseAutoConfigScript.Checked = activeProxy.UseAutoConfigureScript;
			this.txtUseAutoConfigScriptAddress.Text = activeProxy.UseAutoConfigureScriptAddress;
			this.ckbUseProxyServer.Checked = activeProxy.UseProxyServer;
			this.txtUseProxyServerAddress.Text = activeProxy.UseProxyServerAddress;
			this.txtUseProxyServerPort.Text = activeProxy.UseProxyServerPort;
			this.ckbBypassProxyForLocal.Checked = activeProxy.BypassProxyForLocalAddress;

			refreshFields();
			this.Text = activeProxy.Name + " - " + this.Text;
		} 
		#endregion

		#region On Changed Events
		private void ckbUseProxyServer_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = ckbUseProxyServer.Checked;
			this.txtUseProxyServerAddress.Enabled = enabled;
			this.txtUseProxyServerPort.Enabled = enabled;
			this.btnAdvanced.Enabled = enabled;
			this.ckbBypassProxyForLocal.Enabled = enabled;
		} 

		private void ckbUseAutoConfigScript_CheckedChanged(object sender, EventArgs e)
		{
			this.txtUseAutoConfigScriptAddress.Enabled = this.ckbUseAutoConfigScript.Checked;
		}
		#endregion

		#region Button Events
		private void btnAdvanced_Click(object sender, EventArgs e)
		{
			UpdateActiveProxySettings();
			AdvancedDialog dlgAdvanced = new AdvancedDialog(activeProxy);
			dlgAdvanced.ShowDialog(this);
			refreshFields();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			UpdateActiveProxySettings();
			this.Close();
		} 
		#endregion

		#region Support methods
		private void refreshFields()
		{
			bool useProxyEnabled = ckbUseProxyServer.Checked;
			bool sameproxy = activeProxy.UseSameProxyServerForAllProtocols;
			bool allProxyEmpty = (string.IsNullOrEmpty(activeProxy.HTTPProxyAddress) &&
									string.IsNullOrEmpty(activeProxy.SecureProxyAddress) &&
									string.IsNullOrEmpty(activeProxy.FTPProxyAddress) &&
									string.IsNullOrEmpty(activeProxy.GopherProxyAddress));

			this.txtUseProxyServerAddress.Enabled = useProxyEnabled & (sameproxy | allProxyEmpty);
			this.txtUseProxyServerPort.Enabled = useProxyEnabled & (sameproxy | allProxyEmpty);
			this.btnAdvanced.Enabled = useProxyEnabled;
			this.ckbBypassProxyForLocal.Enabled = useProxyEnabled;

			this.txtUseAutoConfigScriptAddress.Enabled = this.ckbUseAutoConfigScript.Checked;

			//update the things that could've changed on the advanced screen.
			this.txtUseProxyServerAddress.Text = activeProxy.UseProxyServerAddress;
			this.txtUseProxyServerPort.Text = activeProxy.UseProxyServerPort;
			this.ckbBypassProxyForLocal.Checked = activeProxy.BypassProxyForLocalAddress;
		} 


		private void UpdateActiveProxySettings()
		{
			activeProxy.AutoDetectSettings = this.ckbAutoDetectSettings.Checked;
			activeProxy.UseAutoConfigureScript = this.ckbUseAutoConfigScript.Checked;
			activeProxy.UseAutoConfigureScriptAddress = this.txtUseAutoConfigScriptAddress.Text;

			activeProxy.UseProxyServer = this.ckbUseProxyServer.Checked;
			activeProxy.UseProxyServerAddress = this.txtUseProxyServerAddress.Text;
			activeProxy.UseProxyServerPort = this.txtUseProxyServerPort.Text;

			if (string.IsNullOrEmpty(activeProxy.HTTPProxyAddress))
			{
				activeProxy.HTTPProxyAddress = this.txtUseProxyServerAddress.Text;
				activeProxy.HTTPProxyPort = this.txtUseProxyServerPort.Text;
				activeProxy.SecureProxyAddress = this.txtUseProxyServerAddress.Text;
				activeProxy.SecureProxyPort = this.txtUseProxyServerPort.Text;
				activeProxy.FTPProxyAddress = this.txtUseProxyServerAddress.Text;
				activeProxy.FTPProxyPort = this.txtUseProxyServerPort.Text;
				activeProxy.GopherProxyAddress = this.txtUseProxyServerAddress.Text;
				activeProxy.GopherProxyPort = this.txtUseProxyServerPort.Text;
			}
			activeProxy.UseSameProxyServerForAllProtocols = (string.IsNullOrEmpty(this.txtUseProxyServerAddress.Text));

			activeProxy.BypassProxyForLocalAddress = this.ckbBypassProxyForLocal.Checked;
		}

		#endregion


	}
}