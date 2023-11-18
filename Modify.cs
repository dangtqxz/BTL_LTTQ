using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiSinhThiDaiHoc
{
	internal class Modify
	{
		public Modify()
		{
		}
		SqlCommand sqlCommand;
		SqlDataReader dataReader;

		public List<TaiKhoan> TaiKhoans(string query)
		{
			List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
			using (SqlConnection sqlConnection = Connection.GetSqlConnection())
			{
				sqlConnection.Open();
				sqlCommand = new SqlCommand(query, sqlConnection);
				dataReader = sqlCommand.ExecuteReader();
				while (dataReader.Read())
				{
					taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2)));
				}
				sqlConnection.Close();
			}
			return taiKhoans;
		}

		public void Command(string query)
		{
			using (SqlConnection sqlConnection = Connection.GetSqlConnection())
			{
				sqlConnection.Open();
				sqlCommand = new SqlCommand(query, sqlConnection);
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		public DataTable LoadData(string query)
		{
			DataTable dt = new DataTable();
			using (SqlConnection sqlConnection = Connection.GetSqlConnection())
			{
				sqlConnection.Open();
				SqlDataAdapter da = new SqlDataAdapter(query, sqlConnection);
				da.Fill(dt);
				sqlConnection.Close();
			}
			return dt;
		}

		public void QueryExecution(string query)
		{
			SqlConnection sqlConnection = Connection.GetSqlConnection();

		}
	}
}
