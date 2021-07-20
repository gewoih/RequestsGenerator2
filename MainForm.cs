using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RequestsGenerator
{
	public partial class MainForm : Form
	{
		public static MainForm form = null;
		public static RequestTemplate Templates;

		public MainForm()
		{
			InitializeComponent();
			form = this;

			Templates = new RequestTemplate();
			Templates.LoadItems();
		}

		public void TemplatesListViewAddElement(ListViewItem newItem)
		{
			this.TemplatesListView.Items.Add(newItem);
		}

		public void RequestsListViewAddElement(ListViewItem newItem)
		{
			this.RequestsListView.Items.Add(newItem);
		}

		private void TemplatesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (this.TemplatesListView.SelectedIndices.Count > 0)
				Templates.Items[this.TemplatesListView.SelectedIndices[0]].LoadRequests();
		}
	}
}
