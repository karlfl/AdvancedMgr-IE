namespace fleischmann.advancedproxy
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.gridProxySettings = new System.Windows.Forms.DataGridView();
			this.ProxyConfigName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProxyConfigDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.icnProxyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.cxmNotifyIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.useProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSetAsCurrent = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridProxySettings)).BeginInit();
			this.cxmNotifyIconMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.proxyBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// gridProxySettings
			// 
			this.gridProxySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.gridProxySettings.AutoGenerateColumns = false;
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
			this.gridProxySettings.Location = new System.Drawing.Point(12, 12);
			this.gridProxySettings.Name = "gridProxySettings";
			this.gridProxySettings.ReadOnly = true;
			this.gridProxySettings.RowHeadersVisible = false;
			this.gridProxySettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridProxySettings.Size = new System.Drawing.Size(847, 244);
			this.gridProxySettings.TabIndex = 0;
			// 
			// ProxyConfigName
			// 
			this.ProxyConfigName.DataPropertyName = "Name";
			this.ProxyConfigName.HeaderText = "Name";
			this.ProxyConfigName.Name = "ProxyConfigName";
			this.ProxyConfigName.ReadOnly = true;
			// 
			// ProxyConfigDescription
			// 
			this.ProxyConfigDescription.DataPropertyName = "Description";
			this.ProxyConfigDescription.HeaderText = "Description";
			this.ProxyConfigDescription.Name = "ProxyConfigDescription";
			this.ProxyConfigDescription.ReadOnly = true;
			// 
			// icnProxyNotifyIcon
			// 
			this.icnProxyNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.icnProxyNotifyIcon.BalloonTipText = "Easily control all of Internet Explorer\'s Proxy Settings.";
			this.icnProxyNotifyIcon.BalloonTipTitle = "Anvanced Proxy Configurations";
			this.icnProxyNotifyIcon.ContextMenuStrip = this.cxmNotifyIconMenu;
			this.icnProxyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("icnProxyNotifyIcon.Icon")));
			this.icnProxyNotifyIcon.Text = "ProxyNotifyIcon";
			this.icnProxyNotifyIcon.Visible = true;
			this.icnProxyNotifyIcon.DoubleClick += new System.EventHandler(this.icnProxyNotifyIcon_DoubleClick);
			// 
			// cxmNotifyIconMenu
			// 
			this.cxmNotifyIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.useProxyToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.cxmNotifyIconMenu.Name = "cxmNotifyIconMenu";
			this.cxmNotifyIconMenu.Size = new System.Drawing.Size(181, 76);
			// 
			// configureToolStripMenuItem
			// 
			this.configureToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
			this.configureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.configureToolStripMenuItem.Text = "Edit Configurations";
			this.configureToolStripMenuItem.Click += new System.EventHandler(this.configureToolStripMenuItem_Click);
			// 
			// useProxyToolStripMenuItem
			// 
			this.useProxyToolStripMenuItem.Name = "useProxyToolStripMenuItem";
			this.useProxyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.useProxyToolStripMenuItem.Text = "Use Proxy";
			this.useProxyToolStripMenuItem.Click += new System.EventHandler(this.useProxyToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// autoDetectSettingsDataGridViewCheckBoxColumn
			// 
			this.autoDetectSettingsDataGridViewCheckBoxColumn.DataPropertyName = "AutoDetectSettings";
			this.autoDetectSettingsDataGridViewCheckBoxColumn.HeaderText = "AutoDetectSettings";
			this.autoDetectSettingsDataGridViewCheckBoxColumn.Name = "autoDetectSettingsDataGridViewCheckBoxColumn";
			this.autoDetectSettingsDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// useAutoConfigureScriptDataGridViewCheckBoxColumn
			// 
			this.useAutoConfigureScriptDataGridViewCheckBoxColumn.DataPropertyName = "UseAutoConfigureScript";
			this.useAutoConfigureScriptDataGridViewCheckBoxColumn.HeaderText = "UseAutoConfigureScript";
			this.useAutoConfigureScriptDataGridViewCheckBoxColumn.Name = "useAutoConfigureScriptDataGridViewCheckBoxColumn";
			this.useAutoConfigureScriptDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// useAutoConfigureScriptAddressDataGridViewTextBoxColumn
			// 
			this.useAutoConfigureScriptAddressDataGridViewTextBoxColumn.DataPropertyName = "UseAutoConfigureScriptAddress";
			this.useAutoConfigureScriptAddressDataGridViewTextBoxColumn.HeaderText = "UseAutoConfigureScriptAddress";
			this.useAutoConfigureScriptAddressDataGridViewTextBoxColumn.Name = "useAutoConfigureScriptAddressDataGridViewTextBoxColumn";
			this.useAutoConfigureScriptAddressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// useProxyServerDataGridViewCheckBoxColumn
			// 
			this.useProxyServerDataGridViewCheckBoxColumn.DataPropertyName = "UseProxyServer";
			this.useProxyServerDataGridViewCheckBoxColumn.HeaderText = "UseProxyServer";
			this.useProxyServerDataGridViewCheckBoxColumn.Name = "useProxyServerDataGridViewCheckBoxColumn";
			this.useProxyServerDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// bypassProxyForLocalAddressDataGridViewCheckBoxColumn
			// 
			this.bypassProxyForLocalAddressDataGridViewCheckBoxColumn.DataPropertyName = "BypassProxyForLocalAddress";
			this.bypassProxyForLocalAddressDataGridViewCheckBoxColumn.HeaderText = "BypassProxyForLocalAddress";
			this.bypassProxyForLocalAddressDataGridViewCheckBoxColumn.Name = "bypassProxyForLocalAddressDataGridViewCheckBoxColumn";
			this.bypassProxyForLocalAddressDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// useProxyServerAddressDataGridViewTextBoxColumn
			// 
			this.useProxyServerAddressDataGridViewTextBoxColumn.DataPropertyName = "UseProxyServerAddress";
			this.useProxyServerAddressDataGridViewTextBoxColumn.HeaderText = "UseProxyServerAddress";
			this.useProxyServerAddressDataGridViewTextBoxColumn.Name = "useProxyServerAddressDataGridViewTextBoxColumn";
			this.useProxyServerAddressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// useProxyServerPortDataGridViewTextBoxColumn
			// 
			this.useProxyServerPortDataGridViewTextBoxColumn.DataPropertyName = "UseProxyServerPort";
			this.useProxyServerPortDataGridViewTextBoxColumn.HeaderText = "UseProxyServerPort";
			this.useProxyServerPortDataGridViewTextBoxColumn.Name = "useProxyServerPortDataGridViewTextBoxColumn";
			this.useProxyServerPortDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hTTPProxyAddressDataGridViewTextBoxColumn
			// 
			this.hTTPProxyAddressDataGridViewTextBoxColumn.DataPropertyName = "HTTPProxyAddress";
			this.hTTPProxyAddressDataGridViewTextBoxColumn.HeaderText = "HTTPProxyAddress";
			this.hTTPProxyAddressDataGridViewTextBoxColumn.Name = "hTTPProxyAddressDataGridViewTextBoxColumn";
			this.hTTPProxyAddressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// hTTPProxyPortDataGridViewTextBoxColumn
			// 
			this.hTTPProxyPortDataGridViewTextBoxColumn.DataPropertyName = "HTTPProxyPort";
			this.hTTPProxyPortDataGridViewTextBoxColumn.HeaderText = "HTTPProxyPort";
			this.hTTPProxyPortDataGridViewTextBoxColumn.Name = "hTTPProxyPortDataGridViewTextBoxColumn";
			this.hTTPProxyPortDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// secureProxyAddressDataGridViewTextBoxColumn
			// 
			this.secureProxyAddressDataGridViewTextBoxColumn.DataPropertyName = "SecureProxyAddress";
			this.secureProxyAddressDataGridViewTextBoxColumn.HeaderText = "SecureProxyAddress";
			this.secureProxyAddressDataGridViewTextBoxColumn.Name = "secureProxyAddressDataGridViewTextBoxColumn";
			this.secureProxyAddressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// secureProxyPortDataGridViewTextBoxColumn
			// 
			this.secureProxyPortDataGridViewTextBoxColumn.DataPropertyName = "SecureProxyPort";
			this.secureProxyPortDataGridViewTextBoxColumn.HeaderText = "SecureProxyPort";
			this.secureProxyPortDataGridViewTextBoxColumn.Name = "secureProxyPortDataGridViewTextBoxColumn";
			this.secureProxyPortDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fTPProxyAddressDataGridViewTextBoxColumn
			// 
			this.fTPProxyAddressDataGridViewTextBoxColumn.DataPropertyName = "FTPProxyAddress";
			this.fTPProxyAddressDataGridViewTextBoxColumn.HeaderText = "FTPProxyAddress";
			this.fTPProxyAddressDataGridViewTextBoxColumn.Name = "fTPProxyAddressDataGridViewTextBoxColumn";
			this.fTPProxyAddressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fTPProxyPortDataGridViewTextBoxColumn
			// 
			this.fTPProxyPortDataGridViewTextBoxColumn.DataPropertyName = "FTPProxyPort";
			this.fTPProxyPortDataGridViewTextBoxColumn.HeaderText = "FTPProxyPort";
			this.fTPProxyPortDataGridViewTextBoxColumn.Name = "fTPProxyPortDataGridViewTextBoxColumn";
			this.fTPProxyPortDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// gopherProxyAddressDataGridViewTextBoxColumn
			// 
			this.gopherProxyAddressDataGridViewTextBoxColumn.DataPropertyName = "GopherProxyAddress";
			this.gopherProxyAddressDataGridViewTextBoxColumn.HeaderText = "GopherProxyAddress";
			this.gopherProxyAddressDataGridViewTextBoxColumn.Name = "gopherProxyAddressDataGridViewTextBoxColumn";
			this.gopherProxyAddressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// gopherProxyPortDataGridViewTextBoxColumn
			// 
			this.gopherProxyPortDataGridViewTextBoxColumn.DataPropertyName = "GopherProxyPort";
			this.gopherProxyPortDataGridViewTextBoxColumn.HeaderText = "GopherProxyPort";
			this.gopherProxyPortDataGridViewTextBoxColumn.Name = "gopherProxyPortDataGridViewTextBoxColumn";
			this.gopherProxyPortDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// socksProxyAddressDataGridViewTextBoxColumn
			// 
			this.socksProxyAddressDataGridViewTextBoxColumn.DataPropertyName = "SocksProxyAddress";
			this.socksProxyAddressDataGridViewTextBoxColumn.HeaderText = "SocksProxyAddress";
			this.socksProxyAddressDataGridViewTextBoxColumn.Name = "socksProxyAddressDataGridViewTextBoxColumn";
			this.socksProxyAddressDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// socksProxyPortDataGridViewTextBoxColumn
			// 
			this.socksProxyPortDataGridViewTextBoxColumn.DataPropertyName = "SocksProxyPort";
			this.socksProxyPortDataGridViewTextBoxColumn.HeaderText = "SocksProxyPort";
			this.socksProxyPortDataGridViewTextBoxColumn.Name = "socksProxyPortDataGridViewTextBoxColumn";
			this.socksProxyPortDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn
			// 
			this.useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn.DataPropertyName = "UseSameProxyServerForAllProtocols";
			this.useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn.HeaderText = "UseSameProxyServerForAllProtocols";
			this.useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn.Name = "useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn";
			this.useSameProxyServerForAllProtocolsDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// excludeAddressesFromProxyDataGridViewTextBoxColumn
			// 
			this.excludeAddressesFromProxyDataGridViewTextBoxColumn.DataPropertyName = "ExcludeAddressesFromProxy";
			this.excludeAddressesFromProxyDataGridViewTextBoxColumn.HeaderText = "ExcludeAddressesFromProxy";
			this.excludeAddressesFromProxyDataGridViewTextBoxColumn.Name = "excludeAddressesFromProxyDataGridViewTextBoxColumn";
			this.excludeAddressesFromProxyDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// proxyBindingSource
			// 
			this.proxyBindingSource.DataSource = typeof(fleischmann.advancedproxy.Proxy);
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Location = new System.Drawing.Point(552, 261);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSetAsCurrent
			// 
			this.btnSetAsCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSetAsCurrent.Location = new System.Drawing.Point(633, 261);
			this.btnSetAsCurrent.Name = "btnSetAsCurrent";
			this.btnSetAsCurrent.Size = new System.Drawing.Size(95, 23);
			this.btnSetAsCurrent.TabIndex = 2;
			this.btnSetAsCurrent.Text = "Set As Current";
			this.btnSetAsCurrent.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(784, 261);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(871, 296);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSetAsCurrent);
			this.Controls.Add(this.gridProxySettings);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Advanced Proxy Configurations";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridProxySettings)).EndInit();
			this.cxmNotifyIconMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.proxyBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridProxySettings;
		private System.Windows.Forms.BindingSource proxyBindingSource;
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
		private System.Windows.Forms.NotifyIcon icnProxyNotifyIcon;
		private System.Windows.Forms.ContextMenuStrip cxmNotifyIconMenu;
		private System.Windows.Forms.ToolStripMenuItem useProxyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnSetAsCurrent;
		private System.Windows.Forms.Button btnExit;

	}
}