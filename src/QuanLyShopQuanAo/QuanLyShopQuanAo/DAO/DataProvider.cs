using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DAO
{
	public class DataProvider
	{
		
			private static DataProvider _instance;
			private readonly string connectionSTR;

			public static DataProvider Instance
			{
				get
				{
					if (_instance == null)
					{
						_instance = new DataProvider();
					}
					return _instance;
				}
			}

			private DataProvider()
			{
				connectionSTR = "Data Source=.;Initial Catalog=QL_ShopQuanAo;Integrated Security=True";
			}

			public DataTable ExecuteQuery(string query, object[] parameter = null)
			{
				DataTable data = new DataTable();

				using (SqlConnection connection = new SqlConnection(connectionSTR))
				{
					connection.Open();

					SqlCommand command = new SqlCommand(query, connection);

					if (parameter != null)
					{
						string[] listParams = query.Split(' ');
						int i = 0;

						foreach (string item in listParams)
						{
							if (item.StartsWith("@"))
							{
								command.Parameters.AddWithValue(item, parameter[i]);
								i += 1;
							}
						}
					}

					SqlDataAdapter adapter = new SqlDataAdapter(command);

					adapter.Fill(data);

					connection.Close();
				}

				return data;
			}

			public int ExecuteNonQuery(string query, object[] parameter = null)
			{
				int numRowEffected = 0;

				using (SqlConnection connection = new SqlConnection(connectionSTR))
				{
					connection.Open();

					SqlCommand command = new SqlCommand(query, connection);

					if (parameter != null)
					{
						string[] listParams = query.Split(' ');
						int i = 0;

						foreach (string item in listParams)
						{
							if (item.StartsWith("@"))
							{
								command.Parameters.AddWithValue(item, parameter[i]);
								i += 1;
							}
						}
					}

					numRowEffected = command.ExecuteNonQuery();

					connection.Close();
				}

				return numRowEffected;
			}

			public object ExecuteScalar(string query, object[] parameter = null)
			{
				object data = null;

				using (SqlConnection connection = new SqlConnection(connectionSTR))
				{
					connection.Open();

					SqlCommand command = new SqlCommand(query, connection);

					if (parameter != null)
					{
						string[] listParams = query.Split(' ');
						int i = 0;

						foreach (string item in listParams)
						{
							if (item.StartsWith("@"))
							{
								command.Parameters.AddWithValue(item, parameter[i]);
								i += 1;
							}
						}
					}

					data = command.ExecuteScalar();

					connection.Close();
				}

				return data;
			}
		
	}
}
