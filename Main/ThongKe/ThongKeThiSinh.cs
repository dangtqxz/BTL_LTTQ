using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BTL_ThiSinhThiDaiHoc
{
	public partial class ThongKeThiSinh : Form
	{
		Modify md = new Modify();
		public ThongKeThiSinh()
		{
			InitializeComponent();
		}

		private void ThongKeThiSinh_Load(object sender, EventArgs e)
		{
			cbbPhongthi.Items.Clear();
			DataTable dt = md.LoadData("Select Distinct MaPhongThi From PhongThi_ThiSinh");
			foreach (DataRow i in dt.Rows)
			{
				cbbPhongthi.Items.Add(i["MaPhongThi"].ToString());
			}
			btnXuat.Enabled = false;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			cbbPhongthi.Items.Clear();
			DataTable dt = md.LoadData("Select Distinct MaPhongThi From PhongThi_ThiSinh");
			foreach (DataRow i in dt.Rows)
			{
				cbbPhongthi.Items.Add(i["MaPhongThi"].ToString());
			}
			dgvHienThi.DataSource = null;
			btnXuat.Enabled = false;
		}

		private void cbbPhongthi_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = md.LoadData("Select a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, a.GioiTinh, b.TenQue, c.TenKhuVuc, d.TenUuTien, " +
				"e.TenDoiTuong, f.TenNguyenVong, a.SoBD, a.GhiChu From HoSoThiSinh a inner join QueQuan b on a.MaQue = b.MaQue " +
				"inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien inner join DoiTuong e" +
				" on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong inner join Phongthi_ThiSinh g on a.SoBD = g.SoBD" +
				" Where g.MaPhongThi = " + cbbPhongthi.SelectedItem.ToString());
			dgvHienThi.DataSource = dt;
			btnXuat.Enabled = true;
		}

		private void btnXuat_Click(object sender, EventArgs e)
		{
			Excel.Application exApp = new Excel.Application();
			Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
			Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
			Excel.Range tenvung = (Excel.Range)exSheet.Cells[1, 1];
			tenvung.Font.Name = "Arial"; tenvung.Font.Size = 16;
			tenvung.Font.Color = Color.Red;
			tenvung.Value = "DANH SÁCH THÍ SINH PHÒNG THI " + cbbPhongthi.SelectedItem.ToString();
			exSheet.get_Range("A1:C1").Merge(true);


			exSheet.get_Range("A2:G2").Font.Size = 14;
			exSheet.get_Range("A2:G2").Font.Bold = true;
			exSheet.get_Range("A2").Value = "STT";
			exSheet.get_Range("B2").Value = "Số hồ sơ";
			exSheet.get_Range("C2").Value = "Họ";
			exSheet.get_Range("D2").Value = "Tên";
			exSheet.get_Range("E2").Value = "Giới tính";
			exSheet.get_Range("F2").Value = "Ngày sinh";
			exSheet.get_Range("G2").Value = "Số báo danh";
			exSheet.get_Range("A2:G2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

			int k = dgvHienThi.Rows.Count;
			exSheet.get_Range("A2:G" + (k + 2).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
			exSheet.Columns["A"].ColumnWidth = 9;
			exSheet.Columns["B"].ColumnWidth = 15;
			exSheet.Columns["C"].ColumnWidth = 20;
			exSheet.Columns["D"].ColumnWidth = 20;
			exSheet.Columns["E"].ColumnWidth = 15;
			exSheet.Columns["F"].ColumnWidth = 15;
			exSheet.Columns["G"].ColumnWidth = 15;
			for (int i = 0; i < dgvHienThi.Rows.Count; i++)
			{
				exSheet.get_Range("A" + (3 + i).ToString()).Value = (i + 1).ToString();
				exSheet.get_Range("B" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[1].Value.ToString();
				exSheet.get_Range("C" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[2].Value.ToString();
				exSheet.get_Range("D" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[3].Value.ToString();
				exSheet.get_Range("E" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[4].Value.ToString();
				exSheet.get_Range("F" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[5].Value.ToString();
				exSheet.get_Range("G" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[6].Value.ToString();
			}
			exBook.Activate();
			SaveFileDialog svf = new SaveFileDialog();
			svf.Title = "Chọn nơi lưu File";
			svf.ShowDialog();
			string filename = svf.FileName;
			if (filename == "")
			{
				MessageBox.Show("Bạn chưa đặt tên file");
				return;
			}
			exBook.SaveAs(filename);
			exApp.Quit();
		}

		private void btnXuatTat_Click(object sender, EventArgs e)
		{
			DataTable dt = md.LoadData("Select Distinct MaPhongThi From PhongThi_ThiSinh");
			int tab = 0;

			Excel.Application exApp = new Excel.Application();
			Excel.Workbook exBook = exApp.Workbooks.Add();
			Excel.Sheets exSheets = exBook.Worksheets;

			foreach (DataRow item in dt.Rows)
			{
				tab++;
				Excel.Worksheet exSheet = (Excel.Worksheet)exSheets.Add();
				exSheet.Name = "Phòng thi " + item["MaPhongThi"].ToString();

				Excel.Range tenvung = (Excel.Range)exSheet.Cells[1, 1];
				tenvung.Font.Name = "Arial";
				tenvung.Font.Size = 16;
				tenvung.Font.Color = Color.Red;
				tenvung.Value = "DANH SÁCH THÍ SINH PHÒNG THI " + item["MaPhongThi"].ToString();
				exSheet.get_Range("A1:E1").Merge(true);

				exSheet.get_Range("A2:G2").Font.Size = 14;
				exSheet.get_Range("A2:G2").Font.Bold = true;
				exSheet.get_Range("A2").Value = "STT";
				exSheet.get_Range("B2").Value = "Số hồ sơ";
				exSheet.get_Range("C2").Value = "Họ";
				exSheet.get_Range("D2").Value = "Tên";
				exSheet.get_Range("E2").Value = "Giới tính";
				exSheet.get_Range("F2").Value = "Ngày sinh";
				exSheet.get_Range("G2").Value = "Số báo danh";
				exSheet.get_Range("A2:G2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

				DataTable tb = md.LoadData("Select b.MaPhongThi, a.SoHoSo, a.Ho, a.Ten, Case WHEN a.GioiTinh = 1 THEN N'Nam' WHEN a.GioiTinh = 0 THEN N'Nữ' " +
				"End As GioiTinh, a.NgaySinh, a.SoBD From HoSoThiSinh a inner join Phongthi_ThiSinh b on a.SoBD = b.SoBD" +
				" Where b.MaPhongThi = " + item["MaPhongThi"].ToString());
				int k = tb.Rows.Count;
				exSheet.get_Range("A2:G" + (k + 2).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				exSheet.Columns["A"].ColumnWidth = 9;
				exSheet.Columns["B"].ColumnWidth = 15;
				exSheet.Columns["C"].ColumnWidth = 20;
				exSheet.Columns["D"].ColumnWidth = 20;
				exSheet.Columns["E"].ColumnWidth = 15;
				exSheet.Columns["F"].ColumnWidth = 15;
				exSheet.Columns["G"].ColumnWidth = 15;

				for (int i = 0; i < tb.Rows.Count; i++)
				{
					exSheet.get_Range("A" + (3 + i).ToString()).Value = (i + 1).ToString();
					exSheet.get_Range("B" + (3 + i).ToString()).Value = tb.Rows[i][1].ToString();
					exSheet.get_Range("C" + (3 + i).ToString()).Value = tb.Rows[i][2].ToString();
					exSheet.get_Range("D" + (3 + i).ToString()).Value = tb.Rows[i][3].ToString();
					exSheet.get_Range("E" + (3 + i).ToString()).Value = tb.Rows[i][4].ToString();
					exSheet.get_Range("F" + (3 + i).ToString()).Value = tb.Rows[i][5].ToString();
					exSheet.get_Range("G" + (3 + i).ToString()).Value = tb.Rows[i][6].ToString();
				}
			}


			exBook.Activate();
			SaveFileDialog svf = new SaveFileDialog();
			svf.Title = "Chọn nơi lưu File";
			svf.ShowDialog();
			string filename = svf.FileName;
			if (filename == "")
			{
				MessageBox.Show("Bạn chưa đặt tên file");
				return;
			}
			exBook.SaveAs(filename);
			exApp.Quit();
		}
	}
}
