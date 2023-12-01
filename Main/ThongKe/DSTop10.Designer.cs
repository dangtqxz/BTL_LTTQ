namespace BTL_ThiSinhThiDaiHoc
{
	partial class DSTop10
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.cbbNguyenVong = new Guna.UI2.WinForms.Guna2ComboBox();
			this.btnXuat = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btnXuatTat = new Guna.UI2.WinForms.Guna2GradientButton();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
			this.dgvHienThi = new Guna.UI2.WinForms.Guna2DataGridView();
			this.SoHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenQue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemMon1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemMon2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemMon3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TongDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.guna2Panel1.Controls.Add(this.label2);
			this.guna2Panel1.Controls.Add(this.cbbNguyenVong);
			this.guna2Panel1.Controls.Add(this.btnXuat);
			this.guna2Panel1.Controls.Add(this.btnXuatTat);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Controls.Add(this.btnRefresh);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1332, 200);
			this.guna2Panel1.TabIndex = 4;
			// 
			// cbbNguyenVong
			// 
			this.cbbNguyenVong.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbbNguyenVong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.cbbNguyenVong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
			this.cbbNguyenVong.BorderRadius = 6;
			this.cbbNguyenVong.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbbNguyenVong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbbNguyenVong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbNguyenVong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.cbbNguyenVong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbNguyenVong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbNguyenVong.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.cbbNguyenVong.ForeColor = System.Drawing.Color.White;
			this.cbbNguyenVong.ItemHeight = 30;
			this.cbbNguyenVong.Location = new System.Drawing.Point(504, 77);
			this.cbbNguyenVong.Margin = new System.Windows.Forms.Padding(4);
			this.cbbNguyenVong.Name = "cbbNguyenVong";
			this.cbbNguyenVong.Size = new System.Drawing.Size(494, 36);
			this.cbbNguyenVong.TabIndex = 38;
			this.cbbNguyenVong.SelectedIndexChanged += new System.EventHandler(this.cbbNguyenVong_SelectedIndexChanged);
			// 
			// btnXuat
			// 
			this.btnXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnXuat.Animated = true;
			this.btnXuat.BorderRadius = 10;
			this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXuat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnXuat.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnXuat.ForeColor = System.Drawing.Color.White;
			this.btnXuat.Location = new System.Drawing.Point(675, 134);
			this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
			this.btnXuat.Name = "btnXuat";
			this.btnXuat.Size = new System.Drawing.Size(180, 55);
			this.btnXuat.TabIndex = 22;
			this.btnXuat.Text = "Xuất";
			this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
			// 
			// btnXuatTat
			// 
			this.btnXuatTat.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnXuatTat.Animated = true;
			this.btnXuatTat.BorderRadius = 10;
			this.btnXuatTat.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnXuatTat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnXuatTat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnXuatTat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXuatTat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnXuatTat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnXuatTat.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnXuatTat.ForeColor = System.Drawing.Color.White;
			this.btnXuatTat.Location = new System.Drawing.Point(874, 134);
			this.btnXuatTat.Margin = new System.Windows.Forms.Padding(4);
			this.btnXuatTat.Name = "btnXuatTat";
			this.btnXuatTat.Size = new System.Drawing.Size(180, 55);
			this.btnXuatTat.TabIndex = 21;
			this.btnXuatTat.Text = "Xuất tất cả";
			this.btnXuatTat.Click += new System.EventHandler(this.btnXuatTat_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(367, 88);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 25);
			this.label1.TabIndex = 20;
			this.label1.Text = "Nguyện vọng:";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnRefresh.Animated = true;
			this.btnRefresh.BorderRadius = 10;
			this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnRefresh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnRefresh.ForeColor = System.Drawing.Color.White;
			this.btnRefresh.Location = new System.Drawing.Point(1076, 134);
			this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(180, 55);
			this.btnRefresh.TabIndex = 18;
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// dgvHienThi
			// 
			this.dgvHienThi.AllowUserToAddRows = false;
			this.dgvHienThi.AllowUserToDeleteRows = false;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.dgvHienThi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvHienThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvHienThi.ColumnHeadersHeight = 35;
			this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHoSo,
            this.SoBD,
            this.Ho,
            this.Ten,
            this.NgaySinh,
            this.GioiTinh,
            this.TenQue,
            this.DiemMon1,
            this.DiemMon2,
            this.DiemMon3,
            this.DiemCong,
            this.TongDiem});
			this.dgvHienThi.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvHienThi.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgvHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvHienThi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvHienThi.Location = new System.Drawing.Point(0, 200);
			this.dgvHienThi.Margin = new System.Windows.Forms.Padding(4);
			this.dgvHienThi.Name = "dgvHienThi";
			this.dgvHienThi.ReadOnly = true;
			this.dgvHienThi.RowHeadersVisible = false;
			this.dgvHienThi.RowHeadersWidth = 51;
			this.dgvHienThi.RowTemplate.Height = 35;
			this.dgvHienThi.Size = new System.Drawing.Size(1332, 503);
			this.dgvHienThi.TabIndex = 5;
			this.dgvHienThi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvHienThi.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgvHienThi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgvHienThi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgvHienThi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgvHienThi.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgvHienThi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvHienThi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgvHienThi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgvHienThi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dgvHienThi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgvHienThi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvHienThi.ThemeStyle.HeaderStyle.Height = 35;
			this.dgvHienThi.ThemeStyle.ReadOnly = true;
			this.dgvHienThi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvHienThi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvHienThi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dgvHienThi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvHienThi.ThemeStyle.RowsStyle.Height = 35;
			this.dgvHienThi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvHienThi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// SoHoSo
			// 
			this.SoHoSo.DataPropertyName = "SoHoSo";
			this.SoHoSo.HeaderText = "Số hồ sơ";
			this.SoHoSo.MinimumWidth = 100;
			this.SoHoSo.Name = "SoHoSo";
			this.SoHoSo.ReadOnly = true;
			// 
			// SoBD
			// 
			this.SoBD.DataPropertyName = "SoBD";
			this.SoBD.HeaderText = "Số báo danh";
			this.SoBD.MinimumWidth = 150;
			this.SoBD.Name = "SoBD";
			this.SoBD.ReadOnly = true;
			// 
			// Ho
			// 
			this.Ho.DataPropertyName = "Ho";
			this.Ho.HeaderText = "Họ";
			this.Ho.MinimumWidth = 200;
			this.Ho.Name = "Ho";
			this.Ho.ReadOnly = true;
			// 
			// Ten
			// 
			this.Ten.DataPropertyName = "Ten";
			this.Ten.HeaderText = "Tên";
			this.Ten.MinimumWidth = 100;
			this.Ten.Name = "Ten";
			this.Ten.ReadOnly = true;
			// 
			// NgaySinh
			// 
			this.NgaySinh.DataPropertyName = "NgaySinh";
			this.NgaySinh.HeaderText = "Ngày sinh";
			this.NgaySinh.MinimumWidth = 150;
			this.NgaySinh.Name = "NgaySinh";
			this.NgaySinh.ReadOnly = true;
			// 
			// GioiTinh
			// 
			this.GioiTinh.DataPropertyName = "GioiTinh";
			this.GioiTinh.HeaderText = "Giới tính";
			this.GioiTinh.MinimumWidth = 100;
			this.GioiTinh.Name = "GioiTinh";
			this.GioiTinh.ReadOnly = true;
			// 
			// TenQue
			// 
			this.TenQue.DataPropertyName = "TenQue";
			this.TenQue.HeaderText = "Quê quán";
			this.TenQue.MinimumWidth = 100;
			this.TenQue.Name = "TenQue";
			this.TenQue.ReadOnly = true;
			// 
			// DiemMon1
			// 
			this.DiemMon1.DataPropertyName = "DiemMon1";
			this.DiemMon1.HeaderText = "Điểm môn 1";
			this.DiemMon1.MinimumWidth = 100;
			this.DiemMon1.Name = "DiemMon1";
			this.DiemMon1.ReadOnly = true;
			// 
			// DiemMon2
			// 
			this.DiemMon2.DataPropertyName = "DiemMon2";
			this.DiemMon2.HeaderText = "Điểm môn 2";
			this.DiemMon2.MinimumWidth = 100;
			this.DiemMon2.Name = "DiemMon2";
			this.DiemMon2.ReadOnly = true;
			// 
			// DiemMon3
			// 
			this.DiemMon3.DataPropertyName = "DiemMon3";
			this.DiemMon3.HeaderText = "Điểm môn 3";
			this.DiemMon3.MinimumWidth = 100;
			this.DiemMon3.Name = "DiemMon3";
			this.DiemMon3.ReadOnly = true;
			// 
			// DiemCong
			// 
			this.DiemCong.DataPropertyName = "DiemCong";
			this.DiemCong.HeaderText = "Điểm cộng";
			this.DiemCong.MinimumWidth = 100;
			this.DiemCong.Name = "DiemCong";
			this.DiemCong.ReadOnly = true;
			// 
			// TongDiem
			// 
			this.TongDiem.DataPropertyName = "TongDiem";
			this.TongDiem.HeaderText = "Tổng điểm";
			this.TongDiem.MinimumWidth = 100;
			this.TongDiem.Name = "TongDiem";
			this.TongDiem.ReadOnly = true;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(408, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(484, 46);
			this.label2.TabIndex = 41;
			this.label2.Text = "Danh sách top 10 nguyện vọng";
			// 
			// DSTop10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1332, 703);
			this.Controls.Add(this.dgvHienThi);
			this.Controls.Add(this.guna2Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DSTop10";
			this.Text = "DSTop10";
			this.Load += new System.EventHandler(this.DSTop10_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2ComboBox cbbNguyenVong;
		private Guna.UI2.WinForms.Guna2GradientButton btnXuat;
		private Guna.UI2.WinForms.Guna2GradientButton btnXuatTat;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2GradientButton btnRefresh;
		private Guna.UI2.WinForms.Guna2DataGridView dgvHienThi;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoHoSo;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoBD;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenQue;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemMon1;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemMon2;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemMon3;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemCong;
		private System.Windows.Forms.DataGridViewTextBoxColumn TongDiem;
		private System.Windows.Forms.Label label2;
	}
}