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
	public partial class LanSettingDialog : Form
	{
		public Proxy ActiveProxy;
	
		public LanSettingDialog()
		{
			InitializeComponent();
			ActiveProxy = new Proxy();
		}

		public LanSettingDialog(Proxy proxy)
		{
			InitializeComponent();
			ActiveProxy = proxy;
		}

		private void LanSettingDialog_Load(object sender, EventArgs e)
		{
			this.ckbAutoDetectSettings.Checked = ActiveProxy.AutoDetectSettings;
			this.ckbUseAutoConfigScript.Checked = ActiveProxy.UseAutoConfigureScript;
			this.txtUseAutoConfigScriptAddress.Text = ActiveProxy.UseAutoConfigureScriptAddress;
			this.ckbUseProxyServer.Checked = ActiveProxy.UseProxyServer;
			this.txtUseProxyServerAddress.Text = ActiveProxy.UseProxyServerAddress;
			this.txtUseProxyServerPort.Text = ActiveProxy.UseProxyServerPort;
			this.ckbBypassProxyForLocal.Checked = ActiveProxy.BypassProxyForLocalAddress;

			bool enabled = ckbUseProxyServer.Checked;
			this.txtUseProxyServerAddress.Enabled = enabled;
			this.txtUseProxyServerPort.Enabled = enabled;
			this.btnAdvanced.Enabled = enabled;
			this.ckbBypassProxyForLocal.Enabled = enabled;

			this.Text = ActiveProxy.Name + "-" + this.Text;
		}

		private void ckbUseProxyServer_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = ckbUseProxyServer.Checked;
			this.txtUseProxyServerAddress.Enabled = enabled;
			this.txtUseProxyServerPort.Enabled = enabled;
			this.btnAdvanced.Enabled = enabled;
			this.ckbBypassProxyForLocal.Enabled = enabled;
		}

		private void btnAdvanced_Click(object sender, EventArgs e)
		{
			AdvancedDialog dlgAdvanced = new AdvancedDialog(ActiveProxy);
			DialogResult result = dlgAdvanced.ShowDialog(this);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			//Update the settings and save to config file.
			ActiveProxy.AutoDetectSettings = this.ckbAutoDetectSettings.Checked;
			ActiveProxy.UseAutoConfigureScript = this.ckbUseAutoConfigScript.Checked;
			ActiveProxy.UseAutoConfigureScriptAddress = this.txtUseAutoConfigScriptAddress.Text;
			ActiveProxy.UseProxyServer = this.ckbUseProxyServer.Checked;
			ActiveProxy.UseProxyServerAddress = this.txtUseProxyServerAddress.Text;
			ActiveProxy.UseProxyServerPort = this.txtUseProxyServerPort.Text;
			ActiveProxy.BypassProxyForLocalAddress = this.ckbBypassProxyForLocal.Checked;
			ActiveProxy.SaveInConfigFile();
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}