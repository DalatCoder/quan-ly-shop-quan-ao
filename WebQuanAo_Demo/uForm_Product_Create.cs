using System;
using System.Windows.Forms;

namespace WebQuanAo_Demo
{
	public partial class uForm_Product_Create : DevExpress.XtraEditors.XtraUserControl
	{
		private static uForm_Product_Create _instance;

		public static uForm_Product_Create Instance
		{
			get
			{
				if (_instance == null)
					_instance = new uForm_Product_Create();
				return _instance;
			}
		}

		public uForm_Product_Create()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			uForm_Category_Create formThemLoai = new uForm_Category_Create();
			// formThemLoai.ShowDialog();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			

            try
            {
				var tenSP = txtTenSP.Text;
				var kichThuoc = cbxSize.Text;
				var giaBan = txtGiaBan.Text;
				var soLuong = txtSoluong.Text;
				var discount = txtDiscount.Text;
				var loaiSP = cbxLoaiSP.Text;

				StringValidator.CheckRequire(tenSP, "Tên sản phẩm");
				StringValidator.CheckRequire(kichThuoc, "Kích thước sản phẩm");
				StringValidator.CheckRequire(giaBan, "Giá bán sản phẩm");
				StringValidator.CheckRequire(soLuong, "Số lượng sản phẩm");
				StringValidator.CheckRequire(discount, "Discount sản phẩm");

				StringValidator.TextIsStringNumber(soLuong, "Số lượng sản phẩm");
				StringValidator.TextIsStringNumber(discount, "Discount sản phẩm");

            }
            catch (Exception ex)
            {
				MessageBox.Show(ex.Message, "Thông báo không đúng thông tin ^_^");
            }
            


			

			// Nếu không lỗi thì thực thi các dòng dưới này
			// 1. Lấy thông tin 

			// 2. Gán vào đối tượng tương ứng

			// 3. Lưu trữ

			// 4. Hiển thị
		}

		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			txtTenSP.Text = "";
			cbxSize.Text = "";
			txtGiaBan.Text = "";
			txtSoluong.Text = "";
			txtDiscount.Text = "";
			cbxLoaiSP.Text = "";
			pbHinhSP.ImageLocation = "";
			txtMoTa.Text = "";
		}

		private void btnThemLoai_Click(object sender, EventArgs e)
		{
			Form_Category_Create form = new Form_Category_Create();
			form.ShowDialog();
		}
	}
}
