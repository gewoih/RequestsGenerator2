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
			this.Items.Clear();

			SQL connection = new SQL();
			SqlDataReader reader = connection.Execute("select * from RequestsGenerator..Templates");

			while (reader.Read())
			{
				this.AddItem(reader);

				ListViewItem newListViewItem;
				newListViewItem = new ListViewItem(new string[] {
													reader["id"].ToString(),
													reader["fsrar_id"].ToString(),
													reader["command_id"].ToString(),
													reader["request_name"].ToString(),
													reader["xml_text"].ToString() });

				MainForm.form.TemplatesListViewAddElement(newListViewItem);
			}
		}
	}
}
