namespace Fleischmann.AdvancedProxy
{
	partial class ExportForm
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
			this.lbxProxyNames = new System.Windows.Forms.ListBox();
			this.lblProxyPrompt = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.lblFileName = new System.Windows.Forms.Label();
			this.btnGetFileName = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// lbxProxyNames
			// 
			this.lbxProxyNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lbxProxyNames.FormattingEnabled = true;
			this.lbxProxyNames.Location = new System.Drawing.Point(7, 28);
			this.lbxProxyNames.Name = "lbxProxyNames";
			this.lbxProxyNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lbxProxyNames.Size = new System.Drawing.Size(228, 173);
			this.lbxProxyNames.TabIndex = 0;
			this.lbxProxyNames.SelectedIndexChanged += new System.EventHandler(this.lbxProxyNames_SelectedIndexChanged);
			// 
			// lblProxyPrompt
			// 
			this.lblProxyPrompt.AutoSize = true;
			this.lblProxyPrompt.Location = new System.Drawing.Point(8, 9);
			this.lblProxyPrompt.Name = "lblProxyPrompt";
			this.lblProxyPrompt.Size = new System.Drawing.Size(179, 13);
			this.lblProxyPrompt.TabIndex = 1;
			this.lblProxyPrompt.Text = "Choose the Proxy Settings to Export:";
			// 
			// btnExport
			// 
			this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExport.Enabled = false;
			this.btnExport.Location = new System.Drawing.Point(160, 289);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 2;
			this.btnExport.Text = "Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(79, 289);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// txtFileName
			// 
			this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtFileName.Location = new System.Drawing.Point(7, 256);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(196, 20);
			this.txtFileName.TabIndex = 4;
			this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
			// 
			// lblFileName
			// 
			this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblFileName.AutoSize = true;
			this.lblFileName.Location = new System.Drawing.Point(7, 238);
			this.lblFileName.Name = "lblFileName";
			this.lblFileName.Size = new System.Drawing.Size(57, 13);
			this.lblFileName.TabIndex = 5;
			this.lblFileName.Text = "File Name:";
			// 
			// btnGetFileName
			// 
			this.btnGetFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGetFileName.Location = new System.Drawing.Point(209, 255);
			this.btnGetFileName.Name = "btnGetFileName";
			this.btnGetFileName.Size = new System.Drawing.Size(25, 23);
			this.btnGetFileName.TabIndex = 6;
			this.btnGetFileName.Text = "...";
			this.btnGetFileName.UseVisualStyleBackColor = true;
			this.btnGetFileName.Click += new System.EventHandler(this.btnGetFileName_Click);
			// 
			// btnAll
			// 
			this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAll.Location = new System.Drawing.Point(7, 206);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(29, 23);
			this.btnAll.TabIndex = 7;
			this.btnAll.Text = "All";
			this.btnAll.UseVisualStyleBackColor = true;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "pxy";
			this.saveFileDialog.FileName = "ProxyList.pxy";
			this.saveFileDialog.Filter = "Proxy Files|*.pxy|All Files|*.*";
			this.saveFileDialog.InitialDirectory = "\"My Documents\"";
			this.saveFileDialog.OverwritePrompt = false;
			this.saveFileDialog.Title = "Proxy Export File";
			// 
			// ImportExportForm
			// 
			this.AcceptButton = this.btnExport;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(244, 322);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.btnGetFileName);
			this.Controls.Add(this.lblFileName);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.lblProxyPrompt);
			this.Controls.Add(this.lbxProxyNames);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(209, 219);
			this.Name = "ImportExportForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Proxy Export";
			this.Load += new System.EventHandler(this.ExportForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbxProxyNames;
		private System.Windows.Forms.Label lblProxyPrompt;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Label lblFileName;
		private System.Windows.Forms.Button btnGetFileName;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}