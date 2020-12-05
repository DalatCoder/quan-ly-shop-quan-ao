using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo.Commons
{
	public static class ExtensionMethods
	{
		public static void HideColumns(this DataGridView dgv, params string[] columns)
		{
			foreach (string column in columns)
			{
				dgv.Columns[column].Visible = false;
			}
		}
	}
}
