using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DTO
{
	public class KieuTaiKhoan_DTO
	{
		private int _ID_KTK;
		private string _Ten_KTK;

	
		public int ID_KTK { get => _ID_KTK; set => _ID_KTK = value; }
		public string Ten_KTK { get => _Ten_KTK; set => _Ten_KTK = value; }


		public KieuTaiKhoan_DTO(int iD_KTK, string ten_KTK)
		{
			ID_KTK = iD_KTK;
			Ten_KTK = ten_KTK;
		}

		public KieuTaiKhoan_DTO(DataRow row)
		{
			ID_KTK =(int) row["ID_KTK"];
			Ten_KTK = row["Ten_KTK"].ToString();
		}
	}
}
