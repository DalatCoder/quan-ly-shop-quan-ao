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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}