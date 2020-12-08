using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyShopQuanAo.Models
{
    public class KhachHang_DTO
    {
        private int _ID_KH;
        private string _HoTen;
        private string _SDT;
        private string _Diachi;

        public int ID_KH { get { return _ID_KH; } set { _ID_KH = value; } }
        public string HoTen { get { return _HoTen; } set { _HoTen = value; } }
        public string SDT { get { return _SDT; } set { _SDT = value; } }
        public string DiaChi { get { return _Diachi; } set { _Diachi = value; } }

		

        public KhachHang_DTO(int _ID_KH, string _HoTen, string _SDT, string _Diachi)
		{
            ID_KH = _ID_KH;
            HoTen = _HoTen;
            SDT = _SDT;
            DiaChi = _Diachi;
		}

        public KhachHang_DTO(DataRow row)
		{
            ID_KH = (int)row["ID_KH"];
            HoTen = row["HoTen"].ToString();
            SDT = row["SDT"].ToString();
            DiaChi = row["DiaChi"].ToString();
        }

		public KhachHang_DTO(string hoTen, string sDT, string diaChi)
		{
			HoTen = hoTen;
			SDT = sDT;
			DiaChi = diaChi;
		}
	}
}
