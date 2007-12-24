namespace Fleischmann.AdvancedProxy
{
	partial class ImportForm
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
			this.btnImport = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAll = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
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
			this.lbxProxyNames.Size = new System.Drawing.Size(196, 225);
			this.lbxProxyNames.TabIndex = 0;
			this.lbxProxyNames.SelectedIndexChanged += new System.EventHandler(this.lbxProxyNames_SelectedIndexChanged);
			// 
			// lblProxyPrompt
			// 
			this.lblProxyPrompt.AutoSize = true;
			this.lblProxyPrompt.Location = new System.Drawing.Point(8, 9);
			this.lblProxyPrompt.Name = "lblProxyPrompt";
			this.lblProxyPrompt.Size = new System.Drawing.Size(178, 13);
			this.lblProxyPrompt.TabIndex = 1;
			this.lblProxyPrompt.Text = "Choose the Proxy Settings to Import:";
			// 
			// btnImport
			// 
			this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImport.Enabled = false;
			this.btnImport.Location = new System.Drawing.Point(128, 259);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(75, 23);
			this.btnImport.TabIndex = 2;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(47, 259);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnAll
			// 
			this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAll.Location = new System.Drawing.Point(7, 259);
			this.btnAll.Name = "btnAll";
			this.btnAll.Size = new System.Drawing.Size(29, 23);
			this.btnAll.TabIndex = 7;
			this.btnAll.Text = "All";
			this.btnAll.UseVisualStyleBackColor = true;
			this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
			// 
			// ImportForm
			// 
			this.AcceptButton = this.btnImport;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(212, 292);
			this.Controls.Add(this.btnAll);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.lblProxyPrompt);
			this.Controls.Add(this.lbxProxyNames);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(220, 326);
			this.Name = "ImportForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Proxy Import";
			this.Load += new System.EventHandler(this.ImportForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbxProxyNames;
		private System.Windows.Forms.Label lblProxyPrompt;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}