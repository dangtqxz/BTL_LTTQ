namespace BTL_ThiSinhThiDaiHoc
{
	partial class ResetPassword
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
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.lbThongTin = new System.Windows.Forms.Label();
			this.lbDangNhap = new System.Windows.Forms.Label();
			this.lbDangKy = new System.Windows.Forms.Label();
			this.btnResetPW = new Guna.UI2.WinForms.Guna2GradientButton();
			this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.guna2Panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(400, 553);
			this.guna2Panel1.TabIndex = 0;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2PictureBox1.Image = global::BTL_ThiSinhThiDaiHoc.Properties.Resources.logo;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(400, 553);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 2;
			this.guna2PictureBox1.TabStop = false;
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.Controls.Add(this.lbThongTin);
			this.guna2Panel2.Controls.Add(this.lbDangNhap);
			this.guna2Panel2.Controls.Add(this.lbDangKy);
			this.guna2Panel2.Controls.Add(this.btnResetPW);
			this.guna2Panel2.Controls.Add(this.txtEmail);
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.guna2Panel2.Location = new System.Drawing.Point(400, 0);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new System.Drawing.Size(482, 553);
			this.guna2Panel2.TabIndex = 1;
			// 
			// lbThongTin
			// 
			this.lbThongTin.AutoSize = true;
			this.lbThongTin.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbThongTin.ForeColor = System.Drawing.Color.White;
			this.lbThongTin.Location = new System.Drawing.Point(107, 90);
			this.lbThongTin.Name = "lbThongTin";
			this.lbThongTin.Size = new System.Drawing.Size(245, 45);
			this.lbThongTin.TabIndex = 27;
			this.lbThongTin.Text = "Quên mật khẩu";
			// 
			// lbDangNhap
			// 
			this.lbDangNhap.AutoSize = true;
			this.lbDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDangNhap.ForeColor = System.Drawing.Color.White;
			this.lbDangNhap.Location = new System.Drawing.Point(95, 351);
			this.lbDangNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbDangNhap.Name = "lbDangNhap";
			this.lbDangNhap.Size = new System.Drawing.Size(108, 28);
			this.lbDangNhap.TabIndex = 26;
			this.lbDangNhap.Text = "Đăng nhập";
			this.lbDangNhap.Click += new System.EventHandler(this.lbDangNhap_Click);
			// 
			// lbDangKy
			// 
			this.lbDangKy.AutoSize = true;
			this.lbDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDangKy.ForeColor = System.Drawing.Color.White;
			this.lbDangKy.Location = new System.Drawing.Point(260, 351);
			this.lbDangKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbDangKy.Name = "lbDangKy";
			this.lbDangKy.Size = new System.Drawing.Size(84, 28);
			this.lbDangKy.TabIndex = 25;
			this.lbDangKy.Text = "Đăng ký";
			this.lbDangKy.Click += new System.EventHandler(this.lbDangKy_Click);
			// 
			// btnResetPW
			// 
			this.btnResetPW.Animated = true;
			this.btnResetPW.BackColor = System.Drawing.Color.Transparent;
			this.btnResetPW.BorderRadius = 10;
			this.btnResetPW.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnResetPW.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnResetPW.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnResetPW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnResetPW.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnResetPW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnResetPW.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnResetPW.ForeColor = System.Drawing.Color.White;
			this.btnResetPW.Location = new System.Drawing.Point(67, 407);
			this.btnResetPW.Margin = new System.Windows.Forms.Padding(4);
			this.btnResetPW.Name = "btnResetPW";
			this.btnResetPW.Size = new System.Drawing.Size(349, 55);
			this.btnResetPW.TabIndex = 24;
			this.btnResetPW.Text = "Lấy mật khẩu";
			this.btnResetPW.Click += new System.EventHandler(this.btnResetPW_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Animated = true;
			this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
			this.txtEmail.BorderRadius = 6;
			this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEmail.DefaultText = "";
			this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtEmail.ForeColor = System.Drawing.Color.White;
			this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtEmail.Location = new System.Drawing.Point(67, 207);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.PasswordChar = '\0';
			this.txtEmail.PlaceholderText = "Email";
			this.txtEmail.SelectedText = "";
			this.txtEmail.Size = new System.Drawing.Size(349, 44);
			this.txtEmail.TabIndex = 22;
			// 
			// ResetPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.ClientSize = new System.Drawing.Size(882, 553);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.Name = "ResetPassword";
			this.Text = "ResetPassword";
			this.guna2Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
		private System.Windows.Forms.Label lbThongTin;
		private System.Windows.Forms.Label lbDangNhap;
		private System.Windows.Forms.Label lbDangKy;
		private Guna.UI2.WinForms.Guna2GradientButton btnResetPW;
		private Guna.UI2.WinForms.Guna2TextBox txtEmail;
	}
}