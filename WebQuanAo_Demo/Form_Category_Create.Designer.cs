namespace WebQuanAo_Demo
{
	partial class Form_Category_Create
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
			this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.btnThemSP = new DevExpress.XtraEditors.SimpleButton();
			this.txtLoaiSanPham = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.txtLoaiSanPham.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(169, 217);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(476, 30);
			this.btnThoat.TabIndex = 51;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
			this.labelControl3.TabIndex = 50;
			this.labelControl3.Text = "Thêm loại sản phẩm mới";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(315, 96);
			this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(166, 17);
			this.labelControl2.TabIndex = 49;
			this.labelControl2.Text = "Nhập tên loại sản phẩm mới";
			// 
			// btnThemSP
			// 
			this.btnThemSP.Location = new System.Drawing.Point(169, 169);
			this.btnThemSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnThemSP.Name = "btnThemSP";
			this.btnThemSP.Size = new System.Drawing.Size(476, 30);
			this.btnThemSP.TabIndex = 48;
			this.btnThemSP.Text = "Thêm";
			// 
			// txtLoaiSanPham
			// 
			this.txtLoaiSanPham.Location = new System.Drawing.Point(169, 121);
			this.txtLoaiSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtLoaiSanPham.Name = "txtLoaiSanPham";
			this.txtLoaiSanPham.Size = new System.Drawing.Size(476, 24);
			this.txtLoaiSanPham.TabIndex = 47;
			// 
			// Form_Category_Create
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 296);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.btnThemSP);
			this.Controls.Add(this.txtLoaiSanPham);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form_Category_Create";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_Catelary";
			this.Load += new System.EventHandler(this.Form_Catelary_Load);
			((System.ComponentModel.ISupportInitialize)(this.txtLoaiSanPham.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton btnThoat;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.SimpleButton btnThemSP;
		private DevExpress.XtraEditors.TextEdit txtLoaiSanPham;
	}
}