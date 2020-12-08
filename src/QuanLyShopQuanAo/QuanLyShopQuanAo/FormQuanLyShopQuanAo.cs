using QuanLyShopQuanAo.Commons;
using QuanLyShopQuanAo.DAO;
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
	public partial class fQLShopQuanAo : Form
	{
		BindingSource listQuanAo = new BindingSource();
		BindingSource listCTBH = new BindingSource();
		QuanTriVien_DTO loginAccount;
		private int ID_BH;
		List<ChiTietBanHang_DTO> listCTBHTamThoi = new List<ChiTietBanHang_DTO>();


		public fQLShopQuanAo(QuanTriVien_DTO loginAccount)
		{
			InitializeComponent();
			this.loginAccount = loginAccount;
		}

		#region Init State

		void fQLShopQuanAo_Load(object sender, EventArgs e)
		{
			this.Text = "Quản lý cửa hàng quần áo - Xin chào " + loginAccount.TenDangNhap + "!";

			lblTongTien.Text = "0";
			lblTongTienCuoiCung.Text = "0";
			lblTongTienGhiBangChu.Text = TienIch.So_chu(int.Parse(lblTongTienCuoiCung.Text.Replace(".", string.Empty)));

			InitState();
		}

		void InitState()
		{
			dgvQuanAo.DataSource = listQuanAo;
			LoadListQuanAo();
			dgvQuanAo.HideColumns(SanPham.GhiChu, SanPham.ID_LQA);
		}

		#endregion

		#region Methods

		void LoadListQuanAo()
		{
			listQuanAo.DataSource = QuanAo_DAO.Instance.Load_QA();
		}

		#endregion

		#region Events

		void tsmAdmin_Click(object sender, EventArgs e)
		{
			frmAdmin f = new frmAdmin();
			f.ShowDialog();
		}

		void tsmDangXuat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			string chuoiTimKiem = txtTimKiem.Text;
			if (string.IsNullOrWhiteSpace(chuoiTimKiem)) return;

			listQuanAo.DataSource = QuanAo_DAO.Instance.Load_QA_Search(chuoiTimKiem);
		}

		void btnXoaBoLoc_Click(object sender, EventArgs e)
		{
			txtTimKiem.Text = "";
		}

		void btnTaiLaiDS_Click(object sender, EventArgs e)
		{
			LoadListQuanAo();
		}

		private void dgvQuanAo_Click(object sender, EventArgs e)
		{
			if (dgvQuanAo.SelectedRows.Count == 0) return;

			int soLuongToiDa = Convert.ToInt32(dgvQuanAo.SelectedRows[0].Cells[SanPham.SoLuong].Value);
			nmSoLuong.Maximum = soLuongToiDa;
		}

		#endregion

		//List<ChiTietBanHang_DTO> GetChiTietHoaDonFromDataGridView(DataGridView lv)
		//{
		//	List<ChiTietBanHang_DTO> listQA = new List<ChiTietBanHang_DTO>();
		//	foreach (ListViewItem item in lv.Items)
		//	{
		//		string tenQA = item.SubItems[1].Text;
		//		float giaBan = float.Parse( item.SubItems[2].Text);
		//		int soLuong = int.Parse(item.SubItems[3].Text);

		//		ChiTietBanHang_DTO chiTietBanHang_DTO = new ChiTietBanHang_DTO(tenQA, giaBan, soLuong);
		//		listQA.Add(chiTietBanHang_DTO);
		//	}

		//	return listQA;
		//}

		KhachHang_DTO LayThongTinKhachHang()
		{

			string tenKH = txtHoTen.Text;
			string diaChi = txtDiaChi.Text;
			string soDT = txtSDT.Text;

			KhachHang_DTO khachHang = new KhachHang_DTO(tenKH, soDT, diaChi);
			return khachHang;
		}

		void LuuBanHang()
		{
			string TenKH = txtHoTen.Text;
			string DiaChi = txtDiaChi.Text;
			string SDT = txtSDT.Text;
			float discount = (float)Convert.ToDouble(nmGiamGia.Value);

			string msg;

			ID_BH = BanHang_DAO.Instance.Insert_BanHang((DateTime.Now).ToString("ddMMyyyyhhmmss"), discount, TenKH, SDT, DiaChi);

			if (ID_BH != -1)
			{
				msg = "Thanh toán thành công";
				// dvgCTBH.DataSource = null;
			}
			else
			{
				msg = "Có lỗi khi thanh toán";
			}

			MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void LuuChiTietBanHang()
		{

			foreach (ChiTietBanHang_DTO chiTietBanHang in listCTBHTamThoi)
			{
				int MaQA = QuanAo_DAO.Instance.Load_QA_by_Name(chiTietBanHang.Ten_QA).ID_QA;
				int SLBan = chiTietBanHang.SoLuongSanPham;
				if (!ChiTietBanHang_DAO.Instance.Insert_ChiTietBanHang(MaQA, ID_BH, SLBan)) 
				{
					MessageBox.Show("Loi");
					return;
				}
			}
		}


		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			frmBill frmBill = new frmBill(listCTBHTamThoi, LayThongTinKhachHang());
			var kq = frmBill.ShowDialog();
			if (kq == DialogResult.OK)
			{
				LuuBanHang();
				LuuChiTietBanHang();
				// thanh toan
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (dgvQuanAo.SelectedRows.Count == 0)
				return;

			ChiTietBanHang_DTO ctbh = new ChiTietBanHang_DTO();
			ctbh.Ten_QA = dgvQuanAo.SelectedRows[0].Cells[SanPham.Ten_QA].Value.ToString();
			ctbh.GiaBan = (float)Convert.ToDouble(dgvQuanAo.SelectedRows[0].Cells[SanPham.GiaBan].Value);
			ctbh.SoLuongSanPham = (int)nmSoLuong.Value;


			int index = listCTBHTamThoi.FindIndex(v => v.Ten_QA.Equals(ctbh.Ten_QA));
			if (index != -1)
			{
				int SLMoi = listCTBHTamThoi[index].SoLuongSanPham + ctbh.SoLuongSanPham;
				if (SLMoi > 0)
					listCTBHTamThoi[index].SoLuongSanPham += ctbh.SoLuongSanPham;
				else
					listCTBHTamThoi.RemoveAt(index);
			}
			else
			{
				listCTBHTamThoi.Add(ctbh);
			}

			nmSoLuong.Value = 1;

			dvgCTBH.DataSource = null;
			dvgCTBH.DataSource = listCTBHTamThoi;
		}

	}
}
