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
            this.cmbDayNha.SelectionChangeCommitted += CmbDayNha_SelectionChangeCommitted;

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
                btn.BackColor = SystemColors.Control;
                btn.Text = "Phòng " + i.RoomID;
                btn.Name = i.RoomID.ToString();
                btn.Size = new Size(100, 120);
                btn.Click += PhongButton_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void PhongButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int roomId = int.Parse(btn.Name);
            ClearButtonSelection();
            btn.BackColor = Color.LightBlue;

            MessageBox.Show("Bạn chọn phòng: " + roomId);
        }

        private void ClearButtonSelection()
        {
            foreach (Button b in flowLayoutPanel1.Controls.OfType<Button>())
            {
                b.BackColor = SystemColors.Control;
            }
        }


        private void PhongTro_Load(object sender, EventArgs e)
        {
            cmbDayNha.DataSource = DayNhaBLL.getList();
            cmbDayNha.DisplayMember = "HostelName";
            cmbDayNha.ValueMember = "HostelID"; 
            cmbDayNha.Text = "Chọn dãy nhà";
            cmbDayNha.SelectedIndex = 0;


        }
    }
}
