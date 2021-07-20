using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestsGenerator
{
	public class Request
	{
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
				"null, " +
				this.xmlText + ", " +
				this.comment + ", " +
				"convert(char(23), getdate(), 126), " +
				this.status + ") select @@IDENTITY");
		}

		public void DeleteFromBase()
		{
			SQL connection = new SQL();

			connection.Execute("delete from RequestsGenerator..Requests where id = " + 
				this.id.ToString());
		}
	}
}
