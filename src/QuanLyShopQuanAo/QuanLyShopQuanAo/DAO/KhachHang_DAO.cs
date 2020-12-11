using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.Models;

namespace QuanLyShopQuanAo.DAO
{
	public class KhachHang_DAO
	{
		private KhachHang_DAO() { }
		private static KhachHang_DAO _instance;
		public static KhachHang_DAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new KhachHang_DAO();
				}
				return _instance;
			}
		}

		public List<KhachHang_DTO> Load_KH()
		{
			List<KhachHang_DTO> listKhachHang = new List<KhachHang_DTO>();
			string query = "EXEC sp_select_KhachHang";
			DataTable table = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in table.Rows)
			{
				KhachHang_DTO khachHang = new KhachHang_DTO(row);
				listKhachHang.Add(khachHang);
			}

			return listKhachHang;
		}

		public List<KhachHang_DTO> Search_KH(string tieuChuanTim)
		{
			List<KhachHang_DTO> listKhachHang = new List<KhachHang_DTO>();
			string query = "EXEC sp_select_KhachHang_By_KeyWord @TieuChuanTim";
			object[] param = new object[] { tieuChuanTim };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				KhachHang_DTO khachHang = new KhachHang_DTO(row);
				listKhachHang.Add(khachHang);
			}

			return listKhachHang;
		}

		public List<KhachHang_DTO> TimKiemTheoSDT(string SDT)
		{
			string query = "EXEC sp_select_TimKiemKhachHang @SDT";
			object[] param = new object[] { SDT };
			DataTable data = DataProvider.Instance.ExecuteQuery(query, param);

			List<KhachHang_DTO> dsKhachHang = new List<KhachHang_DTO>();

			foreach (DataRow row in data.Rows)
			{
				KhachHang_DTO khachhang = new KhachHang_DTO(row);
				dsKhachHang.Add(khachhang);
			}

			return dsKhachHang;
		}
	}
}
