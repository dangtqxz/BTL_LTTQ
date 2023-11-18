using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_ThiSinhThiDaiHoc
{
	public partial class Register : Form
	{
		Modify md = new Modify();
		public Register()
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

		public bool checkAccount(string ac)
		{
			return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
		}

		public bool checkEmail(string ac)
		{
			return Regex.IsMatch(ac, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			string tentk = txtTendangnhap.Text;
			string email = txtGmail.Text;
			string mk = txtMatkhau.Text;
			string xnmk = txtMatkhau2.Text;
			if (!checkAccount(tentk))
			{
				MessageBox.Show("Vui long nhap ten tk 6-24 ky tu");
				return;
			}
			if (!checkEmail(email))
			{
				MessageBox.Show("Vui long nhap email dung dinh dang");
				return;
			} else
			{
				DataTable dt = md.LoadData("Select * From TKvaMK Where Email = N'" + email + "'");
				if (dt.Rows.Count > 0)
				{
					MessageBox.Show("Email da duoc su dung! Vui long nhap email khac");
					return;
				}
			}
			if (!checkAccount(mk))
			{
				MessageBox.Show("Vui long nhap mk 6-24 ky tu");
				return;
			}
			if (mk != xnmk)
			{
				MessageBox.Show("Vui long xac nhan mat khau chinh xac");
				return;
			}
			try
			{
				string query = "Insert Into TKvaMK Values ('" + tentk + "','" + mk + "','" + email + "')";
				md.Command(query);
				if (MessageBox.Show("Dang ky thanh cong! Ban co muon ve trang dang nhap khong?", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					this.Hide();
					Login login = new Login();
					login.ShowDialog();
					this.Close();
				}
			}
			catch
			{
				MessageBox.Show("Ten tai khoan nay da duoc dang ky. Vui long dang ky tai khoan khac!");
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
