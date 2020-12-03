using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WebQuanAo_Demo.Models
{
    class QuanAo_DTO
    {
        private int _ID_QA;
        private string _Ten_QA;
        private string _Size;
        private int _ID_LQA;
        private float _GiaBan;
        private int _SoLuong;
        private string _GhiChu;
		private int _ID_HQA;
        private byte[] _HinhQA;
        private string _HinhQAP;
        private string _Ten_LQA;

        public int ID_QA { get { return _ID_QA; } set { _ID_QA = value; } }
        public string Ten_QA { get {return _Ten_QA; } set {_Ten_QA=value; } }
        public string Size{ get { return _Size; } set { _Size = value; } }
        public float GiaBan { get { return _GiaBan; } set {_GiaBan=value; } }
        public int SoLuong { get { return _SoLuong; } set { _SoLuong = value; } }
        public string GhiChu { get { return _GhiChu; } set { _GhiChu = value; } }
        public int ID_HQA { get { return _ID_HQA; } set { _ID_HQA = value; } }
        public int ID_LQA { get { return _ID_LQA; } set { _ID_LQA = value; } }
        public byte[] HinhQA { get { return _HinhQA; } set { _HinhQA = value; } }
        public string HinhQAP { get { return _HinhQAP; } set { _HinhQAP = value; } }
        public string Ten_LQA { get { return _Ten_LQA; } set { _Ten_LQA = value; } }

        public QuanAo_DTO(int _ID_QA, string _Ten_QA, string _Size, float _GiaBan, int _SoLuong, string _GhiChu, float _Discount, int _ID_HQA, int _ID_LQA, byte[] _HinhQA, string _HinhQAP, string _Ten_LQA)
		{
            ID_QA = _ID_QA;
            Ten_QA = _Ten_QA;
            Size = _Size;
            GiaBan = _GiaBan;
            SoLuong = _SoLuong;
            GhiChu = _GhiChu;
            ID_HQA = _ID_HQA;
            ID_LQA = _ID_LQA;
            HinhQA = _HinhQA;
            HinhQAP = _HinhQAP;
            Ten_LQA = _Ten_LQA;

		}
        public QuanAo_DTO(DataRow row)
		{
            ID_QA = (int)row["ID_QA"];
            Ten_QA = row["Ten_QA "].ToString();
            Size = row["Size"].ToString();
            GiaBan = (float)row["GiaBan"];
            SoLuong = (int)row["SoLuong"];
            GhiChu = row["GhiChu "].ToString();
            ID_HQA = (int)row["ID_HQA"];
            ID_LQA = (int)row["ID_LQA"];
            HinhQA = (byte[])row["HinhQA"];
            HinhQAP = row["HinhQAP"].ToString();
            Ten_LQA = row["Ten_LQA"].ToString();
        }
    }
}
