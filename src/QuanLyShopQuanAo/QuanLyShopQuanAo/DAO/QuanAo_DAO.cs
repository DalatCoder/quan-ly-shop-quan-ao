﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebQuanAo_Demo.Models;

namespace QuanLyShopQuanAo.DAO
{
	class QuanAo_DAO
	{
		private QuanAo_DAO() { }

		private static QuanAo_DAO _instance;
		public static QuanAo_DAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new QuanAo_DAO();
				}
				return _instance;
			}
		}


		public List<QuanAo_DTO> Load_QA()
		{
			List<QuanAo_DTO> quanao = new List<QuanAo_DTO>();
			string query = "EXEC sp_select_QuanAo";
			DataTable QA = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in QA.Rows)
			{
				QuanAo_DTO qa = new QuanAo_DTO(row);
				quanao.Add(qa);
			}

			return quanao;
		}

		public QuanAo_DTO Load_QA_by_ID(int id_QA)
		{
			List<QuanAo_DTO> quanao = new List<QuanAo_DTO>();
			string query = "EXEC sp_select_QuanAo_by_ID @ID_QA";
			object[] param = new object[] { id_QA };

			DataTable QA = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in QA.Rows)
			{
				QuanAo_DTO qa = new QuanAo_DTO(row);
				return qa;
			}

			return null;
		}

		public List<QuanAo_DTO> Load_QA_by_ID_LQA(int id_LQA)
		{
			List<QuanAo_DTO> quanao = new List<QuanAo_DTO>();

			string query = "EXEC sp_select_QuanAo_by_ID_LQA @ID_LQA";
			object[] param = new object[] { id_LQA };

			DataTable QA = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in QA.Rows)
			{
				QuanAo_DTO qa = new QuanAo_DTO(row);
				quanao.Add(qa);
			}

			return quanao;
		}

		public List<QuanAo_DTO> Load_QA_Search(string tieuchuantim)
		{
			List<QuanAo_DTO> quanao = new List<QuanAo_DTO>();

			string query = "EXEC sp_select_search_QuanAo @TieuChuanTim";
			object[] param = new object[] { tieuchuantim };

			DataTable QA = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in QA.Rows)
			{
				QuanAo_DTO qa = new QuanAo_DTO(row);
				quanao.Add(qa);
			}

			return quanao;
		}

		public List<QuanAo_DTO> Load_QA_By_GiaCa_Discount(float giacathap, float giacacao)
		{
			List<QuanAo_DTO> quanao = new List<QuanAo_DTO>();

			string query = "EXEC sp_select_QuanAo_By_GiaCa_Discount @GiaBanThap , @GiaBanCao";
			object[] param = new object[] { giacathap, giacacao };

			DataTable QA = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in QA.Rows)
			{
				QuanAo_DTO qa = new QuanAo_DTO(row);
				quanao.Add(qa);
			}

			return quanao;
		}

		public bool Insert_QuanAo(string ten_QA, string size, float giaban, int soluong, string ghichu, float discount, int id_LQA,byte[] hinhQA, string hinhQAP)
		{
			string query = "EXEC sp_insert_QuanAo @Ten_QA , @Size, @GiaBan, @SoLuong, @GhiChu, @Discount, @ID_LQA, @HinhQA, @HinhQAP";
			object[] param = new object[] { ten_QA, size, giaban, soluong, ghichu, discount, id_LQA, hinhQA, hinhQAP };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool UpdateQA(int id_QA, string ten_QA, string size, float giaban, int soluong, string ghichu, float discount, int id_LQA, int id_HQA, byte[] hinhQA, string hinhQAP)
		{
			string query = "EXEC sp_update_QuanAo @Ten_QA , @Size, @GiaBan, @SoLuong, @GhiChu, @Discount, @ID_LQA, @HinhQA, @HinhQAP";
			object[] param = new object[] { id_QA, ten_QA, size, giaban, soluong, ghichu, discount, id_LQA, id_HQA, hinhQA, hinhQAP };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		//public bool DelleteQA(int id_QA)
		//{
		//	string query = "EXEC sp_delete_QuanAo_By_ID @ID_QA";
		//	object[] param = new object[] { id_QA };
		//	int result = DataProvider.Instance.ExecuteNonQuery(query, param);
		//	return result > 0;
		//}

	}
}
