using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyShopQuanAo.Models
{
    public static class SanPham
	{
        public static string ID_QA => "ID_QA";
        public static string Ten_QA => "Ten_QA";
        public static string Size => "Size";
        public static string GiaBan => "GiaBan";
        public static string SoLuong => "SoLuong";
        public static string GhiChu => "GhiChu";
        public static string ID_LQA => "ID_LQA";
        public static string Ten_LQA => "Ten_LQA";
        public static string ID_HQA => "ID_HQA";
        public static string HinhQA => "HinhQA";
        public static string HinhQAP => "HinhQAP";
	}

    public class QuanAo_DTO
    {
        private int _ID_QA;
        private string _Ten_QA;
        private string _Size;
        private float _GiaBan;
        private int _SoLuong;
        private string _GhiChu;
        private int _ID_LQA;
        private string _Ten_LQA;

        public int ID_QA { get { return _ID_QA; } set { _ID_QA = value; } }
        public string Ten_QA { get {return _Ten_QA; } set {_Ten_QA=value; } }
        public string Size{ get { return _Size; } set { _Size = value; } }
        public float GiaBan { get { return _GiaBan; } set {_GiaBan=value; } }
        public int SoLuong { get { return _SoLuong; } set { _SoLuong = value; } }
        public string GhiChu { get { return _GhiChu; } set { _GhiChu = value; } }
        public int ID_LQA { get { return _ID_LQA; } set { _ID_LQA = value; } }
        public string Ten_LQA { get { return _Ten_LQA; } set { _Ten_LQA = value; } }

        public QuanAo_DTO(DataRow row)
		{
            ID_QA = (int)row[SanPham.ID_QA];
            Ten_QA = row[SanPham.Ten_QA].ToString();
            Size = row[SanPham.Size].ToString();
            GiaBan = (float)Convert.ToDouble(row[SanPham.GiaBan]);
            SoLuong = (int)row[SanPham.SoLuong];
            GhiChu = row[SanPham.GhiChu].ToString();
            ID_LQA = (int)row[SanPham.ID_LQA];
            Ten_LQA = row[SanPham.Ten_LQA].ToString();
        }

		public QuanAo_DTO(int iD_QA, string ten_QA, string size, float giaBan, int soLuong, string ghiChu, int iD_LQA, string ten_LQA)
		{
			ID_QA = iD_QA;
			Ten_QA = ten_QA;
			Size = size;
			GiaBan = giaBan;
			SoLuong = soLuong;
			GhiChu = ghiChu;
			ID_LQA = iD_LQA;
			Ten_LQA = ten_LQA;
		}
	}
}
