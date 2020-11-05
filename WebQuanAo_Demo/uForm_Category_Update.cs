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
    public partial class uForm_Category_Update : DevExpress.XtraEditors.XtraUserControl
    {
        private static uForm_Category_Update _instance;

        public static uForm_Category_Update Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uForm_Category_Update();
                return _instance;
            }
        }

        public uForm_Category_Update()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnChinhSuaSP_Click(object sender, EventArgs e)
        {
            try
            {
                var tenNhom = txtTenNhom.Text;

                StringValidator.CheckRequire(tenNhom, "Tên nhóm quần áo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo không đủ dữ kiện (•_•)");
            }
        }
    }
}