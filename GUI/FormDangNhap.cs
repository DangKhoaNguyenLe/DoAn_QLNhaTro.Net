using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BLL; // Namespace chứa NguoiDungBLL
using DTO; // Namespace chứa NguoiDungDTO

namespace GUI
{
    public partial class FormDangNhap : Form
    {
        // --- 1. PHẦN API TẠO PLACEHOLDER (GIỮ NGUYÊN) ---
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        // --- 2. KHAI BÁO BLL MỚI ---
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
            this.ActiveControl = null; // Bỏ focus ban đầu cho đẹp
        }

        // --- 3. XỬ LÝ ĐĂNG NHẬP ---
        private void Btn_dangnhap_Click(object sender, EventArgs e)
        {
            ThucHienDangNhap();
        }

        // Hàm xử lý chung (dùng cho cả Nút bấm và Phím Enter)
        private void ThucHienDangNhap()
        {
            string username = txt_taikhoan_login.Text.Trim();
            string password = txt_matkhau_login.Text.Trim();

            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // GỌI BLL: Trả về đối tượng DTO chứa đầy đủ thông tin
                NguoiDungDTO user = bll.KiemTraDangNhap(username, password);

                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công! Xin chào " + user.HoTen, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // --- CHUYỂN FORM & TRUYỀN QUYỀN ---
                    // Lưu ý: FormMainNew phải có Constructor nhận 2 tham số (VaiTro, HoTen)
                    FormMainNew formMain = new FormMainNew(user.VaiTro, user.HoTen);

                    this.Hide();
                    formMain.ShowDialog(); // Dùng ShowDialog để quản lý luồng tốt hơn

                    // Khi FormMain đóng lại thì thoát ứng dụng luôn
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

        // --- CÁC SỰ KIỆN KHÁC ---

        private void Linklabel_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form quên mật khẩu (Giả định bạn có form này)
            FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
            formQuenMatKhau.FormClosed += (s, args) => this.Show();
            this.Hide();
            formQuenMatKhau.Show();
        }

        private void Linklabel_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form đăng ký (Giả định bạn có form này)
            FormDangKy formDangKy = new FormDangKy();
            formDangKy.FormClosed += (s, args) => this.Show();
            this.Hide();
            formDangKy.Show();
        }

        
    }
}