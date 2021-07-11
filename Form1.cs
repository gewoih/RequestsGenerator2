using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RequestsGenerator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			SQL connectionSQL = new SQL();
			SqlDataReader reader = connectionSQL.Execute("select * from Templates");

            while (reader.Read())
            {
				Console.WriteLine("{0}\t{1}\t{2}", 
				reader["id"],
                reader["name"],
                reader["fsrar_id"]);
            }
        }8
	}
}
