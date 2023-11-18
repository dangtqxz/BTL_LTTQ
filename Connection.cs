using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiSinhThiDaiHoc
{
	internal class Connection
	{
		private static string stringConnection = @"Data Source=.\SQLEXPRESS01;Initial Catalog=DSThiSinhThiDaiHoc;Integrated Security=True";

		public static SqlConnection GetSqlConnection()
		{
			return new SqlConnection(stringConnection);
		}
	}
}
