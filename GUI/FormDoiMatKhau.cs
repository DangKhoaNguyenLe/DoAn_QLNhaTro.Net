using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDoiMatKhau : Form
    {
        private string _tenDangNhapHienTai; 
        private TaiKhoanBLL bll = new TaiKhoanBLL();

        public FormDoiMatKhau(string tenDangNhap)
        {
            InitializeComponent();
            _tenDangNhapHienTai = tenDangNhap;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string kq = bll.DoiMatKhau(_tenDangNhapHienTai, txtMatKhauCu.Text, txtMatKhauMoi.Text, txtXacNhan.Text);

            if (kq == "Success")
            {
                MessageBox.Show("Đổi mật khẩu thành công! Vui lòng đăng nhập lại.");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show(kq, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
