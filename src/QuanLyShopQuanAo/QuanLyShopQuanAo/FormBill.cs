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
		public frmBill(List<ChiTietBanHang_DTO> listQA,KhachHang_DTO khachHang)
		{
			InitializeComponent();
			dtgvBill.DataSource = listQA;
			dtgvBill.HideColumns("ID_CTBH");

			lbBill_TenKH.Text = khachHang.HoTen;
			lbBill_SDTKH.Text = khachHang.SDT;
			lbBill_DiaChiKH.Text = khachHang.DiaChi;
		}

		
	}
}
