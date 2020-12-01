using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebQuanAo_Demo
{
	public partial class FormWelcom : DevExpress.XtraEditors.XtraUserControl
    {
        private static FormWelcom _instance;

        public static FormWelcom Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormWelcom();
                return _instance;
            }
        }

        public FormWelcom()
		{
			InitializeComponent();
		}
	}
}
