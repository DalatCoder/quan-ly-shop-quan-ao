using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopQuanAo.Commons;
using QuanLyShopQuanAo.Models;
using QuanLyShopQuanAo.DAO;

namespace QuanLyShopQuanAo
{
	
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		bool Login(string userName, string password)
		{
			return QuanTriVien_DAO.Instance.Login(userName, password);
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var tenDangNhap = txtUserName.Text;
			var matKhau = txtPass.Text;

			try
			{
				StringValidator.CheckRequire(tenDangNhap, "Tên đăng nhập");
				StringValidator.CheckRequire(matKhau, "Mật khẩu");
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			
			if (!Login(tenDangNhap, matKhau))
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông tin không hợp lệ");
				return;
			}

			QuanTriVien_DTO loginAccount = QuanTriVien_DAO.Instance.GetAccountByUserName(tenDangNhap);

			fQLShopQuanAo f = new fQLShopQuanAo(loginAccount);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			string msg = "Bạn có chắc chắn muốn thoát chương trình ?";
			var result = MessageBox.Show(msg, "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result != DialogResult.Yes)
				e.Cancel = true;
		}

		private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			txtPass.UseSystemPasswordChar = !cbShowPass.Checked;
		}
	}
}
