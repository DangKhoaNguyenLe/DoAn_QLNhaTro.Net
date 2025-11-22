using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FormDSHopDong : Form
    {
        HopDongBLL hopDongBLL = new HopDongBLL();

        public FormDSHopDong()
        {
            InitializeComponent();
            dataGridView_dshopdong.AutoGenerateColumns = false;
            this.Dock = DockStyle.Fill;      
            this.AutoSize = false;           
            this.Shown += (s, e) =>
            {
                LoadHopDong();
                AddSTT();
            };
        }
        public void LoadHopDong()
        {
            HopDongBLL hopDongBLL = new HopDongBLL();
            dataGridView_dshopdong.DataSource = hopDongBLL.GetDanhSachHopDong();
        }
        private void AddSTT()
        {
            for (int i = 0; i < dataGridView_dshopdong.Rows.Count; i++)
            {
                dataGridView_dshopdong.Rows[i].Cells["STT"].Value = i + 1;
            }
        }


    }
}
