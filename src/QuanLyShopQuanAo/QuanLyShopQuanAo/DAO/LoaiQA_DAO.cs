using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.Models;

namespace QuanLyShopQuanAo.DAO
{
	public class LoaiQA_DAO
	{
		private LoaiQA_DAO() { }
		private static LoaiQA_DAO _instance;
		public static LoaiQA_DAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new LoaiQA_DAO();
				}
				return _instance;
			}
		}

		public List<LoaiQA_DTO> Load_LQA()
		{
			List<LoaiQA_DTO> listLQA = new List<LoaiQA_DTO>();
			string query = "EXEC sp_select_LoaiQuanAo_All";
			DataTable LQA = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in LQA.Rows)
			{
				LoaiQA_DTO lqa = new LoaiQA_DTO(row);
				listLQA.Add(lqa);
			}

			return listLQA;
		}

		public LoaiQA_DTO Load_LQA_by_ID(int id_LQA)
		{
			string query = "EXEC sp_select_LoaiQuanAo_by_ID @ID_LQA";
			object[] param = new object[] { id_LQA };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in table.Rows)
			{
				LoaiQA_DTO lqa = new LoaiQA_DTO(row);
				return lqa;
			}

			return null;
		}

		public List<LoaiQA_DTO> Load_LQA_by_Name(string name)
		{
			List<LoaiQA_DTO> listLQA = new List<LoaiQA_DTO>();
			string query = "EXEC sp_select_LoaiQuanAo_by_Name @Name";
			object[] param = new object[] { name };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				LoaiQA_DTO lqa = new LoaiQA_DTO(row);
				listLQA.Add(lqa);
			}

			return listLQA;
		}

		public DataTable Load_Master_LQA()
		{
			string query = "EXEC sp_select_Master_LoaiQA";
			DataTable LQA = DataProvider.Instance.ExecuteQuery(query);
			return LQA;
		}

		public bool Insert_LoaiQuanAo(string ten_LQA)
		{
			string query = "EXEC sp_insert_LoaiQuanAo @Ten_LQA";
			object[] param = new object[] { ten_LQA };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool UpdateLQA(int id_LQA, string ten_LQA)
		{
			string query = "EXEC sp_update_LoaiQuanAo @ID_LQA , @Ten_LQA";
			object[] param = new object[] { id_LQA, ten_LQA };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool DeleteQA(int id_LQA)
		{
			string query = "sp_delete_LoaiQA @ID_LQA";
			object[] param = new object[] { id_LQA };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public int GetSoLuongSanPham(int id_LQA)
		{
			string query = "EXEC sp_select_SoLuongSanPham_by_ID_LQA @ID_LQA";
			object[] param = new object[] { id_LQA };
			int result = (int)DataProvider.Instance.ExecuteScalar(query, param);
			return result;
		}
	}
}
