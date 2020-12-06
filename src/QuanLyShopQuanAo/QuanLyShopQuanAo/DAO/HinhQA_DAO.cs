using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyShopQuanAo.Models;

namespace QuanLyShopQuanAo.DAO
{
	public class HinhQA_DAO
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

		public Image Load_HinhSanPham(int id_QA)
		{
			string query = "EXEC sp_select_HinhAnh_By_QuanAo_ID @ID_QA";
			object[] param = new object[] { id_QA };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			if (table.Rows.Count == 0) return null;

			DataRow row = table.Rows[0];
			byte[] raw = (byte[])row["HinhQA"];

			using (var ms = new MemoryStream(raw))
			{
				Image image = Image.FromStream(ms);
				return image;
			}
		}
	}
}
