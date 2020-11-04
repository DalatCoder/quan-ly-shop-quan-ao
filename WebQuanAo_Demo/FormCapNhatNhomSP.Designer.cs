namespace WebQuanAo_Demo
{
    partial class FormCapNhatNhomSP
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
            this.cboNhomSanPham = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenNhom = new DevExpress.XtraEditors.TextEdit();
            this.btnChinhSuaSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaSP = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboNhomSanPham
            // 
            this.cboNhomSanPham.Location = new System.Drawing.Point(409, 198);
            this.cboNhomSanPham.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboNhomSanPham.Name = "cboNhomSanPham";
            this.cboNhomSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNhomSanPham.Size = new System.Drawing.Size(377, 22);
            this.cboNhomSanPham.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 203);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(176, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Xem thể loại quần áo hiện có";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(53, 309);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(197, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên nhóm sản phẩm đang chọn";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(409, 304);
            this.txtTenNhom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(377, 22);
            this.txtTenNhom.TabIndex = 3;
            // 
            // btnChinhSuaSP
            // 
            this.btnChinhSuaSP.Location = new System.Drawing.Point(53, 423);
            this.btnChinhSuaSP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnChinhSuaSP.Name = "btnChinhSuaSP";
            this.btnChinhSuaSP.Size = new System.Drawing.Size(161, 38);
            this.btnChinhSuaSP.TabIndex = 4;
            this.btnChinhSuaSP.Text = "Chỉnh sửa tên sản phẩm";
            this.btnChinhSuaSP.Click += new System.EventHandler(this.btnChinhSuaSP_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(667, 423);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 38);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(328, 423);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(222, 38);
            this.btnXoaSP.TabIndex = 6;
            this.btnXoaSP.Text = "Xóa loại sản phẩm được chọn";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(328, 106);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 2, 5, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(245, 17);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Chỉnh sửa danh mục sản phẩm quần áo";
            // 
            // FormCapNhatNhomSP
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChinhSuaSP);
            this.Controls.Add(this.txtTenNhom);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboNhomSanPham);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormCapNhatNhomSP";
            this.Size = new System.Drawing.Size(850, 688);
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboNhomSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenNhom;
        private DevExpress.XtraEditors.SimpleButton btnChinhSuaSP;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoaSP;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}