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
    public partial class FormThemLoai : DevExpress.XtraEditors.XtraUserControl
    {
        public FormThemLoai()
        {
            InitializeComponent();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
          

            try
            {
                string loaiSanPham = txtLoaiSanPham.Text;
                int min = 2;
                StringValidator.CheckRequire(loaiSanPham,"Tên loại sản phẩm mới");
                StringValidator.CheckMinLength(loaiSanPham, min,"Tên loại sản phẩm mới");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo không đủ dữ kiện $_$");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}