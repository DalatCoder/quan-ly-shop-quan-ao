using QuanLyShopQuanAo.Commons;
using QuanLyShopQuanAo.DAO;
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

		public fQLShopQuanAo()
		{
			InitializeComponent();

			

			LoadListQuanAo();
		}

		void LoadListQuanAo()
		{
			//ID_QA = (int)row["ID_QA"];
			//Ten_QA = row["Ten_QA"].ToString();
			//Size = row["Size"].ToString();
			//GiaBan = (float)Convert.ToDouble(row["GiaBan"]);
			//SoLuong = (int)row["SoLuong"];
			//GhiChu = row["GhiChu"].ToString();
			//ID_HQA = (int)row["ID_HQA"];
			//ID_LQA = (int)row["ID_LQA"];
			////HinhQA = (byte[])row["HinhQA"];
			//HinhQAP = row["HinhQAP"].ToString();
			//Ten_LQA = row["Ten_LQA"].ToString();


			dgvQuanAo.DataSource = QuanAo_DAO.Instance.Load_QA();

			dgvQuanAo.Columns["GhiChu"].Visible = false;
			dgvQuanAo.Columns["ID_HQA"].Visible = false;
			dgvQuanAo.Columns["ID_LQA"].Visible = false;
			dgvQuanAo.Columns["HinhQA"].Visible = false;
			dgvQuanAo.Columns["HinhQAP"].Visible = false;

		}

		private void tsmAdmin_Click(object sender, EventArgs e)
		{
			frmAdmin f = new frmAdmin();
			f.ShowDialog();
		}

		private void tsmDangXuat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void fQLShopQuanAo_Load(object sender, EventArgs e)
		{
			lbChu.Text = TienIch.So_chu(int.Parse(lbSo.Text.Replace(".", string.Empty)));
		}

		
	}
}
