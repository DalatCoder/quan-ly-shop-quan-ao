using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopQuanAo.Commons
{
	public class InputValidator
	{
		private StringBuilder errorBuilder = new StringBuilder();
		private string title = "Unknow field";
		private string rawString = "";
		public bool HasError => !string.IsNullOrWhiteSpace(errorBuilder.ToString());

		public InputValidator SetTitle(string errorTitle)
		{
			this.title = errorTitle;
			return this;
		}

		public InputValidator SetInputString(string inputString)
		{
			rawString = inputString;
			return this;
		}

		public string GetErrorMessage()
		{
			return errorBuilder.ToString();
		}

		public InputValidator sanitizeString()
		{
			string invalidChar = " ~!@#$%^&*()+_`-=,./<>?;':[]{ }\\|";
			foreach (var symbol in invalidChar.ToCharArray())
			{
				rawString = rawString.Replace(symbol.ToString(), string.Empty);
			}

			rawString = rawString.Trim();
			return this;
		}

		public InputValidator Require()
		{
			if (rawString.Length == 0)
				errorBuilder.AppendLine(title + " không hợp lệ (❁´◡`❁)");
			return this;
		}

		public InputValidator EqualOrGreaterThan(int min)
		{
			if (rawString.Length < min)
				errorBuilder.AppendLine(title + " phải ít nhất " + min + " kí tự ╰(*°▽°*)╯");
			return this;
		}

		public InputValidator GreaterThan(int min)
		{
			if (rawString.Length <= min)
				errorBuilder.AppendLine(title + " phải nhiều hơn " + min + " kí tự ╰(*°▽°*)╯");
			return this;
		}

		public InputValidator EqualOrLessThan(int max)
		{
			if (rawString.Length > max)
				errorBuilder.AppendLine(title + " phải ít hơn hoặc bằng " + max + " kí tự ಠ_ಠ");
			return this;
		}

		public InputValidator LessThan(int max)
		{
			if (rawString.Length >= max)
				errorBuilder.AppendLine(title + " phải ít hơn " + max + " kí tự ಠ_ಠ");
			return this;
		}

		public InputValidator EqualTo(int length)
		{
			if (rawString.Length != length)
				errorBuilder.AppendLine(title + " phải có đủ " + length + " kí tự (●'◡'●)");
			return this;
		}

		public InputValidator IsNumber(string raw, string tieude)
		{
			bool isDouble = double.TryParse(raw, out _);
			if (!isDouble)
				errorBuilder.AppendLine(tieude + " phải là số (¬‿¬)");
			return this;
		}
	}
}
