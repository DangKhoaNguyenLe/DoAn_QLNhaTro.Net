using BLL;
using DTO;
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
        PhongTroBLL PhongTroBLL;
        public PhongTro()
        {
            InitializeComponent();
            DayNhaBLL = new DayNhaBLL();
            PhongTroBLL = new PhongTroBLL();
            this.Load += PhongTro_Load;
            this.cmbDayNha.SelectionChangeCommitted += CmbDayNha_SelectionChangeCommitted; ;

        }

        private void CmbDayNha_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int id = int.Parse(cmbDayNha.SelectedValue.ToString()); 
            loadPhong(id);
        }

        private void loadPhong(int id)
        {
           List<PhongTroDTO> phongTros = PhongTroBLL.getListByHostel(id);
            flowLayoutPanel1.Controls.Clear();
            foreach (var i in phongTros)
            {
                Button btn = new Button();
                btn.Text = "Phòng " + i.RoomID;
                btn.Size = new Size(100, 120);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }



        private void PhongTro_Load(object sender, EventArgs e)
        {
            cmbDayNha.DataSource = DayNhaBLL.getList();
            cmbDayNha.DisplayMember = "HostelName";
            cmbDayNha.ValueMember = "HostelID"; 
            cmbDayNha.SelectedIndex = 0;


        }
    }
}
