namespace BTL_ThiSinhThiDaiHoc
{
	partial class HoSoThiSinh
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
			this.btnRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btnInsert = new Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.dgvHienThi = new Guna.UI2.WinForms.Guna2DataGridView();
			this.SoHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenQue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenUuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenDoiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNguyenVong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
			this.SuspendLayout();
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
			this.btnRefresh.Location = new System.Drawing.Point(278, 50);
			this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(180, 55);
			this.btnRefresh.TabIndex = 18;
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnInsert.Animated = true;
			this.btnInsert.BorderRadius = 10;
			this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInsert.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnInsert.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnInsert.ForeColor = System.Drawing.Color.White;
			this.btnInsert.Location = new System.Drawing.Point(57, 50);
			this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(180, 55);
			this.btnInsert.TabIndex = 11;
			this.btnInsert.Text = "Thêm";
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.guna2Panel1.Controls.Add(this.btnInsert);
			this.guna2Panel1.Controls.Add(this.btnRefresh);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1332, 158);
			this.guna2Panel1.TabIndex = 0;
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
            this.Ho,
            this.Ten,
            this.NgaySinh,
            this.GioiTinh,
            this.TenQue,
            this.TenKhuVuc,
            this.TenUuTien,
            this.TenDoiTuong,
            this.TenNguyenVong,
            this.SoBD,
            this.GhiChu});
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
			this.dgvHienThi.Location = new System.Drawing.Point(0, 158);
			this.dgvHienThi.Margin = new System.Windows.Forms.Padding(4);
			this.dgvHienThi.Name = "dgvHienThi";
			this.dgvHienThi.ReadOnly = true;
			this.dgvHienThi.RowHeadersVisible = false;
			this.dgvHienThi.RowHeadersWidth = 51;
			this.dgvHienThi.RowTemplate.Height = 35;
			this.dgvHienThi.Size = new System.Drawing.Size(1332, 545);
			this.dgvHienThi.TabIndex = 1;
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
			this.dgvHienThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThi_CellClick);
			// 
			// SoHoSo
			// 
			this.SoHoSo.DataPropertyName = "SoHoSo";
			this.SoHoSo.FillWeight = 134.9455F;
			this.SoHoSo.HeaderText = "Số hồ sơ";
			this.SoHoSo.MinimumWidth = 100;
			this.SoHoSo.Name = "SoHoSo";
			this.SoHoSo.ReadOnly = true;
			// 
			// Ho
			// 
			this.Ho.DataPropertyName = "Ho";
			this.Ho.FillWeight = 160.4278F;
			this.Ho.HeaderText = "Họ";
			this.Ho.MinimumWidth = 100;
			this.Ho.Name = "Ho";
			this.Ho.ReadOnly = true;
			// 
			// Ten
			// 
			this.Ten.DataPropertyName = "Ten";
			this.Ten.HeaderText = "Tên";
			this.Ten.MinimumWidth = 200;
			this.Ten.Name = "Ten";
			this.Ten.ReadOnly = true;
			// 
			// NgaySinh
			// 
			this.NgaySinh.DataPropertyName = "NgaySinh";
			this.NgaySinh.HeaderText = "Ngày sinh";
			this.NgaySinh.MinimumWidth = 200;
			this.NgaySinh.Name = "NgaySinh";
			this.NgaySinh.ReadOnly = true;
			// 
			// GioiTinh
			// 
			this.GioiTinh.DataPropertyName = "GioiTinh";
			this.GioiTinh.HeaderText = "Giới tính";
			this.GioiTinh.MinimumWidth = 200;
			this.GioiTinh.Name = "GioiTinh";
			this.GioiTinh.ReadOnly = true;
			// 
			// TenQue
			// 
			this.TenQue.DataPropertyName = "TenQue";
			this.TenQue.HeaderText = "Quê quán";
			this.TenQue.MinimumWidth = 200;
			this.TenQue.Name = "TenQue";
			this.TenQue.ReadOnly = true;
			// 
			// TenKhuVuc
			// 
			this.TenKhuVuc.DataPropertyName = "TenKhuVuc";
			this.TenKhuVuc.HeaderText = "Khu vực";
			this.TenKhuVuc.MinimumWidth = 200;
			this.TenKhuVuc.Name = "TenKhuVuc";
			this.TenKhuVuc.ReadOnly = true;
			// 
			// TenUuTien
			// 
			this.TenUuTien.DataPropertyName = "TenUuTien";
			this.TenUuTien.HeaderText = "Ưu tiên";
			this.TenUuTien.MinimumWidth = 200;
			this.TenUuTien.Name = "TenUuTien";
			this.TenUuTien.ReadOnly = true;
			// 
			// TenDoiTuong
			// 
			this.TenDoiTuong.DataPropertyName = "TenDoiTuong";
			this.TenDoiTuong.HeaderText = "Đối tượng";
			this.TenDoiTuong.MinimumWidth = 200;
			this.TenDoiTuong.Name = "TenDoiTuong";
			this.TenDoiTuong.ReadOnly = true;
			// 
			// TenNguyenVong
			// 
			this.TenNguyenVong.DataPropertyName = "TenNguyenVong";
			this.TenNguyenVong.HeaderText = "Nguyện vọng";
			this.TenNguyenVong.MinimumWidth = 200;
			this.TenNguyenVong.Name = "TenNguyenVong";
			this.TenNguyenVong.ReadOnly = true;
			// 
			// SoBD
			// 
			this.SoBD.DataPropertyName = "SoBD";
			this.SoBD.HeaderText = "Số báo danh";
			this.SoBD.MinimumWidth = 200;
			this.SoBD.Name = "SoBD";
			this.SoBD.ReadOnly = true;
			// 
			// GhiChu
			// 
			this.GhiChu.DataPropertyName = "GhiChu";
			this.GhiChu.HeaderText = "Ghi chú";
			this.GhiChu.MinimumWidth = 500;
			this.GhiChu.Name = "GhiChu";
			this.GhiChu.ReadOnly = true;
			// 
			// HoSoThiSinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1332, 703);
			this.ControlBox = false;
			this.Controls.Add(this.dgvHienThi);
			this.Controls.Add(this.guna2Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "HoSoThiSinh";
			this.ShowIcon = false;
			this.Text = "Hồ sơ thí sinh";
			this.Load += new System.EventHandler(this.HoSoThiSinh_Load);
			this.guna2Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Guna.UI2.WinForms.Guna2GradientButton btnRefresh;
		private Guna.UI2.WinForms.Guna2GradientButton btnInsert;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2DataGridView dgvHienThi;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoHoSo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenQue;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVuc;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenUuTien;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenDoiTuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNguyenVong;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoBD;
		private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
	}
}