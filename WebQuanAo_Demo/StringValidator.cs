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

		public static void CheckRequire(string raw, string errMessage)
		{
			if (sanitizeString(raw).Length == 0)
				throw new Exception(errMessage);
		}

		public static void CheckMinLength(string raw, int min, string errMessage)
		{
			if (sanitizeString(raw).Length < min)
				throw new Exception(errMessage);
		}

		public static void CheckMaxLength(string raw, int max, string errMessage)
		{
			if (sanitizeString(raw).Length > max)
				throw new Exception(errMessage);
		}

		public static void CheckLengthEqualTo(string raw, int length, string errMessage)
		{
			if (sanitizeString(raw).Length != length)
				throw new Exception(errMessage);
		}
	}
}
