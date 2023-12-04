namespace BTL_ThiSinhThiDaiHoc
{
	partial class QLDiem
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel_body = new Guna.UI2.WinForms.Guna2Panel();
			this.btnLamLai = new Guna.UI2.WinForms.Guna2GradientButton();
			this.label4 = new System.Windows.Forms.Label();
			this.cbbMaPhongThi = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvHienThi = new Guna.UI2.WinForms.Guna2DataGridView();
			this.SoBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaPhongThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemMon1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemMon2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiemMon3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_body
			// 
			this.panel_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.panel_body.Controls.Add(this.btnLamLai);
			this.panel_body.Controls.Add(this.label4);
			this.panel_body.Controls.Add(this.cbbMaPhongThi);
			this.panel_body.Controls.Add(this.label2);
			this.panel_body.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_body.Location = new System.Drawing.Point(0, 0);
			this.panel_body.Name = "panel_body";
			this.panel_body.Size = new System.Drawing.Size(1332, 200);
			this.panel_body.TabIndex = 1;
			// 
			// btnLamLai
			// 
			this.btnLamLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnLamLai.Animated = true;
			this.btnLamLai.BorderRadius = 10;
			this.btnLamLai.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLamLai.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.btnLamLai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnLamLai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnLamLai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLamLai.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnLamLai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnLamLai.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.btnLamLai.ForeColor = System.Drawing.Color.White;
			this.btnLamLai.Location = new System.Drawing.Point(1099, 13);
			this.btnLamLai.Margin = new System.Windows.Forms.Padding(4);
			this.btnLamLai.Name = "btnLamLai";
			this.btnLamLai.Size = new System.Drawing.Size(180, 55);
			this.btnLamLai.TabIndex = 40;
			this.btnLamLai.Text = "Hiển thị tất cả";
			this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new System.Drawing.Point(802, 111);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 28);
			this.label4.TabIndex = 38;
			this.label4.Text = "Mã phòng thi:";
			// 
			// cbbMaPhongThi
			// 
			this.cbbMaPhongThi.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbbMaPhongThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.cbbMaPhongThi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
			this.cbbMaPhongThi.BorderRadius = 6;
			this.cbbMaPhongThi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbbMaPhongThi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbbMaPhongThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbMaPhongThi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.cbbMaPhongThi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbMaPhongThi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbMaPhongThi.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.cbbMaPhongThi.ForeColor = System.Drawing.Color.White;
			this.cbbMaPhongThi.ItemHeight = 30;
			this.cbbMaPhongThi.Location = new System.Drawing.Point(974, 103);
			this.cbbMaPhongThi.Margin = new System.Windows.Forms.Padding(4);
			this.cbbMaPhongThi.Name = "cbbMaPhongThi";
			this.cbbMaPhongThi.Size = new System.Drawing.Size(305, 36);
			this.cbbMaPhongThi.TabIndex = 37;
			this.cbbMaPhongThi.SelectedIndexChanged += new System.EventHandler(this.cbbMaPhongThi_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(525, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(266, 46);
			this.label2.TabIndex = 24;
			this.label2.Text = "Quản lý điểm thi";
			// 
			// dgvHienThi
			// 
			this.dgvHienThi.AllowUserToAddRows = false;
			this.dgvHienThi.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvHienThi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvHienThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvHienThi.ColumnHeadersHeight = 35;
			this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgvHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoBD,
            this.MaPhongThi,
            this.DiemMon1,
            this.DiemMon2,
            this.DiemMon3});
			this.dgvHienThi.Cursor = System.Windows.Forms.Cursors.Default;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvHienThi.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvHienThi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvHienThi.Location = new System.Drawing.Point(0, 200);
			this.dgvHienThi.Margin = new System.Windows.Forms.Padding(4);
			this.dgvHienThi.Name = "dgvHienThi";
			this.dgvHienThi.RowHeadersVisible = false;
			this.dgvHienThi.RowHeadersWidth = 51;
			this.dgvHienThi.RowTemplate.Height = 35;
			this.dgvHienThi.Size = new System.Drawing.Size(1332, 503);
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
			this.dgvHienThi.ThemeStyle.ReadOnly = false;
			this.dgvHienThi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgvHienThi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvHienThi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.dgvHienThi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvHienThi.ThemeStyle.RowsStyle.Height = 35;
			this.dgvHienThi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgvHienThi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgvHienThi.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThi_CellEndEdit);
			this.dgvHienThi.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvHienThi_CellValidating);
			// 
			// SoBD
			// 
			this.SoBD.DataPropertyName = "SoBD";
			this.SoBD.HeaderText = "Số báo danh";
			this.SoBD.MinimumWidth = 6;
			this.SoBD.Name = "SoBD";
			// 
			// MaPhongThi
			// 
			this.MaPhongThi.DataPropertyName = "MaPhongThi";
			this.MaPhongThi.HeaderText = "Mã phòng thi";
			this.MaPhongThi.MinimumWidth = 6;
			this.MaPhongThi.Name = "MaPhongThi";
			// 
			// DiemMon1
			// 
			this.DiemMon1.DataPropertyName = "DiemMon1";
			this.DiemMon1.HeaderText = "Điểm môn 1";
			this.DiemMon1.MinimumWidth = 6;
			this.DiemMon1.Name = "DiemMon1";
			// 
			// DiemMon2
			// 
			this.DiemMon2.DataPropertyName = "DiemMon2";
			this.DiemMon2.HeaderText = "Điểm môn 2";
			this.DiemMon2.MinimumWidth = 6;
			this.DiemMon2.Name = "DiemMon2";
			// 
			// DiemMon3
			// 
			this.DiemMon3.DataPropertyName = "DiemMon3";
			this.DiemMon3.HeaderText = "Điểm môn 3";
			this.DiemMon3.MinimumWidth = 6;
			this.DiemMon3.Name = "DiemMon3";
			// 
			// QLDiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1332, 703);
			this.Controls.Add(this.dgvHienThi);
			this.Controls.Add(this.panel_body);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "QLDiem";
			this.Text = "QLDiem";
			this.Load += new System.EventHandler(this.QLDiem_Load);
			this.panel_body.ResumeLayout(false);
			this.panel_body.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel panel_body;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2ComboBox cbbMaPhongThi;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2DataGridView dgvHienThi;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoBD;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongThi;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemMon1;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemMon2;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiemMon3;
		private Guna.UI2.WinForms.Guna2GradientButton btnLamLai;
	}
}