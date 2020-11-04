namespace WebQuanAo_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
			this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.menuBanHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlSeparator1 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
			this.accordionControlSeparator2 = new DevExpress.XtraBars.Navigation.AccordionControlSeparator();
			this.menuThemSP = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.menuChinhSuaSP = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.menuCapNhatNhomSanPham = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.menuThemLoaiSP = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.menuXemSP = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.menuXemNguoiDung = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
			this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
			this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.SuspendLayout();
			// 
			// container
			// 
			this.container.Dock = System.Windows.Forms.DockStyle.Fill;
			this.container.Location = new System.Drawing.Point(228, 31);
			this.container.Margin = new System.Windows.Forms.Padding(2);
			this.container.Name = "container";
			this.container.Size = new System.Drawing.Size(850, 688);
			this.container.TabIndex = 0;
			// 
			// accordionControl1
			// 
			this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuBanHang,
            this.menuThemSP,
            this.menuChinhSuaSP,
            this.menuCapNhatNhomSanPham,
            this.menuThemLoaiSP,
            this.menuXemSP,
            this.menuXemNguoiDung});
			this.accordionControl1.Location = new System.Drawing.Point(0, 31);
			this.accordionControl1.Margin = new System.Windows.Forms.Padding(2);
			this.accordionControl1.Name = "accordionControl1";
			this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
			this.accordionControl1.Size = new System.Drawing.Size(228, 688);
			this.accordionControl1.TabIndex = 1;
			this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// menuBanHang
			// 
			this.menuBanHang.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSeparator1,
            this.accordionControlSeparator2});
			this.menuBanHang.Height = 80;
			this.menuBanHang.Name = "menuBanHang";
			this.menuBanHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.menuBanHang.Text = "Bán Hàng";
			this.menuBanHang.Click += new System.EventHandler(this.accordionControlElement1_Click);
			// 
			// accordionControlSeparator1
			// 
			this.accordionControlSeparator1.Name = "accordionControlSeparator1";
			this.accordionControlSeparator1.Visible = false;
			// 
			// accordionControlSeparator2
			// 
			this.accordionControlSeparator2.Name = "accordionControlSeparator2";
			this.accordionControlSeparator2.Visible = false;
			// 
			// menuThemSP
			// 
			this.menuThemSP.Height = 80;
			this.menuThemSP.Name = "menuThemSP";
			this.menuThemSP.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.menuThemSP.Text = "Thêm Sản Phẩm";
			this.menuThemSP.Click += new System.EventHandler(this.menuThemSP_Click);
			// 
			// menuChinhSuaSP
			// 
			this.menuChinhSuaSP.Height = 80;
			this.menuChinhSuaSP.Name = "menuChinhSuaSP";
			this.menuChinhSuaSP.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.menuChinhSuaSP.Text = "Chỉnh sửa Sản Phẩm";
			this.menuChinhSuaSP.Click += new System.EventHandler(this.menuChinhSuaSP_Click);
			// 
			// menuCapNhatNhomSanPham
			// 
			this.menuCapNhatNhomSanPham.Height = 80;
			this.menuCapNhatNhomSanPham.Name = "menuCapNhatNhomSanPham";
			this.menuCapNhatNhomSanPham.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.menuCapNhatNhomSanPham.Text = "Cập Nhật Nhóm Sản Phẩm";
			this.menuCapNhatNhomSanPham.Click += new System.EventHandler(this.menuCapNhatNhomSanPham_Click);
			// 
			// menuThemLoaiSP
			// 
			this.menuThemLoaiSP.Height = 80;
			this.menuThemLoaiSP.Name = "menuThemLoaiSP";
			this.menuThemLoaiSP.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.menuThemLoaiSP.Text = "Thêm Loại Sản Phẩm";
			this.menuThemLoaiSP.Click += new System.EventHandler(this.menuThemLoaiSP_Click);
			// 
			// menuXemSP
			// 
			this.menuXemSP.Height = 80;
			this.menuXemSP.Name = "menuXemSP";
			this.menuXemSP.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.menuXemSP.Text = "Xem Toàn Bộ Sản Phẩm";
			this.menuXemSP.Click += new System.EventHandler(this.menuXemSP_Click);
			// 
			// menuXemNguoiDung
			// 
			this.menuXemNguoiDung.Height = 80;
			this.menuXemNguoiDung.Name = "menuXemNguoiDung";
			this.menuXemNguoiDung.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.menuXemNguoiDung.Text = "Xem Người Dùng Hiện Có";
			this.menuXemNguoiDung.Click += new System.EventHandler(this.menuXemNguoiDung_Click);
			// 
			// fluentDesignFormControl1
			// 
			this.fluentDesignFormControl1.FluentDesignForm = this;
			this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1});
			this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
			this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
			this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
			this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
			this.fluentDesignFormControl1.Size = new System.Drawing.Size(1078, 31);
			this.fluentDesignFormControl1.TabIndex = 2;
			this.fluentDesignFormControl1.TabStop = false;
			this.fluentDesignFormControl1.TitleItemLinks.Add(this.barStaticItem1);
			// 
			// barStaticItem1
			// 
			this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.barStaticItem1.Caption = "Xin chào Trọng Hiếu";
			this.barStaticItem1.Id = 1;
			this.barStaticItem1.Name = "barStaticItem1";
			// 
			// fluentFormDefaultManager1
			// 
			this.fluentFormDefaultManager1.DockingEnabled = false;
			this.fluentFormDefaultManager1.Form = this;
			this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1});
			this.fluentFormDefaultManager1.MaxItemId = 2;
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1078, 719);
			this.ControlContainer = this.container;
			this.Controls.Add(this.container);
			this.Controls.Add(this.accordionControl1);
			this.Controls.Add(this.fluentDesignFormControl1);
			this.FluentDesignFormControl = this.fluentDesignFormControl1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.NavigationControl = this.accordionControl1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản Lý Shop Quần Áo";
			((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private DevExpress.XtraBars.Navigation.AccordionControlElement menuBanHang;
		private DevExpress.XtraBars.Navigation.AccordionControlElement menuThemSP;
		private DevExpress.XtraBars.Navigation.AccordionControlElement menuChinhSuaSP;
		private DevExpress.XtraBars.Navigation.AccordionControlElement menuCapNhatNhomSanPham;
		private DevExpress.XtraBars.Navigation.AccordionControlElement menuThemLoaiSP;
		private DevExpress.XtraBars.Navigation.AccordionControlElement menuXemSP;
		private DevExpress.XtraBars.Navigation.AccordionControlElement menuXemNguoiDung;
		private DevExpress.XtraBars.BarStaticItem barStaticItem1;
		private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator1;
		private DevExpress.XtraBars.Navigation.AccordionControlSeparator accordionControlSeparator2;
	}
}

