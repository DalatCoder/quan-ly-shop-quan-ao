using QuanLyShopQuanAo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DAO
{
	public class ThongKeBanHang_DAO
	{
		private ThongKeBanHang_DAO() { }

		private static ThongKeBanHang_DAO _instance;
		public static ThongKeBanHang_DAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new ThongKeBanHang_DAO();
				}
				return _instance;
			}
		}

		public DataTable GetListThongKeBanHang(DateTime fromDate, DateTime toDate)
		{
			List<ThongKeBanHang_DTO> thongKeBanHangs = new List<ThongKeBanHang_DTO>();

			string query = "EXEC sp_select_banHang_FromDateToDate @fromDate , @toDate";
			object[] param = new object[] { fromDate, toDate };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			return table;
		}
	}
}
