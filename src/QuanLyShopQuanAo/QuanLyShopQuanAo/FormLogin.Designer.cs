
namespace QuanLyShopQuanAo
{
	partial class frmLogin
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(479, 58);
			this.panel1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(159, 18);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(317, 25);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đăng nhập:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(12, 76);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(479, 58);
			this.panel2.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(159, 18);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(317, 25);
			this.textBox2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mật khẩu:";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(171, 140);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(139, 21);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Hiển thị mật khẩu";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(361, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 36);
			this.button1.TabIndex = 4;
			this.button1.Text = "Thoát";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Location = new System.Drawing.Point(12, 167);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(479, 58);
			this.panel3.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(159, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 36);
			this.button2.TabIndex = 5;
			this.button2.Text = "Đăng nhập";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 246);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button2;
	}
}

