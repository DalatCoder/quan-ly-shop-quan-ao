using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
		BindingSource CTBHList = new BindingSource();

		public frmAdmin()
		{
			InitializeComponent();
			LoadState();
		}

		#region Init State
		void LoadState()
		{
			LoadDefaultDatetimePicker();
			
			dtgvQA.DataSource = QAList;
			dtgvLoaiQA.DataSource = LQAList;
			dtgvHD.DataSource = BHList;

			LoadListQA();
			LoadListLQA();
			LoadListThongKeBanHang();
			//LoadListBH();
			//LoadCTBH();

			if (dtgvHD.Rows.Count > 0)
			{
				dtgvHD.Rows[0].Selected = true;
				dtgvHD_Click(this, new EventArgs());
			}

			InitStateKhachHang();
		}

		void LoadDefaultDatetimePicker()
		{
			DateTime today = DateTime.Now;
			dtpBatDau.Value = new DateTime(today.Year, today.Month, 1);
			dtpKetThuc.Value = dtpBatDau.Value.AddMonths(1).AddDays(-1);
		}

		#endregion

		

		void LoadListQA()
		{
			QAList.DataSource = QuanAo_DAO.Instance.Load_QA();
		}

		void LoadListLQA()
		{
			LQAList.DataSource = LoaiQA_DAO.Instance.Load_LQA();
		}

		

		void LoadListThongKeBanHang()
		{
			BHList.DataSource = ThongKeBanHang_DAO.Instance.GetListThongKeBanHangInTime(dtpBatDau.Value, dtpKetThuc.Value);
		}

		void LoadListBH()
		{
			BHList.DataSource = BanHang_DAO.Instance.Load_BH();
		}

		void LoadCTBH()
		{
			int BH_ID = int.Parse(dtgvHD.Rows[0].Cells.ToString());
			CTBHList.DataSource = ChiTietBanHang_DAO.Instance.Load_CTBH(BH_ID);
		}

		void LoadCategoryIntoCombobox(ComboBox cb)
		{
			cb.DataSource = LoaiQA_DAO.Instance.Load_LQA();
			cb.DisplayMember = "Ten_LQA ";
			cb.ValueMember = "ID_LQA ";
		}

		List<QuanAo_DTO> SearchQA(string Ten)
		{
			List<QuanAo_DTO> listQA = QuanAo_DAO.Instance.Load_QA_Search(Ten);
			return listQA;
		}

		List<QuanAo_DTO> SearchQAbyGia(float Giacao,float Giathap)
		{
			List<QuanAo_DTO> listQA = QuanAo_DAO.Instance.Load_QA_By_GiaCa(Giathap, Giacao);
			return listQA;
		}

		private void btnThemQA_Click(object sender, EventArgs e)
		{
			string Ten = txtTenQA.Text;
			string Size = txtSizeQA.Text;
			int SoLuong = (int)nmSoLuongQA.Value;
			int LoaiQA = (int)cbLoaiQA.SelectedValue;
			float GiaBan = float.Parse(nmGiaBanQA.Text);
			string GhiChu = txtGhiChuQA.Text;

			//if (QuanAo_DAO.Instance.Insert_QuanAo(Ten, Size,GiaBan,SoLuong,GhiChu,LoaiQA,hinhQA,hinhQAP))
			//{
			//	MessageBox.Show("Thêm quần áo thành công");
			//	LoadListQA();
			//}
			//else
			//{
			//	MessageBox.Show("Có lỗi khi thêm quần áo");
			//}
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}


		private void btnSuaQA_Click(object sender, EventArgs e)
		{
			string Ten = txtTenQA.Text;
			string Size = txtSizeQA.Text;
			int LoaiQA = (int)cbLoaiQA.SelectedValue;
			int Soluong = (int)nmSoLuongQA.Value;
			float GiaBan = float.Parse(nmGiaBanQA.Text);
			string GhiChu = txtGhiChuQA.Text;
			int QA_ID = int.Parse(txtIDQA.Text);
			//if (QuanAo_DAO.Instance.UpdateQA(QA_ID, Ten, Size,GiaBan,Soluong,GhiChu, LoaiQA, hinhQA, hinhQAP))
			//{
			//	MessageBox.Show("Cập nhật loại quần áo thành công");
			//	LoadListQA();
			//}
			//else
			//{
			//	MessageBox.Show("Có lỗi khi cập nhật món");
			//}
		}

		private void btnXemQA_Click(object sender, EventArgs e)
		{
			LoadListQA();
		}

		private void btnTimQA_Click(object sender, EventArgs e)
		{
			QAList.DataSource = SearchQA(txtTimQA.Text);
			QAList.DataSource = SearchQAbyGia(float.Parse(txtTimTuGiaQA.Text), float.Parse(txtTimDenGiaQA.Text));
		}

		private void btnThemLoaiQA_Click(object sender, EventArgs e)
		{
			string Ten = txtTenLoaiQA.Text;

			if (LoaiQA_DAO.Instance.Insert_LoaiQuanAo(Ten))
			{
				MessageBox.Show("Thêm loại quần áo thành công");
				LoadListQA();
			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm loại quần áo");
			}
		}


		private void btnSuaLoaiQA_Click(object sender, EventArgs e)
		{
			string Ten = txtTenLoaiQA.Text;
			int QA_ID = int.Parse(txtIDLoaiQA.Text);
			if (LoaiQA_DAO.Instance.UpdateLQA(QA_ID, Ten))
			{
				MessageBox.Show("Cập nhật loại quần áo thành công");
				LoadListQA();
			}
			else
			{
				MessageBox.Show("Có lỗi khi cập nhật loại quần áo");
			}
		}

		private void btnXemLoaiQA_Click(object sender, EventArgs e)
		{
			LoadListLQA();
		}

		



		#region Thong ke hoa don

		private void btnTimKiemBH_Click(object sender, EventArgs e)
		{
			dtgvHD.DataSource = ThongKeBanHang_DAO.Instance.GetListThongKeBanHangInTime(dtpBatDau.Value, dtpKetThuc.Value);
		}

		private void btnXemBH_Click(object sender, EventArgs e)
		{
			dtgvHD.DataSource = ThongKeBanHang_DAO.Instance.GetListThongKeBanHang();

			if (dtgvHD.Rows.Count > 0)
			{
				dtgvHD.Rows[0].Selected = true;
				dtgvHD_Click(this, new EventArgs());
			}
		}

		private void dtgvHD_Click(object sender, EventArgs e)
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
			txtTenKH.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "HoTen"));
			txtSoDTKH.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "SDT"));
			txtDiaChiKH.DataBindings.Add(new Binding("Text", dtgvKH.DataSource, "DiaChi"));
		}

		void btnXemKH_Click(object sender, EventArgs e)
		{
			LoadListKH();
		}

		void txtSoDTKH_TextChanged(object sender, EventArgs e)
		{
			string sdt = txtSoDTKH.Text;
			txtSoLuongHoaDonKH.Text = BanHang_DAO.Instance.Get_SoLuongBanHang_By_KhachHang(sdt).ToString();
		}

		#endregion

	}
}
