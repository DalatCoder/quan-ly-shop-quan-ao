using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyShopQuanAo.Models
{
    public class LoaiQA_DTO
    {
        private int _ID_LQA;
        private string _Ten_LQA;

        public int ID_LQA { get { return _ID_LQA; } set { _ID_LQA = value; } }
        public string Ten_LQA { get { return _Ten_LQA; } set { _Ten_LQA = value; } }

		public LoaiQA_DTO(int _ID_LQA, string _Ten_LQA)
		{
            ID_LQA = _ID_LQA;
            Ten_LQA = _Ten_LQA;
		}

        public LoaiQA_DTO(DataRow row)
		{
            ID_LQA = (int)row["ID_LQA"];
            Ten_LQA = row["Ten_LQA"].ToString();
		}
    }
}
