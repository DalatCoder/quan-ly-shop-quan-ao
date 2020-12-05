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
			StringValidator.CheckRequire(tenDangNhap, "Tên đăng nhập");
			StringValidator.CheckRequire(matKhau, "Mật khẩu");
			string UserName = txtUserName.Text;
			string Pass = txtPass.Text;
			if (!Login(UserName, Pass))
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông tin không hợp lệ");
				return;
			}
			fQLShopQuanAo f = new fQLShopQuanAo();
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
