using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_ThiSinhThiDaiHoc
{
	internal class TaiKhoan
	{
		private string taikhoan;
		private string matkhau;
		private string email;

		public TaiKhoan()
		{
		}

		public TaiKhoan(string taikhoan, string matkhau, string email)
		{
			this.taikhoan = taikhoan;
			this.matkhau = matkhau;
			this.email = email;
		}

		public string Taikhoan { get => taikhoan; set => taikhoan = value; }
		public string Matkhau { get => matkhau; set => matkhau = value; }
		public string Email { get => email; set => email = value; }
	}
}
