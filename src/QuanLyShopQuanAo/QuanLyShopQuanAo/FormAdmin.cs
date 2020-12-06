using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopQuanAo.Commons;
using QuanLyShopQuanAo.DAO;
using QuanLyShopQuanAo.Models;

namespace QuanLyShopQuanAo
{
	public partial class frmAdmin : Form
	{
		BindingSource QAList = new BindingSource();
		BindingSource LQAList = new BindingSource();
		BindingSource KHList = new BindingSource();
		BindingSource BHList = new BindingSource();

		public frmAdmin()
		{
			InitializeComponent();
			LoadState();
		}

		#region Init State

		void LoadState()
		{
			InitStateThongKeHoaDon();
			InitStateQuanAo();
			InitStateLoaiQuanAo();
			InitStateKhachHang();
		}

		#endregion

		List<QuanAo_DTO> SearchQA(string Ten)
		{
			List<QuanAo_DTO> listQA = QuanAo_DAO.Instance.Load_QA_Search(Ten);
			return listQA;
		}

		List<QuanAo_DTO> SearchQAbyGia(float Giacao, float Giathap)
		{
			List<QuanAo_DTO> listQA = QuanAo_DAO.Instance.Load_QA_By_GiaCa(Giathap, Giacao);
			return listQA;
		}

		private void btnTimQA_Click(object sender, EventArgs e)
		{
			QAList.DataSource = SearchQA(txtTimQA.Text);
			QAList.DataSource = SearchQAbyGia(float.Parse(txtTimTuGiaQA.Text), float.Parse(txtTimDenGiaQA.Text));
		}

		#region Thong ke hoa don

		void InitStateThongKeHoaDon()
		{
			dtgvHD.DataSource = BHList;
			LoadDefaultDatetimePicker();
			LoadListThongKeBanHang();

			if (dtgvHD.Rows.Count > 0)
			{
				dtgvHD.Rows[0].Selected = true;
				dtgvHD_Click(dtgvHD.Rows[0], new EventArgs());
			}
		}

		void LoadDefaultDatetimePicker()
		{
			DateTime today = DateTime.Now;
			dtpBatDau.Value = new DateTime(today.Year, today.Month, 1);
			dtpKetThuc.Value = dtpBatDau.Value.AddMonths(1).AddDays(-1);
		}

		void LoadListThongKeBanHang()
		{
			BHList.DataSource = ThongKeBanHang_DAO.Instance.GetListThongKeBanHangInTime(dtpBatDau.Value, dtpKetThuc.Value);
		}

		void btnTimKiemBH_Click(object sender, EventArgs e)
		{
			dtgvHD.DataSource = ThongKeBanHang_DAO.Instance.GetListThongKeBanHangInTime(dtpBatDau.Value, dtpKetThuc.Value);
		}

		void btnXemBH_Click(object sender, EventArgs e)
		{
			dtgvHD.DataSource = ThongKeBanHang_DAO.Instance.GetListThongKeBanHang();

			if (dtgvHD.Rows.Count > 0)
			{
				dtgvHD.Rows[0].Selected = true;
				dtgvHD_Click(this, new EventArgs());
			}
		}

		void dtgvHD_Click(object sender, EventArgs e)
		{
			if (dtgvHD.SelectedRows.Count == 0) return;

			int ID_BH = Convert.ToInt32(dtgvHD.SelectedRows[0].Cells["ID_BH"].Value);
			double Discount = Convert.ToDouble(dtgvHD.SelectedRows[0].Cells["Discount"].Value);
			dtgvChiTietBanHang.DataSource = ChiTietBanHang_DAO.Instance.Load_CTBH(ID_BH);
			txtDiscountBH.Text = Discount.ToString() + " %";

			double tongSoTien = 0;
			foreach (DataGridViewRow row in dtgvChiTietBanHang.Rows)
			{
				int giaBan = Convert.ToInt32(row.Cells["GiaBan"].Value);
				int soLuong = Convert.ToInt32(row.Cells["SoLuongSanPham"].Value);
				tongSoTien += giaBan * soLuong;
			}

			tongSoTien = (tongSoTien / 100) * Discount;
			txtTongTienBH.Text = tongSoTien.ToString("###.###.###");
		}

		#endregion

		#region Quan ao

		void InitStateQuanAo()
		{
			dtgvQuanAo.DataSource = QAList;
			LoadListQA();
			LoadLoaiQuanAoCombobox();
			dtgvQuanAo.HideColumns(SanPham.GhiChu, SanPham.ID_HQA, SanPham.ID_LQA);
			AddDataBindingQuanAo();
		}

		void LoadListQA()
		{
			QAList.DataSource = QuanAo_DAO.Instance.Load_QA();
		}

		void LoadLoaiQuanAoCombobox()
		{
			cbLoaiQA.DataSource = LoaiQA_DAO.Instance.Load_LQA();
			cbLoaiQA.DisplayMember = "Ten_LQA";
			cbLoaiQA.ValueMember = "ID_LQA";
		}

		void AddDataBindingQuanAo()
		{
			txtIDQA.DataBindings.Add(new Binding("Text", dtgvQuanAo.DataSource, SanPham.ID_QA, true, DataSourceUpdateMode.Never));
			txtTenQA.DataBindings.Add(new Binding("Text", dtgvQuanAo.DataSource, SanPham.Ten_QA, true, DataSourceUpdateMode.Never));
			txtSizeQA.DataBindings.Add(new Binding("Text", dtgvQuanAo.DataSource, SanPham.Size, true, DataSourceUpdateMode.Never));
			txtGhiChuQA.DataBindings.Add(new Binding("Text", dtgvQuanAo.DataSource, SanPham.GhiChu, true, DataSourceUpdateMode.Never));
			nmGiaBanQA.DataBindings.Add(new Binding("Value", dtgvQuanAo.DataSource, SanPham.GiaBan, true, DataSourceUpdateMode.Never));
			nmSoLuongQA.DataBindings.Add(new Binding("Value", dtgvQuanAo.DataSource, SanPham.SoLuong, true, DataSourceUpdateMode.Never));
			cbLoaiQA.DataBindings.Add(new Binding("SelectedValue", dtgvQuanAo.DataSource, SanPham.ID_LQA, true, DataSourceUpdateMode.Never));
			pbHinhQA.DataBindings.Add(new Binding("Tag", dtgvQuanAo.DataSource, SanPham.ID_HQA, true, DataSourceUpdateMode.Never));
		}

		void btnThemQA_Click(object sender, EventArgs e)
		{
			string ten = txtTenQA.Text;
			string size = txtSizeQA.Text;
			float giaBan = (float)Convert.ToDouble(nmGiaBanQA.Value);
			int soLuong = Convert.ToInt32(nmSoLuongQA.Value);
			string ghiChu = txtGhiChuQA.Text;
			int idLQA = (int)cbLoaiQA.SelectedValue;
			Image hinhQA = pbHinhQA.Image;
			Bitmap imageBitmap = new Bitmap(hinhQA);
			string hinhQAP = pbHinhQA.ImageLocation;

			byte[] imageData;
			using (var ms = new MemoryStream())
			{
				imageBitmap.Save(ms, ImageFormat.Jpeg);
				imageData = ms.ToArray();
			}

			string msg;
			if (QuanAo_DAO.Instance.Insert_QuanAo(ten, size, giaBan, soLuong, ghiChu, idLQA, imageData, hinhQAP))
			{
				msg = "Thêm quần áo thành công";
				LoadListQA();
			}
			else
			{
				msg = "Có lỗi khi thêm quần áo";
			}

			MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnSuaQA_Click(object sender, EventArgs e)
		{
			int idQA = Convert.ToInt32(txtIDQA.Text);
			string ten = txtTenQA.Text;
			string size = txtSizeQA.Text;
			float giaBan = (float)Convert.ToDouble(nmGiaBanQA.Value);
			int soLuong = Convert.ToInt32(nmSoLuongQA.Value);
			string ghiChu = txtGhiChuQA.Text;
			int idLQA = (int)cbLoaiQA.SelectedValue;
			int idHQA = (int)pbHinhQA.Tag;
			Image hinhQA = pbHinhQA.Image;
			Bitmap image = new Bitmap(hinhQA);
			string hinhQAP = pbHinhQA.ImageLocation;

			byte[] imageData;
			using (var ms = new MemoryStream())
			{
				image.Save(ms, ImageFormat.Jpeg);
				imageData = ms.ToArray();
			}

			string msg;
			if (QuanAo_DAO.Instance.UpdateQA(idQA, ten, size, giaBan, soLuong, ghiChu, idLQA, idHQA, imageData, hinhQAP))
			{
				msg = "Cập nhật quần áo thành công";
				LoadListQA();
			}
			else
			{
				msg = "Có lỗi xảy ra trong quá trình cập nhật quần áo";
			}

			MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void btnXemQA_Click(object sender, EventArgs e)
		{
			LoadListQA();
		}

		void txtIDQA_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtIDQA.Text)) return;

			int ID_QA = Convert.ToInt32(txtIDQA.Text);
			pbHinhQA.Image = HinhQA_DAO.Instance.Load_HinhSanPham(ID_QA);
		}

		void btnBrowseHinhQA_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			var result = dialog.ShowDialog();
			if (result != DialogResult.OK) return;

			string fileName = dialog.FileName;
			var image = Image.FromFile(fileName);
			var bitmapImage = new Bitmap(image);

			pbHinhQA.Image = image;
			pbHinhQA.ImageLocation = fileName;

			byte[] imageData;
			using (var ms = new MemoryStream())
			{
				bitmapImage.Save(ms, ImageFormat.Jpeg);
				imageData = ms.ToArray();
			}
		}

		#endregion

		#region Loai quan ao

		void InitStateLoaiQuanAo()
		{
			dtgvLoaiQuanAo.DataSource = LQAList;
			LoadListLQA();
			AddDataBindingLoaiQuanAo();
		}

		void LoadListLQA()
		{
			LQAList.DataSource = LoaiQA_DAO.Instance.Load_LQA();
		}

		void AddDataBindingLoaiQuanAo()
		{
			txtIDLoaiQA.DataBindings.Add(new Binding("Text", dtgvLoaiQuanAo.DataSource, "ID_LQA", true, DataSourceUpdateMode.Never));
			txtTenLoaiQA.DataBindings.Add(new Binding("Text", dtgvLoaiQuanAo.DataSource, "Ten_LQA", true, DataSourceUpdateMode.Never));
		}

		void btnThemLoaiQA_Click(object sender, EventArgs e)
		{
			string Ten = txtTenLoaiQA.Text;
			string msg;

			if (LoaiQA_DAO.Instance.Insert_LoaiQuanAo(Ten))
			{
				msg = "Thêm loại quần áo thành công";
				LoadListLQA();
			}
			else
			{
				msg = "Có lỗi khi thêm loại quần áo";
			}

			MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void btnSuaLoaiQA_Click(object sender, EventArgs e)
		{
			string Ten = txtTenLoaiQA.Text;
			int ID_LQA = int.Parse(txtIDLoaiQA.Text);
			string msg;

			if (LoaiQA_DAO.Instance.UpdateLQA(ID_LQA, Ten))
			{
				msg = "Cập nhật loại quần áo thành công";
				LoadListLQA();
			}
			else
			{
				msg = "Có lỗi khi cập nhật loại quần áo";
			}

			MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void btnXemLoaiQA_Click(object sender, EventArgs e)
		{
			LoadListLQA();
		}

		#endregion

		#region Khach Hang

		void InitStateKhachHang()
		{
			dtgvKH.DataSource = KHList;
			LoadListKH();
			AddDataBindingKhachHang();
			dtgvKH.HideColumns("ID_KH");
		}

		void LoadListKH()
		{
			KHList.DataSource = KhachHang_DAO.Instance.Load_KH();
		}

		void AddDataBindingKhachHang()
		{
			txtTenKH.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
			txtSoDTKH.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "SDT", true, DataSourceUpdateMode.Never));
			txtDiaChiKH.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
		}

		void txtSoDTKH_TextChanged(object sender, EventArgs e)
		{
			string sdt = txtSoDTKH.Text;
			txtSoLuongHoaDonKH.Text = BanHang_DAO.Instance.Get_SoLuongBanHang_By_KhachHang(sdt).ToString();
		}

		#endregion
	}
}
