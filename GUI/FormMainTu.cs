using BLL;
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
    public partial class FormMainTu : Form
    {
        private Form currentChildForm;
        private UserBLL userBLL;
        bool sidebarExpand = false;
        int taiChinhExpandedHeight;
        int taiChinhCollapsedHeight = 60;
        bool taiChinhExpand = false;
        bool menuExpand = false;
        int menuExpandedHeight;
        int menuCollapsedHeight = 60;



        public FormMainTu()
        {
            InitializeComponent();
            userBLL = new UserBLL();
            this.taiChinhTransition.Tick += TaiChinhTransition_Tick;
            this.menuTransition.Tick += MenuTransition_Tick;
            this.slidebarTransition.Tick += SlidebarTransition_Tick;
            this.button_khachthue.Click += Button_khachthue_Click;
            menuExpandedHeight = panel_khachthue.Height +panel_dshopdong.Height + panel_dskhachthue.Height + 10;
            this.btn_ThuGon.Click += Btn_ThuGon_Click;
            this.button_thongke.Click += Button_thongke_Click;
            this.button_danhsachnha.Click += Button_danhsachnha_Click;
            this.button_phong.Click += Button_phong_Click;
            this.button_dshopdong.Click += Button_dshopdong_Click;
            this.Button_dskhachthue.Click += Button_dskhachthue_Click;
            this.button_taichinh.Click += Button_taichinh_Click;
            taiChinhExpandedHeight = panel_taichinh.Height + panel4.Height + panel5.Height + 10;
            this.button_phieuthu.Click += Button_phieuthu_Click;
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += FormMainTu_FormClosing;
            this.btn_diennuoc.Click += Btn_diennuoc_Click;

        }

        private void Btn_diennuoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDienNuoc());
        }

        private void Button_phieuthu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDSPhieuThu());
        }

        private void Button_taichinh_Click(object sender, EventArgs e)
        {
            taiChinhTransition.Start();
        }



        private void Button_dskhachthue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachThue());

        }


        private void Button_dshopdong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDSHopDong());

        }

        private void Button_khachthue_Click1(object sender, EventArgs e)
        {
        }

        private void Button_phong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPhongTro());
        }

        private void Button_danhsachnha_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDayNha());
        }

        private void Button_thongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKe());
        }

        private void Btn_ThuGon_Click(object sender, EventArgs e)
        {
            slidebarTransition.Start();
        }


        private void SlidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 75)
                {
                    sidebarExpand = false;
                    slidebarTransition.Stop();
                    
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 210)
                {
                    sidebarExpand = true;
                    slidebarTransition.Stop();

                }
            }
        }

        private void Button_khachthue_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }


        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                menuContainer.Height += 10;

                if (menuContainer.Height >= menuExpandedHeight)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;

                if (menuContainer.Height <= menuCollapsedHeight)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }



        private void TaiChinhTransition_Tick(object sender, EventArgs e)
        {
            if (!taiChinhExpand)
            {
                flowLayoutPanel_taichinh.Height += 10;
                if (flowLayoutPanel_taichinh.Height >= taiChinhExpandedHeight)
                {
                    taiChinhTransition.Stop();
                    taiChinhExpand = true;
                }
            }
            else
            {
                flowLayoutPanel_taichinh.Height -= 10;
                if (flowLayoutPanel_taichinh.Height <= taiChinhCollapsedHeight)
                {
                    taiChinhTransition.Stop();
                    taiChinhExpand = false;
                }
            }
        }



        //Hien thi form con
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

            panel_container_main.Controls.Clear();
            panel_container_main.Controls.Add(childForm);
            panel_container_main.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        private void FormMainTu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
         );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                userBLL.getLogout();
            }
        }

    }
}
