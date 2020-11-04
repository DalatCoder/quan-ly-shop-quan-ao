using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WebQuanAo_Demo
{
    public partial class FormXemNguoiDung : DevExpress.XtraEditors.XtraUserControl
    {
        private static FormXemNguoiDung _instance;

        public static FormXemNguoiDung Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormXemNguoiDung();
                return _instance;
            }
        }

        public FormXemNguoiDung()
        {
            InitializeComponent();
        }

		private void FormXemNguoiDung_Load(object sender, EventArgs e)
		{
            dgvNguoiDung.ColumnCount = 3;
            dgvNguoiDung.Columns[0].Name = "Loại người dùng";
            dgvNguoiDung.Columns[1].Name = "Họ và tên";
            dgvNguoiDung.Columns[2].Name = "Số điện thoại";

            string[] row = new string[] { "VIP", "Nguyễn Trọng Hiếu", "0123456789" };
            dgvNguoiDung.Rows.Add(row);

            row = new string[] { "VIP", "Nguyễn Thị Hà", "0123123123" };
            dgvNguoiDung.Rows.Add(row);

            tsslTotal.Text = "Tổng số khách hàng: 2";
            tsslVIP.Text = "Số khách hàng VIP: 2";
            tsslNormal.Text = "Số khách hàng thường: 0";
		}
	}
}