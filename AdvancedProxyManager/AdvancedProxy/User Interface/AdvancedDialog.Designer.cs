namespace fleischmann.advancedproxy
{
	partial class AdvancedDialog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedDialog));
			this.txtHttpAddress = new System.Windows.Forms.TextBox();
			this.txtHttpPort = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbxServers = new System.Windows.Forms.GroupBox();
			this.ckbSameProxyForAll = new System.Windows.Forms.CheckBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSocksAddress = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtSocksPort = new System.Windows.Forms.TextBox();
			this.txtGopherAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGopherPort = new System.Windows.Forms.TextBox();
			this.txtFTPAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFTPPort = new System.Windows.Forms.TextBox();
			this.txtSecureAddress = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSecurePort = new System.Windows.Forms.TextBox();
			this.gbxExceptions = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txtExcludeAddresses = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.gbxServers.SuspendLayout();
			this.gbxExceptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtHttpAddress
			// 
			this.txtHttpAddress.Location = new System.Drawing.Point(101, 36);
			this.txtHttpAddress.Name = "txtHttpAddress";
			this.txtHttpAddress.Size = new System.Drawing.Size(153, 20);
			this.txtHttpAddress.TabIndex = 0;
			// 
			// txtHttpPort
			// 
			this.txtHttpPort.Location = new System.Drawing.Point(264, 36);
			this.txtHttpPort.Name = "txtHttpPort";
			this.txtHttpPort.Size = new System.Drawing.Size(43, 20);
			this.txtHttpPort.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "HTTP:";
			// 
			// gbxServers
			// 
			this.gbxServers.Controls.Add(this.ckbSameProxyForAll);
			this.gbxServers.Controls.Add(this.label13);
			this.gbxServers.Controls.Add(this.label12);
			this.gbxServers.Controls.Add(this.label11);
			this.gbxServers.Controls.Add(this.label10);
			this.gbxServers.Controls.Add(this.label9);
			this.gbxServers.Controls.Add(this.label8);
			this.gbxServers.Controls.Add(this.label7);
			this.gbxServers.Controls.Add(this.label6);
			this.gbxServers.Controls.Add(this.txtSocksAddress);
			this.gbxServers.Controls.Add(this.label5);
			this.gbxServers.Controls.Add(this.txtSocksPort);
			this.gbxServers.Controls.Add(this.txtGopherAddress);
			this.gbxServers.Controls.Add(this.label4);
			this.gbxServers.Controls.Add(this.txtGopherPort);
			this.gbxServers.Controls.Add(this.txtFTPAddress);
			this.gbxServers.Controls.Add(this.label3);
			this.gbxServers.Controls.Add(this.txtFTPPort);
			this.gbxServers.Controls.Add(this.txtSecureAddress);
			this.gbxServers.Controls.Add(this.label2);
			this.gbxServers.Controls.Add(this.txtSecurePort);
			this.gbxServers.Controls.Add(this.txtHttpAddress);
			this.gbxServers.Controls.Add(this.label1);
			this.gbxServers.Controls.Add(this.txtHttpPort);
			this.gbxServers.Location = new System.Drawing.Point(12, 12);
			this.gbxServers.Name = "gbxServers";
			this.gbxServers.Size = new System.Drawing.Size(328, 192);
			this.gbxServers.TabIndex = 3;
			this.gbxServers.TabStop = false;
			this.gbxServers.Text = "Servers";
			// 
			// ckbSameProxyForAll
			// 
			this.ckbSameProxyForAll.AutoSize = true;
			this.ckbSameProxyForAll.Location = new System.Drawing.Point(47, 166);
			this.ckbSameProxyForAll.Name = "ckbSameProxyForAll";
			this.ckbSameProxyForAll.Size = new System.Drawing.Size(225, 17);
			this.ckbSameProxyForAll.TabIndex = 23;
			this.ckbSameProxyForAll.Text = "Use the same proxy server for all protocols";
			this.ckbSameProxyForAll.UseVisualStyleBackColor = true;
			this.ckbSameProxyForAll.CheckedChanged += new System.EventHandler(this.ckbSameProxyForAll_CheckedChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(254, 143);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(10, 13);
			this.label13.TabIndex = 22;
			this.label13.Text = ":";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(254, 117);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(10, 13);
			this.label12.TabIndex = 21;
			this.label12.Text = ":";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(254, 91);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(10, 13);
			this.label11.TabIndex = 20;
			this.label11.Text = ":";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(254, 65);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(10, 13);
			this.label10.TabIndex = 19;
			this.label10.Text = ":";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(254, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(10, 13);
			this.label9.TabIndex = 18;
			this.label9.Text = ":";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(261, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(26, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "Port";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(98, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(108, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Proxy Address to Use";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 15;
			this.label6.Text = "Type";
			// 
			// txtSocksAddress
			// 
			this.txtSocksAddress.Location = new System.Drawing.Point(101, 140);
			this.txtSocksAddress.Name = "txtSocksAddress";
			this.txtSocksAddress.Size = new System.Drawing.Size(153, 20);
			this.txtSocksAddress.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 143);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Socks";
			// 
			// txtSocksPort
			// 
			this.txtSocksPort.Location = new System.Drawing.Point(264, 140);
			this.txtSocksPort.Name = "txtSocksPort";
			this.txtSocksPort.Size = new System.Drawing.Size(43, 20);
			this.txtSocksPort.TabIndex = 13;
			// 
			// txtGopherAddress
			// 
			this.txtGopherAddress.Location = new System.Drawing.Point(101, 114);
			this.txtGopherAddress.Name = "txtGopherAddress";
			this.txtGopherAddress.Size = new System.Drawing.Size(153, 20);
			this.txtGopherAddress.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Gopher:";
			// 
			// txtGopherPort
			// 
			this.txtGopherPort.Location = new System.Drawing.Point(264, 114);
			this.txtGopherPort.Name = "txtGopherPort";
			this.txtGopherPort.Size = new System.Drawing.Size(43, 20);
			this.txtGopherPort.TabIndex = 10;
			// 
			// txtFTPAddress
			// 
			this.txtFTPAddress.Location = new System.Drawing.Point(101, 88);
			this.txtFTPAddress.Name = "txtFTPAddress";
			this.txtFTPAddress.Size = new System.Drawing.Size(153, 20);
			this.txtFTPAddress.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "FTP:";
			// 
			// txtFTPPort
			// 
			this.txtFTPPort.Location = new System.Drawing.Point(264, 88);
			this.txtFTPPort.Name = "txtFTPPort";
			this.txtFTPPort.Size = new System.Drawing.Size(43, 20);
			this.txtFTPPort.TabIndex = 7;
			// 
			// txtSecureAddress
			// 
			this.txtSecureAddress.Location = new System.Drawing.Point(101, 62);
			this.txtSecureAddress.Name = "txtSecureAddress";
			this.txtSecureAddress.Size = new System.Drawing.Size(153, 20);
			this.txtSecureAddress.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Secure:";
			// 
			// txtSecurePort
			// 
			this.txtSecurePort.Location = new System.Drawing.Point(264, 62);
			this.txtSecurePort.Name = "txtSecurePort";
			this.txtSecurePort.Size = new System.Drawing.Size(43, 20);
			this.txtSecurePort.TabIndex = 4;
			// 
			// gbxExceptions
			// 
			this.gbxExceptions.Controls.Add(this.label15);
			this.gbxExceptions.Controls.Add(this.txtExcludeAddresses);
			this.gbxExceptions.Controls.Add(this.label14);
			this.gbxExceptions.Location = new System.Drawing.Point(12, 210);
			this.gbxExceptions.Name = "gbxExceptions";
			this.gbxExceptions.Size = new System.Drawing.Size(328, 94);
			this.gbxExceptions.TabIndex = 4;
			this.gbxExceptions.TabStop = false;
			this.gbxExceptions.Text = "Exceptions";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(48, 74);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(183, 13);
			this.label15.TabIndex = 5;
			this.label15.Text = "Use semicolons (;) to seperate entries";
			// 
			// txtExcludeAddresses
			// 
			this.txtExcludeAddresses.Location = new System.Drawing.Point(47, 32);
			this.txtExcludeAddresses.Multiline = true;
			this.txtExcludeAddresses.Name = "txtExcludeAddresses";
			this.txtExcludeAddresses.Size = new System.Drawing.Size(275, 39);
			this.txtExcludeAddresses.TabIndex = 1;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(48, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(259, 13);
			this.label14.TabIndex = 0;
			this.label14.Text = "Do not use proxy server for addresses beginning with:";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(259, 310);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(178, 310);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// AdvancedDialog
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(352, 338);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.gbxExceptions);
			this.Controls.Add(this.gbxServers);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AdvancedDialog";
			this.ShowIcon = false;
			this.Text = "Proxy Settings";
			this.Load += new System.EventHandler(this.AdvancedDialog_Load);
			this.gbxServers.ResumeLayout(false);
			this.gbxServers.PerformLayout();
			this.gbxExceptions.ResumeLayout(false);
			this.gbxExceptions.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtHttpAddress;
		private System.Windows.Forms.TextBox txtHttpPort;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbxServers;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSocksAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtSocksPort;
		private System.Windows.Forms.TextBox txtGopherAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtGopherPort;
		private System.Windows.Forms.TextBox txtFTPAddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtFTPPort;
		private System.Windows.Forms.TextBox txtSecureAddress;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSecurePort;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox gbxExceptions;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtExcludeAddresses;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.CheckBox ckbSameProxyForAll;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}