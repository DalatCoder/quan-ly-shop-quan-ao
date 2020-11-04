namespace WebQuanAo_Demo
{
	partial class FormChonSanPham
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenSP = new DevExpress.XtraEditors.TextEdit();
            this.txtSize = new DevExpress.XtraEditors.TextEdit();
            this.txtDiscount = new DevExpress.XtraEditors.TextEdit();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.dgvSanPhamChon = new System.Windows.Forms.DataGridView();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbxLoaiQA = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnChonSP = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLoaiQA.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 64);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Sản Phẩm";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(479, 64);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Discount";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(45, 135);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 16);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Size";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(479, 135);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 17);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Loại QA";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(173, 60);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(231, 22);
            this.txtTenSP.TabIndex = 4;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(173, 132);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(231, 22);
            this.txtSize.TabIndex = 5;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(592, 60);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(191, 22);
            this.txtDiscount.TabIndex = 7;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(45, 177);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.Size = new System.Drawing.Size(737, 204);
            this.dgvSanPham.TabIndex = 8;
            // 
            // dgvSanPhamChon
            // 
            this.dgvSanPhamChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamChon.Location = new System.Drawing.Point(45, 453);
            this.dgvSanPhamChon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPhamChon.Name = "dgvSanPhamChon";
            this.dgvSanPhamChon.RowHeadersWidth = 51;
            this.dgvSanPhamChon.Size = new System.Drawing.Size(737, 185);
            this.dgvSanPhamChon.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(159, 674);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "OK";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(563, 674);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(45, 430);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(120, 17);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Sản Phẩm Đã Chọn";
            // 
            // cbxLoaiQA
            // 
            this.cbxLoaiQA.Location = new System.Drawing.Point(592, 132);
            this.cbxLoaiQA.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLoaiQA.Name = "cbxLoaiQA";
            this.cbxLoaiQA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLoaiQA.Size = new System.Drawing.Size(191, 22);
            this.cbxLoaiQA.TabIndex = 14;
            // 
            // btnChonSP
            // 
            this.btnChonSP.Location = new System.Drawing.Point(45, 394);
            this.btnChonSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonSP.Name = "btnChonSP";
            this.btnChonSP.Size = new System.Drawing.Size(100, 28);
            this.btnChonSP.TabIndex = 15;
            this.btnChonSP.Text = "Chọn SP";
            // 
            // FormChonSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 725);
            this.Controls.Add(this.btnChonSP);
            this.Controls.Add(this.cbxLoaiQA);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvSanPhamChon);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChonSanPham";
            this.Text = "ChonSp";
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLoaiQA.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTenSP;
        private DevExpress.XtraEditors.TextEdit txtSize;
        private DevExpress.XtraEditors.TextEdit txtDiscount;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridView dgvSanPhamChon;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cbxLoaiQA;
        private DevExpress.XtraEditors.SimpleButton btnChonSP;
	}
}