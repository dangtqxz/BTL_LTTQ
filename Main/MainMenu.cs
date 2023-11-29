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

		private void btnQLTS_Click(object sender, EventArgs e)
		{
			panel_body.Controls.Clear();
			hstt.TopLevel = false;
			panel_body.Controls.Add(hstt);
			hstt.Dock = DockStyle.Fill;
			hstt.Show();
			HideMenu();
		}

		private void btnQLPT_Click(object sender, EventArgs e)
		{
			panel_body.Controls.Clear();
			qlpt.TopLevel = false;
			panel_body.Controls.Add(qlpt);
			qlpt.Dock = DockStyle.Fill;
			qlpt.Show();
			HideMenu();
		}

		private void btnQLDiem_Click(object sender, EventArgs e)
		{
			panel_body.Controls.Clear();
			qld.TopLevel = false;
			panel_body.Controls.Add(qld);
			qld.Dock = DockStyle.Fill;
			qld.Show();
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
	}
}
