namespace WebQuanAo_Demo
{
	public partial class FormBanHang : DevExpress.XtraEditors.XtraUserControl
    {
        private static FormBanHang _instance;

        public static FormBanHang Instance
		{
			get
			{
                if (_instance == null)
                    _instance = new FormBanHang();
                return _instance;
			}
		}

        public FormBanHang()
        {
            InitializeComponent();
        }
    }
}