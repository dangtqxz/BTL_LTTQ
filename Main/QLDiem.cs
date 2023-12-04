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
	public partial class QLDiem : Form
	{
		Modify md = new Modify();
		private object oldValue;

		public QLDiem()
		{
			InitializeComponent();
		}

		private void QLDiem_Load(object sender, EventArgs e)
		{
			loadData();
		}

		private void loadData()
		{
			cbbMaPhongThi.Items.Clear();
			DataTable dt = md.LoadData("Select Distinct MaPhongThi From PhongThi_ThiSinh");
			foreach (DataRow i in dt.Rows)
			{
				cbbMaPhongThi.Items.Add(i["MaPhongThi"].ToString());
			}
			dt = md.LoadData("Select * From DiemThi Order by Cast(SoBD as int) ASC");
			dgvHienThi.DataSource = dt;
			dgvHienThi.ReadOnly = true;
		}

		private void dgvHienThi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			int columnIndex = e.ColumnIndex;
			object newValue = dgvHienThi.Rows[rowIndex].Cells[columnIndex].Value;

			// Kiểm tra và hạn chế giá trị nhập vào
			if (columnIndex == 2 || columnIndex == 3 || columnIndex == 4)
			{
				if (newValue == null || string.IsNullOrWhiteSpace(newValue.ToString()))
				{
					dgvHienThi.Rows[rowIndex].Cells[columnIndex].Value = DBNull.Value;
					return;
				}

				if (!decimal.TryParse(newValue.ToString(), out decimal diem) || diem < 0 || diem > 10)
				{
					MessageBox.Show("Vui lòng nhập một số hợp lệ (0 - 10).");

					// Hiển thị lại giá trị cũ
					dgvHienThi.Rows[rowIndex].Cells[columnIndex].Value = oldValue;
					return;
				}

				// Lưu trữ giá trị mới vào cơ sở dữ liệu
				object primaryKeyValue = dgvHienThi.Rows[rowIndex].Cells["SoBD"].Value;
				if (columnIndex == 2)
				{
					md.Command("UPDATE DiemThi SET DiemMon1 = " + newValue + " WHERE SoBD = " + primaryKeyValue);
				}

				if (columnIndex == 3)
				{
					md.Command("UPDATE DiemThi SET DiemMon2 = " + newValue + " WHERE SoBD = " + primaryKeyValue);
				}

				if (columnIndex == 4)
				{
					md.Command("UPDATE DiemThi SET DiemMon3 = " + newValue + " WHERE SoBD = " + primaryKeyValue);
				}
			} else
			{
				dgvHienThi.Rows[rowIndex].Cells[columnIndex].Value = oldValue;
				MessageBox.Show("Không được sửa thông tin này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

			


			//if (columnIndex == 2)
			//{
			//	md.Command("Update DiemThi Set DiemMon1 = " + newValue + " Where SoBD = " + primaryKeyValue);
			//}

			//if (columnIndex == 3)
			//{
			//	md.Command("Update DiemThi Set DiemMon2 = " + newValue + " Where SoBD = " + primaryKeyValue);
			//}

			//if (columnIndex == 4)
			//{
			//	md.Command("Update DiemThi Set DiemMon3 = " + newValue + " Where SoBD = " + primaryKeyValue);
			//}

		}

		private void loadCBB()
		{
			DataTable dt = md.LoadData("Select * From DiemThi " +
				"Where MaPhongThi = " + cbbMaPhongThi.SelectedItem.ToString() + " Order by Cast(SoBD as int) ASC");
			dgvHienThi.DataSource = dt;
		}

		private void cbbMaPhongThi_SelectedIndexChanged(object sender, EventArgs e)
		{
			loadCBB();
			dgvHienThi.ReadOnly = false;
		}

		private void btnLamLai_Click(object sender, EventArgs e)
		{
			loadData();
		}

		private void dgvHienThi_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			int rowIndex = e.RowIndex;
			int columnIndex = e.ColumnIndex;

			// Lưu trữ giá trị cũ trước khi chỉnh sửa
			oldValue = dgvHienThi.Rows[rowIndex].Cells[columnIndex].Value;
		}
	}
}
