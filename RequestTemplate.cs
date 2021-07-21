using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestsGenerator
{
	public class RequestTemplate
	{
		public List<Template> Items = new List<Template>();

		public void AddItem(SqlDataReader reader)
		{
			this.Items.Add(new Template(Convert.ToInt32(reader["id"]),
										reader["fsrar_id"].ToString(),
										Convert.ToInt32(reader["command_id"]),
										reader["request_name"].ToString(),
										reader["xml_text"].ToString()));
		}

		public void LoadItems()
		{
			MainForm.form.TemplatesListView.Items.Clear();
			MainForm.form.RequestsListView.Items.Clear();
			MainForm.form.RepliesListView.Items.Clear();
			this.Items.Clear();

			SQL connection = new SQL();
			SqlDataReader reader = connection.Execute("select * from RequestsGenerator..Templates");

			while (reader.Read())
			{
				this.AddItem(reader);

				ListViewItem newListViewItem;
				newListViewItem = new ListViewItem(new string[] {
													reader["id"].ToString(),
													reader["request_name"].ToString(),
													reader["fsrar_id"].ToString() });

				MainForm.form.TemplatesListView.Items.Add(newListViewItem);
			}
		}
	}
}
