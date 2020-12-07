using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.Models;

namespace QuanLyShopQuanAo.DAO
{
	public class HinhQA_DAO
	{
		private HinhQA_DAO() { }
		private static HinhQA_DAO _instance;
		public static HinhQA_DAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new HinhQA_DAO();
				}
				return _instance;
			}
		}

		public HinhQA_DTO Load_HinhSanPham(int id_QA)
		{
			string query = "EXEC sp_select_HinhSanPham_By_ID_QA @ID_QA";
			object[] param = new object[] { id_QA };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			if (table.Rows.Count == 0) return null;

			return new HinhQA_DTO(table.Rows[0]);
		}
	}
}
