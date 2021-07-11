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

		public SQL()
		{
			this.connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RequestsGenerator;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			connection = new SqlConnection(this.connectionString); 
			connection.Open();
			MessageBox.Show("Соединение с сервером установлено.");
		}

		public SqlDataReader Execute(string command)
		{
			SqlCommand newCommand = new SqlCommand(command, connection);
			SqlDataReader dataReader = newCommand.ExecuteReader();

			return (dataReader);
		}
	}
}
