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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoaiSanPham = new DevExpress.XtraEditors.TextEdit();
            this.btnThemSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colTenLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(306, 82);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(191, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chỉnh sửa danh mục sản phẩm";
            // 
            // txtLoaiSanPham
            // 
            this.txtLoaiSanPham.Location = new System.Drawing.Point(327, 143);
            this.txtLoaiSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoaiSanPham.Name = "txtLoaiSanPham";
            this.txtLoaiSanPham.Size = new System.Drawing.Size(360, 22);
            this.txtLoaiSanPham.TabIndex = 1;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(142, 468);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(87, 28);
            this.btnThemSP.TabIndex = 2;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // btnCapNhatSP
            // 
            this.btnCapNhatSP.Location = new System.Drawing.Point(348, 468);
            this.btnCapNhatSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhatSP.Name = "btnCapNhatSP";
            this.btnCapNhatSP.Size = new System.Drawing.Size(87, 28);
            this.btnCapNhatSP.TabIndex = 3;
            this.btnCapNhatSP.Text = "Cập nhật";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(533, 468);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 28);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenLoaiSP});
            this.dataGridView1.Location = new System.Drawing.Point(114, 224);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(573, 185);
            this.dataGridView1.TabIndex = 6;
            // 
            // colTenLoaiSP
            // 
            this.colTenLoaiSP.Frozen = true;
            this.colTenLoaiSP.HeaderText = "Tên loại quần áo";
            this.colTenLoaiSP.MinimumWidth = 100;
            this.colTenLoaiSP.Name = "colTenLoaiSP";
            this.colTenLoaiSP.Width = 125;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(114, 146);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(169, 17);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Nhập tên loại sản phẩm mới";
            // 
            // FormThemLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 540);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhatSP);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.txtLoaiSanPham);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThemLoai";
            this.Text = "FormThemLoai";
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLoaiSanPham;
        private DevExpress.XtraEditors.SimpleButton btnThemSP;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatSP;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiSP;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}