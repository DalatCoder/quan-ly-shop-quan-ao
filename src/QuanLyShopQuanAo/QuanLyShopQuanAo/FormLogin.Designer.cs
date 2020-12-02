
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
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbShowPass = new System.Windows.Forms.CheckBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtUserName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(479, 58);
			this.panel1.TabIndex = 0;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(159, 18);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(317, 25);
			this.txtUserName.TabIndex = 1;
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
			this.panel2.Controls.Add(this.txtPass);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(12, 76);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(479, 58);
			this.panel2.TabIndex = 2;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(159, 18);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(317, 25);
			this.txtPass.TabIndex = 1;
			this.txtPass.UseSystemPasswordChar = true;
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
			// cbShowPass
			// 
			this.cbShowPass.AutoSize = true;
			this.cbShowPass.Location = new System.Drawing.Point(171, 140);
			this.cbShowPass.Name = "cbShowPass";
			this.cbShowPass.Size = new System.Drawing.Size(139, 21);
			this.cbShowPass.TabIndex = 3;
			this.cbShowPass.Text = "Hiển thị mật khẩu";
			this.cbShowPass.UseVisualStyleBackColor = true;
			this.cbShowPass.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
			// 
			// btnExit
			// 
			this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Location = new System.Drawing.Point(361, 12);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(115, 36);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnLogin);
			this.panel3.Controls.Add(this.btnExit);
			this.panel3.Location = new System.Drawing.Point(12, 167);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(479, 58);
			this.panel3.TabIndex = 5;
			// 
			// btnLogin
			// 
			this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Location = new System.Drawing.Point(159, 12);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(115, 36);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(506, 246);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.cbShowPass);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
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
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cbShowPass;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnLogin;
	}
}

