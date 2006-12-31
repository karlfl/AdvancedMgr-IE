namespace fleischmann.advancedproxy
{
	partial class LanSettingDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanSettingDialog));
			this.gbxAutomaticConfiguration = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUseAutoConfigScriptAddress = new System.Windows.Forms.TextBox();
			this.ckbUseAutoConfigScript = new System.Windows.Forms.CheckBox();
			this.ckbAutoDetectSettings = new System.Windows.Forms.CheckBox();
			this.lblAutoConfig = new System.Windows.Forms.Label();
			this.gbxProxyServer = new System.Windows.Forms.GroupBox();
			this.btnAdvanced = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUseProxyServerPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ckbBypassProxyForLocal = new System.Windows.Forms.CheckBox();
			this.txtUseProxyServerAddress = new System.Windows.Forms.TextBox();
			this.ckbUseProxyServer = new System.Windows.Forms.CheckBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.gbxAutomaticConfiguration.SuspendLayout();
			this.gbxProxyServer.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbxAutomaticConfiguration
			// 
			this.gbxAutomaticConfiguration.Controls.Add(this.label2);
			this.gbxAutomaticConfiguration.Controls.Add(this.txtUseAutoConfigScriptAddress);
			this.gbxAutomaticConfiguration.Controls.Add(this.ckbUseAutoConfigScript);
			this.gbxAutomaticConfiguration.Controls.Add(this.ckbAutoDetectSettings);
			this.gbxAutomaticConfiguration.Controls.Add(this.lblAutoConfig);
			this.gbxAutomaticConfiguration.Location = new System.Drawing.Point(12, 12);
			this.gbxAutomaticConfiguration.Name = "gbxAutomaticConfiguration";
			this.gbxAutomaticConfiguration.Size = new System.Drawing.Size(345, 141);
			this.gbxAutomaticConfiguration.TabIndex = 0;
			this.gbxAutomaticConfiguration.TabStop = false;
			this.gbxAutomaticConfiguration.Text = "Automatic Configuration";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Address";
			// 
			// txtUseAutoConfigScriptAddress
			// 
			this.txtUseAutoConfigScriptAddress.Location = new System.Drawing.Point(73, 105);
			this.txtUseAutoConfigScriptAddress.Name = "txtUseAutoConfigScriptAddress";
			this.txtUseAutoConfigScriptAddress.Size = new System.Drawing.Size(206, 20);
			this.txtUseAutoConfigScriptAddress.TabIndex = 3;
			// 
			// ckbUseAutoConfigScript
			// 
			this.ckbUseAutoConfigScript.AutoSize = true;
			this.ckbUseAutoConfigScript.Location = new System.Drawing.Point(9, 82);
			this.ckbUseAutoConfigScript.Name = "ckbUseAutoConfigScript";
			this.ckbUseAutoConfigScript.Size = new System.Drawing.Size(190, 17);
			this.ckbUseAutoConfigScript.TabIndex = 2;
			this.ckbUseAutoConfigScript.Text = "Use Automatic Configuration Script";
			this.ckbUseAutoConfigScript.UseVisualStyleBackColor = true;
			// 
			// ckbAutoDetectSettings
			// 
			this.ckbAutoDetectSettings.AutoSize = true;
			this.ckbAutoDetectSettings.Location = new System.Drawing.Point(9, 58);
			this.ckbAutoDetectSettings.Name = "ckbAutoDetectSettings";
			this.ckbAutoDetectSettings.Size = new System.Drawing.Size(164, 17);
			this.ckbAutoDetectSettings.TabIndex = 1;
			this.ckbAutoDetectSettings.Text = "Automatically Detect Settings";
			this.ckbAutoDetectSettings.UseVisualStyleBackColor = true;
			// 
			// lblAutoConfig
			// 
			this.lblAutoConfig.Location = new System.Drawing.Point(6, 17);
			this.lblAutoConfig.Name = "lblAutoConfig";
			this.lblAutoConfig.Size = new System.Drawing.Size(333, 38);
			this.lblAutoConfig.TabIndex = 0;
			this.lblAutoConfig.Text = "Automatic configuration may override manual settings.  To ensure the use of manua" +
				"l settings, disable automatic  configuration.";
			// 
			// gbxProxyServer
			// 
			this.gbxProxyServer.Controls.Add(this.btnAdvanced);
			this.gbxProxyServer.Controls.Add(this.label4);
			this.gbxProxyServer.Controls.Add(this.txtUseProxyServerPort);
			this.gbxProxyServer.Controls.Add(this.label3);
			this.gbxProxyServer.Controls.Add(this.ckbBypassProxyForLocal);
			this.gbxProxyServer.Controls.Add(this.txtUseProxyServerAddress);
			this.gbxProxyServer.Controls.Add(this.ckbUseProxyServer);
			this.gbxProxyServer.Location = new System.Drawing.Point(12, 159);
			this.gbxProxyServer.Name = "gbxProxyServer";
			this.gbxProxyServer.Size = new System.Drawing.Size(345, 120);
			this.gbxProxyServer.TabIndex = 1;
			this.gbxProxyServer.TabStop = false;
			this.gbxProxyServer.Text = "Proxy Server";
			// 
			// btnAdvanced
			// 
			this.btnAdvanced.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAdvanced.Location = new System.Drawing.Point(258, 60);
			this.btnAdvanced.Name = "btnAdvanced";
			this.btnAdvanced.Size = new System.Drawing.Size(75, 23);
			this.btnAdvanced.TabIndex = 9;
			this.btnAdvanced.Text = "Advanced";
			this.btnAdvanced.UseVisualStyleBackColor = true;
			this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(183, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Port";
			// 
			// txtUseProxyServerPort
			// 
			this.txtUseProxyServerPort.Location = new System.Drawing.Point(214, 61);
			this.txtUseProxyServerPort.Name = "txtUseProxyServerPort";
			this.txtUseProxyServerPort.Size = new System.Drawing.Size(35, 20);
			this.txtUseProxyServerPort.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Address";
			// 
			// ckbBypassProxyForLocal
			// 
			this.ckbBypassProxyForLocal.AutoSize = true;
			this.ckbBypassProxyForLocal.Location = new System.Drawing.Point(29, 87);
			this.ckbBypassProxyForLocal.Name = "ckbBypassProxyForLocal";
			this.ckbBypassProxyForLocal.Size = new System.Drawing.Size(211, 17);
			this.ckbBypassProxyForLocal.TabIndex = 2;
			this.ckbBypassProxyForLocal.Text = "Bypass proxy server for local addresses";
			this.ckbBypassProxyForLocal.UseVisualStyleBackColor = true;
			// 
			// txtUseProxyServerAddress
			// 
			this.txtUseProxyServerAddress.Location = new System.Drawing.Point(77, 61);
			this.txtUseProxyServerAddress.Name = "txtUseProxyServerAddress";
			this.txtUseProxyServerAddress.Size = new System.Drawing.Size(92, 20);
			this.txtUseProxyServerAddress.TabIndex = 5;
			// 
			// ckbUseProxyServer
			// 
			this.ckbUseProxyServer.Location = new System.Drawing.Point(9, 19);
			this.ckbUseProxyServer.Name = "ckbUseProxyServer";
			this.ckbUseProxyServer.Size = new System.Drawing.Size(330, 38);
			this.ckbUseProxyServer.TabIndex = 1;
			this.ckbUseProxyServer.Text = "Use a proxy server for your lan (These settings will not apply to dial-up or vpn " +
				"connections)";
			this.ckbUseProxyServer.UseVisualStyleBackColor = true;
			this.ckbUseProxyServer.CheckedChanged += new System.EventHandler(this.ckbUseProxyServer_CheckedChanged);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnOK.Location = new System.Drawing.Point(201, 285);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(282, 285);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// LanSettingDialog
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(369, 321);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.gbxProxyServer);
			this.Controls.Add(this.gbxAutomaticConfiguration);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LanSettingDialog";
			this.ShowIcon = false;
			this.Text = "Local Area Network (LAN) Settings";
			this.Load += new System.EventHandler(this.LanSettingDialog_Load);
			this.gbxAutomaticConfiguration.ResumeLayout(false);
			this.gbxAutomaticConfiguration.PerformLayout();
			this.gbxProxyServer.ResumeLayout(false);
			this.gbxProxyServer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxAutomaticConfiguration;
		private System.Windows.Forms.Label lblAutoConfig;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUseAutoConfigScriptAddress;
		private System.Windows.Forms.CheckBox ckbUseAutoConfigScript;
		private System.Windows.Forms.CheckBox ckbAutoDetectSettings;
		private System.Windows.Forms.GroupBox gbxProxyServer;
		private System.Windows.Forms.CheckBox ckbBypassProxyForLocal;
		private System.Windows.Forms.CheckBox ckbUseProxyServer;
		private System.Windows.Forms.Button btnAdvanced;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtUseProxyServerPort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUseProxyServerAddress;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
	}
}

