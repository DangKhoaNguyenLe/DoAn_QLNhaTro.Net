using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BLL;
using DTO; 

namespace GUI
{
    public partial class FormDangNhap : Form
    {
    
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        NguoiDungBLL bll = new NguoiDungBLL();

        public FormDangNhap()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;            
            this.btn_dangnhap.Click += Btn_dangnhap_Click;
            this.linklabel_dangky.LinkClicked += Linklabel_dangky_LinkClicked;
            this.linklabel_quenmatkhau.LinkClicked += Linklabel_quenmatkhau_LinkClicked;
            this.pictureBox_Thoat.Click += PictureBox_Thoat_Click;
            this.Load += FormDangNhap_Load;
            this.Shown += FormDangNhap_Shown;
            this.KeyDown += FormDangNhap_KeyDown; 
        }

        private void PictureBox_Thoat_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void SetPlaceholder(TextBox txt, string placeholder)
        {
            SendMessage(txt.Handle, EM_SETCUEBANNER, 1, placeholder);
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            SetPlaceholder(txt_taikhoan_login, "Nhập tên đăng nhập");
            SetPlaceholder(txt_matkhau_login, "Nhập mật khẩu");
        }

        private void FormDangNhap_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null; 
        }


        private void Btn_dangnhap_Click(object sender, EventArgs e)
        {
            ThucHienDangNhap();
        }

        private void ThucHienDangNhap()
        {
            string username = txt_taikhoan_login.Text.Trim();
            string password = txt_matkhau_login.Text.Trim();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
   
                NguoiDungDTO user = bll.KiemTraDangNhap(username, password);

                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công! Xin chào " + user.HoTen, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMainNew formMain = new FormMainNew(user.VaiTro, user.HoTen, user.TenDangNhap, user.MaNguoiDung);

                    this.Hide();
                    formMain.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý phím Enter
        private void FormDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThucHienDangNhap();
            }
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

        
    }
}