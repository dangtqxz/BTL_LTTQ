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
	public partial class HoSoThiSinh : Form
	{
		Modify md = new Modify();
		public HoSoThiSinh()
		{
			InitializeComponent();
		}

		private void HoSoThiSinh_Load(object sender, EventArgs e)
		{
			DataTable tb = md.LoadData("Select a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, Case WHEN a.GioiTinh = 1 THEN N'Nam' WHEN a.GioiTinh = 0 THEN N'Nữ' End As GioiTinh," +
				" b.TenQue, c.TenKhuVuc, d.TenUuTien, e.TenDoiTuong, f.TenNguyenVong, a.SoBD, a.GhiChu From HoSoThiSinh a inner join QueQuan b on a.MaQue = b.MaQue " +
				"inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien inner join DoiTuong e" +
				" on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong " +
				"Order by Cast(SoHoSo as int) ASC");
			dgvHienThi.DataSource = tb;
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			bool editMode = false;
			string idSend = string.Empty;
			ThemSuaXoa frm = new ThemSuaXoa(editMode, idSend);
			frm.ShowDialog();
		}

		private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				bool editMode = true;
				DataGridViewRow selectedRow = dgvHienThi.Rows[e.RowIndex];
				string idSend = selectedRow.Cells["SoHoSo"].Value.ToString();

				ThemSuaXoa frm = new ThemSuaXoa(editMode, idSend);
				frm.ShowDialog();
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			DataTable tb = md.LoadData("Select a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, Case WHEN a.GioiTinh = 1 THEN N'Nam' WHEN a.GioiTinh = 0 THEN N'Nữ' End As GioiTinh, b.TenQue, c.TenKhuVuc, d.TenUuTien, " +
				"e.TenDoiTuong, f.TenNguyenVong, a.SoBD, a.GhiChu From HoSoThiSinh a inner join QueQuan b on a.MaQue = b.MaQue " +
				"inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien inner join DoiTuong e" +
				" on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong " +
				"Order by Cast(SoHoSo as int) ASC");
			dgvHienThi.DataSource = tb;
		}
	}
}
