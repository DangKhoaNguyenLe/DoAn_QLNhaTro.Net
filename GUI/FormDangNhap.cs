using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FormDangNhap : Form
    {
        UserBLL userBLL = new UserBLL();
        public FormDangNhap()
        {
            InitializeComponent();
            this.pictureBox_Thoat.Click += PictureBox_Thoat_Click;
            this.btn_dangnhap.Click += Btn_dangnhap_Click;
            this.linklabel_dangky.LinkClicked += Linklabel_dangky_LinkClicked;
            this.linklabel_quenmatkhau.LinkClicked += Linklabel_quenmatkhau_LinkClicked;
        }

        private void Linklabel_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.FormClosed += (s, args) => this.Show();
            this.Hide();
            formQuenMatKhau.Show();
        }

        private void Linklabel_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.FormClosed += (s, args) => this.Show();
            this.Hide();
            formDangKy.Show();

        }

        private void Btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_taikhoan_login.Text.Trim();
            string password = txt_matkhau_login.Text.Trim();

            // Kiểm tra đầu vào (GUI xử lý)
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi BLL kiểm tra đăng nhập
            bool loginSuccess = userBLL.DangNhap(username, password);

            if (!loginSuccess)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đăng nhập thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            FormMainTu formMain = new FormMainTu();
            formMain.FormClosed += (s, args) => this.Close();

            this.Hide();
            formMain.Show();
        }
        private void PictureBox_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình?","Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question                      
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
