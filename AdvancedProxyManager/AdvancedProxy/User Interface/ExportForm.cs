using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Fleischmann.AdvancedProxy
{
	public partial class ExportForm : Form
	{
		SortableBindingList<ProxySetting> _proxyList;
		bool _overwriteFile = false;

		public ExportForm(SortableBindingList<ProxySetting> proxyList)
		{
			_proxyList = proxyList;

			InitializeComponent();
		}

		private void ExportForm_Load(object sender, EventArgs e)
		{
			this.lbxProxyNames.DataSource = _proxyList;
			this.lbxProxyNames.DisplayMember = "Name";
			this.lbxProxyNames.ValueMember = "Name";
		}

		private void btnAll_Click(object sender, EventArgs e)
		{
			//if the selected count is not equal the items count then select all.
			bool selectAll = this.lbxProxyNames.SelectedItems.Count != this.lbxProxyNames.Items.Count;

			for (int index = 0; index < this.lbxProxyNames.Items.Count; index++)
			{
				this.lbxProxyNames.SetSelected(index, selectAll);
			}
			
		}

		private void btnGetFileName_Click(object sender, EventArgs e)
		{
			DialogResult result = this.saveFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				this.txtFileName.Text = saveFileDialog.FileName;
			}
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			SortableBindingList<ProxySetting> exportList = new SortableBindingList<ProxySetting>();
			foreach (ProxySetting proxy in this.lbxProxyNames.SelectedItems)
			{
				exportList.Add(proxy);
			}

			if (File.Exists(this.txtFileName.Text))
			{
				DialogResult result = MessageBox.Show("File Exists.  Overwrite?", "Overwrite File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					File.Delete(this.txtFileName.Text);
				}
				else
				{
					return;
				}
			}

			exportList.Save(this.txtFileName.Text);

			MessageBox.Show("Proxy settings successfully Exported", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.Close();
		}

		private void lbxProxyNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			enableExportButton();
		}

		private void txtFileName_TextChanged(object sender, EventArgs e)
		{
			enableExportButton();
		}

		private void enableExportButton()
		{
			if (string.IsNullOrEmpty(this.txtFileName.Text) ||
				this.lbxProxyNames.SelectedItems.Count == 0)
			{
				this.btnExport.Enabled = false;
			}
			else
			{
				this.btnExport.Enabled = true;
			}
		}
	}
}