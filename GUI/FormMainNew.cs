using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMainNew : Form
    {
     
        string _vaiTro;
        string _hoTen;
        string _tenDangNhap;
        bool _isDangXuat = false;
        MenuAnimator menuVanHanh, menuTaiChinh, menuDanhMuc, menuHeThong;
        Form currentChildForm;
        int _maNguoiDungHienTai;

        public FormMainNew(string vaiTro, string hoTen, string tenDangNhap, int maNguoiDung)
        {
            InitializeComponent();
            this._vaiTro = vaiTro;
            this._hoTen = hoTen;
            _tenDangNhap = tenDangNhap;
            this._maNguoiDungHienTai = maNguoiDung;
            menuVanHanh = new MenuAnimator(flowLayoutPanel_van_hanh, Van_Hanh_Transition);
            menuTaiChinh = new MenuAnimator(flowLayoutPanel_tai_chinh_ke_toan, Tai_Chinh_Transition);
            menuDanhMuc = new MenuAnimator(flowLayoutPanel_danh_muc, Danh_Muc_Transition);
            menuHeThong = new MenuAnimator(flowLayoutPanel_he_thong, He_Thong_Transition);
            this.FormClosing += FormMainNew_FormClosing;
            button_phong.Click += Button_phong_Click;
            button_doi_mat_khau.Click += Button_doi_mat_khau_Click;
            ApplyTheme();
            DangKySuKien();
            button_doi_mat_khau.Click += Button_doi_mat_khau_Click;
            button_dang_xuat.Click += Button_dang_xuat_Click;
            button_phan_quyen.Click += Button_phan_quyen_Click;
            button_hop_dong.Click += Button_hop_dong_Click;
            button_lap_hoa_don.Click += Button_lap_hoa_don_Click;
            button_thu_chi.Click += Button_thu_chi_Click;
            button_dashboard.Click += Button_dashboard_Click;
        }

        private void Button_dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTongQuan());
        }

        private void Button_thu_chi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQuanLyThuTien());
        }

        private void Button_lap_hoa_don_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLapHoaDon(_maNguoiDungHienTai));
        }

        private void Button_hop_dong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHopDong());
        }

        private void Button_phan_quyen_Click(object sender, EventArgs e)
        {
            if (_vaiTro != "ADMIN")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;
            }

            OpenChildForm(new FormQuanLyNhanVien());
        }

        private void Button_dang_xuat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                _isDangXuat = true;
                this.Hide();

                FormDangNhap frm = new FormDangNhap();
                frm.ShowDialog(); 
                this.Close();
            }
        }

        private void Button_doi_mat_khau_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau frm = new FormDoiMatKhau(_tenDangNhap);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                FormDangNhap frmLogin = new FormDangNhap();
                frmLogin.ShowDialog(); 
                this.Close();
            }
        }

        private void Button_phong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhongTro(_vaiTro));
        }

        private void FormMainNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
             "Bạn có chắc chắn muốn thoát khỏi chương trình không?",
             "Xác nhận thoát",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
         );

        
            if (result == DialogResult.No)
            {
               
                e.Cancel = true;
            }
            else
            {
                
                Application.Exit();
            }
        }

        private void FormMainNew_Load(object sender, EventArgs e)
        {
            
            PhanQuyenGiaoDien();
        }

        private void PhanQuyenGiaoDien()
        {
            if (_vaiTro != "ADMIN")
            {
                button_phan_quyen.Visible = false;
                button_dashboard.Visible = false;
            }
            else
            {
                button_phan_quyen.Visible = true;
                button_dashboard.Visible = true;
            }
        }
        private void DangKySuKien()
        {
            // Toggle Menu
            button_Van_Hanh.Click += (s, e) => menuVanHanh.Toggle();
            button_tai_chinh_ke_toan.Click += (s, e) => menuTaiChinh.Toggle();
            button_quan_ly_danh_muc.Click += (s, e) => menuDanhMuc.Toggle();
            button_he_thong.Click += (s, e) => menuHeThong.Toggle();
            button_nha_tro.Click += (s, e) => OpenChildForm(new FormNhaTro());
            button_dashboard.Click += (s, e) => {
                if (_vaiTro == "ADMIN") OpenChildForm(new FormThongKe());
            };

        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null) currentChildForm.Close();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Clear();
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ApplyTheme() 
        {

            Color topbar = Color.FromArgb(13, 71, 161);          
            Color sidebarBg = Color.FromArgb(236, 239, 241);    
            Color parentColor = Color.FromArgb(26, 35, 126);      
            Color parentHover = Color.FromArgb(40, 53, 147);      
            Color childColor = Color.FromArgb(55, 71, 79);        
            Color childHover = Color.FromArgb(69, 90, 100);       
            Color accent = Color.FromArgb(0, 229, 255);           
            Color white = Color.White;

            panelTop.BackColor = topbar;
            panel_logo.BackColor = topbar;
            panel_user.BackColor = Color.FromArgb(250, 250, 250);
            panel_body.BackColor = Color.FromArgb(245, 245, 245);

            flowLayoutPanel_Menu_Trai.BackColor = sidebarBg;

            Button[] parentButtons =
            {
                button_dashboard,
                button_tai_chinh_ke_toan,
                button_Van_Hanh,
                button_quan_ly_danh_muc,
                button_he_thong
            };

            foreach (var btn in parentButtons)
            {
                btn.BackColor = parentColor;
                btn.ForeColor = white;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);

                // Hover
                btn.MouseEnter += (s, e) => btn.BackColor = parentHover;
                btn.MouseLeave += (s, e) => btn.BackColor = parentColor;
            }


            Button[] childButtons =
            {
                button_lap_hoa_don,
                button_thu_chi,
                button_phong,
                button_khach_thue,
                button_hop_dong,
                button_phan_quyen,
                button_doi_mat_khau,
                button_dang_xuat
            };

            foreach (var btn in childButtons)
            {
                btn.BackColor = childColor;
                btn.ForeColor = white;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 14F);

                btn.Padding = new Padding(20, 0, 0, 0);

                btn.MouseEnter += (s, e) => btn.BackColor = childHover;
                btn.MouseLeave += (s, e) => btn.BackColor = childColor;
            }
        }
    }
}