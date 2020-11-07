namespace WebQuanAo_Demo
{
    partial class uForm_Product_Update
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
			this.txtTenSP = new DevExpress.XtraEditors.TextEdit();
			this.txtGiaBan = new DevExpress.XtraEditors.TextEdit();
			this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
			this.btnChinhSuaSP = new DevExpress.XtraEditors.SimpleButton();
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.pbHinhSP = new System.Windows.Forms.PictureBox();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
			this.tsslTotal = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.btnTimKiemHinhAnh = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.cbxLoaiSP = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbHinhSP)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTenSP
			// 
			this.txtTenSP.Location = new System.Drawing.Point(383, 77);
			this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTenSP.Name = "txtTenSP";
			this.txtTenSP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenSP.Properties.Appearance.Options.UseFont = true;
			this.txtTenSP.Size = new System.Drawing.Size(402, 26);
			this.txtTenSP.TabIndex = 10;
			// 
			// txtGiaBan
			// 
			this.txtGiaBan.Location = new System.Drawing.Point(383, 124);
			this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtGiaBan.Name = "txtGiaBan";
			this.txtGiaBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGiaBan.Properties.Appearance.Options.UseFont = true;
			this.txtGiaBan.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
			this.txtGiaBan.Properties.MaskSettings.Set("mask", "n0");
			this.txtGiaBan.Size = new System.Drawing.Size(402, 26);
			this.txtGiaBan.TabIndex = 11;
			// 
			// txtDiscount
			// 
			this.txtDiscount.Location = new System.Drawing.Point(383, 172);
			this.txtDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtDiscount.Name = "txtDiscount";
			this.txtDiscount.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiscount.Properties.Appearance.Options.UseFont = true;
			this.txtDiscount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
			this.txtDiscount.Properties.MaskSettings.Set("mask", "00.00%");
			this.txtDiscount.Size = new System.Drawing.Size(402, 26);
			this.txtDiscount.TabIndex = 13;
			// 
			// btnChinhSuaSP
			// 
			this.btnChinhSuaSP.Location = new System.Drawing.Point(61, 753);
			this.btnChinhSuaSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnChinhSuaSP.Name = "btnChinhSuaSP";
			this.btnChinhSuaSP.Size = new System.Drawing.Size(189, 33);
			this.btnChinhSuaSP.TabIndex = 15;
			this.btnChinhSuaSP.Text = "Xác nhận chỉnh sửa";
			this.btnChinhSuaSP.Click += new System.EventHandler(this.btnChinhSuaSP_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(679, 753);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(189, 33);
			this.btnThoat.TabIndex = 16;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// pbHinhSP
			// 
			this.pbHinhSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbHinhSP.Location = new System.Drawing.Point(20, 80);
			this.pbHinhSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pbHinhSP.Name = "pbHinhSP";
			this.pbHinhSP.Size = new System.Drawing.Size(170, 227);
			this.pbHinhSP.TabIndex = 69;
			this.pbHinhSP.TabStop = false;
			// 
			// labelControl5
			// 
			this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Appearance.Options.UseTextOptions = true;
			this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl5.Location = new System.Drawing.Point(0, 20);
			this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(808, 33);
			this.labelControl5.TabIndex = 70;
			this.labelControl5.Text = "Chỉnh sửa thông tin sản phẩm";
			// 
			// labelControl10
			// 
			this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl10.Appearance.Options.UseFont = true;
			this.labelControl10.Appearance.Options.UseTextOptions = true;
			this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl10.Location = new System.Drawing.Point(-1, 330);
			this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(808, 33);
			this.labelControl10.TabIndex = 72;
			this.labelControl10.Text = "Danh sách sản phẩm hiện có";
			// 
			// dgvNguoiDung
			// 
			this.dgvNguoiDung.AllowUserToAddRows = false;
			this.dgvNguoiDung.AllowUserToDeleteRows = false;
			this.dgvNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNguoiDung.BackgroundColor = System.Drawing.Color.Azure;
			this.dgvNguoiDung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNguoiDung.Location = new System.Drawing.Point(20, 380);
			this.dgvNguoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvNguoiDung.MultiSelect = false;
			this.dgvNguoiDung.Name = "dgvNguoiDung";
			this.dgvNguoiDung.RowHeadersWidth = 51;
			this.dgvNguoiDung.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvNguoiDung.Size = new System.Drawing.Size(766, 249);
			this.dgvNguoiDung.TabIndex = 71;
			// 
			// tsslTotal
			// 
			this.tsslTotal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsslTotal.Margin = new System.Windows.Forms.Padding(20);
			this.tsslTotal.Name = "tsslTotal";
			this.tsslTotal.Size = new System.Drawing.Size(159, 15);
			this.tsslTotal.Text = "Tổng số sản phẩm hiện có: 0";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotal});
			this.statusStrip1.Location = new System.Drawing.Point(0, 633);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(808, 55);
			this.statusStrip1.TabIndex = 73;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// btnTimKiemHinhAnh
			// 
			this.btnTimKiemHinhAnh.Location = new System.Drawing.Point(249, 277);
			this.btnTimKiemHinhAnh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnTimKiemHinhAnh.Name = "btnTimKiemHinhAnh";
			this.btnTimKiemHinhAnh.Size = new System.Drawing.Size(127, 30);
			this.btnTimKiemHinhAnh.TabIndex = 74;
			this.btnTimKiemHinhAnh.Text = "Thay đổi ảnh";
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(453, 277);
			this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(127, 30);
			this.simpleButton1.TabIndex = 75;
			this.simpleButton1.Text = "Xác nhận chỉnh sửa";
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(658, 277);
			this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(127, 30);
			this.simpleButton2.TabIndex = 76;
			this.simpleButton2.Text = "Mặc định";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(296, 81);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(81, 17);
			this.labelControl1.TabIndex = 77;
			this.labelControl1.Text = "Tên sản phẩm";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(332, 127);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(45, 17);
			this.labelControl2.TabIndex = 78;
			this.labelControl2.Text = "Giá bán";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(326, 174);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(50, 17);
			this.labelControl4.TabIndex = 79;
			this.labelControl4.Text = "Discount";
			// 
			// labelControl6
			// 
			this.labelControl6.Location = new System.Drawing.Point(281, 222);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(97, 17);
			this.labelControl6.TabIndex = 80;
			this.labelControl6.Text = "Nhóm sản phẩm";
			// 
			// cbxLoaiSP
			// 
			this.cbxLoaiSP.FormattingEnabled = true;
			this.cbxLoaiSP.Location = new System.Drawing.Point(383, 218);
			this.cbxLoaiSP.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.cbxLoaiSP.Name = "cbxLoaiSP";
			this.cbxLoaiSP.Size = new System.Drawing.Size(402, 27);
			this.cbxLoaiSP.TabIndex = 81;
			// 
			// uForm_Product_Update
			// 
			this.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cbxLoaiSP);
			this.Controls.Add(this.labelControl6);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.simpleButton2);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.btnTimKiemHinhAnh);
			this.Controls.Add(this.labelControl10);
			this.Controls.Add(this.dgvNguoiDung);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.pbHinhSP);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnChinhSuaSP);
			this.Controls.Add(this.txtDiscount);
			this.Controls.Add(this.txtGiaBan);
			this.Controls.Add(this.txtTenSP);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "uForm_Product_Update";
			this.Size = new System.Drawing.Size(808, 688);
			((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbHinhSP)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtTenSP;
        private DevExpress.XtraEditors.TextEdit txtGiaBan;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private DevExpress.XtraEditors.SimpleButton btnChinhSuaSP;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
		private System.Windows.Forms.PictureBox pbHinhSP;
		private DevExpress.XtraEditors.LabelControl labelControl5;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private System.Windows.Forms.DataGridView dgvNguoiDung;
		private System.Windows.Forms.ToolStripStatusLabel tsslTotal;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private DevExpress.XtraEditors.SimpleButton btnTimKiemHinhAnh;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cbxLoaiSP;
    }
}