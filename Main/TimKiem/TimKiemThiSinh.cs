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
					dt = md.LoadData("Select a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, Case WHEN a.GioiTinh = 1 THEN N'Nam' WHEN a.GioiTinh = 0 THEN N'Nữ' End As GioiTinh, " +
						"b.TenQue, c.TenKhuVuc, d.TenUuTien, e.TenDoiTuong, f.TenNguyenVong, a.SoBD, a.GhiChu From HoSoThiSinh a inner join QueQuan b on a.MaQue = b.MaQue " +
						"inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien inner join DoiTuong e" +
						" on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong Where Ho = N'" + ho + "' And Ten = N'" + ten + "' " +
						"Order by Cast(a.SoHoSo as int) ASC");
				}

				if (dt.Rows.Count > 0)
				{
					dgvHienThi.DataSource = dt;
				}
				else
				{
					dt = md.LoadData("Select a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, Case WHEN a.GioiTinh = 1 THEN N'Nam' WHEN a.GioiTinh = 0 THEN N'Nữ' End As GioiTinh, b.TenQue, c.TenKhuVuc, d.TenUuTien, " +
						"e.TenDoiTuong, f.TenNguyenVong, a.SoBD, a.GhiChu From HoSoThiSinh a inner join QueQuan b on a.MaQue = b.MaQue " +
						"inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien inner join DoiTuong e" +
						" on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong Where a.MaDoiTuong = '" + txtTimKiem.Text + "' Order by Cast(a.SoHoSo as int) ASC");

					if (dt.Rows.Count > 0)
					{
						dgvHienThi.DataSource = dt;
					}
					else
					{
						dt = md.LoadData("Select a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, Case WHEN a.GioiTinh = 1 THEN N'Nam' WHEN a.GioiTinh = 0 THEN N'Nữ' End As GioiTinh, b.TenQue, c.TenKhuVuc, d.TenUuTien, " +
						"e.TenDoiTuong, f.TenNguyenVong, a.SoBD, a.GhiChu From HoSoThiSinh a inner join QueQuan b on a.MaQue = b.MaQue " +
						"inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien inner join DoiTuong e" +
						" on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong Where a.MaNguyenVong = '" + txtTimKiem.Text + "' Order by Cast(a.SoHoSo as int) ASC");

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
