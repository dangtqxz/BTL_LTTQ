﻿using System;
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
	public partial class DSTop10 : Form
	{
		Modify md = new Modify();
		public DSTop10()
		{
			InitializeComponent();
		}

		private void DSTop10_Load(object sender, EventArgs e)
		{
			cbbNguyenVong.Items.Clear();
			DataTable dt = md.LoadData("Select Distinct TenNguyenVong From NguyenVong");
			foreach (DataRow i in dt.Rows)
			{
				cbbNguyenVong.Items.Add(i["TenNguyenVong"].ToString());
			}
			btnXuat.Enabled = false;
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

		private void cbbNguyenVong_SelectedIndexChanged(object sender, EventArgs e)
		{
			string ma = layma(cbbNguyenVong.Text.ToString());
			DataTable dt = md.LoadData("Select Top 10 a.SoHoSo, a.SoBD, a.Ho, a.Ten, a.NgaySinh, Case WHEN a.GioiTinh = 1 THEN N'Nam'" +
				" WHEN a.GioiTinh = 0 THEN N'Nữ' End As GioiTinh, (c.DiemMon1+c.DiemMon2+c.DiemMon3) As TongDiem From HoSoThiSinh a" +
				" inner join NguyenVong b on a.MaNguyenVong = b.MaNguyenVong inner join DiemThi c on a.SoBD = c.SoBD " +
				"Where a.MaNguyenVong = '" + ma + "' Order by TongDiem DESC");
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

		private void btnXuat_Click(object sender, EventArgs e)
		{
			Excel.Application exApp = new Excel.Application();
			Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
			Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
			Excel.Range tenvung = (Excel.Range)exSheet.Cells[1, 1];
			tenvung.Font.Name = "Arial"; tenvung.Font.Size = 16;
			tenvung.Font.Color = Color.Red;
			tenvung.Value = "DANH SÁCH TOP 10 THÍ SINH " + cbbNguyenVong.SelectedItem.ToString();
			exSheet.get_Range("A1:E1").Merge(true);


			exSheet.get_Range("A2:G2").Font.Size = 14;
			exSheet.get_Range("A2:G2").Font.Bold = true;
			exSheet.get_Range("A2").Value = "STT";
			exSheet.get_Range("B2").Value = "Số hồ sơ";
			exSheet.get_Range("C2").Value = "Số báo danh";
			exSheet.get_Range("D2").Value = "Họ";
			exSheet.get_Range("E2").Value = "Tên";
			exSheet.get_Range("F2").Value = "Ngày sinh";
			exSheet.get_Range("G2").Value = "Giới tính";
			exSheet.get_Range("H2").Value = "Tổng điểm";
			exSheet.get_Range("A2:H2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

			int k = dgvHienThi.Rows.Count;
			exSheet.get_Range("A2:H" + (k + 2).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
			exSheet.Columns["A"].ColumnWidth = 9;
			exSheet.Columns["B"].ColumnWidth = 15;
			exSheet.Columns["C"].ColumnWidth = 20;
			exSheet.Columns["D"].ColumnWidth = 20;
			exSheet.Columns["E"].ColumnWidth = 15;
			exSheet.Columns["F"].ColumnWidth = 15;
			exSheet.Columns["G"].ColumnWidth = 15;
			exSheet.Columns["H"].ColumnWidth = 15;
			for (int i = 0; i < dgvHienThi.Rows.Count; i++)
			{
				exSheet.get_Range("A" + (3 + i).ToString()).Value = (i + 1).ToString();
				exSheet.get_Range("B" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[0].Value.ToString();
				exSheet.get_Range("C" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[1].Value.ToString();
				exSheet.get_Range("D" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[2].Value.ToString();
				exSheet.get_Range("E" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[3].Value.ToString();
				exSheet.get_Range("F" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[4].Value.ToString();
				exSheet.get_Range("G" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[5].Value.ToString();
				exSheet.get_Range("H" + (3 + i).ToString()).Value = dgvHienThi.Rows[i].Cells[6].Value.ToString();
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
			DataTable dt = md.LoadData("Select Distinct * From NguyenVong");
			int tab = 0;

			Excel.Application exApp = new Excel.Application();
			Excel.Workbook exBook = exApp.Workbooks.Add();
			Excel.Sheets exSheets = exBook.Worksheets;

			foreach (DataRow item in dt.Rows)
			{
				tab++;
				Excel.Worksheet exSheet = (Excel.Worksheet)exSheets.Add();
				exSheet.Name = item["MaNguyenVong"].ToString();

				Excel.Range tenvung = (Excel.Range)exSheet.Cells[1, 1];
				tenvung.Font.Name = "Arial";
				tenvung.Font.Size = 16;
				tenvung.Font.Color = Color.Red;
				tenvung.Value = "DANH SÁCH TOP 10  " + item["TenNguyenVong"].ToString();
				exSheet.get_Range("A1:H1").Merge(true);

				exSheet.get_Range("A2:G2").Font.Size = 14;
				exSheet.get_Range("A2:G2").Font.Bold = true;
				exSheet.get_Range("A2").Value = "STT";
				exSheet.get_Range("B2").Value = "Số hồ sơ";
				exSheet.get_Range("C2").Value = "Số báo danh";
				exSheet.get_Range("D2").Value = "Họ";
				exSheet.get_Range("E2").Value = "Tên";
				exSheet.get_Range("F2").Value = "Ngày sinh";
				exSheet.get_Range("G2").Value = "Giới tính";
				exSheet.get_Range("H2").Value = "Tổng điểm";
				exSheet.get_Range("A2:H2").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

				string ma = item["MaNguyenVong"].ToString();
				DataTable tb = md.LoadData("Select Top 10 a.SoHoSo, a.SoBD, a.Ho, a.Ten, a.NgaySinh, Case WHEN a.GioiTinh = 1 THEN N'Nam'" +
					" WHEN a.GioiTinh = 0 THEN N'Nữ' End As GioiTinh, (c.DiemMon1+c.DiemMon2+c.DiemMon3) As TongDiem From HoSoThiSinh a" +
					" inner join NguyenVong b on a.MaNguyenVong = b.MaNguyenVong inner join DiemThi c on a.SoBD = c.SoBD " +
					"Where a.MaNguyenVong = '" + ma + "' Order by TongDiem DESC");
				int k = tb.Rows.Count;
				exSheet.get_Range("A2:H" + (k + 2).ToString()).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
				exSheet.Columns["A"].ColumnWidth = 9;
				exSheet.Columns["B"].ColumnWidth = 15;
				exSheet.Columns["C"].ColumnWidth = 20;
				exSheet.Columns["D"].ColumnWidth = 20;
				exSheet.Columns["E"].ColumnWidth = 15;
				exSheet.Columns["F"].ColumnWidth = 15;
				exSheet.Columns["G"].ColumnWidth = 15;
				exSheet.Columns["H"].ColumnWidth = 15;
				
				for (int i = 0; i < tb.Rows.Count; i++)
				{
					exSheet.get_Range("A" + (3 + i).ToString()).Value = (i + 1).ToString();
					exSheet.get_Range("B" + (3 + i).ToString()).Value = tb.Rows[i][0].ToString();
					exSheet.get_Range("C" + (3 + i).ToString()).Value = tb.Rows[i][1].ToString();
					exSheet.get_Range("D" + (3 + i).ToString()).Value = tb.Rows[i][2].ToString();
					exSheet.get_Range("E" + (3 + i).ToString()).Value = tb.Rows[i][3].ToString();
					exSheet.get_Range("F" + (3 + i).ToString()).Value = tb.Rows[i][4].ToString();
					exSheet.get_Range("G" + (3 + i).ToString()).Value = tb.Rows[i][5].ToString();
					exSheet.get_Range("H" + (3 + i).ToString()).Value = tb.Rows[i][6].ToString();
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