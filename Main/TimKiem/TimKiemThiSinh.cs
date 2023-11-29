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
	public partial class TimKiemThiSinh : Form
	{
		Modify md = new Modify();
		public TimKiemThiSinh()
		{
			InitializeComponent();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtTimKiem.Text = "";
			dgvHienThi.DataSource = null;
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if (txtTimKiem.Text.Trim().Equals(""))
			{
				MessageBox.Show("Hãy nhập thông tin để tìm kiếm");
			}
			else
			{
				DataTable dt = new DataTable();
				string hoten = txtTimKiem.Text.Trim();
				string[] count = hoten.Split(' ');

				if (count.Length > 1)
				{
					string ho = hoten.Substring(0, hoten.LastIndexOf(" "));
					string ten = hoten.Substring(hoten.LastIndexOf(" ") + 1);
					dt = md.LoadData("Select * From HoSoThiSinh Where Ho = N'" + ho + "' And Ten = N'" + ten + "'");
				}

				if (dt.Rows.Count > 0)
				{
					dgvHienThi.DataSource = dt;
				}
				else
				{
					dt = md.LoadData("Select * From HoSoThiSinh Where MaDoiTuong = N'" + txtTimKiem.Text + "'");

					if (dt.Rows.Count > 0)
					{
						dgvHienThi.DataSource = dt;
					}
					else
					{
						dt = md.LoadData("Select * From HoSoThiSinh Where MaNguyenVong = N'" + txtTimKiem.Text + "'");

						if (dt.Rows.Count > 0)
						{
							dgvHienThi.DataSource = dt;
						}
						else
						{
							MessageBox.Show("Không tìm thấy kết quả nào");
						}
					}
				}
			}
		}
	}
}
