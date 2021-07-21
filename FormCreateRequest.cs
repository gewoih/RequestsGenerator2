using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestsGenerator
{
	public partial class FormCreateRequest : Form
	{
		private string xmlText = null;

		public FormCreateRequest()
		{
			InitializeComponent();

			this.xmlText = MainForm.Templates.Items[MainForm.form.TemplatesListView.SelectedIndices[0]].xmlText;
			cbFsrarId.SelectedIndex = 0;
		}

		private void btSaveRequest_Click(object sender, EventArgs e)
		{
			Request newRequest = new Request(0, MainForm.Templates.Items[MainForm.form.TemplatesListView.SelectedIndices[0]].id, -1, this.xmlText, this.tbComment.Text, "", "Новый");
			newRequest.UploadToBase();

			MessageBox.Show("Запрос успешно создан.");

			MainForm.form.RequestsListView.Items.Clear();
			MainForm.Templates.Items[MainForm.form.TemplatesListView.SelectedIndices[0]].LoadRequests();

			DialogResult = DialogResult.OK;
		}

		private void btEditXML_Click(object sender, EventArgs e)
		{
			FormXMLEditor newForm = new FormXMLEditor();
			newForm.textEditorControl1.Text = this.xmlText;

			newForm.ShowDialog();

			if (newForm.DialogResult == DialogResult.OK)
				this.xmlText = newForm.textEditorControl1.Text;
		}
	}
}
