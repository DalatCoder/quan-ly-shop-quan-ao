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

		public List<ThongKeBanHang_DTO> GetListThongKeBanHang()
		{
			List<ThongKeBanHang_DTO> listThongKe = new List<ThongKeBanHang_DTO>();
			string query = "EXEC sp_select_BanHang_All";

			DataTable table = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow row in table.Rows)
			{
				ThongKeBanHang_DTO thongKe = new ThongKeBanHang_DTO(row);
				listThongKe.Add(thongKe);
			}

			return listThongKe;
		}

		public List<ThongKeBanHang_DTO> GetListThongKeBanHangInTime(DateTime fromDate, DateTime toDate)
		{
			List<ThongKeBanHang_DTO> listThongKe = new List<ThongKeBanHang_DTO>();
			string query = "EXEC sp_select_banHang_FromDateToDate @fromDate , @toDate";
			object[] param = new object[] { fromDate, toDate };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				ThongKeBanHang_DTO thongKe = new ThongKeBanHang_DTO(row);
				listThongKe.Add(thongKe);
			}

			return listThongKe;
		}
	}
}
