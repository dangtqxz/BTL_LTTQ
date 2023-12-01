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
	public partial class ThemSuaXoa : Form
	{
		Modify md = new Modify();
		private bool _editMode = false;
		private string _key = null;
		public ThemSuaXoa(bool editMode, string key)
		{
			InitializeComponent();
			_editMode = editMode;
			_key = key;
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void ThemSuaXoa_Load(object sender, EventArgs e)
		{
			DataTable dt = md.LoadData("Select Distinct TenDoiTuong From DoiTuong");
			foreach (DataRow i in dt.Rows)
			{
				cbbMaDT.Items.Add(i["TenDoiTuong"].ToString());
			}

			dt = md.LoadData("Select Distinct TenKhuVuc From KhuVuc");
			foreach (DataRow i in dt.Rows)
			{
				cbbMaKV.Items.Add(i["TenKhuVuc"].ToString());
			}

			dt = md.LoadData("Select Distinct TenNguyenVong From NguyenVong");
			foreach (DataRow i in dt.Rows)
			{
				cbbMaNV.Items.Add(i["TenNguyenVong"].ToString());
			}

			dt = md.LoadData("Select Distinct TenQue From QueQuan");
			foreach (DataRow i in dt.Rows)
			{
				cbbMaQue.Items.Add(i["TenQue"].ToString());
			}

			dt = md.LoadData("Select Distinct TenUuTien From UuTien");
			foreach (DataRow i in dt.Rows)
			{
				cbbMaUT.Items.Add(i["TenUuTien"].ToString());
			}

			if (_editMode == false)
			{
				label_Main.Text = "Thêm";

				txtSBD.Enabled = false;
				btnMoi.Enabled = true;
				btnSua.Enabled = false;
				btnXoa.Enabled = false;
				btnRefresh.Enabled = true;
				btnSinhSBD.Enabled = true;


			} else
			{
				label_Main.Text = "Sửa Hoặc Xóa";

				DataTable tb = md.LoadData("Select a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, a.GioiTinh, b.TenQue, c.TenKhuVuc, d.TenUuTien, " +
				"e.TenDoiTuong, f.TenNguyenVong, a.SoBD, a.GhiChu From HoSoThiSinh a inner join QueQuan b on a.MaQue = b.MaQue " +
				"inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien inner join DoiTuong e" +
				" on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong Where a.SoHoSo = '" + _key + "'");

				txtSoHoSo.Text = tb.Rows[0]["SoHoSo"].ToString();
				txtHoTen.Text = tb.Rows[0]["Ho"].ToString() + " " + tb.Rows[0]["Ten"].ToString();
				if (tb.Rows[0]["GioiTinh"].ToString() == "True")
				{
					rdbNam.Checked = true;
					rdbNu.Checked = false;
				} else
				{
					rdbNam.Checked = false;
					rdbNu.Checked = true;
				}
				dtpNgaySinh.Value = Convert.ToDateTime(tb.Rows[0]["NgaySinh"].ToString());
				//txtSBD.Text = tb.Rows[0]["SoBD"].ToString();

				string cellValue = tb.Rows[0]["TenQue"].ToString();
				int index = cbbMaQue.Items.IndexOf(cellValue);
				cbbMaQue.SelectedIndex = index;

				cellValue = tb.Rows[0]["TenKhuVuc"].ToString();
				index = cbbMaKV.Items.IndexOf(cellValue);
				cbbMaKV.SelectedIndex = index;

				cellValue = tb.Rows[0]["TenUuTien"].ToString();
				index = cbbMaUT.Items.IndexOf(cellValue);
				cbbMaUT.SelectedIndex = index;

				cellValue = tb.Rows[0]["TenDoiTuong"].ToString();
				index = cbbMaDT.Items.IndexOf(cellValue);
				cbbMaDT.SelectedIndex = index;

				cellValue = tb.Rows[0]["TenNguyenVong"].ToString();
				index = cbbMaNV.Items.IndexOf(cellValue);
				cbbMaNV.SelectedIndex = index;

				txtGhiChu.Text = tb.Rows[0]["GhiChu"].ToString();

				txtSBD.Enabled = false;
				txtSoHoSo.Enabled = false;
				btnMoi.Enabled = false;
				btnRefresh.Enabled = false;
				btnSua.Enabled = true;
				btnXoa.Enabled = true;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSinhSBD_Click(object sender, EventArgs e)
		{
			if (_editMode == false)
			{
				if (txtHoTen.Text.Trim().Equals(""))
				{
					MessageBox.Show("Hãy nhập Họ và tên");
					txtHoTen.Focus();
					return;
				}
				DataTable tb = new DataTable();
				tb = md.LoadData("Select a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, a.GioiTinh, b.TenQue, c.TenKhuVuc, d.TenUuTien, " +
					"e.TenDoiTuong, f.TenNguyenVong, a.SoBD, a.GhiChu From HoSoThiSinh a inner join QueQuan b on a.MaQue = b.MaQue " +
					"inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien " +
					"inner join DoiTuong e on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong");

				int sbd = 1;
				DataRow newRow = tb.NewRow();

				string input = txtHoTen.Text;
				string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				if (words.Length < 2)
				{
					MessageBox.Show("Hãy nhập đủ Họ và tên");
					txtHoTen.Focus();
					return;
				}

				string ht = txtHoTen.Text;

				int i = ht.LastIndexOf(" ");

				string ten = ht.Substring(i + 1);
				string ho = ht.Substring(0, i);

				newRow["Ho"] = ho;
				newRow["Ten"] = ten;
				newRow["SoBD"] = sbd;
				tb.Rows.Add(newRow);

				tb.DefaultView.Sort = "Ten ASC, Ho ASC";
				tb = tb.DefaultView.ToTable();

				foreach (DataRow dr in tb.Rows)
				{
					dr["SoBD"] = sbd;
					if (dr["SoHoSo"].ToString() != "")
					{
						md.Command("Update HoSoThiSinh Set SoBD = '" + sbd + "' Where SoHoSo = '" + dr["SoHoSo"].ToString() + "'");
					}
					else
					{
						txtSBD.Text = sbd.ToString();
					}
					sbd++;
				}
			} else
			{
				if (txtHoTen.Text.Trim().Equals(""))
				{
					MessageBox.Show("Hãy nhập Họ và tên");
					txtHoTen.Focus();
					return;
				}

				DataTable tb = new DataTable();
				tb = md.LoadData("Select a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, a.GioiTinh, b.TenQue, c.TenKhuVuc, d.TenUuTien, " +
					"e.TenDoiTuong, f.TenNguyenVong, a.SoBD, a.GhiChu From HoSoThiSinh a inner join QueQuan b on a.MaQue = b.MaQue " +
					"inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien " +
					"inner join DoiTuong e on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong");
				string ht = txtHoTen.Text;

				int i = ht.LastIndexOf(" ");

				string ten = ht.Substring(i + 1);
				string ho = ht.Substring(0, i);

				string ma = txtSoHoSo.Text;
				
				foreach(DataRow item in tb.Rows)
				{
					if (item["SoHoSo"].ToString() == ma)
					{
						item["Ho"] = ho;
						item["Ten"] = ten;
						MessageBox.Show(item["Ho"].ToString());
					} 
				}

				tb.DefaultView.Sort = "Ten ASC, Ho ASC";
				tb = tb.DefaultView.ToTable();
				int sbd = 1;
				foreach (DataRow dr in tb.Rows)
				{
					dr["SoBD"] = sbd;
					if (dr["SoHoSo"].ToString() != ma)
					{
						md.Command("Update HoSoThiSinh Set SoBD = '" + sbd + "' Where SoHoSo = '" + dr["SoHoSo"].ToString() + "'");
					}
					else
					{
						txtSBD.Text = sbd.ToString();
					}
					sbd++;
				}
			}	
		}

		private void btnMoi_Click(object sender, EventArgs e)
		{
			if (txtSoHoSo.Text.Trim().Equals(""))
			{
				MessageBox.Show("Hãy nhập Số hồ sơ");
				txtSoHoSo.Focus();
				return;
			}
			if (txtHoTen.Text.Trim().Equals(""))
			{
				MessageBox.Show("Hãy nhập Họ và tên");
				txtHoTen.Focus();
				return;
			}
			string input = txtHoTen.Text;
			string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			if (words.Length < 2)
			{
				MessageBox.Show("Hãy nhập đủ Họ và tên");
				txtHoTen.Focus();
				return;
			}
			if (rdbNam.Checked == false && rdbNu.Checked == false)
			{
				MessageBox.Show("Hãy chọn giới tính");
				rdbNam.Focus();
				return;
			}
			if (cbbMaQue.SelectedIndex == -1)
			{
				MessageBox.Show("Hãy chọn quê quán");
				cbbMaQue.Focus();
				return;
			}
			if (cbbMaKV.SelectedIndex == -1)
			{
				MessageBox.Show("Hãy chọn khu vực");
				cbbMaKV.Focus();
				return;
			}
			if (cbbMaUT.SelectedIndex == -1)
			{
				MessageBox.Show("Hãy chọn ưu tiên");
				cbbMaUT.Focus();
				return;
			}
			if (cbbMaDT.SelectedIndex == -1)
			{
				MessageBox.Show("Hãy chọn đối tượng");
				cbbMaDT.Focus();
				return;
			}
			if (cbbMaNV.SelectedIndex == -1)
			{
				MessageBox.Show("Hãy chọn nguyện vọng");
				cbbMaNV.Focus();
				return;
			}
			if (txtSBD.Text.Trim().Equals(""))
			{
				MessageBox.Show("Hãy sinh số báo danh cho thí sinh");
				txtSBD.Focus();
				return;
			}
			DataTable tb = md.LoadData("Select SoHoSo From HoSoThiSinh Where SoHoSo = '" + txtSoHoSo.Text + "'");
			if (tb.Rows.Count > 0)
			{
				MessageBox.Show("Hãy số hồ sơ đã tồn tại hãy nhập số hồ sơ khác");
				txtSoHoSo.Focus();
				return;
			}
			//hoten
			string ht = txtHoTen.Text;
			int i = ht.LastIndexOf(" ");
			string ten = ht.Substring(i + 1);
			string ho = ht.Substring(0, i);
			//goitinh
			string gt = "0";
			if (rdbNam.Checked)
			{
				gt = "1";
			}


			md.Command("Insert Into HoSoThiSinh Values ('" + txtSoHoSo.Text + "', N'" + ho + "', N'" + ten + "', '" + dtpNgaySinh.Value + "', " + gt + ", '"
				+ layma(cbbMaQue.Text, "Que") + "', '" + layma(cbbMaKV.Text, "KhuVuc") + "', '" + layma(cbbMaUT.Text, "UuTien") + "', '" + layma(cbbMaDT.Text, "DoiTuong") 
				+ "', '" + layma(cbbMaNV.Text, "NguyenVong") + "', '" + txtSBD.Text + "', N'" + txtGhiChu.Text + "')");
			MessageBox.Show("Thêm mới thành công");

			//Xoa bảng phòng thi
			md.Command("Delete From PhongThi_ThiSinh");
			md.Command("Delete From DiemThi");
			this.Close();
		}

		private string layma(string tenLoai, string ten)
		{
			if (ten == "Que")
			{
				string sql = $"SELECT MaQue FROM QueQuan WHERE Ten{ten} = N'{tenLoai}'";
				DataTable result = md.LoadData(sql);

				if (result.Rows.Count > 0)
				{
					return result.Rows[0]["MaQue"].ToString();
				}

				return null;
			}
            else
            {
				string sql = $"SELECT Ma{ten} FROM {ten} WHERE Ten{ten} = N'{tenLoai}'";
				DataTable result = md.LoadData(sql);

				if (result.Rows.Count > 0)
				{
					return result.Rows[0][$"Ma{ten}"].ToString();
				}

				return null;
			}  
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (txtHoTen.Text.Trim().Equals(""))
			{
				MessageBox.Show("Hãy nhập Họ và tên");
				txtHoTen.Focus();
				return;
			}
			string input = txtHoTen.Text;
			string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			if (words.Length < 2)
			{
				MessageBox.Show("Hãy nhập đủ Họ và tên");
				txtHoTen.Focus();
				return;
			}
			if (rdbNam.Checked == false && rdbNu.Checked == false)
			{
				MessageBox.Show("Hãy chọn giới tính");
				rdbNam.Focus();
				return;
			}
			if (cbbMaQue.SelectedIndex == -1)
			{
				MessageBox.Show("Hãy chọn quê quán");
				cbbMaQue.Focus();
				return;
			}
			if (cbbMaKV.SelectedIndex == -1)
			{
				MessageBox.Show("Hãy chọn khu vực");
				cbbMaKV.Focus();
				return;
			}
			if (cbbMaUT.SelectedIndex == -1)
			{
				MessageBox.Show("Hãy chọn ưu tiên");
				cbbMaUT.Focus();
				return;
			}
			if (cbbMaDT.SelectedIndex == -1)
			{
				MessageBox.Show("Hãy chọn đối tượng");
				cbbMaDT.Focus();
				return;
			}
			if (cbbMaNV.SelectedIndex == -1)
			{
				MessageBox.Show("Hãy chọn nguyện vọng");
				cbbMaNV.Focus();
				return;
			}
			if (txtSBD.Text.Trim().Equals(""))
			{
				MessageBox.Show("Hãy sinh số báo danh cho thí sinh");
				txtSBD.Focus();
				return;
			}	
			//hoten
			string ht = txtHoTen.Text;
			int i = ht.LastIndexOf(" ");
			string ten = ht.Substring(i + 1);
			string ho = ht.Substring(0, i);
			//goitinh
			string gt = "0";
			if (rdbNam.Checked)
			{
				gt = "1";
			}

			md.Command("UPDATE HoSoThiSinh SET Ho = N'" + ho + "', Ten = N'" + ten + "', NgaySinh = '" + dtpNgaySinh.Value + "', GioiTinh = " + gt
				+ ", MaQue = '" + layma(cbbMaQue.Text, "Que") + "', MaKhuVuc = '" + layma(cbbMaKV.Text, "KhuVuc") + "', MaUuTien = '" + layma(cbbMaUT.Text, "UuTien")
				+ "', MaDoiTuong = '" + layma(cbbMaDT.Text, "DoiTuong") + "', MaNguyenVong = '" + layma(cbbMaNV.Text, "NguyenVong") + "', SoBD = '" + txtSBD.Text
				+ "', GhiChu = N'" + txtGhiChu.Text + "' WHERE SoHoSo = '" + txtSoHoSo.Text + "'");
			MessageBox.Show("Đã sửa xong");
			//Xóa
			md.Command("Delete From PhongThi_ThiSinh");
			md.Command("Delete From DiemThi");
			this.Close();
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn xóa hồ sơ thí sinh có mã "+txtSoHoSo.Text+" không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				md.Command("Delete HoSoThiSinh Where SoHoSo = '" + txtSoHoSo.Text + "'");
				MessageBox.Show("Xóa thành công");
				//Xóa
				md.Command("Delete From PhongThi_ThiSinh");
				md.Command("Delete From DiemThi");

				DataTable tb = new DataTable();
				tb = md.LoadData("Select a.SoHoSo, a.Ho, a.Ten, a.NgaySinh, a.GioiTinh, b.TenQue, c.TenKhuVuc, d.TenUuTien, " +
					"e.TenDoiTuong, f.TenNguyenVong, a.SoBD, a.GhiChu From HoSoThiSinh a inner join QueQuan b on a.MaQue = b.MaQue " +
					"inner join KhuVuc c on a.MaKhuVuc = c.MaKhuVuc inner join UuTien d on a.MaUuTien = d.MaUuTien " +
					"inner join DoiTuong e on a.MaDoiTuong = e.MaDoiTuong inner join NguyenVong f on a.MaNguyenVong = f.MaNguyenVong");

				DataRow[] rowDelete = tb.Select("SoHoSo = '" + txtSoHoSo.Text + "'");
				foreach(DataRow row in rowDelete)
				{
					tb.Rows.Remove(row);
				}
				int sbd = 1;

				tb.DefaultView.Sort = "Ten ASC, Ho ASC";
				tb = tb.DefaultView.ToTable();

				foreach (DataRow dr in tb.Rows)
				{
					dr["SoBD"] = sbd;
					if (dr["SoHoSo"].ToString() != "")
					{
						md.Command("Update HoSoThiSinh Set SoBD = '" + sbd + "' Where SoHoSo = '" + dr["SoHoSo"].ToString() + "'");
					}
					else
					{
						txtSBD.Text = sbd.ToString();
					}
					sbd++;
				}

				this.Close();
			}
		}
	}
}
