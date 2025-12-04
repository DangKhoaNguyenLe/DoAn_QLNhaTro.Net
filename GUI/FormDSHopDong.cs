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
using DTO;

namespace GUI
{
    public partial class FormDSHopDong : Form
    {
        HopDongBLL hopDongBLL = new HopDongBLL();
        DayNhaBLL dayNhaBLL = new DayNhaBLL();

        public FormDSHopDong()
        {
            InitializeComponent();
            dataGridView_dshopdong.AutoGenerateColumns = false;
            this.Load += FormDSHopDong_Load;
            comboBox_daynha.SelectedIndexChanged += cmbDayNha_SelectedIndexChanged;
            this.pictureBox_timkiem.Click += pictureBox_timkiem_Click;
            this.pictureBox_lammoi.Click += PictureBox_lammoi_Click;
            this.button_themhopdong.Click += Button_themhopdong_Click;
            this.button_xoahopdong.Click += Button_xoahopdong_Click;
        }

        private void Button_xoahopdong_Click(object sender, EventArgs e)
        {
            if (dataGridView_dshopdong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xóa!");
                return;
            }

            // Lấy hàng đang chọn
            DataGridViewRow row = dataGridView_dshopdong.SelectedRows[0];

            // Lấy ContractID từ cột ẩn
            int contractID = Convert.ToInt32(row.Cells["ContractID"].Value);

            // Xác nhận
            if (MessageBox.Show("Bạn có chắc muốn xóa hợp đồng này?",
                                "Xác nhận", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            // Gọi BLL
            HopDongBLL bll = new HopDongBLL();
            bool result = bll.XoaHopDong(contractID);

            if (result)
            {
                MessageBox.Show("Xóa hợp đồng thành công!");

                // Load lại danh sách
                LoadHopDong();
            }
            else
            {
                MessageBox.Show("Không thể xóa hợp đồng!");
            }
        }


        private void Button_themhopdong_Click(object sender, EventArgs e)
        {
            FormThemHopDong form = new FormThemHopDong();
            form.ShowDialog();
            LoadHopDong();
        }

        private void PictureBox_lammoi_Click(object sender, EventArgs e)
        {
            textBox_lammoi.Clear();
            LoadHopDong();
            if (comboBox_daynha.Items.Count > 0)
                comboBox_daynha.SelectedIndex = 0;
        }

        private void pictureBox_timkiem_Click(object sender, EventArgs e)
        {
            string keyword = textBox_lammoi.Text.Trim();
            string tenDay = comboBox_daynha.Text.Trim();

            // Gọi BLL để tìm kiếm
            List<DanhSachHopDongDTO> result = hopDongBLL.TimKiemTheoTen(keyword, tenDay);

            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách thuê nào phù hợp!", "Kết quả tìm kiếm", MessageBoxButtons.OK,MessageBoxIcon.Information);
                dataGridView_dshopdong.DataSource = null;
                button_tongsohopdong.Text = "0";            
                return;
            }

            dataGridView_dshopdong.DataSource = result;
            UpdateTongSoHopDong();
        }

        private void FormDSHopDong_Load(object sender, EventArgs e)
        {
            LoadDayNha();
            LoadHopDong();
        }

        // ==================== LOAD DÃY NHÀ ===========================
        private void LoadDayNha()
        {
            List<DayNhaDTO> list = dayNhaBLL.getListByAdmin();
            comboBox_daynha.DataSource = list;
            comboBox_daynha.DisplayMember = "HostelName";
            comboBox_daynha.ValueMember = "HostelID";
        }

        // ==================== LOAD HỢP ĐỒNG ===========================
        public void LoadHopDong()
        {
            List<DanhSachHopDongDTO> ds = hopDongBLL.LayDanhSachHopDong();
            dataGridView_dshopdong.DataSource = ds;
            UpdateTongSoHopDong();
        }

        // ==================== LỌC THEO DÃY ============================
        private void cmbDayNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenDay = comboBox_daynha.Text.Trim();
            List<DanhSachHopDongDTO> ds = hopDongBLL.LayHopDongTheoDay(tenDay);
            dataGridView_dshopdong.DataSource = ds;
            UpdateTongSoHopDong();
        }

        private void UpdateTongSoHopDong()
        {
            int soLuong = dataGridView_dshopdong.Rows.Count;
            button_tongsohopdong.Text = soLuong.ToString();
        }
    }
}
