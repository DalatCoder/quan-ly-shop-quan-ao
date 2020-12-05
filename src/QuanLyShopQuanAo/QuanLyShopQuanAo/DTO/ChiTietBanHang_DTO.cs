using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyShopQuanAo.Models
{
    public class ChiTietBanHang_DTO
    {
        private int _ID_CTBH;
        private int _ID_QA;
        private int _ID_BH;
        private int _SoLuongSanPham;

        public int ID_CTBH { get { return _ID_CTBH; } set { _ID_CTBH = value; } }
        public int ID_QA { get { return _ID_QA; } set { _ID_QA = value; } }
        public int ID_BH { get { return _ID_BH; } set { _ID_BH = value; } }
        public int SoLuongSanPham { get { return _SoLuongSanPham; } set { _SoLuongSanPham = value; } }
        public ChiTietBanHang_DTO(int _ID_CTBH, int _ID_QA, int _ID_BH, int _SoLuongSanPham)
		{
            ID_CTBH = _ID_CTBH;
            ID_QA = _ID_QA;
            ID_QA = _ID_BH;
            SoLuongSanPham = _SoLuongSanPham;
		}
        public ChiTietBanHang_DTO(DataRow row)
		{
            ID_CTBH = (int)row["ID_CTBH"];
            ID_QA = (int)row["ID_QA"];
            ID_BH = (int)row["ID_BH"];
            SoLuongSanPham = (int)row["SoLuongSanPham"];

        }
    }
}
