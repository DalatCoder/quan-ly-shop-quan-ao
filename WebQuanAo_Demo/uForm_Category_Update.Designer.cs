namespace WebQuanAo_Demo
{
    partial class uForm_Category_Update
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
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtTenNhom = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslTotal = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).BeginInit();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(103, 80);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(184, 17);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Tên nhóm sản phẩm đang chọn";
			// 
			// txtTenNhom
			// 
			this.txtTenNhom.Location = new System.Drawing.Point(295, 77);
			this.txtTenNhom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTenNhom.Name = "txtTenNhom";
			this.txtTenNhom.Properties.ReadOnly = true;
			this.txtTenNhom.Size = new System.Drawing.Size(404, 24);
			this.txtTenNhom.TabIndex = 3;
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
			this.labelControl3.TabIndex = 41;
			this.labelControl3.Text = "Chỉnh sửa danh mục sản phẩm";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotal});
			this.statusStrip1.Location = new System.Drawing.Point(0, 633);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(808, 55);
			this.statusStrip1.TabIndex = 48;
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
			this.labelControl10.Location = new System.Drawing.Point(0, 238);
			this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(808, 33);
			this.labelControl10.TabIndex = 47;
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
			this.dgvNguoiDung.Location = new System.Drawing.Point(20, 295);
			this.dgvNguoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvNguoiDung.MultiSelect = false;
			this.dgvNguoiDung.Name = "dgvNguoiDung";
			this.dgvNguoiDung.RowHeadersWidth = 51;
			this.dgvNguoiDung.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvNguoiDung.Size = new System.Drawing.Size(766, 334);
			this.dgvNguoiDung.TabIndex = 46;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(295, 109);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(404, 23);
			this.simpleButton1.TabIndex = 49;
			this.simpleButton1.Text = "Xóa sản phẩm đang chọn";
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(295, 195);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(404, 23);
			this.simpleButton2.TabIndex = 52;
			this.simpleButton2.Text = "Xác nhận cập nhật tên";
			// 
			// textEdit1
			// 
			this.textEdit1.Location = new System.Drawing.Point(295, 163);
			this.textEdit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textEdit1.Name = "textEdit1";
			this.textEdit1.Size = new System.Drawing.Size(404, 24);
			this.textEdit1.TabIndex = 51;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(187, 166);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(100, 17);
			this.labelControl1.TabIndex = 50;
			this.labelControl1.Text = "Cập nhật tên mới";
			// 
			// uForm_Category_Update
			// 
			this.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.simpleButton2);
			this.Controls.Add(this.textEdit1);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.labelControl10);
			this.Controls.Add(this.dgvNguoiDung);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.txtTenNhom);
			this.Controls.Add(this.labelControl2);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "uForm_Category_Update";
			this.Size = new System.Drawing.Size(808, 688);
			((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenNhom;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslTotal;
		private DevExpress.XtraEditors.LabelControl labelControl10;
		private System.Windows.Forms.DataGridView dgvNguoiDung;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.TextEdit textEdit1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}