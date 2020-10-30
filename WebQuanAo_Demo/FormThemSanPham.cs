using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebQuanAo_Demo
{
	public partial class FormThemSanPham : Form
	{
		public FormThemSanPham()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			FormThemLoai formThemLoai = new FormThemLoai();
			formThemLoai.ShowDialog();
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
			if (errorMessage.Length > 0)
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
	}
}
