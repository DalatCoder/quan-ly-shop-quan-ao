using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.Models;

namespace QuanLyShopQuanAo.DAO
{
	public class ChiTietBanHang_DAO
	{
		private ChiTietBanHang_DAO() { }

		private static ChiTietBanHang_DAO _instance;
		public static ChiTietBanHang_DAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new ChiTietBanHang_DAO();
				}
				return _instance;
			}
		}
		public List<ChiTietBanHang_DTO> Load_CTBH(int id_BH)
		{
			List<ChiTietBanHang_DTO> listCTBH = new List<ChiTietBanHang_DTO>();

			string query = "EXEC sp_select_ChiTietBanHang @ID_BH";
			object[] param = new object[] { id_BH };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				ChiTietBanHang_DTO chiTietBanHang = new ChiTietBanHang_DTO(row);
				listCTBH.Add(chiTietBanHang);
			}

			return listCTBH;
		}

		public bool Insert_ChiTietBanHang(int id_QA, int id_BH, int soluongsanpham)
		{
			string query = "EXEC sp_insert_ChiTietBanHang @ID_QA , @ID_BH , @SoLuongSanPham";
			object[] param = new object[] { id_QA, id_BH, soluongsanpham };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
	}
}
