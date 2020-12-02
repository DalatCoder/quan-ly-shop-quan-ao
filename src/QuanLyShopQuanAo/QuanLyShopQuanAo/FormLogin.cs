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
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
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
