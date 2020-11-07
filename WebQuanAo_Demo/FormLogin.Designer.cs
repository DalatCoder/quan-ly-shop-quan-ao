namespace WebQuanAo_Demo
{
    partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
			this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap.Appearance.Options.UseFont = true;
			this.btnDangNhap.Location = new System.Drawing.Point(679, 310);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(271, 27);
			this.btnDangNhap.TabIndex = 3;
			this.btnDangNhap.Text = "Log in";
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(541, 162);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(95, 17);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Tên Đăng Nhập";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(541, 246);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(56, 17);
			this.labelControl2.TabIndex = 4;
			this.labelControl2.Text = "Mật khẩu";
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(679, 239);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Properties.AutoHeight = false;
			this.txtMatKhau.Properties.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(271, 24);
			this.txtMatKhau.TabIndex = 2;
			// 
			// txtTenDangNhap
			// 
			this.txtTenDangNhap.EditValue = "Username";
			this.txtTenDangNhap.Location = new System.Drawing.Point(679, 162);
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.Properties.Appearance.BackColor = System.Drawing.Color.White;
			this.txtTenDangNhap.Properties.Appearance.Options.UseBackColor = true;
			this.txtTenDangNhap.Properties.AutoHeight = false;
			this.txtTenDangNhap.Size = new System.Drawing.Size(271, 34);
			this.txtTenDangNhap.TabIndex = 1;
			// 
			// FormLogin
			// 
			this.AcceptButton = this.btnDangNhap;
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
			this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
			this.ClientSize = new System.Drawing.Size(1074, 688);
			this.Controls.Add(this.txtTenDangNhap);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.btnDangNhap);
			this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormLogin";
			((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.TextEdit txtMatKhau;
		private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
	}
}