using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebQuanAo_Demo.Models;

namespace QuanLyShopQuanAo.DAO
{
	class HinhQA_DAO
	{
		private HinhQA_DAO() { }
		private static HinhQA_DAO _instance;
		public static HinhQA_DAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new HinhQA_DAO();
				}
				return _instance;
			}
		}
		public List<QuanAo_DTO> Load_HinhSanPham(int id_HQA)
		{
			List<QuanAo_DTO> hinhquanao = new List<QuanAo_DTO>();
			string query = "EXEC sp_select_HinhSanPham @ID_HQA";
			object[] param = new object[] { id_HQA };

			DataTable HQA = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in HQA.Rows)
			{
				QuanAo_DTO hqa = new QuanAo_DTO(row);
				hinhquanao.Add(hqa);
			}

			return hinhquanao;
		}

	}
}
