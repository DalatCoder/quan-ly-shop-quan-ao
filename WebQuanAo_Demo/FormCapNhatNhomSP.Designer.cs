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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnChinhSuaSP = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaSP = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomSanPham.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboNhomSanPham
            // 
            this.cboNhomSanPham.Location = new System.Drawing.Point(250, 73);
            this.cboNhomSanPham.Name = "cboNhomSanPham";
            this.cboNhomSanPham.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNhomSanPham.Size = new System.Drawing.Size(275, 20);
            this.cboNhomSanPham.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(56, 76);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Xem thể loại quần áo hiện có";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(56, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(149, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên nhóm sản phẩm đang chọn";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(250, 136);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(275, 20);
            this.textEdit1.TabIndex = 3;
            // 
            // btnChinhSuaSP
            // 
            this.btnChinhSuaSP.Location = new System.Drawing.Point(77, 206);
            this.btnChinhSuaSP.Name = "btnChinhSuaSP";
            this.btnChinhSuaSP.Size = new System.Drawing.Size(127, 23);
            this.btnChinhSuaSP.TabIndex = 4;
            this.btnChinhSuaSP.Text = "Chỉnh sửa tên sản phẩm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(425, 206);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Location = new System.Drawing.Point(231, 206);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(163, 23);
            this.btnXoaSP.TabIndex = 6;
            this.btnXoaSP.Text = "Xóa loại sản phẩm được chọn";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(206, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(188, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Chỉnh sửa danh mục sản phẩm quần áo";
            // 
            // FormCapNhatNhomSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 290);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnXoaSP);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChinhSuaSP);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboNhomSanPham);
            this.Name = "FormCapNhatNhomSP";
            this.Text = "FormCapNhatNhomSP";
            ((System.ComponentModel.ISupportInitialize)(this.cboNhomSanPham.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cboNhomSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btnChinhSuaSP;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoaSP;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}