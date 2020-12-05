using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.Models;

namespace QuanLyShopQuanAo.DAO
{
	class BanHang_DAO
	{
		private BanHang_DAO() { }

		private static BanHang_DAO _instance;
		public static BanHang_DAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new BanHang_DAO();
				}
				return _instance;
			}
		}
		public List<BanHang_DTO> Load_BH()
		{
			List<BanHang_DTO> banhang = new List<BanHang_DTO>();
			string query = "EXEC sp_select_BanHang_All";
			DataTable BH = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in BH.Rows)
			{
				BanHang_DTO bh = new BanHang_DTO(row);
				banhang.Add(bh);
			}

			return banhang;
		}

		public BanHang_DTO Load_BH_By_ID(int id_BH)
		{
			List<BanHang_DTO> banhang = new List<BanHang_DTO>();
			string query = "EXEC sp_select_BanHang_by_ID @ID_BH";
			object[] param = new object[] { id_BH };

			DataTable BH = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in BH.Rows)
			{
				BanHang_DTO bh = new BanHang_DTO(row);
				return bh;
			}

			return null;
		}
		public List<BanHang_DTO> Load_BH_By_Date(DateTime ngaybatdau, DateTime ngayketthuc)
		{
			List<BanHang_DTO> banhang = new List<BanHang_DTO>();
			string query = "EXEC sp_select_BanHang_by_ngay @ngaybatdau,@ngayketthuc";
			object[] param = new object[] { ngaybatdau,ngayketthuc };

			DataTable BH = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in BH.Rows)
			{
				BanHang_DTO bh = new BanHang_DTO(row);
				banhang.Add(bh);
			}

			return banhang;
		}
		public bool Insert_BanHang(int id_GD, DateTime ngaybanhang, string hoten, string sdt)
		{
			string query = "EXEC sp_insert_BanHang @ID_GD , @NgayBanHang , @HoTen , @SDT";
			object[] param = new object[] { id_GD, ngaybanhang, hoten, sdt };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}
	}
}
