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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.btnThongKe.Click += BtnThongKe_Click;
            this.btnDayNha.Click += BtnDayNha_Click;
            this.btnPhongTro.Click += BtnPhongTro_Click;
        }

        private void BtnPhongTro_Click(object sender, EventArgs e)
        {
            LoadForm(new PhongTro());
        }
        private void BtnDayNha_Click(object sender, EventArgs e)
        {
            LoadForm(new DayNha());
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            LoadForm(new ThongKe());
        }
        private void LoadForm(UserControl nameForm)
        {
            panel.Controls.Clear();
            nameForm.Dock = DockStyle.Top;
            panel.Controls.Add(nameForm);
        }
    }
}
