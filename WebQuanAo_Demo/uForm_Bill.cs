using System;
using System.Windows.Forms;

namespace WebQuanAo_Demo
{
	public partial class uForm_Bill : DevExpress.XtraEditors.XtraUserControl
    {
        private static uForm_Bill _instance;

        public static uForm_Bill Instance
		{
			get
			{
                if (_instance == null)
                    _instance = new uForm_Bill();
                return _instance;
			}
		}

        public uForm_Bill()
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

		private void btnTimKiemQA_Click(object sender, EventArgs e)
		{
            FormChonSanPham formChonSanPham = new FormChonSanPham();
            formChonSanPham.ShowDialog();
		}
	}
}