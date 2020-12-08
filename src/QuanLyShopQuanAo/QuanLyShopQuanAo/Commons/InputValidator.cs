﻿using System;
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

		public InputValidator SanitizeInput()
		{
			string invalidChar = " ~!@#$%^&*()+_`-=,./<>?;':[]{}\\|";
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

		public InputValidator MustBeValidString()
		{
			string invalidChar = "~!@#$%^&*()+`-=,./<>?;':[]{}\\|";
			foreach (var symbol in invalidChar.ToCharArray())
			{
				if (rawString.Contains(symbol.ToString()))
				{
					errorBuilder.AppendLine(title + " không được chứa các ký tự không họp lệ");
					break;
				}
			}
			return this;
		}

		public InputValidator HasLengthEqualOrGreaterThan(int min)
		{
			if (rawString.Length < min)
				errorBuilder.AppendLine(title + " phải ít nhất " + min + " kí tự ╰(*°▽°*)╯");
			return this;
		}

		public InputValidator HasLengthGreaterThan(int min)
		{
			if (rawString.Length <= min)
				errorBuilder.AppendLine(title + " phải nhiều hơn " + min + " kí tự ╰(*°▽°*)╯");
			return this;
		}

		public InputValidator HasLengthEqualOrLessThan(int max)
		{
			if (rawString.Length > max)
				errorBuilder.AppendLine(title + " phải ít hơn hoặc bằng " + max + " kí tự ಠ_ಠ");
			return this;
		}

		public InputValidator HasLengthLessThan(int max)
		{
			if (rawString.Length >= max)
				errorBuilder.AppendLine(title + " phải ít hơn " + max + " kí tự ಠ_ಠ");
			return this;
		}

		public InputValidator HasLengthEqualTo(int length)
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
