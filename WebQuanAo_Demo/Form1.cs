﻿using DevExpress.XtraBars;
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
            if (!container.Controls.Contains(uForm_Bill.Instance))
			{
                container.Controls.Add(uForm_Bill.Instance);
                uForm_Bill.Instance.Dock = DockStyle.Fill;
                uForm_Bill.Instance.Anchor = AnchorStyles.None;
			}
            uForm_Bill.Instance.BringToFront();    
		}

		private void menuThemSP_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(uForm_Product_Create.Instance))
            {
                container.Controls.Add(uForm_Product_Create.Instance);
                uForm_Product_Create.Instance.Dock = DockStyle.Fill;
                uForm_Product_Create.Instance.Anchor = AnchorStyles.None;
            }
            uForm_Product_Create.Instance.BringToFront();
        }

		private void menuChinhSuaSP_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(uForm_Product_Update.Instance))
            {
                container.Controls.Add(uForm_Product_Update.Instance);
                uForm_Product_Update.Instance.Dock = DockStyle.Fill;
                uForm_Product_Update.Instance.Anchor = AnchorStyles.None;
            }
            uForm_Product_Update.Instance.BringToFront();
        }

		private void menuCapNhatNhomSanPham_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(uForm_Category_Update.Instance))
            {
                container.Controls.Add(uForm_Category_Update.Instance);
                uForm_Category_Update.Instance.Dock = DockStyle.Fill;
                uForm_Category_Update.Instance.Anchor = AnchorStyles.None;
            }
            uForm_Category_Update.Instance.BringToFront();
        }

		private void menuThemLoaiSP_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(uForm_Category_Create.Instance))
            {
                container.Controls.Add(uForm_Category_Create.Instance);
                uForm_Category_Create.Instance.Dock = DockStyle.Fill;
                uForm_Category_Create.Instance.Anchor = AnchorStyles.None;
            }
            uForm_Category_Create.Instance.BringToFront();
        }

		private void menuXemSP_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(uFormToanBoSanPham.Instance))
            {
                container.Controls.Add(uFormToanBoSanPham.Instance);
                uFormToanBoSanPham.Instance.Dock = DockStyle.Fill;
                uFormToanBoSanPham.Instance.Anchor = AnchorStyles.None;
            }
            uFormToanBoSanPham.Instance.BringToFront();
        }

		private void menuXemNguoiDung_Click(object sender, EventArgs e)
		{
            if (!container.Controls.Contains(uForm_User_Read.Instance))
            {
                container.Controls.Add(uForm_User_Read.Instance);
                uForm_User_Read.Instance.Dock = DockStyle.Fill;
                uForm_User_Read.Instance.Anchor = AnchorStyles.None;
            }
            uForm_User_Read.Instance.BringToFront();
        }
	}
}
