using QuanLyShopQuanAo.Commons;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyShopQuanAo
{
	public partial class fQLShopQuanAo : Form
	{
		private int ID_BH;
		QuanTriVien_DTO loginAccount;
		List<ChiTietBanHang_DTO> listCTBHTamThoi = new List<ChiTietBanHang_DTO>();
		public double TongTienHoaDonHienTai => listCTBHTamThoi.Sum(v => v.ThanhTien);
		public double DiscountHienTai => Convert.ToDouble(nmGiamGia.Value);
		public double TongTienThanhToanCuoiCung => TongTienHoaDonHienTai - (TongTienHoaDonHienTai * DiscountHienTai / 100);

		public fQLShopQuanAo(QuanTriVien_DTO loginAccount)
		{
			InitializeComponent();
			this.loginAccount = loginAccount;

			if (loginAccount.Ten_KTK == "Quản trị viên")
			{
				tsmAdmin.Enabled = true;
			}
			else
			{
				tsmAdmin.Enabled = false;
			}

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
			LoadListQuanAo();
			dgvQuanAo.HideColumns(SanPham.GhiChu, SanPham.ID_LQA);
		}

		#endregion

		#region Methods

		void LoadListQuanAo()
		{
			dgvQuanAo.DataSource = null;
			dgvQuanAo.DataSource = QuanAo_DAO.Instance.Load_QA();
		}

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
			string ID_GD = (DateTime.Now).ToString("ddMMyyyyhhmmss");

			ID_BH = BanHang_DAO.Instance.Insert_BanHang(ID_GD, discount, TenKH, SDT, DiaChi);

			string msg;
			if (ID_BH != -1)
			{
				msg = "Thanh toán thành công";
				dgvCTBH.DataSource = null;
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
				int MaQA = chiTietBanHang.ID_QA;
				int SLBan = chiTietBanHang.SoLuongSanPham;

				if (!ChiTietBanHang_DAO.Instance.Insert_ChiTietBanHang(MaQA, ID_BH, SLBan))
				{
					string msg = "Có lỗi trong quá trình thêm tạo đơn hàng";
					MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}
		}

		#endregion

		#region Events

		void tsmAdmin_Click(object sender, EventArgs e)
		{
			if (listCTBHTamThoi.Count > 0)
			{
				string msg = "Vui lòng hoàn thành đơn hàng hiện tại";
				MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			frmAdmin f = new frmAdmin();
			f.ShowDialog();

			// Tải lại danh sách quần áo - Nếu như người dùng chỉnh sửa trong trang quản lý
			LoadListQuanAo();
			dgvQuanAo.HideColumns(SanPham.GhiChu, SanPham.ID_LQA);
		}

		void tsmDangXuat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			string chuoiTimKiem = txtTimKiem.Text;
			if (string.IsNullOrWhiteSpace(chuoiTimKiem)) return;

			dgvQuanAo.DataSource = QuanAo_DAO.Instance.Load_QA_Search(chuoiTimKiem);
		}

		void btnXoaBoLoc_Click(object sender, EventArgs e)
		{
			txtTimKiem.Text = "";
		}

		void btnTaiLaiDS_Click(object sender, EventArgs e)
		{
			LoadListQuanAo();
		}

		// Đặt số lượng tối đa cho numericUpDown - Không cho người dùng chọn quá số lượng sản phẩm hiện có
		private void dgvQuanAo_Click(object sender, EventArgs e)
		{
			if (dgvQuanAo.SelectedRows.Count == 0) return;

			int soLuongToiDa = Convert.ToInt32(dgvQuanAo.SelectedRows[0].Cells[SanPham.SoLuong].Value);
			nmSoLuong.Maximum = soLuongToiDa;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (dgvQuanAo.SelectedRows.Count == 0)
				return;

			ChiTietBanHang_DTO chiTietBanHang = new ChiTietBanHang_DTO();
			chiTietBanHang.ID_QA = Convert.ToInt32(dgvQuanAo.SelectedRows[0].Cells[SanPham.ID_QA].Value);
			chiTietBanHang.Ten_QA = dgvQuanAo.SelectedRows[0].Cells[SanPham.Ten_QA].Value.ToString();
			chiTietBanHang.GiaBan = (float)Convert.ToDouble(dgvQuanAo.SelectedRows[0].Cells[SanPham.GiaBan].Value);
			chiTietBanHang.SoLuongSanPham = (int)nmSoLuong.Value;

			int index = listCTBHTamThoi.FindIndex(v => v.ID_QA == chiTietBanHang.ID_QA);
			if (index == -1)
			{
				if (chiTietBanHang.SoLuongSanPham > 0)
					listCTBHTamThoi.Add(chiTietBanHang);
			}
			else
			{
				int SLMoi = listCTBHTamThoi[index].SoLuongSanPham + chiTietBanHang.SoLuongSanPham;
				if (SLMoi > 0)
					listCTBHTamThoi[index].SoLuongSanPham += chiTietBanHang.SoLuongSanPham;
				else
					listCTBHTamThoi.RemoveAt(index);
			}

			int SLHienCo = Convert.ToInt32(dgvQuanAo.SelectedRows[0].Cells[SanPham.SoLuong].Value);
			dgvQuanAo.SelectedRows[0].Cells[SanPham.SoLuong].Value = SLHienCo - chiTietBanHang.SoLuongSanPham;
			nmSoLuong.Value = 1;

			nmSoLuong.Maximum = SLHienCo - chiTietBanHang.SoLuongSanPham;

			dgvCTBH.DataSource = null;
			dgvCTBH.DataSource = listCTBHTamThoi;
			dgvCTBH.HideColumns("ID_CTBH", "ID_QA");

			lblTongTien.Text = TongTienHoaDonHienTai.ToString();
		}

		private void btnThanhToan_Click(object sender, EventArgs e)
		{

			if (listCTBHTamThoi.Count == 0)
			{
				MessageBox.Show("Vui lòng thêm quần áo cần mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}


			KhachHang_DTO khachHang = LayThongTinKhachHang();

			InputValidator inputValidator = new InputValidator();
			inputValidator.SetTitle("Tên khách hàng")
				.SetInputString(khachHang.HoTen)
				.SanitizeInput()
				.Require()
				.MustBeValidString();

			khachHang.HoTen = khachHang.HoTen.Sanitize();

			inputValidator.SetTitle("SĐT khách hàng")
				.SetInputString(khachHang.SDT)
				.SanitizeInput()
				.Require()
				.MustBeValidString()
				.IsNumber();



			khachHang.SDT = khachHang.SDT.Sanitize();

			if (inputValidator.HasError)
			{
				MessageBox.Show(inputValidator.GetErrorMessage());
				return;
			}

			frmBill frmBill = new frmBill(listCTBHTamThoi, khachHang, DiscountHienTai);
			var result = frmBill.ShowDialog();

			if (result == DialogResult.OK)
			{
				LuuBanHang();
				LuuChiTietBanHang();
				listCTBHTamThoi.Clear();
			}
		}

		private void lblTongTien_TextChanged(object sender, EventArgs e)
		{
			lblTongTienCuoiCung.Text = TongTienThanhToanCuoiCung.ToString();
			lblTongTienGhiBangChu.Text = TienIch.So_chu(TongTienThanhToanCuoiCung);
		}

		private void nmGiamGia_ValueChanged(object sender, EventArgs e)
		{
			lblTongTienCuoiCung.Text = TongTienThanhToanCuoiCung.ToString();
			lblTongTienGhiBangChu.Text = TienIch.So_chu(TongTienThanhToanCuoiCung);
		}

		private void tsmThemQA_Click(object sender, EventArgs e)
		{
			nmSoLuong.Value = 1;
			btnThem.PerformClick();
		}

		private void tsmXoaBoLoc_Click(object sender, EventArgs e)
		{
			btnXoaBoLoc.PerformClick();
		}

		private void tsmTaiLaiDS_Click(object sender, EventArgs e)
		{
			btnTaiLaiDS.PerformClick();
		}

		private void tsmThanhToan_Click(object sender, EventArgs e)
		{
			btnThanhToan.PerformClick();
		}

		private void tsmHuyDon_Click(object sender, EventArgs e)
		{
			btnHuyDon.PerformClick();
		}

		private void btnHuyDon_Click(object sender, EventArgs e)
		{
			listCTBHTamThoi.Clear();
			dgvCTBH.DataSource = null;
		}

		private void dgvQuanAo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			nmSoLuong.Value = 1;
			btnThem.PerformClick();
		}

		private void txtSDT_TextChanged(object sender, EventArgs e)
		{
			string sdt = txtSDT.Text;
			if (string.IsNullOrWhiteSpace(sdt))
			{
				txtHoTen.Text = "";
				txtDiaChi.Text = "";
				return;
			}
			List<KhachHang_DTO> dsKhachHang = KhachHang_DAO.Instance.TimKiemTheoSDT(sdt);
			if (dsKhachHang.Count == 0)
			{
				txtHoTen.Text = "";
				txtDiaChi.Text = "";
			}
			else
			{
				txtHoTen.Text = dsKhachHang[0].HoTen;
				txtDiaChi.Text = dsKhachHang[0].DiaChi;
			}
		}

		#endregion
	}
}
