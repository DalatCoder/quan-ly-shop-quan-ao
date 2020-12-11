using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.Models;

namespace QuanLyShopQuanAo.DAO
{
	public class BanHang_DAO
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

		public int Insert_BanHang(string id_GD, float discount, string hoten, string sdt, string diaChi)
		{
			string query = "EXEC sp_insert_BanHang @ID_GD , @Discount , @HoTen , @SDT , @DiaChi";
			object[] param = new object[] { id_GD, discount, hoten, sdt, diaChi };
			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			int result = -1;
			foreach (DataRow row in table.Rows)
			{
				result = (int)row["ID_BH"];
			}

			return result;
		}

		public int GetHoaDonBanHangChuaDuocThanhToan(int id_KH)
		{
			string query = "EXEC sp_select_BanHang_ChuaThanhToan_By_KhachHang @ID_KH";
			object[] param = new object[] { id_KH };
			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			int ID_BH = -1;
			foreach (DataRow row in table.Rows)
			{
				ID_BH = (int)row["ID_BH"];
			}

			return ID_BH;
		}

		public bool ThanhToanHoaDon(int id_BH, string id_GD, float discount)
		{
			string query = "EXEC sp_ThanhToanBanHang @ID_BH , @ID_GD , @discount";
			object[] param = new object[] { id_BH, id_GD, discount };
			int result = DataProvider.Instance.ExecuteNonQuery(query, param);
			return result > 0;
		}

		/// <summary>
		/// Phương thức lấy số lượng đơn hàng đã thanh toán của mỗi khách hàng
		/// </summary>
		/// <param name="id_kh">Mã số khách hàng</param>
		/// <returns>Số lượng đơn hàng của khách</returns>
		public int Get_SoLuongBanHang_By_KhachHang(int id_kh)
		{
			string query = "EXEC sp_select_BanHang_By_KhacHang_ID @ID_KH";
			object[] param = new object[] { id_kh };
			int result = (int)DataProvider.Instance.ExecuteScalar(query, param);
			return result;
		}

		/// <summary>
		/// Phương thức lấy số lượng đơn hàng đã thanh toán của mỗi khách hàng
		/// </summary>
		/// <param name="SDT">Số điện thoại của khách hàng</param>
		/// <returns>Số lượng đơn hàng của khách</returns>
		public int Get_SoLuongBanHang_By_KhachHang(string SDT)
		{
			string query = "EXEC sp_select_BanHang_By_KhachHang_SDT @SDT";
			object[] param = new object[] { SDT };
			int result = (int)DataProvider.Instance.ExecuteScalar(query, param);
			return result;
		}

		public int TinhTongTienChuaGiamGia(DateTime fromdate,DateTime todate)
		{
			string query = "EXEC sp_TinhTongTienChuaGiamGia @fromdate , @todate";
			object[] param = new object[] { fromdate, todate };
			int result = (int)DataProvider.Instance.ExecuteScalar(query, param);
			return result;
		}

		public int TinhTongTienGiamGia(DateTime fromdate,DateTime todate)
		{
			string query = "EXEC sp_TinhTongTienGiamGia @fromdate , @todate";
			object[] param = new object[] { fromdate, todate };
			int result = (int)DataProvider.Instance.ExecuteScalar(query, param);
			return result;
		}
	}
}
