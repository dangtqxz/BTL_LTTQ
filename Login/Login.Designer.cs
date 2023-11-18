namespace BTL_ThiSinhThiDaiHoc
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbThongTin = new System.Windows.Forms.Label();
			this.lbDangKy = new System.Windows.Forms.Label();
			this.lbQuenMK = new System.Windows.Forms.Label();
			this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
			this.txtMatkhau = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtTendangnhap = new Guna.UI2.WinForms.Guna2TextBox();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Panel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
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
			// panel1
			// 
			this.panel1.Controls.Add(this.lbThongTin);
			this.panel1.Controls.Add(this.lbDangKy);
			this.panel1.Controls.Add(this.lbQuenMK);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.txtMatkhau);
			this.panel1.Controls.Add(this.txtTendangnhap);
			this.panel1.Location = new System.Drawing.Point(400, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(482, 553);
			this.panel1.TabIndex = 1;
			// 
			// lbThongTin
			// 
			this.lbThongTin.AutoSize = true;
			this.lbThongTin.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbThongTin.ForeColor = System.Drawing.Color.White;
			this.lbThongTin.Location = new System.Drawing.Point(146, 85);
			this.lbThongTin.Name = "lbThongTin";
			this.lbThongTin.Size = new System.Drawing.Size(187, 45);
			this.lbThongTin.TabIndex = 21;
			this.lbThongTin.Text = "Đăng Nhập";
			// 
			// lbDangKy
			// 
			this.lbDangKy.AutoSize = true;
			this.lbDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDangKy.ForeColor = System.Drawing.Color.White;
			this.lbDangKy.Location = new System.Drawing.Point(97, 346);
			this.lbDangKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbDangKy.Name = "lbDangKy";
			this.lbDangKy.Size = new System.Drawing.Size(84, 28);
			this.lbDangKy.TabIndex = 20;
			this.lbDangKy.Text = "Đăng ký";
			this.lbDangKy.Click += new System.EventHandler(this.lbDangKy_Click);
			// 
			// lbQuenMK
			// 
			this.lbQuenMK.AutoSize = true;
			this.lbQuenMK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbQuenMK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbQuenMK.ForeColor = System.Drawing.Color.White;
			this.lbQuenMK.Location = new System.Drawing.Point(262, 346);
			this.lbQuenMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbQuenMK.Name = "lbQuenMK";
			this.lbQuenMK.Size = new System.Drawing.Size(145, 28);
			this.lbQuenMK.TabIndex = 19;
			this.lbQuenMK.Text = "Quên mật khẩu";
			this.lbQuenMK.Click += new System.EventHandler(this.lbQuenMK_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Animated = true;
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.BorderRadius = 10;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(69, 402);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(349, 55);
			this.btnLogin.TabIndex = 18;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtMatkhau
			// 
			this.txtMatkhau.Animated = true;
			this.txtMatkhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
			this.txtMatkhau.BorderRadius = 6;
			this.txtMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMatkhau.DefaultText = "";
			this.txtMatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMatkhau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.txtMatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMatkhau.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtMatkhau.ForeColor = System.Drawing.Color.White;
			this.txtMatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMatkhau.Location = new System.Drawing.Point(69, 271);
			this.txtMatkhau.Margin = new System.Windows.Forms.Padding(5);
			this.txtMatkhau.Name = "txtMatkhau";
			this.txtMatkhau.PasswordChar = '*';
			this.txtMatkhau.PlaceholderText = "Mật khẩu";
			this.txtMatkhau.SelectedText = "";
			this.txtMatkhau.Size = new System.Drawing.Size(349, 44);
			this.txtMatkhau.TabIndex = 17;
			// 
			// txtTendangnhap
			// 
			this.txtTendangnhap.Animated = true;
			this.txtTendangnhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
			this.txtTendangnhap.BorderRadius = 6;
			this.txtTendangnhap.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTendangnhap.DefaultText = "";
			this.txtTendangnhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTendangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTendangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTendangnhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTendangnhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.txtTendangnhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTendangnhap.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtTendangnhap.ForeColor = System.Drawing.Color.White;
			this.txtTendangnhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTendangnhap.Location = new System.Drawing.Point(69, 196);
			this.txtTendangnhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTendangnhap.Name = "txtTendangnhap";
			this.txtTendangnhap.PasswordChar = '\0';
			this.txtTendangnhap.PlaceholderText = "Tên đăng nhập";
			this.txtTendangnhap.SelectedText = "";
			this.txtTendangnhap.Size = new System.Drawing.Size(349, 44);
			this.txtTendangnhap.TabIndex = 16;
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.guna2PictureBox1.Image = global::BTL_ThiSinhThiDaiHoc.Properties.Resources.logo;
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(400, 553);
			this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2PictureBox1.TabIndex = 0;
			this.guna2PictureBox1.TabStop = false;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.ClientSize = new System.Drawing.Size(882, 553);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.guna2Panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Login";
			this.guna2Panel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Panel panel1;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private System.Windows.Forms.Label lbThongTin;
		private System.Windows.Forms.Label lbDangKy;
		private System.Windows.Forms.Label lbQuenMK;
		private Guna.UI2.WinForms.Guna2GradientButton btnLogin;
		private Guna.UI2.WinForms.Guna2TextBox txtMatkhau;
		private Guna.UI2.WinForms.Guna2TextBox txtTendangnhap;
	}
}