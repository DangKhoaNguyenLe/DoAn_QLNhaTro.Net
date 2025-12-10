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
    public partial class FormMainNew : Form
    {
        // Khai báo animator
        private MenuAnimator menuVanHanh, menuTaiChinh, menuDanhMuc, menuHeThong;

        // Form con
        private Form currentChildForm;
        public FormMainNew()
        {
            InitializeComponent();

            // Khởi tạo animator cho 4 menu
            menuVanHanh = new MenuAnimator(flowLayoutPanel_van_hanh, Van_Hanh_Transition);
            menuTaiChinh = new MenuAnimator(flowLayoutPanel_tai_chinh_ke_toan, Tai_Chinh_Transition);
            menuDanhMuc = new MenuAnimator(flowLayoutPanel_danh_muc, Danh_Muc_Transition);
            menuHeThong = new MenuAnimator(flowLayoutPanel_he_thong, He_Thong_Transition);

            // Gán sự kiện click
            button_Van_Hanh.Click += (s, e) => menuVanHanh.Toggle();
            button_tai_chinh_ke_toan.Click += (s, e) => menuTaiChinh.Toggle();
            button_quan_ly_danh_muc.Click += (s, e) => menuDanhMuc.Toggle();
            button_he_thong.Click += (s, e) => menuHeThong.Toggle();

            // Các nút mở form con
            button_dashboard.Click += (s, e) => OpenChildForm(new FormThongKe());
            button_hop_dong.Click += (s, e) => OpenChildForm(new FormDSHopDong());
            button_phong.Click += (s, e) => OpenChildForm(new FormPhongTro());
            button_khach_thue.Click += (s, e) => OpenChildForm(new FormKhachThue());
            button_nha_tro.Click += (s, e) => OpenChildForm(new FormDayNha());
            button_dien_nuoc.Click += (s, e) => OpenChildForm(new FormDienNuoc());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

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

        private void Button_he_thong_Click(object sender, EventArgs e)
        {
            He_Thong_Transition.Start();
        }

        private void Button_quan_ly_danh_muc_Click(object sender, EventArgs e)
        {
            Danh_Muc_Transition.Start();
        }

        private void Button_tai_chinh_ke_toan_Click(object sender, EventArgs e)
        {
            Tai_Chinh_Transition.Start();
        }

        private void Button_Van_Hanh_Click(object sender, EventArgs e)
        {
            Van_Hanh_Transition.Start();
        }
    }
}
