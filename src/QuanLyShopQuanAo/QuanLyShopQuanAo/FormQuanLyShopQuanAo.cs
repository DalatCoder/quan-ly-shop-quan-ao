using QuanLyShopQuanAo.Commons;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.Models;
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
		BindingSource listQuanAo = new BindingSource();
		QuanTriVien_DTO loginAccount;

		public fQLShopQuanAo(QuanTriVien_DTO loginAccount)
		{
			InitializeComponent();
			this.loginAccount = loginAccount;
		}

		#region Init State

		void fQLShopQuanAo_Load(object sender, EventArgs e)
		{
			this.Text = "Quản lý cửa hàng quần áo - Xin chào " + loginAccount.TenDangNhap + "!";
			lbChu.Text = TienIch.So_chu(int.Parse(lbSo.Text.Replace(".", string.Empty)));

			InitState();
		}

		void InitState()
		{
			dgvQuanAo.DataSource = listQuanAo;
			LoadListQuanAo();
			dgvQuanAo.HideColumns("GhiChu", "ID_HQA", "ID_LQA", "HinhQA", "HinhQAP");
		}

		#endregion

		#region Methods

		void LoadListQuanAo()
		{
			listQuanAo.DataSource = QuanAo_DAO.Instance.Load_QA();
		}

		#endregion

		#region Events

		void tsmAdmin_Click(object sender, EventArgs e)
		{
			frmAdmin f = new frmAdmin();
			f.ShowDialog();
		}

		void tsmDangXuat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			string chuoiTimKiem = txtTimKiem.Text;
			if (string.IsNullOrWhiteSpace(chuoiTimKiem)) return;

			listQuanAo.DataSource = QuanAo_DAO.Instance.Load_QA_Search(chuoiTimKiem);
		}

		void btnXoaBoLoc_Click(object sender, EventArgs e)
		{
			txtTimKiem.Text = "";
		}

		void btnTaiLaiDS_Click(object sender, EventArgs e)
		{
			LoadListQuanAo();
		}

		#endregion
	}
}
