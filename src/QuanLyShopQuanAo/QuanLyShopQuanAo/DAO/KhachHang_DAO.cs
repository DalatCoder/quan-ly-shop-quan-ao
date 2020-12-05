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
			List<KhachHang_DTO> khachhang = new List<KhachHang_DTO>();
			string query = "EXEC sp_select_KhachHang";
			DataTable KH = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in KH.Rows)
			{
				KhachHang_DTO kh = new KhachHang_DTO(row);
				khachhang.Add(kh);
			}

			return khachhang;
		}

	}
}
