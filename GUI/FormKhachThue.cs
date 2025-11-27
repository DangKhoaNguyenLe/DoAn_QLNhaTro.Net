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
    public partial class FormKhachThue : Form
    {
        KhachThueBLL ktbll = new KhachThueBLL();
        public FormKhachThue()
        {
            InitializeComponent();
            dataGridView_khachthue.AutoGenerateColumns = false;
            this.Shown += (s, e) =>
            {
                LoadDSKhachThue();
                AddSTT();
            };
        }


        public void LoadDSKhachThue()
        {
            dataGridView_khachthue.DataSource = ktbll.LayDSKhachThue();
        }

        private void AddSTT()
        {
            for (int i = 0; i < dataGridView_khachthue.Rows.Count; i++)
            {
                dataGridView_khachthue.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
    }
}
