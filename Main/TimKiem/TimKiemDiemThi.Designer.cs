namespace BTL_ThiSinhThiDaiHoc
{
	partial class TimKiemDiemThi
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
			this.btnTimKiem = new Guna.UI2.WinForms.Guna2GradientButton();
			this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
			this.dgvHienThi = new Guna.UI2.WinForms.Guna2DataGridView();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.guna2Panel1.Controls.Add(this.btnTimKiem);
			this.guna2Panel1.Controls.Add(this.txtTimKiem);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Controls.Add(this.btnRefresh);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1332, 150);
			this.guna2Panel1.TabIndex = 2;
			// 
			// btnTimKiem
			// 
			this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnTimKiem.Animated = true;
			this.btnTimKiem.BorderRadius = 10;
			this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTimKiem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnTimKiem.ForeColor = System.Drawing.Color.White;
			this.btnTimKiem.Location = new System.Drawing.Point(594, 73);
			this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
			this.btnTimKiem.Name = "btnTimKiem";
			this.btnTimKiem.Size = new System.Drawing.Size(180, 55);
			this.btnTimKiem.TabIndex = 21;
			this.btnTimKiem.Text = "Tìm kiếm";
			this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtTimKiem.Animated = true;
			this.txtTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
			this.txtTimKiem.BorderRadius = 6;
			this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTimKiem.DefaultText = "";
			this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.txtTimKiem.ForeColor = System.Drawing.Color.White;
			this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtTimKiem.Location = new System.Drawing.Point(386, 13);
			this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.PasswordChar = '\0';
			this.txtTimKiem.PlaceholderText = "";
			this.txtTimKiem.SelectedText = "";
			this.txtTimKiem.Size = new System.Drawing.Size(279, 39);
			this.txtTimKiem.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(172, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 25);
			this.label1.TabIndex = 20;
			this.label1.Text = "Thông tin cần tìm kiếm";
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
			this.btnRefresh.Location = new System.Drawing.Point(796, 73);
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
			this.dgvHienThi.Location = new System.Drawing.Point(0, 150);
			this.dgvHienThi.Margin = new System.Windows.Forms.Padding(4);
			this.dgvHienThi.Name = "dgvHienThi";
			this.dgvHienThi.ReadOnly = true;
			this.dgvHienThi.RowHeadersVisible = false;
			this.dgvHienThi.RowHeadersWidth = 51;
			this.dgvHienThi.RowTemplate.Height = 35;
			this.dgvHienThi.Size = new System.Drawing.Size(1332, 553);
			this.dgvHienThi.TabIndex = 3;
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
			// TimKiemDiemThi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1332, 703);
			this.Controls.Add(this.dgvHienThi);
			this.Controls.Add(this.guna2Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TimKiemDiemThi";
			this.Text = "TimKiemDiemThi";
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2GradientButton btnTimKiem;
		private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2GradientButton btnRefresh;
		private Guna.UI2.WinForms.Guna2DataGridView dgvHienThi;
	}
}