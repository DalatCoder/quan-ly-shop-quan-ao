using QuanLyShopQuanAo.Commons;
using QuanLyShopQuanAo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo
{
	public partial class frmBill : Form
	{
		public frmBill(List<ChiTietBanHang_DTO> listQA,KhachHang_DTO khachHang, double discount)
		{
			InitializeComponent();
			dtgvBill.DataSource = listQA;
			dtgvBill.HideColumns("ID_CTBH", "ID_QA");

			lbBill_TenKH.Text = khachHang.HoTen;
			lbBill_SDTKH.Text = khachHang.SDT;
			lbBill_DiaChiKH.Text = khachHang.DiaChi;
			lbBill_Discount.Text = discount.ToString() + " %";
			double total = listQA.Sum(v => v.ThanhTien);
			lbBill_TongTien.Text = total.ToString("###.###.###");
			lbBill_ThanhToan.Text = (total - (total * discount / 100)).ToString("###.###.###");
		}

		private void btnBill_ThanhToan_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnBill_Thoat_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
