using QuanLyShopQuanAo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.DAO
{
	public class KieuTaiKhoan_DAO
	{
		public List<KieuTaiKhoan_DTO> GetKieuTaiKhoan()
		{
			string query = "EXEC sp_select_KieuTaiKhoan";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			List<KieuTaiKhoan_DTO> dsKieuTaiKhoan = new List<KieuTaiKhoan_DTO>();

			foreach (DataRow row in data.Rows)
			{
				KieuTaiKhoan_DTO kieutaikhoan = new KieuTaiKhoan_DTO(row);
				dsKieuTaiKhoan.Add(kieutaikhoan);
			}

			return dsKieuTaiKhoan;
		}
	}
}
