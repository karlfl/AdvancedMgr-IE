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
	public partial class MainForm : Form
	{
		bool applicationExiting = false;

		List<ProxySetting> proxyList;

		public MainForm(List<ProxySetting> theProxyList)
		{
			InitializeComponent();
			proxyList = theProxyList;
			this.proxyBindingSource.DataSource = proxyList;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (proxyList.Count == 0)
			{
				DialogResult result = MessageBox.Show("You currently have no Proxy Settings defined.  Would you like to create an initial settings based on your current proxy settings in Internet Explorer?", "Create Initial Proxy Set", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (result == DialogResult.Yes)
				{
					ProxySetting currentRegistryProxy = ProxySetting.GetCurrentProxyFromRegistry();
					ProxyNamePromptDialog dlgNamePrompt = new ProxyNamePromptDialog();
					dlgNamePrompt.txtName.Text = currentRegistryProxy.Name;
					result = dlgNamePrompt.ShowDialog(this);
					if (result == DialogResult.OK)
					{
						currentRegistryProxy.Name = dlgNamePrompt.txtName.Text;
						currentRegistryProxy.SaveInConfigFile();
						proxyList.Add(currentRegistryProxy);
						this.gridProxySettings.DataSource = proxyList;
						this.gridProxySettings.Refresh();
					}
				}
			}

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
			ProxySetting.modifyUseProxy(newValue);

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			applicationExiting = true;
			Application.Exit();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			ProxyNamePromptDialog dlgNamePrompt = new ProxyNamePromptDialog();
			DialogResult result = dlgNamePrompt.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				ProxySetting newProxy = new ProxySetting();
				newProxy.Name = dlgNamePrompt.txtName.Text;

				LanSettingDialog dlgLanSettings = new LanSettingDialog(newProxy);
				result = dlgLanSettings.ShowDialog(this);
				if (result == DialogResult.OK)
				{
					//don't add it until they've entered the data for it and saved it.
					proxyList.Add(newProxy);
					this.gridProxySettings.DataSource = proxyList;
					this.gridProxySettings.Refresh();
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			ProxySetting selectedProxy = (ProxySetting)this.gridProxySettings.SelectedRows[0].DataBoundItem;
			EditProxy(selectedProxy);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
				ProxySetting selectedProxy = (ProxySetting)this.gridProxySettings.SelectedRows[0].DataBoundItem;
				DialogResult result = MessageBox.Show("Are you sure you want to delete this Proxy Setting?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					this.gridProxySettings.DataSource = null;
					selectedProxy.Delete();
					proxyList.Remove(selectedProxy);
					this.gridProxySettings.DataSource = proxyList;
					this.gridProxySettings.Refresh();
				}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void gridProxySettings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ProxySetting selectedProxy = (ProxySetting)this.gridProxySettings.Rows[e.RowIndex].DataBoundItem;
			EditProxy(selectedProxy);
		}

		private void EditProxy(ProxySetting selectedProxy)
		{
			LanSettingDialog dlgLanSettings = new LanSettingDialog(selectedProxy);
			DialogResult result = dlgLanSettings.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				this.gridProxySettings.Refresh();
			}
		}

	}
}