using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RequestsGenerator
{
	class SQL
	{
		private string connectionString;
		private SqlConnection connection;
		private SqlCommand newCommand;
		private SqlDataReader dataReader;

		public SQL()
		{
			this.connectionString = "Data Source=sqlserver;User ID=sa;Password=icq99802122;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True";
			//this.connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RequestsGenerator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			connection = new SqlConnection(this.connectionString); 
			connection.Open();
		}

		public SqlDataReader Execute(string command)
		{
			this.newCommand = null;
			this.newCommand = new SqlCommand(command, connection);
			this.dataReader = newCommand.ExecuteReader();

			return (dataReader);
		}
	}
}
