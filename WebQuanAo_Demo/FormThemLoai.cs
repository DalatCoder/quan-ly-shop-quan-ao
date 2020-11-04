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
    public partial class FormThemLoai : DevExpress.XtraEditors.XtraForm
    {
        public FormThemLoai()
        {
            InitializeComponent();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
          

            try
            {
                string erroMessage = "Vui lòng nhập loại sản phẩm mới !!!";
                string data = txtLoaiSanPham.Text;
                int min = 2;
                StringValidator.CheckRequire(data, erroMessage);
                StringValidator.CheckMinLength(data, min, erroMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo không đủ dự kiện $_$");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}