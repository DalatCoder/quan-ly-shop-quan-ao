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
            string errorMessage = "Vui lòng nhập:\n";
            if (txtTenDangNhap.Text == "")
                errorMessage += "- Tên đăng nhập !!!\n";
            if (txtMatKhau.Text == "")
                errorMessage += "- Mật khẩu !!!\n";

            if(errorMessage.Length>0)
            {
                MessageBox.Show(errorMessage, "Thông báo chưa đủ dự kiện ^_^");
            }    
        }
    }
}