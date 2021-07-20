using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestsGenerator
{
	public class Template
	{
		public List<Request> RequestsHistory = new List<Request>();
		public int id { get; set; }
		public string fsrarId { get; set; }
		public int commandId { get; set; }
		public string name { get; set; }
		public string xmlText { get; set; }

		public Template(int id, string fsrarId, int commandId, string name, string xmlText)
		{
			this.id = id;
			this.fsrarId = fsrarId;
			this.commandId = commandId;
			this.name = name;
			this.xmlText = xmlText;
		}

		public void AddRequest(SqlDataReader reader)
		{
			this.RequestsHistory.Add(new Request(Convert.ToInt32(reader["id"]), 
												Convert.ToInt32(reader["template_id"]), 
												Convert.ToInt32(reader["query_id"]),
												reader["xml_text"].ToString(), 
												reader["comment"].ToString(), 
												reader["date"].ToString(),
												reader["status"].ToString()));
		}

		public void LoadRequests()
		{
			this.RequestsHistory.Clear();

			SQL connection = new SQL();
			SqlDataReader reader = connection.Execute("select * from RequestsGenerator..Requests where template_id = " + Convert.ToInt32(this.id));

			while (reader.Read())
			{
				this.AddRequest(reader);

				ListViewItem newListViewItem;
				newListViewItem = new ListViewItem(new string[] { 
													reader["id"].ToString(), 
													reader["template_id"].ToString(),
													reader["query_id"].ToString(),
													reader["date"].ToString(),
													reader["comment"].ToString(),
													reader["status"].ToString() });
				MainForm.form.RequestsListViewAddElement(newListViewItem);
			}
		}

		public void UploadToBase()
		{
			SQL connection = new SQL();

			connection.Execute("insert into RequestsGenerator..Templates values(" +
			this.name + "," +
			this.fsrarId + "," +
			this.commandId.ToString() + "," +
			this.xmlText + ")");
		}

		public void DeleteFromBase()
		{
			SQL connection = new SQL();

			connection.Execute("delete from RequestsGenerator..Templates where id = " + this.id.ToString() +
					"delete from RequestsGenerator..Requests where template_id = " + this.id.ToString());
		}
	}
}
