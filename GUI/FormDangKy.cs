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
using System.Runtime.InteropServices;

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

            // === GỌI PLACEHOLDER ===
            SetPlaceholder(txt_taikhoan_dangky, "Nhập tài khoản...");
            SetPasswordPlaceholder(txt_matkhau_dangky, "Nhập mật khẩu...");
            SetPasswordPlaceholder(txt_XNmatkhau_dangky, "Xác nhận mật khẩu...");

            SetPlaceholder(txt_fullname_dangky, "Nhập họ và tên...");
            SetPlaceholder(txt_phone, "Số điện thoại...");
            SetPlaceholder(txt_email_dangky, "Email...");

            // === TẮT FOCUS BAN ĐẦU (KHÔNG CHO FOCUS VÀO Ô ĐẦU TIÊN) ===
            this.Shown += FormDangKy_Shown;
        }

        // Khi form hiển thị xong, bỏ focus khỏi tất cả control
        private void FormDangKy_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;   // Không control nào được focus
        }

        // =====================================================================
        //  PLACEHOLDER CHO TEXT THƯỜNG
        // =====================================================================
        private void SetPlaceholder(TextBox txt, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Text = placeholder;
                txt.ForeColor = Color.Gray;
            }

            txt.Enter += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                }
            };

            txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        // =====================================================================
        //  PLACEHOLDER CHO MẬT KHẨU (ẩn ● khi nhập)
        // =====================================================================
        private void SetPasswordPlaceholder(TextBox txt, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.UseSystemPasswordChar = false;
                txt.Text = placeholder;
                txt.ForeColor = Color.Gray;
            }

            txt.Enter += (s, e) =>
            {
                if (txt.Text == placeholder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.Black;
                    txt.UseSystemPasswordChar = true; // bật ●
                }
            };

            txt.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.UseSystemPasswordChar = false;
                    txt.Text = placeholder;
                    txt.ForeColor = Color.Gray;
                }
            };
        }

        // =====================================================================
        //  NÚT ĐĂNG KÝ
        // =====================================================================
        private void Btn_dangky_Click(object sender, EventArgs e)
        {
            string username = txt_taikhoan_dangky.Text.Trim();
            string password = txt_matkhau_dangky.Text.Trim();
            string XNpassword = txt_XNmatkhau_dangky.Text.Trim();
            string fullName = txt_fullname_dangky.Text.Trim();
            string phone = txt_phone.Text.Trim();
            string email = txt_email_dangky.Text.Trim();

            // Nếu textbox chứa placeholder thì coi như chưa nhập
            if (username == "Nhập tài khoản..." ||
                fullName == "Nhập họ và tên..." ||
                phone == "Số điện thoại..." ||
                email == "Email..." ||
                password == "Nhập mật khẩu..." ||
                XNpassword == "Xác nhận mật khẩu...")
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

            // Gán data
            UserDTO user = new UserDTO();
            user.Username = username;
            user.PasswordHash = password;
            user.FullName = fullName;
            user.Phone = phone;
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
                MessageBox.Show("Số điện thoại không hợp lệ! (Phải 10 số, bắt đầu bằng 0)",
                                "Lỗi số điện thoại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (result == 5)
            {
                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi hệ thống khi đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =====================================================================
        //  QUAY LẠI LOGIN
        // =====================================================================
        private void LinkLabel_quaylaiLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        // =====================================================================
        //  NÚT THOÁT
        // =====================================================================
        private void PictureBox_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát chương trình?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
