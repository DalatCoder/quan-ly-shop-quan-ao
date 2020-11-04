using System;
using System.Windows.Forms;

namespace WebQuanAo_Demo
{
	public partial class FormThemSanPham : UserControl
	{
		public FormThemSanPham()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			FormThemLoai formThemLoai = new FormThemLoai();
			// formThemLoai.ShowDialog();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			string errorMessage = "Vui lòng nhập: \n";
			if (txtTenSP.Text == "")
				errorMessage += "- Tên sản phẩm !!! \n";
		    if (txtSize.Text == "")
				errorMessage += "- Kích thước !!! \n";
		    if (txtGiaBan.Text == "")
				errorMessage += "- Giá bán !!! \n";
			if (txtSoluong.Text == "")
				errorMessage += "- Số lượng !!! \n";
		    if (txtDiscount.Text == "")
				errorMessage += "- Discount !!! \n";
			if (cbxLoaiSP.Text == "")
				errorMessage += "- Loại sản phẩm !!!\n";
            


			// Nếu có lỗi, in ra và thoát hàm
			if (errorMessage!= "Vui lòng nhập: \n")
			{
				MessageBox.Show(errorMessage, "Thông báo chưa đủ thông tin @_@");
				return;
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
			txtSize.Text = "";
			txtGiaBan.Text = "";
			txtSoluong.Text = "";
			txtDiscount.Text = "";
			cbxLoaiSP.Text = "";
			pictureBox1.ImageLocation = "";
			txtMoTa.Text = "";
		}

        private void btnExit_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }
    }
}
