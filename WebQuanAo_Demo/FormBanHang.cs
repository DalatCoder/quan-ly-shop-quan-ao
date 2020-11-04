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
    public partial class FormBanHang : DevExpress.XtraEditors.XtraUserControl
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                var maGiaoDich = txtMaGiaoDich.Text;
                var hoTenKH = txtTenKhachHang.Text;
                var soDienThoai = txtSoDT.Text;

                StringValidator.CheckRequire(maGiaoDich, "Mã giao dịch");
                StringValidator.CheckRequire(hoTenKH, "Họ tên khách hàng");
                StringValidator.CheckRequire(soDienThoai, "Số điện thoại");
                StringValidator.TextIsStringNumber(soDienThoai, "Số điện thoại");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Thông báo không đủ dữ kiện");
            }
        }

       
    }
}