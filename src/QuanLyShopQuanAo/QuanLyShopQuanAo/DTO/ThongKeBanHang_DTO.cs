using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.Models
{
	public class ThongKeBanHang_DTO
	{
		private string _ID_BH;
		private string _ID_GD;
		private string _HoTen;
		private string _SDT;
		private DateTime _NgayBanHang;
		private float _Discount;

		public ThongKeBanHang_DTO(string iD_BH, string iD_GD, string hoTen, string sDT, DateTime ngayBanHang, float discount)
		{
			ID_BH = iD_BH;
			ID_GD = iD_GD;
			HoTen = hoTen;
			SDT = sDT;
			NgayBanHang = ngayBanHang;
			Discount = discount;
		}

		public ThongKeBanHang_DTO(DataRow row)
		{
			ID_BH = row["ID_BH"].ToString();
			ID_GD = row["ID_GD"].ToString();
			HoTen = row["HoTen"].ToString();
			SDT = row["SDT"].ToString();
			NgayBanHang = DateTime.Parse(row["NgayBanHang"].ToString());
			Discount = (float)Convert.ToDouble(row["Discount"]);
		}

		public string ID_BH { get => _ID_BH; set => _ID_BH = value; }
		public string ID_GD { get => _ID_GD; set => _ID_GD = value; }
		public string HoTen { get => _HoTen; set => _HoTen = value; }
		public string SDT { get => _SDT; set => _SDT = value; }
		public DateTime NgayBanHang { get => _NgayBanHang; set => _NgayBanHang = value; }
		public float Discount { get => _Discount; set => _Discount = value; }
	}
}
