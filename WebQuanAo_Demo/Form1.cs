using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WebQuanAo_Demo
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void accordionControlElement1_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(FormBanHang.Instance))
			{
                container.Controls.Add(FormBanHang.Instance);
                FormBanHang.Instance.Dock = DockStyle.Fill;
                FormBanHang.Instance.Anchor = AnchorStyles.None;
			}
            FormBanHang.Instance.BringToFront();    
		}

		private void menuThemSP_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(FormThemSP.Instance))
            {
                container.Controls.Add(FormThemSP.Instance);
                FormThemSP.Instance.Dock = DockStyle.Fill;
                FormThemSP.Instance.Anchor = AnchorStyles.None;
            }
            FormThemSP.Instance.BringToFront();
        }

		private void menuChinhSuaSP_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(FormChinhSuaSP.Instance))
            {
                container.Controls.Add(FormChinhSuaSP.Instance);
                FormChinhSuaSP.Instance.Dock = DockStyle.Fill;
                FormChinhSuaSP.Instance.Anchor = AnchorStyles.None;
            }
            FormChinhSuaSP.Instance.BringToFront();
        }

		private void menuCapNhatNhomSanPham_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(FormCapNhatNhomSP.Instance))
            {
                container.Controls.Add(FormCapNhatNhomSP.Instance);
                FormCapNhatNhomSP.Instance.Dock = DockStyle.Fill;
                FormCapNhatNhomSP.Instance.Anchor = AnchorStyles.None;
            }
            FormCapNhatNhomSP.Instance.BringToFront();
        }

		private void menuThemLoaiSP_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(FormThemLoai.Instance))
            {
                container.Controls.Add(FormThemLoai.Instance);
                FormThemLoai.Instance.Dock = DockStyle.Fill;
                FormThemLoai.Instance.Anchor = AnchorStyles.None;
            }
            FormThemLoai.Instance.BringToFront();
        }

		private void menuXemSP_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(FormToanBoSanPham.Instance))
            {
                container.Controls.Add(FormToanBoSanPham.Instance);
                FormToanBoSanPham.Instance.Dock = DockStyle.Fill;
                FormToanBoSanPham.Instance.Anchor = AnchorStyles.None;
            }
            FormToanBoSanPham.Instance.BringToFront();
        }

		private void menuXemNguoiDung_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(FormXemNguoiDung.Instance))
            {
                container.Controls.Add(FormXemNguoiDung.Instance);
                FormXemNguoiDung.Instance.Dock = DockStyle.Fill;
                FormXemNguoiDung.Instance.Anchor = AnchorStyles.None;
            }
            FormXemNguoiDung.Instance.BringToFront();
        }
	}
}
