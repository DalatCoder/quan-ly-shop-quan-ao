using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.Models
{
	public class ChiTietBanHang_DTO
	{
		private int _ID_CTBH;
		private int _ID_QA;
		private string _Ten_QA;
		private float _GiaBan;
		private int _SoLuongSanPham;

		public ChiTietBanHang_DTO() { }

		public ChiTietBanHang_DTO(DataRow row)
		{
			ID_CTBH = (int)row["ID_CTBH"];
			ID_QA = (int)row["ID_QA"];
			Ten_QA = row["Ten_QA"].ToString();
			GiaBan = (float)Convert.ToDouble(row["GiaBan"]);
			SoLuongSanPham = (int)row["SoLuongSanPham"];
		}

		public ChiTietBanHang_DTO(int iD_CTBH, int iD_QA, string ten_QA, float giaBan, int soLuongSanPham)
		{
			ID_CTBH = iD_CTBH;
			ID_QA = iD_QA;
			Ten_QA = ten_QA;
			GiaBan = giaBan;
			SoLuongSanPham = soLuongSanPham;
		}

		public int ID_CTBH { get => _ID_CTBH; set => _ID_CTBH = value; }
		public int ID_QA { get => _ID_QA; set => _ID_QA = value; }
		public string Ten_QA { get => _Ten_QA; set => _Ten_QA = value; }
		public float GiaBan { get => _GiaBan; set => _GiaBan = value; }
		public int SoLuongSanPham { get => _SoLuongSanPham; set => _SoLuongSanPham = value; }
		public float ThanhTien { get => GiaBan * SoLuongSanPham; }
	}
}
