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
	public partial class MainForm : Form
	{
		bool applicationExiting = false;

		public MainForm(List<Proxy> theProxyList)
		{
			InitializeComponent();
			this.proxyBindingSource.DataSource = theProxyList;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			Proxy currentRegistryProxy = Proxy.GetCurrentProxyFromRegistry();
			useProxyToolStripMenuItem.Checked =  currentRegistryProxy.UseProxyServer;
		}

		private void icnProxyNotifyIcon_DoubleClick(object sender, EventArgs e)
		{
			this.Show();
		}

		private void configureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Show();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!applicationExiting)
			{
				DialogResult result = MessageBox.Show("Minimize to System Tray?", "Closing = Advanced Proxy Configure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					this.Hide();
					e.Cancel = true;
				}
			}
		}

		private void useProxyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool newValue = !useProxyToolStripMenuItem.Checked;
			useProxyToolStripMenuItem.Checked = newValue;
			Proxy.modifyUseProxy(newValue);

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			applicationExiting = true;
			Application.Exit();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Proxy selectedProxy = (Proxy)this.gridProxySettings.SelectedRows[0].DataBoundItem;
			LanSettingDialog dlgLanSettings = new LanSettingDialog(selectedProxy);
			DialogResult result = dlgLanSettings.ShowDialog();
			if (result == DialogResult.OK)
			{
				this.gridProxySettings.Refresh();
			}
		}
	}
}