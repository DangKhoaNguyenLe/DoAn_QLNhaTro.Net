using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class DayNha : UserControl
    {
        DayNhaBLL dayNha;
        public DayNha()
        {
            InitializeComponent();
            dayNha = new DayNhaBLL();
            this.Load += DayNha_Load;
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
            this.btnFormAddDayNha.Click += BtnFormAddDayNha_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnSua.Click += BtnSua_Click;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (drvDayNha.SelectedRows.Count > 0)
            {
                int selectedIndex = drvDayNha.SelectedRows[0].Index;
                int id = int.Parse(drvDayNha.Rows[selectedIndex].Cells["HostelID"].Value.ToString());
                FormDayNha sua = new FormDayNha("Edit dãy nhà", "Cập nhật", id);
                sua.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng nào.", "Thông báo", MessageBoxButtons.OK);
            }
            loadDataGridView(dayNha.getList());
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (drvDayNha.SelectedRows.Count > 0)
            {
                int selectedIndex = drvDayNha.SelectedRows[0].Index;
                int id = int.Parse(drvDayNha.Rows[selectedIndex].Cells["HostelID"].Value.ToString());
                DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    dayNha.delete(id);
                    MessageBox.Show("Xóa thành công", "Thành công", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                }
                loadDataGridView(dayNha.getList());
                CountDayNha(dayNha.getList());
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng nào.", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void BtnFormAddDayNha_Click(object sender, EventArgs e)
        {
            FormDayNha them = new FormDayNha(string.Empty, string.Empty, 0);
            them.ShowDialog();
            loadDataGridView(dayNha.getList());
            CountDayNha(dayNha.getList());
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            loadDataGridView(dayNha.searchByName(txtSearch.Text));
        }

        public void loadDataGridView(List<DayNhaDTO> dayNhas)
        {
            drvDayNha.DataSource = dayNhas;
        }
        public void CountDayNha(List<DayNhaDTO> dayNhas)
        {
            int count = dayNhas.Count();
            lbCount.Text = count.ToString();
        }

        private void DayNha_Load(object sender, EventArgs e)
        {
            loadDataGridView(dayNha.getList());
            CountDayNha(dayNha.getList());
        }


    }
}
