using BLL;
using DTO;
using DTO.DTO;
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
        //KhachThueBLL ktbll = new KhachThueBLL();
        //DayNhaBLL dayNhaBLL = new DayNhaBLL();
        //public FormKhachThue()
        //{
        //    InitializeComponent();
        //    dataGridView_khachthue.AutoGenerateColumns = false;
        //    this.Load += FormKhachThue_Load;
        //    this.comboBox_daynha.SelectedIndexChanged += comboBox_daynha_SelectedIndexChanged;
        //    this.pictureBox_timkiem.Click += pictureBox_timkiem_Click;
        //    this.pictureBox_lammoi.Click += PictureBox_lammoi_Click;
        //    this.Button_themkhachthue.Click += Button_themkhachthue_Click;
        //    this.Button_xoa.Click += Button_xoa_Click;

        //}


        //private void Button_xoa_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView_khachthue.SelectedRows.Count == 0)
        //    {
        //        MessageBox.Show("Vui lòng chọn khách thuê cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    int selectedIndex = dataGridView_khachthue.SelectedRows[0].Index;
        //    int tenantID = Convert.ToInt32(dataGridView_khachthue.Rows[selectedIndex].Cells["TenantID"].Value);
        //    string tenKhach = dataGridView_khachthue.Rows[selectedIndex].Cells["FullName"].Value.ToString();

        //    DialogResult result = MessageBox.Show(
        //        $"Bạn có chắc chắn muốn xóa khách thuê: {tenKhach}?\n\n" +
        //        "LƯU Ý: Hành động này sẽ xóa toàn bộ Hợp đồng, Hóa đơn và Tài khoản liên quan của khách này!",
        //        "Xác nhận xóa",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Warning);

        //    if (result == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            if (ktbll.XoaKhachThue(tenantID))
        //            {
        //                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                if (comboBox_daynha.SelectedValue != null && int.TryParse(comboBox_daynha.SelectedValue.ToString(), out int hostelID))
        //                {
        //                    dataGridView_khachthue.DataSource = ktbll.LayKhachThueTheoDay(hostelID);
        //                }
        //                else
        //                {
        //                    LoadDSKhachThue();
        //                }

        //                AddSTT();
        //                UpdateTongSoKhachThue();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Xóa thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        //private void Button_themkhachthue_Click(object sender, EventArgs e)
        //{
        //    FormThemKhachThue frm = new FormThemKhachThue();

        //    frm.ShowDialog();
        //    if (comboBox_daynha.SelectedValue != null && int.TryParse(comboBox_daynha.SelectedValue.ToString(), out int hostelID))
        //    {                List<KhachThueDTO> list = ktbll.LayKhachThueTheoDay(hostelID);
        //        dataGridView_khachthue.DataSource = list;
        //    }
        //    else
        //    {
        //        LoadDSKhachThue();
        //    }
        //    AddSTT();
        //    UpdateTongSoKhachThue();
        //}


        //private void FormKhachThue_Load(object sender, EventArgs e)
        //{

        //    LoadDayNha();

        //    if (comboBox_daynha.Items.Count > 0)
        //    {
        //        comboBox_daynha.SelectedIndex = 0; 
        //    }
        //    else
        //    {
        //        LoadDSKhachThue(); 
        //    }
        //}

        //private void PictureBox_lammoi_Click(object sender, EventArgs e)
        //{
        //    textBox_lammoi.Clear();
        //    if (comboBox_daynha.SelectedValue != null && int.TryParse(comboBox_daynha.SelectedValue.ToString(), out int hostelID))
        //    {
        //        List<KhachThueDTO> listKhach = ktbll.LayKhachThueTheoDay(hostelID);

        //        dataGridView_khachthue.DataSource = listKhach;
        //    }
        //    else
        //    {
        //        dataGridView_khachthue.DataSource = null;
        //    }
        //    AddSTT();
        //    UpdateTongSoKhachThue();
        //}

        //private void pictureBox_timkiem_Click(object sender, EventArgs e)
        //{
        //    string keyword = textBox_lammoi.Text.Trim();

        //    if (comboBox_daynha.SelectedValue != null && comboBox_daynha.SelectedValue is int)
        //    {
        //        int hostelID = (int)comboBox_daynha.SelectedValue;
        //        List<KhachThueDTO> result = ktbll.TimKiemTheoTen(keyword, hostelID);

        //        if (result.Count == 0)
        //        {
        //            MessageBox.Show("Không tìm thấy khách thuê nào phù hợp trong dãy này!", "Thông báo");
        //        }
        //        dataGridView_khachthue.DataSource = result;
        //    }

        //    AddSTT();
        //    UpdateTongSoKhachThue();
        //}

        //// ==================== LOAD DÃY NHÀ ===========================
        //private void LoadDayNha()
        //{
        //    List<DayNhaDTO> list = dayNhaBLL.getListByAdmin();
        //    comboBox_daynha.DataSource = list;
        //    comboBox_daynha.DisplayMember = "HostelName";
        //    comboBox_daynha.ValueMember = "HostelID";
        //}
        //public void LoadDSKhachThue()
        //{
        //    dataGridView_khachthue.DataSource = ktbll.LayDSKhachThue();
        //    UpdateTongSoKhachThue();
        //}
        //private void comboBox_daynha_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox_daynha.SelectedValue == null || !(comboBox_daynha.SelectedValue is int))
        //    {
        //        return;
        //    }

        //    int hostelID = (int)comboBox_daynha.SelectedValue;

        //    List<KhachThueDTO> listKhach = ktbll.LayKhachThueTheoDay(hostelID);

        //    dataGridView_khachthue.DataSource = listKhach;
        //    AddSTT();
        //    UpdateTongSoKhachThue();
        //}



        //private void UpdateTongSoKhachThue()
        //{
        //    int soLuong = dataGridView_khachthue.Rows.Count;
        //    button_tongsokhachthue.Text = soLuong.ToString();
        //}
        //private void AddSTT()
        //{
        //    for (int i = 0; i < dataGridView_khachthue.Rows.Count; i++)
        //    {
        //        dataGridView_khachthue.Rows[i].Cells["STT"].Value = i + 1;
        //    }
        //}
    }
}
