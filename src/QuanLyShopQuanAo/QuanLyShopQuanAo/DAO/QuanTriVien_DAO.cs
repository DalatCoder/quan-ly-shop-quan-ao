using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DAO
{
	class QuanTriVien_DAO
	{
		private QuanTriVien_DAO() { }

		private static QuanTriVien_DAO _instance;

		public static QuanTriVien_DAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new QuanTriVien_DAO();
				}
				return _instance;
			}
		}

		public bool Login(string tenDangNhap, string matKhau)
		{
			string query = "EXEC sp_select_DangNhapAdmin @TenDangNhap , @MatKhau";
			object[] param = new object[] { tenDangNhap, matKhau };
			DataTable result = DataProvider.Instance.ExecuteQuery(query, param);
			return result.Rows.Count > 0;
		}		
	}
}
