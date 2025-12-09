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

        int VanHanhExpandedHeight;
        int VanHanhCollapsedHeight = 60;
        bool VanHanhExpand = false;

        int taiChinhExpandedHeight;
        int taiChinhCollapsedHeight = 60;
        bool taiChinhExpand = false;

        int DanhMucExpandedHeight;
        int DanhMucCollapsedHeight = 60;
        bool DanhMucExpand = false;

        int HeThongExpandedHeight;
        int HeThongCollapsedHeight = 60;
        bool HeThongExpand = false;
        public FormMainNew()
        {
            InitializeComponent();

            this.button_Van_Hanh.Click += Button_Van_Hanh_Click;
            this.Van_Hanh_Transition.Tick += Van_Hanh_Transition_Tick;
            this.VanHanhExpandedHeight = flowLayoutPanel_van_hanh.Height + flowLayoutPanel_van_hanh.Controls.OfType<Control>().Sum(c => c.Height) + 10;

            this.button_tai_chinh_ke_toan.Click += Button_tai_chinh_ke_toan_Click;
            this.Tai_Chinh_Transition.Tick += Tai_Chinh_Transition_Tick;
            this.taiChinhExpandedHeight = flowLayoutPanel_tai_chinh_ke_toan.Height + flowLayoutPanel_tai_chinh_ke_toan.Controls.OfType<Control>().Sum(c => c.Height) + 10;

            this.button_quan_ly_danh_muc.Click += Button_quan_ly_danh_muc_Click;
            this.Danh_Muc_Transition.Tick += Danh_Muc_Transition_Tick;
            this.DanhMucExpandedHeight = flowLayoutPanel_danh_muc.Height + flowLayoutPanel_danh_muc.Controls.OfType<Control>().Sum(c => c.Height) + 10;

            this.button_he_thong.Click += Button_he_thong_Click;
            this.He_Thong_Transition.Tick += He_Thong_Transition_Tick;
            this.HeThongExpandedHeight = flowLayoutPanel_he_thong.Height + flowLayoutPanel_he_thong.Controls.OfType<Control>().Sum(c => c.Height) + 10;
        }



        //Menu thu gon button he thong
        private void Button_he_thong_Click(object sender, EventArgs e)
        {
            He_Thong_Transition.Start();
        }
        private void He_Thong_Transition_Tick(object sender, EventArgs e)
        {
            if (!HeThongExpand)
            {
                flowLayoutPanel_he_thong.Height += 10;
                if (flowLayoutPanel_he_thong.Height >= HeThongExpandedHeight)
                {
                    He_Thong_Transition.Stop();
                    HeThongExpand = true;
                }
            }
            else
            {
                flowLayoutPanel_he_thong.Height -= 10;
                if (flowLayoutPanel_he_thong.Height <= HeThongCollapsedHeight)
                {
                    He_Thong_Transition.Stop();
                    HeThongExpand = false;
                }
            }
        }


        //Menu thu gon button quan ly danh muc
        private void Button_quan_ly_danh_muc_Click(object sender, EventArgs e)
        {
            Danh_Muc_Transition.Start();    
        }

        private void Danh_Muc_Transition_Tick(object sender, EventArgs e)
        {
            if (!DanhMucExpand)
            {
                flowLayoutPanel_danh_muc.Height += 10;
                if (flowLayoutPanel_danh_muc.Height >= DanhMucExpandedHeight)
                {
                    Danh_Muc_Transition.Stop();
                    DanhMucExpand = true;
                }
            }
            else
            {
                flowLayoutPanel_danh_muc.Height -= 10;
                if (flowLayoutPanel_danh_muc.Height <= DanhMucCollapsedHeight)
                {
                    Danh_Muc_Transition.Stop();
                    DanhMucExpand = false;
                }
            }
        }

        //Menu thu gon button tai chinh ke toan
        private void Button_tai_chinh_ke_toan_Click(object sender, EventArgs e)
        {
            Tai_Chinh_Transition.Start();
        }

        private void Tai_Chinh_Transition_Tick(object sender, EventArgs e)
        {
            if (!taiChinhExpand)
            {
                flowLayoutPanel_tai_chinh_ke_toan.Height += 10;
                if (flowLayoutPanel_tai_chinh_ke_toan.Height >= taiChinhExpandedHeight)
                {
                    Tai_Chinh_Transition.Stop();
                    taiChinhExpand = true;
                }
            }
            else
            {
                flowLayoutPanel_tai_chinh_ke_toan.Height -= 10;
                if (flowLayoutPanel_tai_chinh_ke_toan.Height <= taiChinhCollapsedHeight)
                {
                    Tai_Chinh_Transition.Stop();
                    taiChinhExpand = false;
                }
            }
        }

        //Menu thu gon button van hanh

        private void Button_Van_Hanh_Click(object sender, EventArgs e)
        {
            Van_Hanh_Transition.Start();
        }

        private void Van_Hanh_Transition_Tick(object sender, EventArgs e)
        {
            if (!VanHanhExpand)
            {
                flowLayoutPanel_van_hanh.Height += 10;
                if (flowLayoutPanel_van_hanh.Height >= VanHanhExpandedHeight)
                {
                    Van_Hanh_Transition.Stop();
                    VanHanhExpand = true;
                }
            }
            else
            {
                flowLayoutPanel_van_hanh.Height -= 10;
                if (flowLayoutPanel_van_hanh.Height <= VanHanhCollapsedHeight)
                {
                    Van_Hanh_Transition.Stop();
                    VanHanhExpand = false;
                }
            }
        }
    }
}
