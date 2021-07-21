using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestsGenerator
{
	public partial class FormCreateTemplate : Form
	{
		private List<RequestType> RequestTypes = null;
		private string xmlText = null;

		public FormCreateTemplate()
		{
			InitializeComponent();
			RequestTypes = new List<RequestType>();
			
			cbTypes.DisplayMember = "name";
			cbTypes.ValueMember = "id";
			cbFsrarId.SelectedIndex = 0;

			SQL connection = new SQL();
			SqlDataReader reader = connection.Execute("select id, name from Egais..Command order by name");

			while (reader.Read())
				RequestTypes.Add(new RequestType(Convert.ToInt32(reader["id"]), reader["name"].ToString()));

			cbTypes.DataSource = RequestTypes;
		}

		private void btSave_Click(object sender, EventArgs e)
		{
			if ((tbName.Text.Length != 0) && (cbFsrarId.SelectedIndex != -1) &&
				(cbTypes.SelectedIndex != -1) && (xmlText != null))
			{
				Template newTemplate = new Template(0, cbFsrarId.Text, this.RequestTypes[cbTypes.SelectedIndex].id, tbName.Text, xmlText);
				newTemplate.UploadToBase();

				MessageBox.Show("Тип запроса \"" + tbName.Text + "\" успешно добавлен.");

				MainForm.Templates.LoadItems();
				this.DialogResult = DialogResult.OK;
			}
			else
				MessageBox.Show("Заполните все поля!");
		}

		private void btBrowse_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName != "")
			{
				xmlText = System.IO.File.ReadAllText(openFileDialog1.FileName);
				this.lbBrowseStatus.Text = openFileDialog1.FileName;
				this.lbBrowseStatus.ForeColor = Color.Green;
			}
		}
	}

	public class RequestType
	{
		public int id { get; set; }
		public string name { get; set; }

		public RequestType(int id, string name)
		{
			this.id = id;
			this.name = name;
		}
	}
}
