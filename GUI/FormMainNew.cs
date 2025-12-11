using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMainNew : Form
    {
     
        private string _vaiTro;
        private string _hoTen;

        private MenuAnimator menuVanHanh, menuTaiChinh, menuDanhMuc, menuHeThong;
        private Form currentChildForm;

        public FormMainNew(string vaiTro, string hoTen)
        {
            InitializeComponent();
            this._vaiTro = vaiTro;
            this._hoTen = hoTen;

            menuVanHanh = new MenuAnimator(flowLayoutPanel_van_hanh, Van_Hanh_Transition);
            menuTaiChinh = new MenuAnimator(flowLayoutPanel_tai_chinh_ke_toan, Tai_Chinh_Transition);
            menuDanhMuc = new MenuAnimator(flowLayoutPanel_danh_muc, Danh_Muc_Transition);
            menuHeThong = new MenuAnimator(flowLayoutPanel_he_thong, He_Thong_Transition);
            this.FormClosing += FormMainNew_FormClosing;
            button_phong.Click += Button_phong_Click;
            ApplyTheme();
            DangKySuKien();
        }

        private void Button_phong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhongTro());
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
            if (_vaiTro == "NHANVIEN")
            {
                // 1. Thống Kê Doanh Thu -> Ẩn hoàn toàn
                // (Giả sử nút Dashboard là nút xem thống kê)
                button_dashboard.Visible = false;
                // Nếu bạn có nút "Báo cáo doanh thu" riêng trong nhóm Tài chính:
                button_bao_cao_doanh_thu.Visible = false;

                // 2. Quản Lý Nhân Viên -> Ẩn hoàn toàn
                // Thường nằm trong nhóm Hệ thống
                button_phan_quyen.Visible = false; // Ẩn nút phân quyền/nhân viên

                // Nếu muốn ẩn cả nhóm Hệ thống vì nhân viên không cần dùng:
                // flowLayoutPanel_he_thong.Visible = false; 

                // 3. Cấu Hình Giá & Xóa Dữ Liệu
                // Các nút này vẫn HIỆN để nhân viên vào xem, 
                // nhưng vào bên trong sẽ bị khóa (Xử lý ở phần OpenChildForm bên dưới)
            }
        }
        private void DangKySuKien()
        {
            // Toggle Menu
            button_Van_Hanh.Click += (s, e) => menuVanHanh.Toggle();
            button_tai_chinh_ke_toan.Click += (s, e) => menuTaiChinh.Toggle();
            button_quan_ly_danh_muc.Click += (s, e) => menuDanhMuc.Toggle();
            button_he_thong.Click += (s, e) => menuHeThong.Toggle();


            // 1. Cấu hình giá (Dịch vụ) -> Cần truyền quyền để khóa TextBox
            //button_dich_vu.Click += (s, e) => OpenChildForm(new FormDichVu(_vaiTro));

            // 2. Các form danh sách (Phòng, Khách) -> Cần truyền quyền để khóa nút Xóa
            //button_phong.Click += (s, e) => OpenChildForm(new FormPhongTro(_vaiTro));
            //button_khach_thue.Click += (s, e) => OpenChildForm(new FormKhachThue(_vaiTro));
            //button_hop_dong.Click += (s, e) => OpenChildForm(new FormDSHopDong(_vaiTro));

            //// 3. Phiếu Chi -> Cần truyền quyền để giới hạn số tiền
            //button_thu_chi.Click += (s, e) => OpenChildForm(new FormPhieuChi(_vaiTro));

            // Các form bình thường (Ai cũng giống nhau)
            button_dien_nuoc.Click += (s, e) => OpenChildForm(new FormDienNuoc());
            button_nha_tro.Click += (s, e) => OpenChildForm(new FormNhaTro());

            // Nút Thống kê (Admin mới được bấm, dù đã ẩn nhưng chặn thêm ở đây cho chắc)
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
                button_bao_cao_doanh_thu,
                button_phong,
                button_khach_thue,
                button_hop_dong,
                button_dien_nuoc,
                button_nha_tro,
                button_tai_san,
                button_dich_vu,
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