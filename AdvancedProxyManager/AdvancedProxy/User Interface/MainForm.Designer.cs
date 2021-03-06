namespace Fleischmann.AdvancedProxy
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gridProxySettings = new System.Windows.Forms.DataGridView();
            this.ProxyConfigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProxyConfigDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoDetectSettingsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.useAutoConfigureScriptDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.useAutoConfigureScriptAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useProxyServerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bypassProxyForLocalAddressDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.useProxyServerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useProxyServerPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hTTPProxyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hTTPProxyPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secureProxyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secureProxyPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTPProxyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fTPProxyPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gopherProxyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gopherProxyPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socksProxyAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socksProxyPortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.excludeAddressesFromProxyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.icnProxyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cxmNotifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCurrentProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.useAutoDetectProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useAutoConfigProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.InternetSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.autorunAtStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSetAsCurrent = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.refreshIconTimer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.setAsCurrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureCurrentIESettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProxySettingRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsCurrentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridProxySettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proxyBindingSource)).BeginInit();
            this.cxmNotifyIconMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MenuProxySettingRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridProxySettings
            // 
            this.gridProxySettings.AllowUserToAddRows = false;
            this.gridProxySettings.AllowUserToDeleteRows = false;
            this.gridProxySettings.AllowUserToOrderColumns = true;
            this.gridProxySettings.AllowUserToResizeRows = false;
            this.gridProxySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProxySettings.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProxySettings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProxySettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProxySettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProxyConfigName,
            this.ProxyConfigDescription,
            this.autoDetectSettingsDataGridViewCheckBoxColumn,
            this.useAutoConfigureScriptDataGridViewCheckBoxColumn,
            this.useAutoConfigureScriptAddressDataGridViewTextBoxColumn,
            this.useProxyServerDataGridViewCheckBoxColumn,
            this.bypassProxyForLocalAddressDataGridViewCheckBoxColumn,
            this.useProxyServerAddressDataGridViewTextBoxColumn,
            this.useProxyServerPortDataGridViewTextBoxColumn,
            this.hTTPProxyAddressDataGridViewTextBoxColumn,
            this.hTTPProxyPortDataGridViewTextBoxColumn,
            this.secureProxyAddressDataGridViewTextBoxColumn,
            this.secureProxyPortDataGridViewTextBoxColumn,
            this.fTPProxyAddressDataGridViewTextBoxColumn,
            this.fTPProxyPortDataGridViewTextBoxColumn,
            this.gopherProxyAddressDataGridViewTextBoxColumn,
            this.gopherProxyPortDataGridViewTextBoxColumn,
            this.socksProxyAddressDataGridViewTextBoxColumn,
            this.socksProxyPortDataGridViewTextBoxColumn,
            this.useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn,
            this.excludeAddressesFromProxyDataGridViewTextBoxColumn});
            this.gridProxySettings.DataSource = this.proxyBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProxySettings.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridProxySettings.Location = new System.Drawing.Point(12, 35);
            this.gridProxySettings.MultiSelect = false;
            this.gridProxySettings.Name = "gridProxySettings";
            this.gridProxySettings.ReadOnly = true;
            this.gridProxySettings.RowHeadersVisible = false;
            this.gridProxySettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProxySettings.Size = new System.Drawing.Size(320, 232);
            this.gridProxySettings.TabIndex = 0;
            this.gridProxySettings.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProxySettings_CellMouseUp);
            this.gridProxySettings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProxySettings_CellDoubleClick);
            // 
            // ProxyConfigName
            // 
            this.ProxyConfigName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProxyConfigName.DataPropertyName = "Name";
            this.ProxyConfigName.HeaderText = "Proxy Setting";
            this.ProxyConfigName.Name = "ProxyConfigName";
            this.ProxyConfigName.ReadOnly = true;
            // 
            // ProxyConfigDescription
            // 
            this.ProxyConfigDescription.DataPropertyName = "Description";
            this.ProxyConfigDescription.HeaderText = "Description";
            this.ProxyConfigDescription.Name = "ProxyConfigDescription";
            this.ProxyConfigDescription.ReadOnly = true;
            this.ProxyConfigDescription.Visible = false;
            // 
            // autoDetectSettingsDataGridViewCheckBoxColumn
            // 
            this.autoDetectSettingsDataGridViewCheckBoxColumn.DataPropertyName = "AutoDetectSettings";
            this.autoDetectSettingsDataGridViewCheckBoxColumn.HeaderText = "AutoDetectSettings";
            this.autoDetectSettingsDataGridViewCheckBoxColumn.Name = "autoDetectSettingsDataGridViewCheckBoxColumn";
            this.autoDetectSettingsDataGridViewCheckBoxColumn.ReadOnly = true;
            this.autoDetectSettingsDataGridViewCheckBoxColumn.Visible = false;
            // 
            // useAutoConfigureScriptDataGridViewCheckBoxColumn
            // 
            this.useAutoConfigureScriptDataGridViewCheckBoxColumn.DataPropertyName = "UseAutoConfigureScript";
            this.useAutoConfigureScriptDataGridViewCheckBoxColumn.HeaderText = "UseAutoConfigureScript";
            this.useAutoConfigureScriptDataGridViewCheckBoxColumn.Name = "useAutoConfigureScriptDataGridViewCheckBoxColumn";
            this.useAutoConfigureScriptDataGridViewCheckBoxColumn.ReadOnly = true;
            this.useAutoConfigureScriptDataGridViewCheckBoxColumn.Visible = false;
            // 
            // useAutoConfigureScriptAddressDataGridViewTextBoxColumn
            // 
            this.useAutoConfigureScriptAddressDataGridViewTextBoxColumn.DataPropertyName = "UseAutoConfigureScriptAddress";
            this.useAutoConfigureScriptAddressDataGridViewTextBoxColumn.HeaderText = "UseAutoConfigureScriptAddress";
            this.useAutoConfigureScriptAddressDataGridViewTextBoxColumn.Name = "useAutoConfigureScriptAddressDataGridViewTextBoxColumn";
            this.useAutoConfigureScriptAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.useAutoConfigureScriptAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // useProxyServerDataGridViewCheckBoxColumn
            // 
            this.useProxyServerDataGridViewCheckBoxColumn.DataPropertyName = "UseProxyServer";
            this.useProxyServerDataGridViewCheckBoxColumn.HeaderText = "UseProxyServer";
            this.useProxyServerDataGridViewCheckBoxColumn.Name = "useProxyServerDataGridViewCheckBoxColumn";
            this.useProxyServerDataGridViewCheckBoxColumn.ReadOnly = true;
            this.useProxyServerDataGridViewCheckBoxColumn.Visible = false;
            // 
            // bypassProxyForLocalAddressDataGridViewCheckBoxColumn
            // 
            this.bypassProxyForLocalAddressDataGridViewCheckBoxColumn.DataPropertyName = "BypassProxyForLocalAddress";
            this.bypassProxyForLocalAddressDataGridViewCheckBoxColumn.HeaderText = "BypassProxyForLocalAddress";
            this.bypassProxyForLocalAddressDataGridViewCheckBoxColumn.Name = "bypassProxyForLocalAddressDataGridViewCheckBoxColumn";
            this.bypassProxyForLocalAddressDataGridViewCheckBoxColumn.ReadOnly = true;
            this.bypassProxyForLocalAddressDataGridViewCheckBoxColumn.Visible = false;
            // 
            // useProxyServerAddressDataGridViewTextBoxColumn
            // 
            this.useProxyServerAddressDataGridViewTextBoxColumn.DataPropertyName = "UseProxyServerAddress";
            this.useProxyServerAddressDataGridViewTextBoxColumn.HeaderText = "UseProxyServerAddress";
            this.useProxyServerAddressDataGridViewTextBoxColumn.Name = "useProxyServerAddressDataGridViewTextBoxColumn";
            this.useProxyServerAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.useProxyServerAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // useProxyServerPortDataGridViewTextBoxColumn
            // 
            this.useProxyServerPortDataGridViewTextBoxColumn.DataPropertyName = "UseProxyServerPort";
            this.useProxyServerPortDataGridViewTextBoxColumn.HeaderText = "UseProxyServerPort";
            this.useProxyServerPortDataGridViewTextBoxColumn.Name = "useProxyServerPortDataGridViewTextBoxColumn";
            this.useProxyServerPortDataGridViewTextBoxColumn.ReadOnly = true;
            this.useProxyServerPortDataGridViewTextBoxColumn.Visible = false;
            // 
            // hTTPProxyAddressDataGridViewTextBoxColumn
            // 
            this.hTTPProxyAddressDataGridViewTextBoxColumn.DataPropertyName = "HTTPProxyAddress";
            this.hTTPProxyAddressDataGridViewTextBoxColumn.HeaderText = "HTTPProxyAddress";
            this.hTTPProxyAddressDataGridViewTextBoxColumn.Name = "hTTPProxyAddressDataGridViewTextBoxColumn";
            this.hTTPProxyAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.hTTPProxyAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // hTTPProxyPortDataGridViewTextBoxColumn
            // 
            this.hTTPProxyPortDataGridViewTextBoxColumn.DataPropertyName = "HTTPProxyPort";
            this.hTTPProxyPortDataGridViewTextBoxColumn.HeaderText = "HTTPProxyPort";
            this.hTTPProxyPortDataGridViewTextBoxColumn.Name = "hTTPProxyPortDataGridViewTextBoxColumn";
            this.hTTPProxyPortDataGridViewTextBoxColumn.ReadOnly = true;
            this.hTTPProxyPortDataGridViewTextBoxColumn.Visible = false;
            // 
            // secureProxyAddressDataGridViewTextBoxColumn
            // 
            this.secureProxyAddressDataGridViewTextBoxColumn.DataPropertyName = "SecureProxyAddress";
            this.secureProxyAddressDataGridViewTextBoxColumn.HeaderText = "SecureProxyAddress";
            this.secureProxyAddressDataGridViewTextBoxColumn.Name = "secureProxyAddressDataGridViewTextBoxColumn";
            this.secureProxyAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.secureProxyAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // secureProxyPortDataGridViewTextBoxColumn
            // 
            this.secureProxyPortDataGridViewTextBoxColumn.DataPropertyName = "SecureProxyPort";
            this.secureProxyPortDataGridViewTextBoxColumn.HeaderText = "SecureProxyPort";
            this.secureProxyPortDataGridViewTextBoxColumn.Name = "secureProxyPortDataGridViewTextBoxColumn";
            this.secureProxyPortDataGridViewTextBoxColumn.ReadOnly = true;
            this.secureProxyPortDataGridViewTextBoxColumn.Visible = false;
            // 
            // fTPProxyAddressDataGridViewTextBoxColumn
            // 
            this.fTPProxyAddressDataGridViewTextBoxColumn.DataPropertyName = "FTPProxyAddress";
            this.fTPProxyAddressDataGridViewTextBoxColumn.HeaderText = "FTPProxyAddress";
            this.fTPProxyAddressDataGridViewTextBoxColumn.Name = "fTPProxyAddressDataGridViewTextBoxColumn";
            this.fTPProxyAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.fTPProxyAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // fTPProxyPortDataGridViewTextBoxColumn
            // 
            this.fTPProxyPortDataGridViewTextBoxColumn.DataPropertyName = "FTPProxyPort";
            this.fTPProxyPortDataGridViewTextBoxColumn.HeaderText = "FTPProxyPort";
            this.fTPProxyPortDataGridViewTextBoxColumn.Name = "fTPProxyPortDataGridViewTextBoxColumn";
            this.fTPProxyPortDataGridViewTextBoxColumn.ReadOnly = true;
            this.fTPProxyPortDataGridViewTextBoxColumn.Visible = false;
            // 
            // gopherProxyAddressDataGridViewTextBoxColumn
            // 
            this.gopherProxyAddressDataGridViewTextBoxColumn.DataPropertyName = "GopherProxyAddress";
            this.gopherProxyAddressDataGridViewTextBoxColumn.HeaderText = "GopherProxyAddress";
            this.gopherProxyAddressDataGridViewTextBoxColumn.Name = "gopherProxyAddressDataGridViewTextBoxColumn";
            this.gopherProxyAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.gopherProxyAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // gopherProxyPortDataGridViewTextBoxColumn
            // 
            this.gopherProxyPortDataGridViewTextBoxColumn.DataPropertyName = "GopherProxyPort";
            this.gopherProxyPortDataGridViewTextBoxColumn.HeaderText = "GopherProxyPort";
            this.gopherProxyPortDataGridViewTextBoxColumn.Name = "gopherProxyPortDataGridViewTextBoxColumn";
            this.gopherProxyPortDataGridViewTextBoxColumn.ReadOnly = true;
            this.gopherProxyPortDataGridViewTextBoxColumn.Visible = false;
            // 
            // socksProxyAddressDataGridViewTextBoxColumn
            // 
            this.socksProxyAddressDataGridViewTextBoxColumn.DataPropertyName = "SocksProxyAddress";
            this.socksProxyAddressDataGridViewTextBoxColumn.HeaderText = "SocksProxyAddress";
            this.socksProxyAddressDataGridViewTextBoxColumn.Name = "socksProxyAddressDataGridViewTextBoxColumn";
            this.socksProxyAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.socksProxyAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // socksProxyPortDataGridViewTextBoxColumn
            // 
            this.socksProxyPortDataGridViewTextBoxColumn.DataPropertyName = "SocksProxyPort";
            this.socksProxyPortDataGridViewTextBoxColumn.HeaderText = "SocksProxyPort";
            this.socksProxyPortDataGridViewTextBoxColumn.Name = "socksProxyPortDataGridViewTextBoxColumn";
            this.socksProxyPortDataGridViewTextBoxColumn.ReadOnly = true;
            this.socksProxyPortDataGridViewTextBoxColumn.Visible = false;
            // 
            // useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn
            // 
            this.useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn.DataPropertyName = "UseSameProxyServerForAllProtocols";
            this.useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn.HeaderText = "UseSameProxyServerForAllProtocols";
            this.useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn.Name = "useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn";
            this.useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn.ReadOnly = true;
            this.useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn.Visible = false;
            // 
            // excludeAddressesFromProxyDataGridViewTextBoxColumn
            // 
            this.excludeAddressesFromProxyDataGridViewTextBoxColumn.DataPropertyName = "ExcludeAddressesFromProxy";
            this.excludeAddressesFromProxyDataGridViewTextBoxColumn.HeaderText = "ExcludeAddressesFromProxy";
            this.excludeAddressesFromProxyDataGridViewTextBoxColumn.Name = "excludeAddressesFromProxyDataGridViewTextBoxColumn";
            this.excludeAddressesFromProxyDataGridViewTextBoxColumn.ReadOnly = true;
            this.excludeAddressesFromProxyDataGridViewTextBoxColumn.Visible = false;
            // 
            // proxyBindingSource
            // 
            this.proxyBindingSource.DataSource = typeof(Fleischmann.AdvancedProxy.ProxySetting);
            // 
            // icnProxyNotifyIcon
            // 
            this.icnProxyNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.icnProxyNotifyIcon.BalloonTipText = "Easily control all of Internet Explorer\'s Proxy Settings.";
            this.icnProxyNotifyIcon.BalloonTipTitle = "Advanced Proxy Configurations";
            this.icnProxyNotifyIcon.ContextMenuStrip = this.cxmNotifyIconMenu;
            this.icnProxyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("icnProxyNotifyIcon.Icon")));
            this.icnProxyNotifyIcon.Text = "Advanced Proxy Manager";
            this.icnProxyNotifyIcon.Visible = true;
            this.icnProxyNotifyIcon.DoubleClick += new System.EventHandler(this.icnProxyNotifyIcon_DoubleClick);
            // 
            // cxmNotifyIconMenu
            // 
            this.cxmNotifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.setCurrentProxyToolStripMenuItem,
            this.toolStripSeparator3,
            this.useAutoDetectProxyToolStripMenuItem,
            this.useAutoConfigProxyToolStripMenuItem,
            this.useProxyToolStripMenuItem,
            this.toolStripSeparator2,
            this.InternetSettingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.autorunAtStartupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cxmNotifyIconMenu.Name = "cxmNotifyIconMenu";
            this.cxmNotifyIconMenu.Size = new System.Drawing.Size(185, 198);
            this.cxmNotifyIconMenu.Text = "Advanced Proxy Manager";
            this.cxmNotifyIconMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cxmNotifyIconMenu_Opening);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.configureToolStripMenuItem.Text = "Edit Configurations";
            this.configureToolStripMenuItem.ToolTipText = "Brings up the dialog that allows creating and editing of the proxy configurations" +
                ".";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
            // 
            // setCurrentProxyToolStripMenuItem
            // 
            this.setCurrentProxyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstProxyToolStripMenuItem});
            this.setCurrentProxyToolStripMenuItem.Name = "setCurrentProxyToolStripMenuItem";
            this.setCurrentProxyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.setCurrentProxyToolStripMenuItem.Text = "Set Current Proxy To";
            this.setCurrentProxyToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setCurrentProxyToolStripMenuItem.ToolTipText = "Use this to quickly set the proxy to a set of previously configured settings.";
            // 
            // firstProxyToolStripMenuItem
            // 
            this.firstProxyToolStripMenuItem.Name = "firstProxyToolStripMenuItem";
            this.firstProxyToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.firstProxyToolStripMenuItem.Text = "FirstProxy";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(181, 6);
            // 
            // useAutoDetectProxyToolStripMenuItem
            // 
            this.useAutoDetectProxyToolStripMenuItem.Name = "useAutoDetectProxyToolStripMenuItem";
            this.useAutoDetectProxyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.useAutoDetectProxyToolStripMenuItem.Text = "Use Auto Detect Proxy";
            this.useAutoDetectProxyToolStripMenuItem.ToolTipText = "Toggle the use of Auto Detection for determining proxy settings.";
            this.useAutoDetectProxyToolStripMenuItem.Click += new System.EventHandler(this.useAutoDetectProxyToolStripMenuItem_Click);
            // 
            // useAutoConfigProxyToolStripMenuItem
            // 
            this.useAutoConfigProxyToolStripMenuItem.Name = "useAutoConfigProxyToolStripMenuItem";
            this.useAutoConfigProxyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.useAutoConfigProxyToolStripMenuItem.Text = "Use Auto Config Scrpt";
            this.useAutoConfigProxyToolStripMenuItem.ToolTipText = "Toggle the use of an Auto Configuration Script for determining proxy settings.";
            this.useAutoConfigProxyToolStripMenuItem.Click += new System.EventHandler(this.useAutoConfigProxyToolStripMenuItem_Click);
            // 
            // useProxyToolStripMenuItem
            // 
            this.useProxyToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.useProxyToolStripMenuItem.Name = "useProxyToolStripMenuItem";
            this.useProxyToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.useProxyToolStripMenuItem.Text = "Use Custom Proxy ";
            this.useProxyToolStripMenuItem.ToolTipText = "Toggle the Use of custom proxy server(s).";
            this.useProxyToolStripMenuItem.Click += new System.EventHandler(this.useProxyToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // InternetSettingsToolStripMenuItem
            // 
            this.InternetSettingsToolStripMenuItem.Name = "InternetSettingsToolStripMenuItem";
            this.InternetSettingsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.InternetSettingsToolStripMenuItem.Text = "Internet Settings...";
            this.InternetSettingsToolStripMenuItem.ToolTipText = "Open the Internet Settings control panel.";
            this.InternetSettingsToolStripMenuItem.Click += new System.EventHandler(this.InternetSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // autorunAtStartupToolStripMenuItem
            // 
            this.autorunAtStartupToolStripMenuItem.Name = "autorunAtStartupToolStripMenuItem";
            this.autorunAtStartupToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.autorunAtStartupToolStripMenuItem.Text = "Autorun at Startup";
            this.autorunAtStartupToolStripMenuItem.ToolTipText = "Enable Advanced Proxy Configuration program to automatically run every time windo" +
                "ws starts.";
            this.autorunAtStartupToolStripMenuItem.Click += new System.EventHandler(this.autorunAtStartupToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(69, 272);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSetAsCurrent
            // 
            this.btnSetAsCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetAsCurrent.Location = new System.Drawing.Point(180, 272);
            this.btnSetAsCurrent.Name = "btnSetAsCurrent";
            this.btnSetAsCurrent.Size = new System.Drawing.Size(95, 23);
            this.btnSetAsCurrent.TabIndex = 2;
            this.btnSetAsCurrent.Text = "Set As Current";
            this.btnSetAsCurrent.UseVisualStyleBackColor = true;
            this.btnSetAsCurrent.Click += new System.EventHandler(this.btnSetAsCurrent_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(121, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(11, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(285, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(49, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // refreshIconTimer
            // 
            this.refreshIconTimer.Enabled = true;
            this.refreshIconTimer.Interval = 1000;
            this.refreshIconTimer.Tick += new System.EventHandler(this.refreshIconTimer_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "ProxyList.pxy";
            this.saveFileDialog.InitialDirectory = "My Documents";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.proxyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(344, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "&Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // proxyToolStripMenuItem
            // 
            this.proxyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator5,
            this.setAsCurrentToolStripMenuItem,
            this.captureCurrentIESettingsToolStripMenuItem});
            this.proxyToolStripMenuItem.Name = "proxyToolStripMenuItem";
            this.proxyToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.proxyToolStripMenuItem.Text = "&Proxy";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addToolStripMenuItem.Text = "&Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(154, 6);
            // 
            // setAsCurrentToolStripMenuItem
            // 
            this.setAsCurrentToolStripMenuItem.Name = "setAsCurrentToolStripMenuItem";
            this.setAsCurrentToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.setAsCurrentToolStripMenuItem.Text = "Set as Current";
            this.setAsCurrentToolStripMenuItem.Click += new System.EventHandler(this.btnSetAsCurrent_Click);
            // 
            // captureCurrentIESettingsToolStripMenuItem
            // 
            this.captureCurrentIESettingsToolStripMenuItem.Name = "captureCurrentIESettingsToolStripMenuItem";
            this.captureCurrentIESettingsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.captureCurrentIESettingsToolStripMenuItem.Text = "Capture IE Proxy";
            this.captureCurrentIESettingsToolStripMenuItem.ToolTipText = "Captures the current proxy settings in IE and creates a new Proxy Setting.";
            this.captureCurrentIESettingsToolStripMenuItem.Click += new System.EventHandler(this.captureCurrentIESettingsToolStripMenuItem_Click);
            // 
            // MenuProxySettingRightClick
            // 
            this.MenuProxySettingRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.setAsCurrentToolStripMenuItem1});
            this.MenuProxySettingRightClick.Name = "MenuProxySettingRightClick";
            this.MenuProxySettingRightClick.ShowImageMargin = false;
            this.MenuProxySettingRightClick.Size = new System.Drawing.Size(131, 92);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.copyToolStripMenuItem.Text = "C&opy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.deleteToolStripMenuItem1.Text = "&Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.editToolStripMenuItem1.Text = "&Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // setAsCurrentToolStripMenuItem1
            // 
            this.setAsCurrentToolStripMenuItem1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.setAsCurrentToolStripMenuItem1.Name = "setAsCurrentToolStripMenuItem1";
            this.setAsCurrentToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.setAsCurrentToolStripMenuItem1.Text = "&Set as Current";
            this.setAsCurrentToolStripMenuItem1.Click += new System.EventHandler(this.btnSetAsCurrent_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.pxy";
            this.openFileDialog.FileName = "ProxyList.pxy";
            this.openFileDialog.Filter = "Proxy Files|*.pxy|All Files|*.*";
            this.openFileDialog.InitialDirectory = "My Documents";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 307);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSetAsCurrent);
            this.Controls.Add(this.gridProxySettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Advanced Proxy Configurations";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gridProxySettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proxyBindingSource)).EndInit();
            this.cxmNotifyIconMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MenuProxySettingRightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridProxySettings;
		private System.Windows.Forms.BindingSource proxyBindingSource;
		private System.Windows.Forms.NotifyIcon icnProxyNotifyIcon;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSetAsCurrent;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Timer refreshIconTimer;
		private System.Windows.Forms.ContextMenuStrip cxmNotifyIconMenu;
		private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setCurrentProxyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem firstProxyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem useProxyToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem InternetSettingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem autorunAtStartupToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem useAutoDetectProxyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem useAutoConfigProxyToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem proxyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem setAsCurrentToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip MenuProxySettingRightClick;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem setAsCurrentToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProxyConfigName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProxyConfigDescription;
		private System.Windows.Forms.DataGridViewCheckBoxColumn autoDetectSettingsDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn useAutoConfigureScriptDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn useAutoConfigureScriptAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn useProxyServerDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn bypassProxyForLocalAddressDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn useProxyServerAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn useProxyServerPortDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hTTPProxyAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hTTPProxyPortDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn secureProxyAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn secureProxyPortDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fTPProxyAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fTPProxyPortDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gopherProxyAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn gopherProxyPortDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn socksProxyAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn socksProxyPortDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn excludeAddressesFromProxyDataGridViewTextBoxColumn;
		private System.Windows.Forms.ToolStripMenuItem captureCurrentIESettingsToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;

	}
}