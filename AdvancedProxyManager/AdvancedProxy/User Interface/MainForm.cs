// Project: AdvancedProxy, File: MainForm.cs
// Namespace: Fleischmann.AdvancedProxy, Class: MainForm
// Path: D:\My Documents\Visual Studio 2005\Projects\AdvancedProxy\AdvancedProxy\User Interface, Author: rzd7jx
// Code lines: 170, Size of file: 5.02 KB
// Creation date: 12/30/2006 11:40 AM
// Last modified: 1/15/2007 3:18 PM
// Generated with Commenter by abi.exDream.com

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
		#region Private Fields
		private Icon enabledIcon = new Icon(Application.StartupPath + "\\Enabled.ico");
		private Icon disabledIcon = new Icon(Application.StartupPath + "\\Disabled.ico");

		private const string BaseAutoRunKey = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";

		private const int WM_QUERYENDSESSION = 0x11;
		private bool _applicationExiting = false;
		private SortableBindingList<ProxySetting> _proxyList;
		private bool endSessionPending;

		private SortOrder currentSortOrder = SortOrder.Ascending;
		#endregion

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="MainForm"/> class.
		/// </summary>
		/// <param name="theProxyList">The proxy list.</param>
		public MainForm(SortableBindingList<ProxySetting> theProxyList)
		{
			InitializeComponent();

			_proxyList = theProxyList;
			_proxyList.Sort("Name", ListSortDirection.Ascending);
			this.proxyBindingSource.DataSource = _proxyList;

			this.gridProxySettings.Columns[0].HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.Ascending;
			this.gridProxySettings.Refresh();

			//Handle Power events
			SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(SystemEvents_PowerModeChanged);

			icnProxyNotifyIcon.ShowBalloonTip(1); // when first opening display a balloon tip.
		} 
		#endregion

		#region Form Load and Closing Events
		/// <summary>
		/// Handles the Load event of the MainForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			RefreshTrayIcon();
		}

		/// <summary>
		/// Handles the FormClosing event of the MainForm control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (endSessionPending)
			{
				// The session is ending.
				e.Cancel = false;
			}
			else if (!_applicationExiting)
			{
				//DialogResult result = MessageBox.Show("Minimize to System Tray?", "Closing Advanced Proxy Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				//if (result == DialogResult.Yes)
				//{
				this.Hide();
				e.Cancel = true;
				//}
			}
			base.OnClosing(e);
		} 
		#endregion

		#region Power Changes and Shutdown Handling
		/// <summary>
		/// Overrides the WNDs the proc.
		/// Capture the shutdown events.
		/// </summary>
		/// <param name="m">The m.</param>
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_QUERYENDSESSION)
				endSessionPending = true;
			base.WndProc(ref m);
		}

		/// <summary>
		/// Handles the PowerModeChanged event of the SystemEvents control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="Microsoft.Win32.PowerModeChangedEventArgs"/> instance containing the event data.</param>
		private void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
		{
			if (e.Mode == PowerModes.Resume)
			{
				RefreshTrayIcon();
				icnProxyNotifyIcon.ShowBalloonTip(10);
			}
		} 
		#endregion

		#region Button and Grid Click Events
		/// <summary>
		/// Handles the Click event of the btnAdd control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void btnAdd_Click(object sender, EventArgs e)
		{
			ProxyNamePromptDialog dlgNamePrompt = new ProxyNamePromptDialog(_proxyList);
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
					_proxyList.Sort();
					//this.gridProxySettings.DataSource = null;
					//this.gridProxySettings.DataSource = _proxyList;
					//this.gridProxySettings.Refresh();
				}
			}
		}

		/// <summary>
		/// Handles the Click event of the btnEdit control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void btnEdit_Click(object sender, EventArgs e)
		{
			int selectedProxyPosition = this.gridProxySettings.SelectedRows[0].Index;
			EditProxy(selectedProxyPosition);
		}

		/// <summary>
		/// Handles the Click event of the btnDelete control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			ProxySetting selectedProxy = (ProxySetting)this.gridProxySettings.SelectedRows[0].DataBoundItem;
			DialogResult result = MessageBox.Show(this,"Are you sure you want to delete the \"" + selectedProxy.Name + "\" proxy setting?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
//				this.gridProxySettings.DataSource = null;
				selectedProxy.DeleteFromConfig();
				_proxyList.Remove(selectedProxy);
				_proxyList.Sort();
//				this.gridProxySettings.DataSource = _proxyList;
//				this.gridProxySettings.Refresh();
			}
		}

		/// <summary>
		/// Handles the Click event of the btnSetAsCurrent control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void btnSetAsCurrent_Click(object sender, EventArgs e)
		{
			ProxySetting selectedProxy = (ProxySetting)this.gridProxySettings.SelectedRows[0].DataBoundItem;
			selectedProxy.SetAsCurrentProxy();
		}

		/// <summary>
		/// Handles the Click event of the btnExit control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
			this.Close();
		}

		/// <summary>
		/// Handles the CellDoubleClick event of the gridProxySettings control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.Windows.Forms.DataGridViewCellEventArgs"/> instance containing the event data.</param>
		private void gridProxySettings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex > -1)
			{
				EditProxy(e.RowIndex);
			}
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ProxySetting selectedProxy = (ProxySetting)this.gridProxySettings.SelectedRows[0].DataBoundItem;
			ProxySetting newProxy = selectedProxy.Clone();
			ProxyNamePromptDialog dlgNamePrompt = new ProxyNamePromptDialog(_proxyList);
			dlgNamePrompt.txtName.Text = selectedProxy.Name + "_copy";
			DialogResult result = dlgNamePrompt.ShowDialog();
			if (result == DialogResult.OK)
			{
				newProxy.Name = dlgNamePrompt.txtName.Text;

				//Add the proxy
				newProxy.SaveInConfigFile();
				_proxyList.Add(newProxy);
				_proxyList.Sort();

				//refresh the grid.
				//this.gridProxySettings.DataSource = null; //clear grid first.
				//this.gridProxySettings.DataSource = _proxyList;
				//this.gridProxySettings.Refresh();
			}

		}

		private void gridProxySettings_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				if (e.RowIndex >= 0)
				{
					// Select the row the user has clicked.
					// The row appears selected until the menu is displayed on the screen.
					DataGridViewRow clickedRow = gridProxySettings.Rows[e.RowIndex];
					DataGridViewRow oldSelectedRow = gridProxySettings.SelectedRows[0];
					oldSelectedRow.Selected = false;
					clickedRow.Selected = true;

					//Display context menu at mouse position
					Point mousePosition = new Point(e.X, e.Y);
					MenuProxySettingRightClick.Show(gridProxySettings, mousePosition);

					//Reset selected row
					//clickedRow.Selected = false;
					//oldSelectedRow.Selected = true;
				}
			}
		}

		#endregion

		#region Notification Area (System Tray) Icon and Menu Methods 
		/// <summary>
		/// Handles the Tick event of the refreshIconTimer control.
		/// Keeps the tray icon matching the status of the Proxy Enable options
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void refreshIconTimer_Tick(object sender, EventArgs e)
		{
			RefreshTrayIcon();
		}

		/// <summary>
		/// Refreshes the tray icon.
		/// </summary>
		private void RefreshTrayIcon()
		{
			if (ProxySetting.AnyCurrentActiveProxySet())
			{
				this.icnProxyNotifyIcon.Icon = enabledIcon;

			}
			else
			{
				this.icnProxyNotifyIcon.Icon = disabledIcon;

			}
		}

		/// <summary>
		/// Handles the DoubleClick event of the icnProxyNotifyIcon control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void icnProxyNotifyIcon_DoubleClick(object sender, EventArgs e)
		{
			useProxyToolStripMenuItem_Click(sender, e);
		}

		/// <summary>
		/// Handles the Opening event of the cxmNotifyIconMenu control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.ComponentModel.CancelEventArgs"/> instance containing the event data.</param>
		private void cxmNotifyIconMenu_Opening(object sender, CancelEventArgs e)
		{
			//populate the set config... dropdown
			setCurrentProxyToolStripMenuItem.DropDownItems.Clear();
			foreach (ProxySetting aProxy in _proxyList)
			{
				ToolStripItem proxyMenuItem = setCurrentProxyToolStripMenuItem.DropDownItems.Add(aProxy.Name);
				proxyMenuItem.Click += new System.EventHandler(this.proxyMenuItem_Click);
			}

			//set the check marks on the proxy flags
			useAutoDetectProxyToolStripMenuItem.Checked = ProxySetting.GetCurrentActiveAutoDetectProxy();
			useAutoConfigProxyToolStripMenuItem.Checked = ProxySetting.GetCurrentActiveAutoConfigProxy();
			useProxyToolStripMenuItem.Checked = ProxySetting.GetCurrentActiveUseProxy();

			//set the check mark on the autorun option.
			RegistryKey autoRunKey = Registry.CurrentUser.OpenSubKey(BaseAutoRunKey);
			string autorunexe = Convert.ToString(autoRunKey.GetValue("Advanced Proxy Manager"));
			if (string.IsNullOrEmpty(autorunexe))
			{
				autorunAtStartupToolStripMenuItem.Checked = false;
			}
			else
			{
				autorunAtStartupToolStripMenuItem.Checked = true;
			}


		}

		/// <summary>
		/// Handles the Click event of the configureToolStripMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void configureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Show();
			this.BringToFront();
		}

		/// <summary>
		/// Handles the Click event of the useAutoDetectProxyToolStripMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void useAutoDetectProxyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool useProxy = !useAutoDetectProxyToolStripMenuItem.Checked;
			useAutoDetectProxyToolStripMenuItem.Checked = useProxy;
			ProxySetting.ModifyCurrentActiveAutoDetectProxy(useProxy);

			RefreshTrayIcon();
		}

		/// <summary>
		/// Handles the Click event of the useAutoConfigProxyToolStripMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void useAutoConfigProxyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool useProxy = !useAutoConfigProxyToolStripMenuItem.Checked;
			useAutoConfigProxyToolStripMenuItem.Checked = useProxy;

			if (useProxy)
			{
				string currentAutoConfigURL = ProxySetting.GetCurrentActiveAutoConfigURL();
				AutoConfigScriptPromptForm frmConfigScript = new AutoConfigScriptPromptForm();
				frmConfigScript.txtAddress.Text = currentAutoConfigURL;
				DialogResult result = frmConfigScript.ShowDialog();
				if (result == DialogResult.OK)
				{
					ProxySetting.ModifyCurrentActiveAutoConfigProxyURL(frmConfigScript.txtAddress.Text);
				}
				else
				{
					return;
				}
			}

			ProxySetting.ModifyCurrentActiveAutoConfigProxy(useProxy);

			RefreshTrayIcon();

		}

		/// <summary>
		/// Handles the Click event of the useProxyToolStripMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void useProxyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool useProxy = !useProxyToolStripMenuItem.Checked;
			useProxyToolStripMenuItem.Checked = useProxy;
			ProxySetting.ModifyCurrentActiveUseProxy(useProxy);

			RefreshTrayIcon();
		}

		/// <summary>
		/// Handles the Click event of the proxyMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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

		/// <summary>
		/// Handles the Click event of the InternetSettingsToolStripMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void InternetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			WinInetInterop.DisplayInternetControlPanel(this.Handle);
		}

		/// <summary>
		/// Handles the Click event of the autorunAtStartupToolStripMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void autorunAtStartupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool autoRun = !autorunAtStartupToolStripMenuItem.Checked;
			autorunAtStartupToolStripMenuItem.Checked = autoRun;
			string installdir = Application.ExecutablePath;
			RegistryKey currentUserKey = Registry.CurrentUser;
			RegistryKey autoRunKey = currentUserKey.OpenSubKey(BaseAutoRunKey, true);
			if (autoRun)
			{
				autoRunKey.SetValue("Advanced Proxy Manager", installdir);
			}
			else
			{
				autoRunKey.DeleteValue("Advanced Proxy Manager");
			}
		}

		/// <summary>
		/// Handles the Click event of the exitToolStripMenuItem control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_applicationExiting = true;
			this.icnProxyNotifyIcon.Visible = false;
			Application.Exit();
		}
		#endregion

		#region Edit Proxy Method
		/// <summary>
		/// Edits the proxy.
		/// </summary>
		/// <param name="selectedProxyPosition">The selected proxy position in the array.</param>
		private void EditProxy(int selectedProxyPosition)
		{
			//make a copy of the current selected proxy setting so we can ignore when user cancels.
			ProxySetting selectedProxy = _proxyList[selectedProxyPosition].Clone();
			LanSettingDialog dlgLanSettings = new LanSettingDialog(selectedProxy);
			DialogResult result = dlgLanSettings.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				selectedProxy.SaveInConfigFile();
				//replace the one in the list
				_proxyList[selectedProxyPosition] = selectedProxy;
				this.gridProxySettings.Refresh();
			}
		} 
		#endregion 

	}
}