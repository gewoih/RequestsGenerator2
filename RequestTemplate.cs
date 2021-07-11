using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestsGenerator
{
	class RequestTemplate
	{
		public int id { get; set; }
		public int fsrar_id { get; set; }
		public int command_id { get; set; }
		public string name { get; set; }
		public string xmlText { get; set; }
		private List<Request> Requests;

		public RequestTemplate(int id, int fsrar_id, int command_id, string name, string xmlText)
		{
			this.id = id;
			this.fsrar_id = fsrar_id;
			this.command_id = command_id;
			this.name = name;
			this.xmlText = xmlText;
			Requests = new List<Request>();
		}

		public void AddRequest(Request newRequest)
		{
			Requests.Add(newRequest);
		}

		public void LoadRequests()
		{
			SQL connection = new SQL();
			connection.Execute("select * from Requests where template_id = " + this.id.ToString());
		}
	}
}
