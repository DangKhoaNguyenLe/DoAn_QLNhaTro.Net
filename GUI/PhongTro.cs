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
    public partial class PhongTro : Form
    {
        DayNhaBLL DayNhaBLL;
        public PhongTro()
        {
            InitializeComponent();
            DayNhaBLL = new DayNhaBLL();
            this.Load += PhongTro_Load;
            this.cmbDayNha.SelectedIndexChanged += CmbDayNha_SelectedIndexChanged;

            for (int i = 1; i <= 36; i++)
            {
                Button btn = new Button();
                btn.Text = "Phòng " + i;
                btn.Size = new Size(100, 120);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void CmbDayNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PhongTro_Load(object sender, EventArgs e)
        {
            cmbDayNha.DataSource = DayNhaBLL.getList();
            cmbDayNha.DisplayMember = "HostelName";
            cmbDayNha.ValueMember = "HostelID";
        }
    }
}
