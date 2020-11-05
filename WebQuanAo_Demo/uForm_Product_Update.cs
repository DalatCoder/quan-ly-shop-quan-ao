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
    public partial class uForm_Product_Update : DevExpress.XtraEditors.XtraUserControl
    {
        private static uForm_Product_Update _instance;

        public static uForm_Product_Update Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uForm_Product_Update();
                return _instance;
            }
        }

        public uForm_Product_Update()
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
                var tenSanPham = txtTenSP.Text;
                var giaBan = txtGiaBan.Text;
                var discount = txtDiscount.Text;
                var nhomSanPham = cbNhomSanPham.Text;

                StringValidator.CheckRequire(tenSanPham, "Tên sản phẩm");
                StringValidator.CheckRequire(giaBan, "Giá bán sản phẩm");
                StringValidator.CheckRequire(discount, "Discount sản phẩm");
                StringValidator.CheckRequire(nhomSanPham, "Nhóm sản phẩm");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo không đủ dữ kiện");
            }
        }

        
    }
}