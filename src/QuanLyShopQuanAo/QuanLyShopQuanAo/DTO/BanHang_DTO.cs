using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyShopQuanAo.Models
{
    public class BanHang_DTO
    {
        private int _ID_BH;
        private int _ID_KH;
        private string _ID_GD;
        private DateTime _NgayBanHang;
        private float _Discount;

        public int ID_BH { get { return _ID_BH; } set { _ID_BH = value; } }
        public int ID_KH { get { return _ID_KH; } set { _ID_KH = value; } }
        public string ID_GD { get { return _ID_GD; } set { _ID_GD = value; } }
        public DateTime NgayBanHang { get { return _NgayBanHang; } set { _NgayBanHang = value; } }
        public float Discount { get { return _Discount; } set { _Discount = value; } }

        public BanHang_DTO(int _ID_BH, int _ID_KH, string _ID_GD, DateTime _NgayBanHang, float _Discount)
		{
            ID_BH = _ID_BH;
            ID_KH = _ID_KH;
            ID_GD = _ID_GD;
            NgayBanHang = _NgayBanHang;
            Discount = _Discount;
		}

        public BanHang_DTO(DataRow row)
		{
            ID_BH = (int)row["ID_BH"];
            ID_KH = (int)row["ID_KH"];
            ID_GD = row["ID_GD"].ToString();
            NgayBanHang = (DateTime)row["NgayBanHang"];
            Discount = (float)row["Discount"];
        }
    }
}
