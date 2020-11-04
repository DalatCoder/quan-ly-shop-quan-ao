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
			}
            FormBanHang.Instance.BringToFront();    
		}

		private void menuThemSP_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(FormThemSanPham.Instance))
            {
                container.Controls.Add(FormThemSanPham.Instance);
                FormThemSanPham.Instance.Dock = DockStyle.Fill;
            }
            FormThemSanPham.Instance.BringToFront();
        }
	}
}
