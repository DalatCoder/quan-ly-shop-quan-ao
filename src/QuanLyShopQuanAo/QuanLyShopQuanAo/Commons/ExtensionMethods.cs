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

		public static string Sanitize(this string rawString)
		{
			if (rawString.Length == 0)
				return rawString;

			string resultString = rawString[0].ToString() ;
			foreach (var letter in rawString.ToCharArray())
			{
				if (letter != ' ')
					resultString += letter.ToString();
				else
					if ( resultString.Length > 0 && resultString[resultString.Length - 1] != ' ')
					resultString += letter.ToString();
			}

			return resultString.Trim();
		}
	}
}
