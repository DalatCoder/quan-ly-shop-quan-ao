namespace WebQuanAo_Demo
{
    partial class FormThemLoai
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
			this.txtLoaiSanPham = new DevExpress.XtraEditors.TextEdit();
			this.btnThemSP = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslTotal = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.txtLoaiSanPham.Properties)).BeginInit();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
			this.SuspendLayout();
			// 
			// txtLoaiSanPham
			// 
			this.txtLoaiSanPham.Location = new System.Drawing.Point(171, 112);
			this.txtLoaiSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtLoaiSanPham.Name = "txtLoaiSanPham";
			this.txtLoaiSanPham.Size = new System.Drawing.Size(476, 24);
			this.txtLoaiSanPham.TabIndex = 1;
			// 
			// btnThemSP
			// 
			this.btnThemSP.Location = new System.Drawing.Point(297, 160);
			this.btnThemSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnThemSP.Name = "btnThemSP";
			this.btnThemSP.Size = new System.Drawing.Size(212, 30);
			this.btnThemSP.TabIndex = 2;
			this.btnThemSP.Text = "Thêm";
			this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(317, 87);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(166, 17);
			this.labelControl2.TabIndex = 7;
			this.labelControl2.Text = "Nhập tên loại sản phẩm mới";
			// 
			// labelControl3
			// 
			this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Appearance.Options.UseTextOptions = true;
			this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl3.Location = new System.Drawing.Point(0, 20);
			this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(808, 33);
			this.labelControl3.TabIndex = 40;
			this.labelControl3.Text = "Thêm loại sản phẩm mới";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotal});
			this.statusStrip1.Location = new System.Drawing.Point(0, 633);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(808, 55);
			this.statusStrip1.TabIndex = 45;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsslTotal
			// 
			this.tsslTotal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsslTotal.Margin = new System.Windows.Forms.Padding(20);
			this.tsslTotal.Name = "tsslTotal";
			this.tsslTotal.Size = new System.Drawing.Size(194, 15);
			this.tsslTotal.Text = "Tổng số nhóm sản phẩm hiện có: 0";
			// 
			// labelControl10
			// 
			this.labelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl10.Appearance.Options.UseFont = true;
			this.labelControl10.Appearance.Options.UseTextOptions = true;
			this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl10.Location = new System.Drawing.Point(0, 247);
			this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(808, 33);
			this.labelControl10.TabIndex = 44;
			this.labelControl10.Text = "Danh sách loại sản phẩm hiện có";
			// 
			// dgvNguoiDung
			// 
			this.dgvNguoiDung.AllowUserToAddRows = false;
			this.dgvNguoiDung.AllowUserToDeleteRows = false;
			this.dgvNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNguoiDung.BackgroundColor = System.Drawing.Color.Azure;
			this.dgvNguoiDung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNguoiDung.Location = new System.Drawing.Point(20, 297);
			this.dgvNguoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvNguoiDung.MultiSelect = false;
			this.dgvNguoiDung.Name = "dgvNguoiDung";
			this.dgvNguoiDung.RowHeadersWidth = 51;
			this.dgvNguoiDung.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvNguoiDung.Size = new System.Drawing.Size(766, 332);
			this.dgvNguoiDung.TabIndex = 43;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(297, 208);
			this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(212, 30);
			this.simpleButton1.TabIndex = 46;
			this.simpleButton1.Text = "Mặc định";
			// 
			// FormThemLoai
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.labelControl10);
			this.Controls.Add(this.dgvNguoiDung);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.btnThemSP);
			this.Controls.Add(this.txtLoaiSanPham);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormThemLoai";
			this.Size = new System.Drawing.Size(808, 688);
			((System.ComponentModel.ISupportInitialize)(this.txtLoaiSanPham.Properties)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtLoaiSanPham;
        private DevExpress.XtraEditors.SimpleButton btnThemSP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslTotal;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private System.Windows.Forms.DataGridView dgvNguoiDung;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
	}
}