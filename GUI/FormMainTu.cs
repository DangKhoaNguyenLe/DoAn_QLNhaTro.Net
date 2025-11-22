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

        public FormMainTu()
        {
            InitializeComponent();
            userBLL = new UserBLL();
            this.menuTransition.Tick += MenuTransition_Tick;
            this.slidebarTransition.Tick += SlidebarTransition_Tick;
            this.button_khachthue.Click += Button_khachthue_Click;
            this.btn_ThuGon.Click += Btn_ThuGon_Click;
            this.button_trangchu.Click += Button_taikhoan_Click;
            this.button_thongke.Click += Button_thongke_Click;
            this.button_danhsachnha.Click += Button_danhsachnha_Click;
            this.button_phong.Click += Button_phong_Click;
            this.button_dshopdong.Click += Button_dshopdong_Click;
            this.Button_dskhachthue.Click += Button_dskhachthue_Click;
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += FormMainTu_FormClosing;

        }

        private void FormMainTu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?","Xác nhận thoát",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question
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

        private void Button_dskhachthue_Click(object sender, EventArgs e)
        {
        }

        private void Button_dshopdong_Click1(object sender, EventArgs e)
        {
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
            OpenChildForm(new PhongTro());
        }

        private void Button_danhsachnha_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDayNha());
        }

        private void Button_thongke_Click(object sender, EventArgs e)
        {
            
        }

        private void Button_taikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTaiKhoan());
        }

        private void Btn_ThuGon_Click(object sender, EventArgs e)
        {
            slidebarTransition.Start();
        }

        bool sidebarExpand = false;
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

        bool menuExpand = false;

        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                // Mở rộng
                menuContainer.Height += 10;
                if (menuContainer.Height >= 215)   // chiều cao menu mở
                {
                    menuTransition.Stop();
                    menuExpand = true;             // Đánh dấu đang mở
                }
            }
            else
            {
                // Thu gọn
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 70)    // chiều cao menu thu gọn
                {
                    menuTransition.Stop();
                    menuExpand = false;            // Đánh dấu đã thu
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





    }
}
