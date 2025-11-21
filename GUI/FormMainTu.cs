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
        public FormMainTu()
        {
            InitializeComponent();
            this.menuTransition.Tick += MenuTransition_Tick;
            this.slidebarTransition.Tick += SlidebarTransition_Tick;
            this.button_khachthue.Click += Button_khachthue_Click;
            this.btn_ThuGon.Click += Btn_ThuGon_Click;
            
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


    }
}
