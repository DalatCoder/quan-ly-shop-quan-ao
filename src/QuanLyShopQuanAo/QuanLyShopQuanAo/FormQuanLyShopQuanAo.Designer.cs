namespace QuanLyShopQuanAo
{
	partial class fQLShopQuanAo
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmChucNang = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.btnXoaBoLoc = new System.Windows.Forms.Button();
			this.btnTaiLaiDS = new System.Windows.Forms.Button();
			this.dgvQuanAo = new System.Windows.Forms.DataGridView();
			this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
			this.btnThem = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.lvDonHang = new System.Windows.Forms.ListView();
			this.btnThanhToan = new System.Windows.Forms.Button();
			this.btnHuyDon = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpNgayMua = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMaDon = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.nmGiamGia = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTongTienDaGiamGia = new System.Windows.Forms.TextBox();
			this.tsmThemQA = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmXoaBoLoc = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmTaiLaiDS = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmThanhToan = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmHuyDon = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmDangXuat = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuanAo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdmin,
            this.tsmChucNang});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmAdmin
			// 
			this.tsmAdmin.Name = "tsmAdmin";
			this.tsmAdmin.Size = new System.Drawing.Size(55, 20);
			this.tsmAdmin.Text = "Admin";
			this.tsmAdmin.Click += new System.EventHandler(this.tsmAdmin_Click);
			// 
			// tsmChucNang
			// 
			this.tsmChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmThemQA,
            this.tsmXoaBoLoc,
            this.tsmTaiLaiDS,
            this.tsmThanhToan,
            this.tsmHuyDon,
            this.tsmDangXuat});
			this.tsmChucNang.Name = "tsmChucNang";
			this.tsmChucNang.Size = new System.Drawing.Size(77, 20);
			this.tsmChucNang.Text = "Chức năng";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.nmSoLuong);
			this.groupBox1.Controls.Add(this.btnTaiLaiDS);
			this.groupBox1.Controls.Add(this.btnXoaBoLoc);
			this.groupBox1.Controls.Add(this.txtTimKiem);
			this.groupBox1.Location = new System.Drawing.Point(0, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(524, 92);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm nhanh quần áo theo mã hoặc tên";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvQuanAo);
			this.groupBox2.Location = new System.Drawing.Point(0, 125);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(524, 443);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách quần áo hiện có";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtSDT);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.txtHoTen);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new System.Drawing.Point(530, 27);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(534, 92);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thông tin khách hàng";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lvDonHang);
			this.groupBox4.Location = new System.Drawing.Point(530, 125);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(534, 443);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Thông tin đơn hàng";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txtTongTienDaGiamGia);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.txtTongTien);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.nmGiamGia);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Controls.Add(this.txtMaDon);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Controls.Add(this.dtpNgayMua);
			this.groupBox5.Controls.Add(this.label3);
			this.groupBox5.Controls.Add(this.btnHuyDon);
			this.groupBox5.Controls.Add(this.btnThanhToan);
			this.groupBox5.Location = new System.Drawing.Point(0, 574);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(1064, 95);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Thông tin thanh toán";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(12, 25);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(297, 26);
			this.txtTimKiem.TabIndex = 0;
			// 
			// btnXoaBoLoc
			// 
			this.btnXoaBoLoc.Location = new System.Drawing.Point(12, 57);
			this.btnXoaBoLoc.Name = "btnXoaBoLoc";
			this.btnXoaBoLoc.Size = new System.Drawing.Size(135, 25);
			this.btnXoaBoLoc.TabIndex = 1;
			this.btnXoaBoLoc.Text = "Xóa bộ lọc";
			this.btnXoaBoLoc.UseVisualStyleBackColor = true;
			// 
			// btnTaiLaiDS
			// 
			this.btnTaiLaiDS.Location = new System.Drawing.Point(174, 56);
			this.btnTaiLaiDS.Name = "btnTaiLaiDS";
			this.btnTaiLaiDS.Size = new System.Drawing.Size(135, 26);
			this.btnTaiLaiDS.TabIndex = 2;
			this.btnTaiLaiDS.Text = "Tải lại danh sách";
			this.btnTaiLaiDS.UseVisualStyleBackColor = true;
			// 
			// dgvQuanAo
			// 
			this.dgvQuanAo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvQuanAo.BackgroundColor = System.Drawing.Color.White;
			this.dgvQuanAo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvQuanAo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvQuanAo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvQuanAo.Location = new System.Drawing.Point(3, 22);
			this.dgvQuanAo.MultiSelect = false;
			this.dgvQuanAo.Name = "dgvQuanAo";
			this.dgvQuanAo.ReadOnly = true;
			this.dgvQuanAo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
			this.dgvQuanAo.Size = new System.Drawing.Size(518, 418);
			this.dgvQuanAo.TabIndex = 0;
			// 
			// nmSoLuong
			// 
			this.nmSoLuong.Location = new System.Drawing.Point(315, 25);
			this.nmSoLuong.Name = "nmSoLuong";
			this.nmSoLuong.Size = new System.Drawing.Size(57, 26);
			this.nmSoLuong.TabIndex = 3;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(378, 26);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(140, 25);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "Thêm quần áo";
			this.btnThem.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Họ tên *:";
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(79, 24);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(194, 26);
			this.txtHoTen.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(279, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "SĐT *:";
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(334, 24);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(194, 26);
			this.txtSDT.TabIndex = 7;
			// 
			// lvDonHang
			// 
			this.lvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvDonHang.FullRowSelect = true;
			this.lvDonHang.GridLines = true;
			this.lvDonHang.Location = new System.Drawing.Point(3, 22);
			this.lvDonHang.MultiSelect = false;
			this.lvDonHang.Name = "lvDonHang";
			this.lvDonHang.Size = new System.Drawing.Size(528, 418);
			this.lvDonHang.TabIndex = 0;
			this.lvDonHang.UseCompatibleStateImageBehavior = false;
			this.lvDonHang.View = System.Windows.Forms.View.Details;
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.Location = new System.Drawing.Point(865, 16);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(95, 73);
			this.btnThanhToan.TabIndex = 5;
			this.btnThanhToan.Text = "Thanh toán";
			this.btnThanhToan.UseVisualStyleBackColor = true;
			// 
			// btnHuyDon
			// 
			this.btnHuyDon.Location = new System.Drawing.Point(966, 16);
			this.btnHuyDon.Name = "btnHuyDon";
			this.btnHuyDon.Size = new System.Drawing.Size(95, 73);
			this.btnHuyDon.TabIndex = 6;
			this.btnHuyDon.Text = "Hủy đơn";
			this.btnHuyDon.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "Ngày mua:";
			// 
			// dtpNgayMua
			// 
			this.dtpNgayMua.Location = new System.Drawing.Point(94, 19);
			this.dtpNgayMua.Name = "dtpNgayMua";
			this.dtpNgayMua.Size = new System.Drawing.Size(194, 26);
			this.dtpNgayMua.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(294, 22);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 18);
			this.label4.TabIndex = 9;
			this.label4.Text = "Mã đơn:";
			// 
			// txtMaDon
			// 
			this.txtMaDon.Location = new System.Drawing.Point(366, 19);
			this.txtMaDon.Name = "txtMaDon";
			this.txtMaDon.Size = new System.Drawing.Size(194, 26);
			this.txtMaDon.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(566, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 18);
			this.label5.TabIndex = 11;
			this.label5.Text = "Giảm giá(%):";
			// 
			// nmGiamGia
			// 
			this.nmGiamGia.Location = new System.Drawing.Point(672, 20);
			this.nmGiamGia.Name = "nmGiamGia";
			this.nmGiamGia.Size = new System.Drawing.Size(66, 26);
			this.nmGiamGia.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 62);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 18);
			this.label6.TabIndex = 13;
			this.label6.Text = "Tổng tiền:";
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(94, 59);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.Size = new System.Drawing.Size(194, 26);
			this.txtTongTien.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(294, 62);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(170, 18);
			this.label7.TabIndex = 15;
			this.label7.Text = "Tổng tiền sau giảm giá:";
			// 
			// txtTongTienDaGiamGia
			// 
			this.txtTongTienDaGiamGia.Location = new System.Drawing.Point(470, 59);
			this.txtTongTienDaGiamGia.Name = "txtTongTienDaGiamGia";
			this.txtTongTienDaGiamGia.Size = new System.Drawing.Size(194, 26);
			this.txtTongTienDaGiamGia.TabIndex = 16;
			// 
			// tsmThemQA
			// 
			this.tsmThemQA.Name = "tsmThemQA";
			this.tsmThemQA.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.tsmThemQA.Size = new System.Drawing.Size(249, 22);
			this.tsmThemQA.Text = "Thêm quần áo";
			// 
			// tsmXoaBoLoc
			// 
			this.tsmXoaBoLoc.Name = "tsmXoaBoLoc";
			this.tsmXoaBoLoc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.tsmXoaBoLoc.Size = new System.Drawing.Size(249, 22);
			this.tsmXoaBoLoc.Text = "Xóa bộ lọc hiện thời";
			// 
			// tsmTaiLaiDS
			// 
			this.tsmTaiLaiDS.Name = "tsmTaiLaiDS";
			this.tsmTaiLaiDS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.tsmTaiLaiDS.Size = new System.Drawing.Size(249, 22);
			this.tsmTaiLaiDS.Text = "Tải lại danh sách quần áo";
			// 
			// tsmThanhToan
			// 
			this.tsmThanhToan.Name = "tsmThanhToan";
			this.tsmThanhToan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.tsmThanhToan.Size = new System.Drawing.Size(249, 22);
			this.tsmThanhToan.Text = "Thanh toán";
			// 
			// tsmHuyDon
			// 
			this.tsmHuyDon.Name = "tsmHuyDon";
			this.tsmHuyDon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
			this.tsmHuyDon.Size = new System.Drawing.Size(249, 22);
			this.tsmHuyDon.Text = "Hủy đơn";
			// 
			// tsmDangXuat
			// 
			this.tsmDangXuat.Name = "tsmDangXuat";
			this.tsmDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.tsmDangXuat.Size = new System.Drawing.Size(249, 22);
			this.tsmDangXuat.Text = "Đăng xuất";
			this.tsmDangXuat.Click += new System.EventHandler(this.tsmDangXuat_Click);
			// 
			// fQLShopQuanAo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1064, 681);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "fQLShopQuanAo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý cửa hàng quần áo";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuanAo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmGiamGia)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmAdmin;
		private System.Windows.Forms.ToolStripMenuItem tsmChucNang;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btnXoaBoLoc;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTaiLaiDS;
		private System.Windows.Forms.DataGridView dgvQuanAo;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.NumericUpDown nmSoLuong;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.ListView lvDonHang;
		private System.Windows.Forms.Button btnHuyDon;
		private System.Windows.Forms.Button btnThanhToan;
		private System.Windows.Forms.NumericUpDown nmGiamGia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaDon;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox dtpNgayMua;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTongTienDaGiamGia;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ToolStripMenuItem tsmThemQA;
		private System.Windows.Forms.ToolStripMenuItem tsmXoaBoLoc;
		private System.Windows.Forms.ToolStripMenuItem tsmTaiLaiDS;
		private System.Windows.Forms.ToolStripMenuItem tsmThanhToan;
		private System.Windows.Forms.ToolStripMenuItem tsmHuyDon;
		private System.Windows.Forms.ToolStripMenuItem tsmDangXuat;
	}
}