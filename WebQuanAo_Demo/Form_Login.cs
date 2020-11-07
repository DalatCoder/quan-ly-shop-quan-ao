using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WebQuanAo_Demo
{
    public partial class Form_Login : DevExpress.XtraEditors.XtraForm
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                var tenDangNhap = txtTenDangNhap.Text;
                var matKhau = txtMatKhau.Text;

                StringValidator.CheckRequire(tenDangNhap, "Tên đăng nhập");
                StringValidator.CheckRequire(matKhau, "Mật khẩu");

                string taikhoan = "thiha123";
                string password = "123";

                if(tenDangNhap!=taikhoan||matKhau!=password)
				{
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    return;
				}

                this.Hide();
                Form_HomePage form1 = new Form_HomePage();
                form1.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo chưa đủ dữ kiện ಥ_ಥ");
            }
        }
    }
}