namespace WebQuanAo_Demo
{
    partial class FormBanHang
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Quần thun",
            "10.000",
            "10"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Áo thun",
            "5.000",
            "5"}, -1);
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtMaGiaoDich = new DevExpress.XtraEditors.TextEdit();
			this.txtTenKhachHang = new DevExpress.XtraEditors.TextEdit();
			this.btnThemHoaDon = new DevExpress.XtraEditors.SimpleButton();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.btnTimKiemQA = new DevExpress.XtraEditors.SimpleButton();
			this.txtSoDT = new DevExpress.XtraEditors.TextEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.lvChiTietSanPham = new System.Windows.Forms.ListView();
			this.colTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.txtMaGiaoDich.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSoDT.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(405, 35);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(167, 17);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Thông tin hóa đơn bán hàng";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(76, 132);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(77, 17);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "Mã giao dịch";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(40, 192);
			this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(109, 17);
			this.labelControl4.TabIndex = 3;
			this.labelControl4.Text = "Họ tên khách hàng";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(72, 245);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(77, 17);
			this.labelControl3.TabIndex = 4;
			this.labelControl3.Text = "Số điện thoại";
			// 
			// txtMaGiaoDich
			// 
			this.txtMaGiaoDich.Location = new System.Drawing.Point(210, 132);
			this.txtMaGiaoDich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtMaGiaoDich.Name = "txtMaGiaoDich";
			this.txtMaGiaoDich.Size = new System.Drawing.Size(737, 24);
			this.txtMaGiaoDich.TabIndex = 5;
			// 
			// txtTenKhachHang
			// 
			this.txtTenKhachHang.Location = new System.Drawing.Point(210, 188);
			this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtTenKhachHang.Name = "txtTenKhachHang";
			this.txtTenKhachHang.Size = new System.Drawing.Size(737, 24);
			this.txtTenKhachHang.TabIndex = 6;
			// 
			// btnThemHoaDon
			// 
			this.btnThemHoaDon.Location = new System.Drawing.Point(80, 624);
			this.btnThemHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnThemHoaDon.Name = "btnThemHoaDon";
			this.btnThemHoaDon.Size = new System.Drawing.Size(134, 30);
			this.btnThemHoaDon.TabIndex = 8;
			this.btnThemHoaDon.Text = "Xác nhận mua hàng";
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(829, 624);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(87, 30);
			this.btnThoat.TabIndex = 9;
			this.btnThoat.Text = "Thoát";
			// 
			// btnTimKiemQA
			// 
			this.btnTimKiemQA.Location = new System.Drawing.Point(405, 624);
			this.btnTimKiemQA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnTimKiemQA.Name = "btnTimKiemQA";
			this.btnTimKiemQA.Size = new System.Drawing.Size(192, 30);
			this.btnTimKiemQA.TabIndex = 10;
			this.btnTimKiemQA.Text = "Tìm kiếm quần áo";
			// 
			// txtSoDT
			// 
			this.txtSoDT.Location = new System.Drawing.Point(210, 241);
			this.txtSoDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtSoDT.Name = "txtSoDT";
			this.txtSoDT.Properties.AutoHeight = false;
			this.txtSoDT.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.txtSoDT.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
			this.txtSoDT.Properties.MaskSettings.Set("mask", "000.000.0000");
			this.txtSoDT.Size = new System.Drawing.Size(737, 26);
			this.txtSoDT.TabIndex = 11;
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(429, 290);
			this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(152, 17);
			this.labelControl5.TabIndex = 12;
			this.labelControl5.Text = "Chi tiết sản phẩm đã chọn";
			// 
			// lvChiTietSanPham
			// 
			this.lvChiTietSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenSP,
            this.colDonGia,
            this.colSoLuong});
			this.lvChiTietSanPham.GridLines = true;
			this.lvChiTietSanPham.HideSelection = false;
			this.lvChiTietSanPham.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.lvChiTietSanPham.Location = new System.Drawing.Point(40, 336);
			this.lvChiTietSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lvChiTietSanPham.Name = "lvChiTietSanPham";
			this.lvChiTietSanPham.Size = new System.Drawing.Size(907, 200);
			this.lvChiTietSanPham.TabIndex = 13;
			this.lvChiTietSanPham.UseCompatibleStateImageBehavior = false;
			this.lvChiTietSanPham.View = System.Windows.Forms.View.Details;
			// 
			// colTenSP
			// 
			this.colTenSP.Text = "Tên Sản Phẩm";
			this.colTenSP.Width = 276;
			// 
			// colDonGia
			// 
			this.colDonGia.Text = "Đơn Giá";
			this.colDonGia.Width = 161;
			// 
			// colSoLuong
			// 
			this.colSoLuong.Text = "Số Lượng";
			this.colSoLuong.Width = 103;
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(148, 571);
			this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(121, 17);
			this.labelControl6.TabIndex = 14;
			this.labelControl6.Text = "Tổng tiền thanh toán";
			// 
			// textEdit2
			// 
			this.textEdit2.EditValue = "125.000";
			this.textEdit2.Location = new System.Drawing.Point(357, 568);
			this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
			this.textEdit2.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.textEdit2.Properties.ReadOnly = true;
			this.textEdit2.Size = new System.Drawing.Size(281, 24);
			this.textEdit2.TabIndex = 15;
			// 
			// FormBanHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textEdit2);
			this.Controls.Add(this.labelControl6);
			this.Controls.Add(this.lvChiTietSanPham);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.txtSoDT);
			this.Controls.Add(this.btnTimKiemQA);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnThemHoaDon);
			this.Controls.Add(this.txtTenKhachHang);
			this.Controls.Add(this.txtMaGiaoDich);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormBanHang";
			this.Size = new System.Drawing.Size(808, 688);
			((System.ComponentModel.ISupportInitialize)(this.txtMaGiaoDich.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSoDT.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtMaGiaoDich;
        private DevExpress.XtraEditors.TextEdit txtTenKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnThemHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemQA;
        private DevExpress.XtraEditors.TextEdit txtSoDT;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ListView lvChiTietSanPham;
        private System.Windows.Forms.ColumnHeader colTenSP;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit2;
    }
}