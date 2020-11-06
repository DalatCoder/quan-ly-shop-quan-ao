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
    public partial class uFormToanBoSanPham : DevExpress.XtraEditors.XtraUserControl
    {
        private static uFormToanBoSanPham _instance;

        public static uFormToanBoSanPham Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uFormToanBoSanPham();
                return _instance;
            }
        }

        public uFormToanBoSanPham()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
	}
}