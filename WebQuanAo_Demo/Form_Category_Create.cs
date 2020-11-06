using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebQuanAo_Demo
{
	public partial class Form_Category_Create :DevExpress.XtraEditors.XtraForm
	{
		public Form_Category_Create()
		{
			InitializeComponent();
		}

		private void Form_Catelary_Load(object sender, EventArgs e)
		{

		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
