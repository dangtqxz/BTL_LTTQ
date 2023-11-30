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
	public partial class DSTrungTuyen : Form
	{
		Modify md = new Modify();
		public DSTrungTuyen()
		{
			InitializeComponent();
		}

		private void DSTrungTuyen_Load(object sender, EventArgs e)
		{
			cbbNguyenVong.Items.Clear();
			DataTable dt = md.LoadData("Select Distinct TenNguyenVong From NguyenVong");
			foreach (DataRow i in dt.Rows)
			{
				cbbNguyenVong.Items.Add(i["TenNguyenVong"].ToString());
			}
			btnXuat.Enabled = false;
		}

		private void cbbNguyenVong_SelectedIndexChanged(object sender, EventArgs e)
		{
			string ma = layma(cbbNguyenVong.Text.ToString());
			DataTable top = md.LoadData("Select * From DiemChuan Where MaNguyenVong = '" + ma + "'");
			string topvalue = top.Rows[0]["ChiTieu"].ToString();
			MessageBox.Show(topvalue);
			DataTable dt = md.LoadData("Select Top " + topvalue + " a.SoHoSo, a.SoBD, a.Ho, a.Ten, Case WHEN a.GioiTinh = 1 THEN N'Nam' WHEN a.GioiTinh = 0 THEN N'Nữ' " +
				"End As GioiTinh, a.NgaySinh, b.TenQue,  h.DiemMon1, h.DiemMon2, h.DiemMon3, (c.DiemCong+d.DiemUuTien+e.DiemCong) As DiemCong, " +
				"(h.DiemMon1+h.DiemMon2+h.DiemMon3+c.DiemCong+d.DiemUuTien+e.DiemCong) As TongDiem From HoSoThiSinh a inner join QueQuan b on a.MaQue = b.MaQue " +
				"inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien inner join DoiTuong e on a.MaDoiTuong = e.MaDoiTuong " +
				"inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong inner join DiemThi h on a.SoBD = h.SoBD inner join DiemChuan g on a.MaNguyenVong = g.MaNguyenVong " +
				"Where a.MaNguyenVong = '" + ma + "' and (h.DiemMon1+h.DiemMon2+h.DiemMon3+c.DiemCong+d.DiemUuTien+e.DiemCong) >= g.DiemChuan Order by TongDiem DESC");
			dgvHienThi.DataSource = dt;
			if (dt.Rows.Count > 0)
			{
				btnXuat.Enabled = true;
			}
		}

		private string layma(string ten)
		{
			string sql = $"SELECT MaNguyenVong FROM NguyenVong WHERE TenNguyenVong = N'{ten}'";
			DataTable result = md.LoadData(sql);
			if (result.Rows.Count > 0)
			{
				return result.Rows[0]["MaNguyenVong"].ToString();
			}
			return null;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			cbbNguyenVong.Items.Clear();
			DataTable dt = md.LoadData("Select Distinct TenNguyenVong From NguyenVong");
			foreach (DataRow i in dt.Rows)
			{
				cbbNguyenVong.Items.Add(i["TenNguyenVong"].ToString());
			}
			dgvHienThi.DataSource = null;
			btnXuat.Enabled = false;
		}
	}
}
