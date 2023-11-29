using System;
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
		HoSoThiSinh hstt = new HoSoThiSinh();
		QLPhongThi qlpt = new QLPhongThi();
		QLDiem qld = new QLDiem();
		TimKiemThiSinh tkts = new TimKiemThiSinh();
		TimKiemDiemThi tkdt = new TimKiemDiemThi();
		public MainMenu()
		{
			InitializeComponent();
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{
			HomeMenu();
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
			MoFile(qld);
			HideMenu();
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
			MoFile(tkdt);
			HideMenu();
		}
	}
}
