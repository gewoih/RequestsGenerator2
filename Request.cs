using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestsGenerator
{
	public class Request
	{
		public List<Reply> Replies = new List<Reply>();
		public int id { get; set; }
		public int templateId { get; set; }
		public int queryId { get; set; }
		public string xmlText { get; set; }
		public string comment { get; set; }
		public string date { get; set; }
		public string status { get; set; }

		public Request(int id, int templateId, int queryId, string xmlText, string comment, string date, string status)
		{
			this.id = id;
			this.templateId = templateId;
			this.queryId = queryId;
			this.xmlText = xmlText;
			this.comment = comment;
			this.date = date;
			this.status = status;
		}

		public void UploadToBase()
		{
			SQL connection = new SQL();

			connection.Execute("insert into RequestsGenerator..Requests values(" +
				this.templateId.ToString() + ", " +
				this.queryId.ToString() + ", " +
				"'" + this.xmlText + "', " +
				"'" + this.comment + "', " +
				"convert(char(23), getdate(), 126), " +
				"'" + this.status + "') select @@IDENTITY");
		}

		public void DeleteFromBase()
		{
			SQL connection = new SQL();

			connection.Execute("delete from RequestsGenerator..Requests where id = " + 
				this.id.ToString());
		}

		public void AddReply(SqlDataReader reader)
		{
			this.Replies.Add(new Reply(Convert.ToInt32(reader["id"]),
										Convert.ToInt32(reader["queryid"]),
										reader["data"].ToString(),
										reader["received"].ToString()));
		}

		public void LoadReplies()
		{
			this.Replies.Clear();

			SQL connection = new SQL();
			SqlDataReader reader = connection.Execute("select id, queryid, data, received from Egais..Reply where queryid = " + Convert.ToInt32(this.queryId));

			while (reader.Read())
			{
				this.AddReply(reader);

				ListViewItem newListViewItem;
				newListViewItem = new ListViewItem(new string[] {
													reader["id"].ToString(),
													reader["queryid"].ToString(),
													reader["received"].ToString(),
													reader["data"].ToString() });
				MainForm.form.RepliesListView.Items.Add(newListViewItem);
			}
		}

		public void SendToEgais()
		{
			SQL connection = new SQL();

			SqlDataReader reader = connection.Execute("execute Egais..QueryAdd " +
			"'" + MainForm.Templates.Items[Convert.ToInt32(MainForm.form.TemplatesListView.SelectedIndices[0])].fsrarId + "', " +
			"'" + this.xmlText + "', " +
			MainForm.Templates.Items[Convert.ToInt32(MainForm.form.TemplatesListView.SelectedIndices[0])].commandId); ;

			if (reader.Read())
			{
				this.queryId = Convert.ToInt32(reader.GetValue(1));
				this.status = "Отправлен в ЕГАИС";

				connection.Execute("update RequestsGenerator..Requests set query_id = " +
					this.queryId.ToString() + ", status = " +
					"'" + this.status + "' where id = " +
					this.id.ToString());
			}
		}
	}
}
