﻿using QuanLyShopQuanAo.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo
{
	public partial class fQLShopQuanAo : Form
	{
		
		public fQLShopQuanAo()
		{
			InitializeComponent();
		}

		private void tsmAdmin_Click(object sender, EventArgs e)
		{
			frmAdmin f = new frmAdmin();
			f.ShowDialog();
		}

		private void tsmDangXuat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void fQLShopQuanAo_Load(object sender, EventArgs e)
		{
			lbChu.Text = TienIch.So_chu(int.Parse(lbSo.Text.Replace(".", string.Empty)));
		}

		
	}
}
