using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_ThiSinhThiDaiHoc
{
	public partial class QLPhongThi : Form
	{
		Modify md = new Modify();
		public QLPhongThi()
		{
			InitializeComponent();
		}

		private void loadData()
		{
			cbbSoPhongThi.Items.Clear();
			DataTable dt = md.LoadData("Select Distinct MaPhongThi From PhongThi_ThiSinh Order by Cast(MaPhongThi as int) ASC");
			foreach (DataRow i in dt.Rows)
			{
				cbbSoPhongThi.Items.Add(i["MaPhongThi"].ToString());
			}

			dt = md.LoadData("Select * From PhongThi_ThiSinh Order by Cast(SoBD as int) ASC");
			dgvHienThi.DataSource = dt;
		}

		private void QLPhongThi_Load(object sender, EventArgs e)
		{
			loadData();
		}

		private void cbbSoPhongThi_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = md.LoadData("Select * From PhongThi_ThiSinh " +
				"Where MaPhongThi = " + cbbSoPhongThi.SelectedItem.ToString() + " Order by Cast(SoBD as int) ASC");
			dgvHienThi.DataSource = dt;
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			if (txtSoThiSinh.Text == "")
			{
				MessageBox.Show("Hãy nhập số thí sinh của một phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else
			{
				md.Command("Delete From PhongThi_ThiSinh");
				DataTable tb = md.LoadData("Select * From HoSoThiSinh Order by Cast(SoBD as int) ASC");
				var n = tb.Rows.Count;
				var m = Int32.Parse(txtSoThiSinh.Text);
				var count = 0;
				var maphong = 0;
                foreach (DataRow item in tb.Rows)
                {
                    if (count==0)
					{
						count = m;
						maphong++;
					}
					md.Command("Insert Into PhongThi_ThiSinh Values ('" + maphong + "','" + item["SoBD"] + "','" + m + "')");
					count--;
                }
				loadData();
				
				//Sửa lại bảng điểm thi
				DataTable tbd = md.LoadData("Select * From PhongThi_ThiSinh");
				md.Command(" Delete From DiemThi");
                foreach (DataRow item in tbd.Rows)
                {
					md.Command("Insert Into DiemThi Values ('" + item["SoBD"] + "', '" + item["MaPhongThi"] + "', 0, 0, 0)");
                }
                //
            }
		}

		private void txtSoThiSinh_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnLamLai_Click(object sender, EventArgs e)
		{
			txtSoThiSinh.Text = "";
			loadData();
		}
	}
}
