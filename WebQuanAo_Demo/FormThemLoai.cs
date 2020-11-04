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
    public partial class FormThemLoai : DevExpress.XtraEditors.XtraUserControl
    {
        public FormThemLoai()
        {
            InitializeComponent();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtLoaiSanPham.Text == "")
                errorMessage = "Vui lòng nhập loại sản phẩm mới !!!";

            if(errorMessage.Length>0)
            {
                MessageBox.Show(errorMessage, "Thông báo không đủ dự kiện $_$");
                return;
            }    

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}