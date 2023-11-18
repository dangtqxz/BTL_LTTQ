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
	public partial class ResetPassword : Form
	{
		Modify md = new Modify();
		public ResetPassword()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void lbDangNhap_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login form = new Login();
			form.ShowDialog();
			this.Close();
		}

		private void lbDangKy_Click(object sender, EventArgs e)
		{
			this.Hide();
			Register form = new Register();
			form.ShowDialog();
			this.Close();
		}

		private void btnResetPW_Click(object sender, EventArgs e)
		{
			string email = txtEmail.Text;
			if (email.Trim() == "")
			{
				MessageBox.Show("Vui long email dang ky!");
			}
			else
			{
				string query = "Select * From TKvaMK Where Email = '" + email + "'";
				if (md.TaiKhoans(query).Count != 0)
				{
					MessageBox.Show("Tài khoản: " + md.TaiKhoans(query)[0].Taikhoan+" \nMật khẩu: "+ md.TaiKhoans(query)[0].Matkhau);
				}
				else
				{
					MessageBox.Show("Email chua duoc dang ky!");
				}
			}
		}
	}
}
