// Project: AdvancedProxy, File: MainForm.cs
// Namespace: Fleischmann.AdvancedProxy, Class: MainForm
// Path: D:\My Documents\Visual Studio 2005\Projects\AdvancedProxy\AdvancedProxy\User Interface, Author: rzd7jx
// Code lines: 170, Size of file: 5.02 KB
// Creation date: 12/30/2006 11:40 AM
// Last modified: 1/11/2007 12:22 PM
// Generated with Commenter by abi.exDream.com

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
		private bool _applicationExiting = false;
		private List<ProxySetting> _proxyList;

		public MainForm(List<ProxySetting> theProxyList)
		{
			InitializeComponent();
			_proxyList = theProxyList;
			this.proxyBindingSource.DataSource = _proxyList;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if (_proxyList.Count == 0)
			{
				DialogResult result = MessageBox.Show("You currently have no Proxy Settings defined.  /n Would you like to create an initial settings based on your current proxy settings in Internet Explorer?", "Create Initial Proxy Set", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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
						_proxyList.Add(currentRegistryProxy);
						this.gridProxySettings.DataSource = _proxyList;
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
			if (!_applicationExiting)
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
			_applicationExiting = true;
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
					_proxyList.Add(newProxy);
					this.gridProxySettings.DataSource = _proxyList;
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
					_proxyList.Remove(selectedProxy);
					this.gridProxySettings.DataSource = _proxyList;
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

		private void cxmNotifyIconMenu_Opening(object sender, CancelEventArgs e)
		{
			//First Clear the list.
			setCurrentProxyToolStripMenuItem.DropDownItems.Clear();

		    foreach (ProxySetting aProxy in _proxyList)
		    {
		        ToolStripItem proxyMenuItem = setCurrentProxyToolStripMenuItem.DropDownItems.Add(aProxy.Name);
				proxyMenuItem.Click += new System.EventHandler(this.proxyMenuItem_Click);
		    }

			useProxyToolStripMenuItem.Checked = ProxySetting.GetUseProxy();

		}

		private void proxyMenuItem_Click(object sender, EventArgs e)
		{
			foreach (ProxySetting aproxy in _proxyList)
			{
				if (aproxy.Name == ((ToolStripItem)sender).Text)
				{
					aproxy.SetAsCurrentProxy();

				}
			}
		}

		private void btnSetAsCurrent_Click(object sender, EventArgs e)
		{
			ProxySetting selectedProxy = (ProxySetting)this.gridProxySettings.SelectedRows[0].DataBoundItem;
			selectedProxy.SetAsCurrentProxy();

		}

	}
}