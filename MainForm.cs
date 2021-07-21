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
		public static RequestTemplate Templates = null;

		public MainForm()
		{
			InitializeComponent();
			form = this;

			Templates = new RequestTemplate();
			Templates.LoadItems();
		}

		public void TemplatesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (this.TemplatesListView.SelectedIndices.Count > 0)
			{
				this.RequestsListView.Items.Clear();
				this.RepliesListView.Items.Clear();
				Templates.Items[this.TemplatesListView.SelectedIndices[0]].LoadRequests();
				textEditorControl1.Text = Templates.Items[TemplatesListView.SelectedIndices[0]].xmlText;
			}
		}

		private void RequestsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (this.RequestsListView.SelectedIndices.Count > 0)
			{
				this.RepliesListView.Items.Clear();
				Templates.Items[this.TemplatesListView.SelectedIndices[0]].RequestsHistory[this.RequestsListView.SelectedIndices[0]].LoadReplies();
				textEditorControl1.Text = Templates.Items[TemplatesListView.SelectedIndices[0]].RequestsHistory[RequestsListView.SelectedIndices[0]].xmlText;
			}
		}

		private void RepliesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			textEditorControl1.Text = Templates.Items[TemplatesListView.SelectedIndices[0]].RequestsHistory[RequestsListView.SelectedIndices[0]].Replies[RepliesListView.SelectedIndices[0]].xmlText;
		}

		private void miAddTemplate_Click(object sender, EventArgs e)
		{
			FormCreateTemplate newForm = new FormCreateTemplate();
			newForm.ShowDialog();
		}

		private void miCreateRequest_Click(object sender, EventArgs e)
		{
			if (this.TemplatesListView.SelectedItems.Count > 0)
			{
				FormCreateRequest newForm = new FormCreateRequest();
				newForm.ShowDialog();
			}
		}

		private void miDeleteTemplate_Click(object sender, EventArgs e)
		{
			if (this.TemplatesListView.SelectedItems.Count > 0)
			{
				DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить этот шаблон?", "Удаление шаблона", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					Templates.Items[this.TemplatesListView.SelectedIndices[0]].DeleteFromBase();
					Templates.LoadItems();

					MessageBox.Show("Шаблон успешно удален.");
				}
			}
		}

		private void miSendRequest_Click(object sender, EventArgs e)
		{
			Templates.Items[this.TemplatesListView.SelectedIndices[0]].RequestsHistory[this.RequestsListView.SelectedIndices[0]].SendToEgais();

			MessageBox.Show("Запрос успешно отправлен в ЕГАИС.");

			MainForm.form.RequestsListView.Items.Clear();
			Templates.Items[this.TemplatesListView.SelectedIndices[0]].LoadRequests();
		}

		private void miDeleteRequest_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить этот запрос?", "Удаление запроса", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Templates.Items[this.TemplatesListView.SelectedIndices[0]].RequestsHistory[this.RequestsListView.SelectedIndices[0]].DeleteFromBase();

				MainForm.form.RequestsListView.Items.Clear();
				Templates.Items[this.TemplatesListView.SelectedIndices[0]].LoadRequests();

				MessageBox.Show("Запрос успешно удален.");
			}
		}

		private void miSaveRequest_Click(object sender, EventArgs e)
		{

		}
	}
}
