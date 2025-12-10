using System;
using System.Drawing;
using System.Runtime.InteropServices; 
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FormDangNhap : Form
    {
        //private const int EM_SETCUEBANNER = 0x1501;
        //[DllImport("user32.dll", CharSet = CharSet.Auto)]
        //private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        //UserBLL userBLL = new UserBLL();

        //public FormDangNhap()
        //{
        //    InitializeComponent();

        //    // Đăng ký các sự kiện
        //    this.pictureBox_Thoat.Click += PictureBox_Thoat_Click;
        //    this.btn_dangnhap.Click += Btn_dangnhap_Click;
        //    this.linklabel_dangky.LinkClicked += Linklabel_dangky_LinkClicked;
        //    this.linklabel_quenmatkhau.LinkClicked += Linklabel_quenmatkhau_LinkClicked;

        //    this.Load += FormDangNhap_Load;
        //    this.Shown += FormDangNhap_Shown;
        //}

        //// 2. Hàm thiết lập Placeholder (Dùng API)
        //private void SetPlaceholder(TextBox txt, string placeholder)
        //{
        //    // Số 1 (TRUE) nghĩa là vẫn hiện chữ gợi ý ngay cả khi ô đó đang được Focus
        //    SendMessage(txt.Handle, EM_SETCUEBANNER, 1, placeholder);
        //}

        //private void FormDangNhap_Load(object sender, EventArgs e)
        //{
        //    // Thiết lập chữ gợi ý cho cả 2 ô
        //    SetPlaceholder(txt_taikhoan_login, "Nhập tên đăng nhập");
        //    SetPlaceholder(txt_matkhau_login, "Nhập mật khẩu");
        //}

        //private void FormDangNhap_Shown(object sender, EventArgs e)
        //{
        //    // Bỏ focus khi form vừa hiện lên để nhìn đẹp hơn (không nhấp nháy con trỏ)
        //    this.ActiveControl = null;
        //}

        //private void Btn_dangnhap_Click(object sender, EventArgs e)
        //{
        //    string username = txt_taikhoan_login.Text.Trim();
        //    string password = txt_matkhau_login.Text.Trim();

        //    // Kiểm tra rỗng
        //    // (Với cách API, bạn không cần lo kiểm tra text == "Nhập tên..." nữa, vì Text sẽ tự động rỗng)
        //    if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        //    {
        //        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // Gọi BLL kiểm tra
        //    bool loginSuccess = userBLL.DangNhap(username, password);

        //    if (!loginSuccess)
        //    {
        //        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    // Chuyển Form
        //    FormMainNew formMain = new FormMainNew();
        //    formMain.FormClosed += (s, args) => this.Close(); // Đóng form đăng nhập khi form chính đóng
        //    this.Hide();
        //    formMain.Show();
        //}

        //private void Linklabel_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    FormQuenMatKhau formQuenMatKhau = new FormQuenMatKhau();
        //    formQuenMatKhau.FormClosed += (s, args) => this.Show();
        //    this.Hide();
        //    formQuenMatKhau.Show();
        //}

        //private void Linklabel_dangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    FormDangKy formDangKy = new FormDangKy();
        //    formDangKy.FormClosed += (s, args) => this.Show();
        //    this.Hide();
        //    formDangKy.Show();
        //}

        //private void PictureBox_Thoat_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show(
        //        "Bạn có chắc muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question
        //    );

        //    if (result == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //}
    }
}