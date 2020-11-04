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
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo chưa đủ dữ kiện ಥ_ಥ");
            }
        }
    }
}