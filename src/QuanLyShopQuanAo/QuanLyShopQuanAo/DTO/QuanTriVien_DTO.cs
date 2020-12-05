using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyShopQuanAo.Models
{
	class QuanTriVien_DTO
	{
		private int _ID_QTV;
		private string _TenDangNhap;
		private string _MatKhau;

		public int ID_QTV { get { return _ID_QTV; } set { _ID_QTV = value; } }
		public string TenDangNhap { get { return _TenDangNhap; } set { _TenDangNhap = value; } }
		public string MatKhau { get { return _MatKhau; } set { _MatKhau = value; } }
		public QuanTriVien_DTO(int _ID_QTV, string _TenDangNhap, string _MatKhau)
		{
			ID_QTV = _ID_QTV;
			TenDangNhap = _TenDangNhap;
			MatKhau = _MatKhau;
		}
		public QuanTriVien_DTO(DataRow row)
		{
			ID_QTV = (int)row["ID_QTV"];
			TenDangNhap = row["TenDangNhap"].ToString();
			MatKhau = row["MatKhau"].ToString();
		}
	}
}
