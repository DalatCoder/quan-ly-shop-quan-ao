﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.Models;

namespace QuanLyShopQuanAo.DAO
{
	public class QuanAo_DAO
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
			List<QuanAo_DTO> listQuanAo = new List<QuanAo_DTO>();
			string query = "EXEC sp_select_QuanAo_All";

			var table = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in table.Rows)
			{
				QuanAo_DTO quanAo = new QuanAo_DTO(row);
				listQuanAo.Add(quanAo);
			}

			return listQuanAo;
		}

		public QuanAo_DTO Load_QA_by_ID(int id_QA)
		{
			string query = "EXEC sp_select_QuanAo_by_ID @ID_QA";
			object[] param = new object[] { id_QA };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				QuanAo_DTO quanAo = new QuanAo_DTO(row);
				return quanAo;
			}

			return null;
		}

		public List<QuanAo_DTO> Load_QA_by_ID_LQA(int id_LQA)
		{
			List<QuanAo_DTO> listQuanAo = new List<QuanAo_DTO>();

			string query = "EXEC sp_select_QuanAo_by_ID_LQA @ID_LQA";
			object[] param = new object[] { id_LQA };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				QuanAo_DTO quanAo = new QuanAo_DTO(row);
				listQuanAo.Add(quanAo);
			}

			return listQuanAo;
		}

		public List<QuanAo_DTO> Load_QA_Search(string tieuChuanTim)
		{
			List<QuanAo_DTO> listQuanAo = new List<QuanAo_DTO>();

			string query = "EXEC sp_select_QuanAo_By_Keyword @TieuChuanTim";
			object[] param = new object[] { tieuChuanTim };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				QuanAo_DTO quanAo = new QuanAo_DTO(row);
				listQuanAo.Add(quanAo);
			}

			return listQuanAo;
		}

		public List<QuanAo_DTO> Load_QA_By_GiaCa(float giaThap, float giaCao)
		{
			List<QuanAo_DTO> listQuanAo = new List<QuanAo_DTO>();

			string query = "EXEC sp_select_QuanAo_By_Price @GiaBanThap , @GiaBanCao";
			object[] param = new object[] { giaThap, giaCao };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				QuanAo_DTO quanAo = new QuanAo_DTO(row);
				listQuanAo.Add(quanAo);
			}

			return listQuanAo;
		}

		public bool Insert_QuanAo(string ten_QA, string size, float giaban, int soluong, string ghichu, int id_LQA, byte[] hinhQA, string hinhQAP)
		{
			string query = "EXEC sp_insert_QuanAo @Ten_QA , @Size , @GiaBan , @SoLuong , @GhiChu , @ID_LQA , @HinhQA , @HinhQAP";
			object[] param = new object[] { ten_QA, size, giaban, soluong, ghichu, id_LQA, hinhQA, hinhQAP };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		public bool Update_QuanAo(int id_QA, string ten_QA, string size, float giaban, int soluong, string ghichu, int id_LQA, byte[] hinhQA, string hinhQAP)
		{
			string query = "EXEC sp_update_QuanAo @ID_QA , @Ten_QA , @Size , @GiaBan , @SoLuong , @GhiChu , @ID_LQA , @HinhQA , @HinhQAP";
			object[] param = new object[] { id_QA, ten_QA, size, giaban, soluong, ghichu, id_LQA, hinhQA, hinhQAP };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		/*public bool DelleteQA(int id_QA)
		{
			string query = "EXEC sp_delete_QuanAo_By_ID @ID_QA";
			object[] param = new object[] { id_QA };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}*/

	}
}
