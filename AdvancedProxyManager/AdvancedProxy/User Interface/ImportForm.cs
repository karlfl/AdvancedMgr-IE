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
	public partial class ImportForm : Form
	{
		private SortableBindingList<ProxySetting> _proxyListToImport = new SortableBindingList<ProxySetting>();
		private SortableBindingList<ProxySetting> _proxyList = new SortableBindingList<ProxySetting>();
		private string _fileName;

		public SortableBindingList<ProxySetting> ProxyListToImport
		{
			get { return _proxyListToImport; }
			set { _proxyListToImport = value; }
		}

		public ImportForm(string fileName)
		{
			_fileName = fileName;
			InitializeComponent();
		}

		private void ImportForm_Load(object sender, EventArgs e)
		{
			_proxyList.Load(_fileName);
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

		private void btnImport_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;

			foreach (ProxySetting proxy in this.lbxProxyNames.SelectedItems)
			{
				_proxyListToImport.Add(proxy);
			}

			this.Close();
		}

		private void lbxProxyNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.lbxProxyNames.SelectedItems.Count == 0)
			{
				this.btnImport.Enabled = false;
			}
			else
			{
				this.btnImport.Enabled = true;
			}
		}
	}
}