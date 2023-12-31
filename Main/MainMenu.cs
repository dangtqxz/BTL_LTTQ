﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_ThiSinhThiDaiHoc
{
	public partial class MainMenu : Form
	{
		Modify md = new Modify();
		HoSoThiSinh hstt = new HoSoThiSinh();
		QLPhongThi qlpt = new QLPhongThi();
		QLDiem qld = new QLDiem();
		TimKiemThiSinh tkts = new TimKiemThiSinh();
		TimKiemDiemThi tkdt = new TimKiemDiemThi();
		ThongKeThiSinh tktsinh = new ThongKeThiSinh();
		DSTop10 tktop10 = new DSTop10();
		DSDiemThi tkdthi = new DSDiemThi();
		DSTrungTuyen DSTrungTuyen = new DSTrungTuyen();
		public MainMenu()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{
			HomeMenu();
			MoFile(hstt);
			HideMenu();
		}

		private void HomeMenu()
		{
			panelTimKiem.Visible = false;
			panelThongKe.Visible = false;
		}

		private void ShowMenu(Panel panel)
		{
			if (panel.Visible == false)
			{
				HideMenu();
				panel.Visible = true;
			}
			else panel.Visible = false;
		}

		private void HideMenu()
		{
			if (panelTimKiem.Visible)
			{
				panelTimKiem.Visible = false;
			}
			if (panelThongKe.Visible)
			{
				panelThongKe.Visible = false;
			}
		}

		private Form activeForm = null;

		private void MoFile(Form form)
		{
			if (activeForm != null)
			{
				activeForm.Close();
			}
			form.TopLevel = false;
			form.FormBorderStyle = FormBorderStyle.None;
			form.Dock = DockStyle.Fill;
			panel_body.Controls.Add(form);
			panel_body.Tag = form;
			form.BringToFront();
			form.Show();
		}

		private void btnQLTS_Click(object sender, EventArgs e)
		{
			MoFile(hstt);
			HideMenu();
		}

		private void btnQLPT_Click(object sender, EventArgs e)
		{
			MoFile(qlpt);
			HideMenu();
		}

		private void btnQLDiem_Click(object sender, EventArgs e)
		{
			DataTable dt = md.LoadData("Select * From DiemThi");
			if (dt.Rows.Count > 0)
			{
				MoFile(qld);
				HideMenu();
			} else
			{
				MessageBox.Show("Vui lòng xếp phòng thi trước khi nhập điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			ShowMenu(panelTimKiem);
		}

		private void btnThongKe_Click(object sender, EventArgs e)
		{
			ShowMenu(panelThongKe);
		}

		private void btnThiSinh_Click(object sender, EventArgs e)
		{
			MoFile(tkts);
			HideMenu();
		}

		private void btnDiemThi_Click(object sender, EventArgs e)
		{
			DataTable dt = md.LoadData("Select * From DiemThi");
			if (dt.Rows.Count > 0)
			{
				MoFile(tkdt);
				HideMenu();
			}
			else
			{
				MessageBox.Show("Vui lòng xếp phòng thi và nhập điểm trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btndstspt_Click(object sender, EventArgs e)
		{
			DataTable dt = md.LoadData("Select * From PhongThi_ThiSinh");
			if (dt.Rows.Count > 0)
			{
				MoFile(tktsinh);
				HideMenu();
			}
			else
			{
				MessageBox.Show("Vui lòng xếp phòng thi trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btntop10_Click(object sender, EventArgs e)
		{
			DataTable dt = md.LoadData("Select * From DiemThi");
			if (dt.Rows.Count > 0)
			{
				MoFile(tktop10);
				HideMenu();
			}
			else
			{
				MessageBox.Show("Vui lòng xếp phòng thi và nhập điểm trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btndstrungtuyen_Click(object sender, EventArgs e)
		{
			DataTable dt = md.LoadData("Select * From DiemThi");
			if (dt.Rows.Count > 0)
			{
				MoFile(DSTrungTuyen);
				HideMenu();
			}
			else
			{
				MessageBox.Show("Vui lòng xếp phòng thi và nhập điểm trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btndsdt_Click(object sender, EventArgs e)
		{
			DataTable dt = md.LoadData("Select * From DiemThi");
			if (dt.Rows.Count > 0)
			{
				MoFile(tkdthi);
				HideMenu();
			}
			else
			{
				MessageBox.Show("Vui lòng xếp phòng thi và nhập điểm trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void guna2PictureBox1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn quay lại trang đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				this.Hide();
				Login form = new Login();
				form.ShowDialog();
				this.Close();
			}
		}

		private void btnDangXuat_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				this.Hide();
				Login form = new Login();
				form.ShowDialog();
				this.Close();
			}
		}
	}
}
