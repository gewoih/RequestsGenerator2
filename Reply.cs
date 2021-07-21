using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestsGenerator
{
	public class Reply
	{
		public int id { get; set; }
		public int queryId { get; set; }
		public string xmlText { get; set; }
		public string date { get; set; }

		public Reply(int id, int queryId, string xmlText, string date)
		{
			this.id = id;
			this.queryId = queryId;
			this.xmlText = xmlText;
			this.date = date;
		}
	}
}
