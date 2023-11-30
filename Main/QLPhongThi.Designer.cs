namespace BTL_ThiSinhThiDaiHoc
{
	partial class QLPhongThi
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
			this.label4 = new System.Windows.Forms.Label();
			this.cbbSoPhongThi = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSoThiSinh = new Guna.UI2.WinForms.Guna2TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnInsert = new Guna.UI2.WinForms.Guna2GradientButton();
			this.dgvHienThi = new Guna.UI2.WinForms.Guna2DataGridView();
			this.MaPhongThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoThiSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
			this.SuspendLayout();
			// 
			// panel_body
			// 
			this.panel_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.panel_body.Controls.Add(this.label4);
			this.panel_body.Controls.Add(this.cbbSoPhongThi);
			this.panel_body.Controls.Add(this.label2);
			this.panel_body.Controls.Add(this.txtSoThiSinh);
			this.panel_body.Controls.Add(this.label1);
			this.panel_body.Controls.Add(this.btnInsert);
			this.panel_body.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel_body.Location = new System.Drawing.Point(0, 0);
			this.panel_body.Name = "panel_body";
			this.panel_body.Size = new System.Drawing.Size(1332, 300);
			this.panel_body.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label4.Location = new System.Drawing.Point(792, 232);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 28);
			this.label4.TabIndex = 38;
			this.label4.Text = "Mã phòng thi:";
			// 
			// cbbSoPhongThi
			// 
			this.cbbSoPhongThi.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbbSoPhongThi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.cbbSoPhongThi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
			this.cbbSoPhongThi.BorderRadius = 6;
			this.cbbSoPhongThi.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbbSoPhongThi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbbSoPhongThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbSoPhongThi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.cbbSoPhongThi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbSoPhongThi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbbSoPhongThi.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.cbbSoPhongThi.ForeColor = System.Drawing.Color.White;
			this.cbbSoPhongThi.ItemHeight = 30;
			this.cbbSoPhongThi.Location = new System.Drawing.Point(964, 224);
			this.cbbSoPhongThi.Margin = new System.Windows.Forms.Padding(4);
			this.cbbSoPhongThi.Name = "cbbSoPhongThi";
			this.cbbSoPhongThi.Size = new System.Drawing.Size(305, 36);
			this.cbbSoPhongThi.TabIndex = 37;
			this.cbbSoPhongThi.SelectedIndexChanged += new System.EventHandler(this.cbbSoPhongThi_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(522, 9);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(289, 46);
			this.label2.TabIndex = 24;
			this.label2.Text = "Quản lý phòng thi";
			// 
			// txtSoThiSinh
			// 
			this.txtSoThiSinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtSoThiSinh.Animated = true;
			this.txtSoThiSinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
			this.txtSoThiSinh.BorderRadius = 6;
			this.txtSoThiSinh.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSoThiSinh.DefaultText = "";
			this.txtSoThiSinh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSoThiSinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSoThiSinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSoThiSinh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSoThiSinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
			this.txtSoThiSinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSoThiSinh.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.txtSoThiSinh.ForeColor = System.Drawing.Color.White;
			this.txtSoThiSinh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSoThiSinh.Location = new System.Drawing.Point(332, 113);
			this.txtSoThiSinh.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.txtSoThiSinh.Name = "txtSoThiSinh";
			this.txtSoThiSinh.PasswordChar = '\0';
			this.txtSoThiSinh.PlaceholderText = "";
			this.txtSoThiSinh.SelectedText = "";
			this.txtSoThiSinh.Size = new System.Drawing.Size(307, 44);
			this.txtSoThiSinh.TabIndex = 22;
			this.txtSoThiSinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoThiSinh_KeyPress);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(69, 116);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 28);
			this.label1.TabIndex = 23;
			this.label1.Text = "Số thí sinh một phòng thi:";
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
			this.btnInsert.Location = new System.Drawing.Point(74, 179);
			this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(180, 55);
			this.btnInsert.TabIndex = 21;
			this.btnInsert.Text = "Xếp phòng thi";
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.MaPhongThi,
            this.SoBD,
            this.SoThiSinh});
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
			this.dgvHienThi.Location = new System.Drawing.Point(0, 300);
			this.dgvHienThi.Margin = new System.Windows.Forms.Padding(4);
			this.dgvHienThi.Name = "dgvHienThi";
			this.dgvHienThi.ReadOnly = true;
			this.dgvHienThi.RowHeadersVisible = false;
			this.dgvHienThi.RowHeadersWidth = 51;
			this.dgvHienThi.RowTemplate.Height = 35;
			this.dgvHienThi.Size = new System.Drawing.Size(1332, 403);
			this.dgvHienThi.TabIndex = 2;
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
			// MaPhongThi
			// 
			this.MaPhongThi.DataPropertyName = "MaPhongThi";
			this.MaPhongThi.HeaderText = "Mã phòng thi";
			this.MaPhongThi.MinimumWidth = 6;
			this.MaPhongThi.Name = "MaPhongThi";
			this.MaPhongThi.ReadOnly = true;
			// 
			// SoBD
			// 
			this.SoBD.DataPropertyName = "SoBD";
			this.SoBD.HeaderText = "Số báo danh";
			this.SoBD.MinimumWidth = 6;
			this.SoBD.Name = "SoBD";
			this.SoBD.ReadOnly = true;
			// 
			// SoThiSinh
			// 
			this.SoThiSinh.DataPropertyName = "SoThiSinh";
			this.SoThiSinh.HeaderText = "Số thí sinh";
			this.SoThiSinh.MinimumWidth = 6;
			this.SoThiSinh.Name = "SoThiSinh";
			this.SoThiSinh.ReadOnly = true;
			// 
			// QLPhongThi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1332, 703);
			this.Controls.Add(this.dgvHienThi);
			this.Controls.Add(this.panel_body);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "QLPhongThi";
			this.Text = "QLPhongThi";
			this.Load += new System.EventHandler(this.QLPhongThi_Load);
			this.panel_body.ResumeLayout(false);
			this.panel_body.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel panel_body;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txtSoThiSinh;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2GradientButton btnInsert;
		private Guna.UI2.WinForms.Guna2DataGridView dgvHienThi;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2ComboBox cbbSoPhongThi;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongThi;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoBD;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoThiSinh;
	}
}