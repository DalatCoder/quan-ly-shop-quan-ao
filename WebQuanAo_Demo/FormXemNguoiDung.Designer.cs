namespace WebQuanAo_Demo
{
    partial class FormXemNguoiDung
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
			this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tsslTotal = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslVIP = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslNormal = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseTextOptions = true;
			this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.Location = new System.Drawing.Point(0, 20);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(808, 33);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Danh sách người dùng hiện có";
			// 
			// dgvNguoiDung
			// 
			this.dgvNguoiDung.AllowUserToAddRows = false;
			this.dgvNguoiDung.AllowUserToDeleteRows = false;
			this.dgvNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNguoiDung.BackgroundColor = System.Drawing.Color.Azure;
			this.dgvNguoiDung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNguoiDung.Location = new System.Drawing.Point(20, 80);
			this.dgvNguoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvNguoiDung.MultiSelect = false;
			this.dgvNguoiDung.Name = "dgvNguoiDung";
			this.dgvNguoiDung.RowHeadersWidth = 51;
			this.dgvNguoiDung.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgvNguoiDung.Size = new System.Drawing.Size(764, 549);
			this.dgvNguoiDung.TabIndex = 1;
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotal,
            this.tsslVIP,
            this.tsslNormal});
			this.statusStrip1.Location = new System.Drawing.Point(0, 633);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(808, 55);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tsslTotal
			// 
			this.tsslTotal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsslTotal.Margin = new System.Windows.Forms.Padding(20);
			this.tsslTotal.Name = "tsslTotal";
			this.tsslTotal.Size = new System.Drawing.Size(127, 15);
			this.tsslTotal.Text = "Tổng số khách hàng: 2";
			// 
			// tsslVIP
			// 
			this.tsslVIP.Margin = new System.Windows.Forms.Padding(20);
			this.tsslVIP.Name = "tsslVIP";
			this.tsslVIP.Size = new System.Drawing.Size(117, 15);
			this.tsslVIP.Text = "Số khách hàng VIP: 1";
			// 
			// tsslNormal
			// 
			this.tsslNormal.Margin = new System.Windows.Forms.Padding(20);
			this.tsslNormal.Name = "tsslNormal";
			this.tsslNormal.Size = new System.Drawing.Size(139, 15);
			this.tsslNormal.Text = "Số khách hàng thường: 1";
			// 
			// FormXemNguoiDung
			// 
			this.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Appearance.Options.UseFont = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.dgvNguoiDung);
			this.Controls.Add(this.labelControl1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FormXemNguoiDung";
			this.Size = new System.Drawing.Size(808, 688);
			this.Load += new System.EventHandler(this.FormXemNguoiDung_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsslTotal;
		private System.Windows.Forms.ToolStripStatusLabel tsslVIP;
		private System.Windows.Forms.ToolStripStatusLabel tsslNormal;
	}
}