using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestsGenerator
{
	class Request
	{
		public int id { get; set; }
		public int requestTemplate { get; set; }
		public string xmlText { get; set; }
		public string comment { get; set; }
		public DateTime date { get; set; }
	}
}
