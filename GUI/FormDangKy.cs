using BLL;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace GUI
{
    public partial class FormDangKy : Form
    {
        UserBLL userBLL = new UserBLL();

        public FormDangKy()
        {
            InitializeComponent();
            this.pictureBox_Thoat.Click += PictureBox_Thoat_Click;
            this.linkLabel_quaylaiLogin.LinkClicked += LinkLabel_quaylaiLogin_LinkClicked;
            this.btn_dangky.Click += Btn_dangky_Click;

        }

        private void Btn_dangky_Click(object sender, EventArgs e)
        {
            string username = txt_taikhoan_dangky.Text.Trim();
            string password = txt_matkhau_dangky.Text.Trim();
            string XNpassword = txt_XNmatkhau_dangky.Text.Trim();
            string fullName = txt_fullname_dangky.Text.Trim();
            string email = txt_email_dangky.Text.Trim();

            // Kiểm tra trống
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(XNpassword) ||
                string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xác nhận mật khẩu
            if (password != XNpassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gán dữ liệu cho DTO
            UserDTO user = new UserDTO();
            user.Username = username;
            user.PasswordHash = password;
            user.FullName = fullName;
            user.Email = email;

            int result = userBLL.DangKy(user);

            if (result == 1)
            {
                MessageBox.Show("Thiếu thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (result == 2)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == 3)
            {
                MessageBox.Show("Email không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == 4)
            {
                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi hệ thống khi đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void LinkLabel_quaylaiLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void PictureBox_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}