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

		private void loadCbb()
		{
			DataTable tb = md.LoadData("Select MaQue From QueQuan");
			foreach (DataRow dr in tb.Rows)
			{
				cbbMaQue.Items.Add(dr["MaQue"].ToString());
			}
			tb = md.LoadData("Select MaKhuVuc From KhuVuc");
			foreach (DataRow dr in tb.Rows)
			{
				cbbMaKV.Items.Add(dr["MaKhuVuc"].ToString());
			}
			tb = md.LoadData("Select MaUuTien From UuTien");
			foreach (DataRow dr in tb.Rows)
			{
				cbbMaUT.Items.Add(dr["MaUuTien"].ToString());
			}
			tb = md.LoadData("Select MaDoiTuong From DoiTuong");
			foreach (DataRow dr in tb.Rows)
			{
				cbbMaDT.Items.Add(dr["MaDoiTuong"].ToString());
			}
			tb = md.LoadData("Select MaNguyenVong From NguyenVong");
			foreach (DataRow dr in tb.Rows)
			{
				cbbMaNV.Items.Add(dr["MaNguyenVong"].ToString());
			}
		}

		private void HoSoThiSinh_Load(object sender, EventArgs e)
		{
			loadCbb();
			DataTable tb = md.LoadData("Select * From HoSoThiSinh");
			dgvHienThi.DataSource = tb;
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{

		}
	}
}
