using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebQuanAo_Demo
{
	public static class StringValidator
	{
		public static string sanitizeString(string raw)
		{
			string invalidChar = " ~!@#$%^&*()+_`-=,./<>?;':[]{ }\\|";
			foreach (var symbol in invalidChar.ToCharArray())
			{
				raw = raw.Replace(symbol.ToString(), string.Empty);
			}

			return raw.Trim();
		}

		public static void CheckRequire(string raw, string tieude)
		{
			if (sanitizeString(raw).Length == 0)
				throw new Exception(tieude + " không hợp lệ (❁´◡`❁)");
		}

		public static void CheckMinLength(string raw, int min, string tieude)
		{
			if (sanitizeString(raw).Length < min)
				throw new Exception(tieude + " phải nhiều hơn " + min + " kí tự");
		}

		public static void CheckMaxLength(string raw, int max, string tieude)
		{
			if (sanitizeString(raw).Length > max)
				throw new Exception(tieude + "");
		}

		public static void CheckLengthEqualTo(string raw, int length, string tieude)
		{
			if (sanitizeString(raw).Length != length)
				throw new Exception(tieude + " phải có đủ " + length + " kí tự");
		}

		public static void TextIsStringNumber(string raw, string tieude)
		{
			bool isDouble = double.TryParse(raw, out _);
			if (!isDouble)
				throw new Exception(tieude + " phải là số");
		}
	}
}
