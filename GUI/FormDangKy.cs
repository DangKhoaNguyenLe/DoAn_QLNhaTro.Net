using BLL; // Sử dụng NguoiDungBLL
using DTO; // Sử dụng NguoiDungDTO
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDangKy : Form
    {
 
        NguoiDungBLL bll = new NguoiDungBLL();

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public FormDangKy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.pictureBox_Thoat.Click += PictureBox_Thoat_Click;
            this.linkLabel_quaylaiLogin.LinkClicked += LinkLabel_quaylaiLogin_LinkClicked;
            this.btn_dangky.Click += Btn_dangky_Click;

            this.Load += FormDangKy_Load;
            this.Shown += FormDangKy_Shown;
        }

        private void SetPlaceholder(TextBox txt, string placeholder)
        {
            SendMessage(txt.Handle, EM_SETCUEBANNER, 1, placeholder);
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            SetPlaceholder(txt_taikhoan_dangky, "Nhập tài khoản");
            SetPlaceholder(txt_matkhau_dangky, "Nhập mật khẩu");
            SetPlaceholder(txt_XNmatkhau_dangky, "Xác nhận mật khẩu");
            SetPlaceholder(txt_fullname_dangky, "Nhập họ và tên");
            SetPlaceholder(txt_phone, "Số điện thoại");
        
        }

        private void FormDangKy_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null; 
        }

        private void Btn_dangky_Click(object sender, EventArgs e)
        { 
            string username = txt_taikhoan_dangky.Text.Trim();
            string password = txt_matkhau_dangky.Text.Trim();
            string XNpassword = txt_XNmatkhau_dangky.Text.Trim();
            string fullName = txt_fullname_dangky.Text.Trim();
            string phone = txt_phone.Text.Trim();
         

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản và Mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            NguoiDungDTO newUser = new NguoiDungDTO();
            newUser.TenDangNhap = username;
            newUser.MatKhau = password;
            newUser.HoTen = fullName;
            newUser.SDT = phone;

            string ketQua = bll.DangKyTaiKhoan(newUser, XNpassword);


            if (ketQua == "ThanhCong")
            {
                MessageBox.Show("Đăng ký thành công! Bạn có thể đăng nhập ngay.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LinkLabel_quaylaiLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

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