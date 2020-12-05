using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.Models;

namespace QuanLyShopQuanAo.DAO
{
	class LoaiQA_DAO
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
			List<LoaiQA_DTO> loaiquanao = new List<LoaiQA_DTO>();
			string query = "EXEC sp_select_LoaiQuanAo_All";
			DataTable LQA = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in LQA.Rows)
			{
				LoaiQA_DTO lqa = new LoaiQA_DTO(row);
				loaiquanao.Add(lqa);
			}

			return loaiquanao;
		}

		public LoaiQA_DTO Load_LQA_by_ID(int id_LQA)
		{
			List<LoaiQA_DTO> loaiquanao = new List<LoaiQA_DTO>();
			string query = "EXEC sp_select_LoaiQuanAo_by_ID @ID_LQA";
			object[] param = new object[] { id_LQA };

			DataTable LQA = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in LQA.Rows)
			{
				LoaiQA_DTO lqa = new LoaiQA_DTO(row);
				return lqa;
			}

			return null;
		}

		//public List<LoaiQA_DTO> Load_Master_LQA()
		//{
		//	List<LoaiQA_DTO> loaiquanao = new List<LoaiQA_DTO>();
		//	string query = "EXEC sp_select_Master_LoaiQA";
		//	DataTable LQA = DataProvider.Instance.ExecuteQuery(query);

		//	foreach (DataRow row in LQA.Rows)
		//	{
		//		LoaiQA_DTO lqa = new LoaiQA_DTO(row);
		//		loaiquanao.Add(lqa);
		//	}

		//	return loaiquanao;
		//}

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

		/*public bool DelleteLQA(int id_LQA)
		{
			string query = "EXEC sp_delete_LoaiQuanAo_by_ID @ID_LQA";
			object[] param = new object[] { id_LQA };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}*/
	}
}
