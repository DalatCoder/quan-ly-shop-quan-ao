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
    public partial class FormToanBoSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private static FormToanBoSanPham _instance;

        public static FormToanBoSanPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormToanBoSanPham();
                return _instance;
            }
        }

        public FormToanBoSanPham()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
	}
}