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

		#region Thong ke hoa don

		void InitStateThongKeHoaDon()
		{
			dtgvHD.DataSource = BHList;
			LoadDefaultDatetimePicker();
			LoadListThongKeBanHang();
			dtgvHD.HideColumns("ID_BH", "ID_GD");

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
			List<ChiTietBanHang_DTO> listCTBH = ChiTietBanHang_DAO.Instance.Load_CTBH(ID_BH);

			dtgvChiTietBanHang.DataSource = listCTBH;
			dtgvChiTietBanHang.HideColumns("ID_CTBH");

			txtDiscountBH.Text = Discount.ToString() + " %";

			double tongSoTien = 0;
			foreach (ChiTietBanHang_DTO chiTietBanHang in listCTBH)
				tongSoTien += chiTietBanHang.ThanhTien;

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
			dtgvQuanAo.HideColumns(SanPham.GhiChu, SanPham.ID_LQA);
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
		}

		// Binding HinhQA tương ứng với ID sản phẩm
		void txtIDQA_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtIDQA.Text)) return;

			int ID_QA = Convert.ToInt32(txtIDQA.Text);
			HinhQA_DTO hinhQA = HinhQA_DAO.Instance.Load_HinhSanPham(ID_QA);

			if (hinhQA != null)
			{
				pbHinhQA.Image = hinhQA.ToImage();
				pbHinhQA.Tag = hinhQA;
				pbHinhQA.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			else
			{
				pbHinhQA.Image = null;
				pbHinhQA.Tag = null;
			}
		}

		void btnThemQA_Click(object sender, EventArgs e)
		{
			string ten = txtTenQA.Text;
			string size = txtSizeQA.Text;
			float giaBan = (float)Convert.ToDouble(nmGiaBanQA.Value);
			int soLuong = Convert.ToInt32(nmSoLuongQA.Value);
			string ghiChu = txtGhiChuQA.Text;
			int idLQA = (int)cbLoaiQA.SelectedValue;

			string defaultImagePath = TienIch.GetPathTo("Assests", "image.jpg");
			byte[] hinhQA = TienIch.ConvertImageToByteArray(Image.FromFile(defaultImagePath));
			string hinhQAP = defaultImagePath;

			if (pbHinhQA.Image != null)
			{
				hinhQA = TienIch.ConvertImageToByteArray(pbHinhQA.Image);
				hinhQAP = pbHinhQA.ImageLocation;
			}

			string msg;
			if (QuanAo_DAO.Instance.Insert_QuanAo(ten, size, giaBan, soLuong, ghiChu, idLQA, hinhQA, hinhQAP))
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

			string defaultImagePath = TienIch.GetPathTo("Assests", "image.jpg");
			byte[] hinhQA = TienIch.ConvertImageToByteArray(Image.FromFile(defaultImagePath));
			string hinhQAP = defaultImagePath;

			if (pbHinhQA.Image != null)
			{
				hinhQA = TienIch.ConvertImageToByteArray(pbHinhQA.Image);
				hinhQAP = pbHinhQA.ImageLocation;
			}

			string msg;
			if (QuanAo_DAO.Instance.Update_QuanAo(idQA, ten, size, giaBan, soLuong, ghiChu, idLQA, hinhQA, hinhQAP))
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

		void btnBrowseHinhQA_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			var result = dialog.ShowDialog();
			if (result != DialogResult.OK) return;

			string fileName = dialog.FileName;
			var image = Image.FromFile(fileName);

			pbHinhQA.Image = image;
			pbHinhQA.ImageLocation = fileName;
			pbHinhQA.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void btnTimQA_Click(object sender, EventArgs e)
		{
			string tenQA = txtTimQA.Text;
			

			if (string.IsNullOrWhiteSpace(tenQA))
			{
				if (string.IsNullOrWhiteSpace(txtTimTuGiaQA.Text)||string.IsNullOrWhiteSpace(txtTimDenGiaQA.Text))
				{
					MessageBox.Show("Vui lòng nhập thông tin tìm kiếm");
				}
				else
				{
					float giathap = (float)Convert.ToDouble(txtTimTuGiaQA.Text);
					float giacao = (float)Convert.ToDouble(txtTimDenGiaQA.Text);

					QAList.DataSource = QuanAo_DAO.Instance.Load_QA_By_GiaCa(giathap, giacao);
				}
			}
			else
			{
				if (string.IsNullOrWhiteSpace(txtTimTuGiaQA.Text) || string.IsNullOrWhiteSpace(txtTimDenGiaQA.Text))
				{
					QAList.DataSource = QuanAo_DAO.Instance.Load_QA_Search(tenQA);
				}
				else
				{
					float giathap = (float)Convert.ToDouble(txtTimTuGiaQA.Text);
					float giacao = (float)Convert.ToDouble(txtTimDenGiaQA.Text);

					QAList.DataSource = QuanAo_DAO.Instance.Load_QA_By_TenQA_GiaCa(tenQA, giathap, giacao);
				}

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
			txtLoaiQA_ID.DataBindings.Add(new Binding("Text", dtgvLoaiQuanAo.DataSource, "ID_LQA", true, DataSourceUpdateMode.Never));
			txtLoaiQA_Ten.DataBindings.Add(new Binding("Text", dtgvLoaiQuanAo.DataSource, "Ten_LQA", true, DataSourceUpdateMode.Never));
			
		}

		void btnThemLoaiQA_Click(object sender, EventArgs e)
		{
			string Ten = txtLoaiQA_Ten.Text;



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
			string Ten = txtLoaiQA_Ten.Text;
			int ID_LQA = int.Parse(txtLoaiQA_ID.Text);
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

		private void btnLoaiQA_TimKiem_Click(object sender, EventArgs e)
		{
			string tenLoaiQA = txtLoaiQA_TimKiemTen.Text;

			if (string.IsNullOrWhiteSpace(tenLoaiQA))
			{
				MessageBox.Show("Vui lòng nhập tên loại quần áo");
			}
			else
			{
				LQAList.DataSource = LoaiQA_DAO.Instance.Load_LQA_by_Name(tenLoaiQA);
			}
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
			txtKhachHang_Ten.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
			txtKhachHang_SDT.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "SDT", true, DataSourceUpdateMode.Never));
			txtKhachHang_DiaChi.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
		}

		void txtSoDTKH_TextChanged(object sender, EventArgs e)
		{
			string sdt = txtKhachHang_SDT.Text;
			txtKhachHang_SoLuongHoaDon.Text = BanHang_DAO.Instance.Get_SoLuongBanHang_By_KhachHang(sdt).ToString();
		}

		private void txtKhachHang_TimKiem_TenSDT_TextChanged(object sender, EventArgs e)
		{
			string chuoiTimKiem = txtKhachHang_TimKiem_TenSDT.Text;

			if (string.IsNullOrWhiteSpace(chuoiTimKiem)) return;
			
				KHList.DataSource = KhachHang_DAO.Instance.Search_KH(chuoiTimKiem);
			
		}
		private void btnKhachHang_XoaBoLoc_Click(object sender, EventArgs e)
		{
			txtKhachHang_TimKiem_TenSDT.Text = "";
		}

		private void btnKhachHang_TaiLaiDS_Click(object sender, EventArgs e)
		{
			LoadListKH();
		}


		#endregion

		private void txtLoaiQA_ID_TextChanged(object sender, EventArgs e)
		{
			int soluong = LoaiQA_DAO.Instance.GetSoLuongSanPham(int.Parse(txtLoaiQA_ID.Text));
			txtLoaiQA_SoLuongSP.Text = soluong.ToString();
		}
	}
}
