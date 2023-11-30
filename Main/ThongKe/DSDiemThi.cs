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
	public partial class DSDiemThi : Form
	{
		Modify md = new Modify();	
		public DSDiemThi()
		{
			InitializeComponent();
		}

		private void DSDiemThi_Load(object sender, EventArgs e)
		{
			cbbPhongthi.Items.Clear();
			DataTable dt = md.LoadData("Select Distinct MaPhongThi From PhongThi_ThiSinh");
			foreach (DataRow i in dt.Rows)
			{
				cbbPhongthi.Items.Add(i["MaPhongThi"].ToString());
			}
			btnXuat.Enabled = false;
		}

		private void cbbPhongthi_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Sửa ở đây
			DataTable dt = md.LoadData("Select Top 10 a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, Case WHEN a.GioiTinh = 1 THEN N'Nam' WHEN a.GioiTinh = 0 THEN N'Nữ' " +
				"End As GioiTinh, b.TenQue, a.SoBD, h.DiemMon1, h.DiemMon2, h.DiemMon3, (c.DiemCong+d.DiemUuTien+e.DiemCong) As DiemCong, " +
				"(h.DiemMon1+h.DiemMon2+h.DiemMon3+c.DiemCong+d.DiemUuTien+e.DiemCong) As TongDiem, " +
				"Case When (h.DiemMon1+h.DiemMon2+h.DiemMon3+c.DiemCong+d.DiemUuTien+e.DiemCong) < g.DiemChuan Then N'Trượt' " +
				"When (h.DiemMon1+h.DiemMon2+h.DiemMon3+c.DiemCong+d.DiemUuTien+e.DiemCong) >= g.DiemChuan Then N'Đỗ' End As Loai From HoSoThiSinh a " +
				"inner join QueQuan b on a.MaQue = b.MaQue inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien " +
				"inner join DoiTuong e on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong " +
				"inner join DiemThi h on a.SoBD = h.SoBD inner join DiemChuan g on a.MaNguyenVong = g.MaNguyenVong" +
				" Where h.MaPhongThi = " + cbbPhongthi.SelectedItem.ToString());
			dgvHienThi.DataSource = dt;
			btnXuat.Enabled = true;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			cbbPhongthi.Items.Clear();
			DataTable dt = md.LoadData("Select Distinct MaPhongThi From PhongThi_ThiSinh");
			foreach (DataRow i in dt.Rows)
			{
				cbbPhongthi.Items.Add(i["MaPhongThi"].ToString());
			}
			dgvHienThi.DataSource = md.LoadData("Select Top 10 a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, Case WHEN a.GioiTinh = 1 THEN N'Nam' WHEN a.GioiTinh = 0 THEN N'Nữ' " +
				"End As GioiTinh, b.TenQue, a.SoBD, h.DiemMon1, h.DiemMon2, h.DiemMon3, (c.DiemCong+d.DiemUuTien+e.DiemCong) As DiemCong, " +
				"(h.DiemMon1+h.DiemMon2+h.DiemMon3+c.DiemCong+d.DiemUuTien+e.DiemCong) As TongDiem, " +
				"Case When (h.DiemMon1+h.DiemMon2+h.DiemMon3+c.DiemCong+d.DiemUuTien+e.DiemCong) < g.DiemChuan Then N'Trượt' " +
				"When (h.DiemMon1+h.DiemMon2+h.DiemMon3+c.DiemCong+d.DiemUuTien+e.DiemCong) >= g.DiemChuan Then N'Đỗ' End As Loai From HoSoThiSinh a " +
				"inner join QueQuan b on a.MaQue = b.MaQue inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien " +
				"inner join DoiTuong e on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong " +
				"inner join DiemThi h on a.SoBD = h.SoBD inner join DiemChuan g on a.MaNguyenVong = g.MaNguyenVong" +
				" Where h.MaPhongThi = ''");
			btnXuat.Enabled = false;
		}

		private void btnXuat_Click(object sender, EventArgs e)
		{

		}
	}
}
