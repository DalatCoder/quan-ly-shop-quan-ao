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
    public partial class FormCapNhatNhomSP : DevExpress.XtraEditors.XtraUserControl
    {
        public FormCapNhatNhomSP()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChinhSuaSP_Click(object sender, EventArgs e)
        {
            try
            {
                var loaiQuanAo = cboNhomSanPham.Text;
                var tenNhom = txtTenNhom.Text;

                StringValidator.CheckRequire(loaiQuanAo, "Nhóm loại quần áo");
                StringValidator.CheckRequire(tenNhom, "Tên nhóm quần áo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo không đủ dữ kiện (•_•)");
            }
        }
    }
}