
namespace QuanLyShopQuanAo
{
	partial class frmAdmin
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
			this.tcAdmin = new System.Windows.Forms.TabControl();
			this.tpDoanhThu = new System.Windows.Forms.TabPage();
			this.tpBanHang = new System.Windows.Forms.TabPage();
			this.tpQuanAo = new System.Windows.Forms.TabPage();
			this.tpLoaiQuanAo = new System.Windows.Forms.TabPage();
			this.tpKhachHang = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnThemQA = new System.Windows.Forms.Button();
			this.btnXoaQA = new System.Windows.Forms.Button();
			this.btnSuaQA = new System.Windows.Forms.Button();
			this.btnXemQA = new System.Windows.Forms.Button();
			this.btnTimQA = new System.Windows.Forms.Button();
			this.txtTimQA = new System.Windows.Forms.TextBox();
			this.dtgvQA = new System.Windows.Forms.DataGridView();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtIDQA = new System.Windows.Forms.TextBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtTenQA = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txtGiaBanQA = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cboSizeQA = new System.Windows.Forms.ComboBox();
			this.nmSoLuongQA = new System.Windows.Forms.NumericUpDown();
			this.tcAdmin.SuspendLayout();
			this.tpQuanAo.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvQA)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmSoLuongQA)).BeginInit();
			this.SuspendLayout();
			// 
			// tcAdmin
			// 
			this.tcAdmin.Controls.Add(this.tpDoanhThu);
			this.tcAdmin.Controls.Add(this.tpBanHang);
			this.tcAdmin.Controls.Add(this.tpQuanAo);
			this.tcAdmin.Controls.Add(this.tpLoaiQuanAo);
			this.tcAdmin.Controls.Add(this.tpKhachHang);
			this.tcAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcAdmin.Location = new System.Drawing.Point(0, 0);
			this.tcAdmin.Name = "tcAdmin";
			this.tcAdmin.SelectedIndex = 0;
			this.tcAdmin.Size = new System.Drawing.Size(1064, 681);
			this.tcAdmin.TabIndex = 0;
			// 
			// tpDoanhThu
			// 
			this.tpDoanhThu.Location = new System.Drawing.Point(4, 26);
			this.tpDoanhThu.Name = "tpDoanhThu";
			this.tpDoanhThu.Padding = new System.Windows.Forms.Padding(3);
			this.tpDoanhThu.Size = new System.Drawing.Size(1056, 651);
			this.tpDoanhThu.TabIndex = 0;
			this.tpDoanhThu.Text = "Doanh Thu";
			this.tpDoanhThu.UseVisualStyleBackColor = true;
			// 
			// tpBanHang
			// 
			this.tpBanHang.Location = new System.Drawing.Point(4, 26);
			this.tpBanHang.Name = "tpBanHang";
			this.tpBanHang.Padding = new System.Windows.Forms.Padding(3);
			this.tpBanHang.Size = new System.Drawing.Size(1056, 651);
			this.tpBanHang.TabIndex = 1;
			this.tpBanHang.Text = "Bán Hàng";
			this.tpBanHang.UseVisualStyleBackColor = true;
			// 
			// tpQuanAo
			// 
			this.tpQuanAo.Controls.Add(this.panel4);
			this.tpQuanAo.Controls.Add(this.panel3);
			this.tpQuanAo.Controls.Add(this.panel2);
			this.tpQuanAo.Controls.Add(this.panel1);
			this.tpQuanAo.Location = new System.Drawing.Point(4, 26);
			this.tpQuanAo.Name = "tpQuanAo";
			this.tpQuanAo.Padding = new System.Windows.Forms.Padding(3);
			this.tpQuanAo.Size = new System.Drawing.Size(1056, 651);
			this.tpQuanAo.TabIndex = 2;
			this.tpQuanAo.Text = "Quần Áo";
			this.tpQuanAo.UseVisualStyleBackColor = true;
			// 
			// tpLoaiQuanAo
			// 
			this.tpLoaiQuanAo.Location = new System.Drawing.Point(4, 26);
			this.tpLoaiQuanAo.Name = "tpLoaiQuanAo";
			this.tpLoaiQuanAo.Padding = new System.Windows.Forms.Padding(3);
			this.tpLoaiQuanAo.Size = new System.Drawing.Size(1056, 651);
			this.tpLoaiQuanAo.TabIndex = 3;
			this.tpLoaiQuanAo.Text = "Loại Quần Áo";
			this.tpLoaiQuanAo.UseVisualStyleBackColor = true;
			// 
			// tpKhachHang
			// 
			this.tpKhachHang.Location = new System.Drawing.Point(4, 26);
			this.tpKhachHang.Name = "tpKhachHang";
			this.tpKhachHang.Padding = new System.Windows.Forms.Padding(3);
			this.tpKhachHang.Size = new System.Drawing.Size(1056, 651);
			this.tpKhachHang.TabIndex = 4;
			this.tpKhachHang.Text = "Khách Hàng";
			this.tpKhachHang.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnXemQA);
			this.panel1.Controls.Add(this.btnSuaQA);
			this.panel1.Controls.Add(this.btnXoaQA);
			this.panel1.Controls.Add(this.btnThemQA);
			this.panel1.Location = new System.Drawing.Point(9, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(550, 100);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtTimQA);
			this.panel2.Controls.Add(this.btnTimQA);
			this.panel2.Location = new System.Drawing.Point(565, 7);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(483, 100);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dtgvQA);
			this.panel3.Location = new System.Drawing.Point(9, 114);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(550, 529);
			this.panel3.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel9);
			this.panel4.Controls.Add(this.panel8);
			this.panel4.Controls.Add(this.panel7);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Location = new System.Drawing.Point(565, 114);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(483, 529);
			this.panel4.TabIndex = 3;
			// 
			// btnThemQA
			// 
			this.btnThemQA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThemQA.Location = new System.Drawing.Point(26, 24);
			this.btnThemQA.Name = "btnThemQA";
			this.btnThemQA.Size = new System.Drawing.Size(85, 54);
			this.btnThemQA.TabIndex = 0;
			this.btnThemQA.Text = "Thêm";
			this.btnThemQA.UseVisualStyleBackColor = true;
			// 
			// btnXoaQA
			// 
			this.btnXoaQA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoaQA.Location = new System.Drawing.Point(163, 24);
			this.btnXoaQA.Name = "btnXoaQA";
			this.btnXoaQA.Size = new System.Drawing.Size(85, 54);
			this.btnXoaQA.TabIndex = 1;
			this.btnXoaQA.Text = "Xóa";
			this.btnXoaQA.UseVisualStyleBackColor = true;
			// 
			// btnSuaQA
			// 
			this.btnSuaQA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSuaQA.Location = new System.Drawing.Point(298, 24);
			this.btnSuaQA.Name = "btnSuaQA";
			this.btnSuaQA.Size = new System.Drawing.Size(85, 54);
			this.btnSuaQA.TabIndex = 2;
			this.btnSuaQA.Text = "Sửa";
			this.btnSuaQA.UseVisualStyleBackColor = true;
			// 
			// btnXemQA
			// 
			this.btnXemQA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXemQA.Location = new System.Drawing.Point(435, 24);
			this.btnXemQA.Name = "btnXemQA";
			this.btnXemQA.Size = new System.Drawing.Size(85, 54);
			this.btnXemQA.TabIndex = 3;
			this.btnXemQA.Text = "Xem";
			this.btnXemQA.UseVisualStyleBackColor = true;
			// 
			// btnTimQA
			// 
			this.btnTimQA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimQA.Location = new System.Drawing.Point(362, 24);
			this.btnTimQA.Name = "btnTimQA";
			this.btnTimQA.Size = new System.Drawing.Size(85, 54);
			this.btnTimQA.TabIndex = 1;
			this.btnTimQA.Text = "Tìm Kiếm";
			this.btnTimQA.UseVisualStyleBackColor = true;
			// 
			// txtTimQA
			// 
			this.txtTimQA.Location = new System.Drawing.Point(42, 40);
			this.txtTimQA.Name = "txtTimQA";
			this.txtTimQA.Size = new System.Drawing.Size(274, 25);
			this.txtTimQA.TabIndex = 2;
			// 
			// dtgvQA
			// 
			this.dtgvQA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvQA.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgvQA.Location = new System.Drawing.Point(0, 0);
			this.dtgvQA.Name = "dtgvQA";
			this.dtgvQA.Size = new System.Drawing.Size(550, 529);
			this.dtgvQA.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.txtIDQA);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Location = new System.Drawing.Point(22, 28);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(438, 52);
			this.panel5.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// txtIDQA
			// 
			this.txtIDQA.Location = new System.Drawing.Point(147, 14);
			this.txtIDQA.Name = "txtIDQA";
			this.txtIDQA.Size = new System.Drawing.Size(278, 25);
			this.txtIDQA.TabIndex = 1;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.txtTenQA);
			this.panel6.Controls.Add(this.label2);
			this.panel6.Location = new System.Drawing.Point(22, 86);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(438, 52);
			this.panel6.TabIndex = 1;
			// 
			// txtTenQA
			// 
			this.txtTenQA.Location = new System.Drawing.Point(147, 14);
			this.txtTenQA.Name = "txtTenQA";
			this.txtTenQA.Size = new System.Drawing.Size(278, 25);
			this.txtTenQA.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên Quần Áo";
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.cboSizeQA);
			this.panel7.Controls.Add(this.label3);
			this.panel7.Location = new System.Drawing.Point(22, 144);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(438, 52);
			this.panel7.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Size";
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.nmSoLuongQA);
			this.panel8.Controls.Add(this.label4);
			this.panel8.Location = new System.Drawing.Point(22, 202);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(438, 52);
			this.panel8.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số Lượng";
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.txtGiaBanQA);
			this.panel9.Controls.Add(this.label5);
			this.panel9.Location = new System.Drawing.Point(22, 260);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(438, 52);
			this.panel9.TabIndex = 4;
			// 
			// txtGiaBanQA
			// 
			this.txtGiaBanQA.Location = new System.Drawing.Point(147, 14);
			this.txtGiaBanQA.Name = "txtGiaBanQA";
			this.txtGiaBanQA.Size = new System.Drawing.Size(278, 25);
			this.txtGiaBanQA.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 17);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Giá Bán";
			// 
			// cboSizeQA
			// 
			this.cboSizeQA.FormattingEnabled = true;
			this.cboSizeQA.Location = new System.Drawing.Point(147, 14);
			this.cboSizeQA.Name = "cboSizeQA";
			this.cboSizeQA.Size = new System.Drawing.Size(278, 25);
			this.cboSizeQA.TabIndex = 1;
			// 
			// nmSoLuongQA
			// 
			this.nmSoLuongQA.Location = new System.Drawing.Point(147, 17);
			this.nmSoLuongQA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nmSoLuongQA.Name = "nmSoLuongQA";
			this.nmSoLuongQA.Size = new System.Drawing.Size(278, 25);
			this.nmSoLuongQA.TabIndex = 1;
			this.nmSoLuongQA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// frmAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 681);
			this.Controls.Add(this.tcAdmin);
			this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin";
			this.tcAdmin.ResumeLayout(false);
			this.tpQuanAo.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvQA)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nmSoLuongQA)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tcAdmin;
		private System.Windows.Forms.TabPage tpDoanhThu;
		private System.Windows.Forms.TabPage tpBanHang;
		private System.Windows.Forms.TabPage tpQuanAo;
		private System.Windows.Forms.TabPage tpLoaiQuanAo;
		private System.Windows.Forms.TabPage tpKhachHang;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.TextBox txtGiaBanQA;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.NumericUpDown nmSoLuongQA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.ComboBox cboSizeQA;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox txtTenQA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox txtIDQA;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dtgvQA;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtTimQA;
		private System.Windows.Forms.Button btnTimQA;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnXemQA;
		private System.Windows.Forms.Button btnSuaQA;
		private System.Windows.Forms.Button btnXoaQA;
		private System.Windows.Forms.Button btnThemQA;
	}
}