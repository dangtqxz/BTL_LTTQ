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
	public partial class Login : Form
	{
		Modify md = new Modify();
		public Login()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void lbDangKy_Click(object sender, EventArgs e)
		{
			this.Hide();
			Register form = new Register();
			form.ShowDialog();
			this.Close();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string tentk = txtTendangnhap.Text;
			string mk = txtMatkhau.Text;
			if (tentk.Trim() == "")
			{
				MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtTendangnhap.Focus();
			}
			else
			{
				if (mk.Trim() == "")
				{
					MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtMatkhau.Focus();
				}
				else
				{
					string query = "Select * From TKvaMK Where TaiKhoan = '" + tentk + "' and MatKhau = '" + mk + "'";
					if (md.TaiKhoans(query).Count != 0)
					{
						this.Hide();
						MainMenu form = new MainMenu();
						form.ShowDialog();
						this.Close();
					}
					else
					{
						MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						txtTendangnhap.Focus();
					}
				}
			}
		}

		private void lbQuenMK_Click(object sender, EventArgs e)
		{
			this.Hide();
			ResetPassword form = new ResetPassword();
			form.ShowDialog();
			this.Close();
		}
	}
}
