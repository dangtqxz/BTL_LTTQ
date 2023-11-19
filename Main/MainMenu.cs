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
		public MainMenu()
		{
			InitializeComponent();
		}

		private void btnQLTS_Click(object sender, EventArgs e)
		{
			panel_body.Controls.Clear();
			hstt.TopLevel = false;
			panel_body.Controls.Add(hstt);
			hstt.Dock = DockStyle.Fill;
			hstt.Show();
		}
	}
}
