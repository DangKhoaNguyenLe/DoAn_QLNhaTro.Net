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
        public PhongTro()
        {
            InitializeComponent();

            for (int i = 1; i <= 36; i++)
            {
                Button btn = new Button();
                btn.Text = "Phòng " + i;
                btn.Size = new Size(100, 120);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
    }
}
