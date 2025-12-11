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
    public partial class FormThemHopDong : Form
    {
        //HopDongBLL contractBLL = new HopDongBLL();
        //PhongTroBLL roomBLL = new PhongTroBLL();
        //DayNhaBLL hostelBLL = new DayNhaBLL();
        //KhachThueBLL tenantBLL = new KhachThueBLL();
        //bool isLoading = false;



        //public FormThemHopDong()
        //{
        //    InitializeComponent();
        //    this.Load += FormThemHopDong_Load;
        //    comboBox_tenphong.SelectedIndexChanged += comboBox_tenphong_SelectedIndexChanged;
        //    button_them.Click += btnThem_Click;
        //}

        //private void FormThemHopDong_Load(object sender, EventArgs e)
        //{
        //    LoadHostel();
        //    LoadTenant();
        //    LoadKyThanhToan();

        //    comboBox_tennhatro.SelectedIndexChanged += comboBox_tennhatro_SelectedIndexChanged;
        //}


        //private void LoadHostel()
        //{
        //    isLoading = true;

        //    List<DayNhaDTO> list = hostelBLL.getListByAdmin();

        //    comboBox_tennhatro.DisplayMember = "HostelName";
        //    comboBox_tennhatro.ValueMember = "HostelID";

        //    comboBox_tennhatro.DataSource = list;

        //    isLoading = false;
        //}


        //private void LoadTenant()
        //{
        //    List<KhachThueDTO> list = tenantBLL.LayDSKhachThue();
        //    list = list.Where(t => t.RoomId == 0).ToList();  // khách chưa ở phòng nào

        //    comboBox_khachthue.DataSource = list;
        //    comboBox_khachthue.DisplayMember = "FullName";
        //    comboBox_khachthue.ValueMember = "TenantID";
        //}

        //private void comboBox_tennhatro_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (isLoading || comboBox_tennhatro.SelectedValue == null)
        //        return;

        //    // Xóa dữ liệu cũ khi đổi nhà trọ
        //    ClearRoomInfo();

        //    int hostelID = Convert.ToInt32(comboBox_tennhatro.SelectedValue);

        //    List<PhongTroDTO> phongConTrong = roomBLL.GetPhongChuaDuNguoi(hostelID);

        //    comboBox_tenphong.DataSource = null;  // Reset
        //    comboBox_tenphong.Items.Clear();

        //    if (phongConTrong.Count == 0)
        //    {
        //        MessageBox.Show("Nhà trọ này không có phòng trống!",
        //            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    comboBox_tenphong.DataSource = phongConTrong;
        //    comboBox_tenphong.DisplayMember = "RoomName";
        //    comboBox_tenphong.ValueMember = "RoomID";
        //}

        //private void ClearRoomInfo()
        //{
        //    comboBox_tenphong.DataSource = null;
        //    comboBox_tenphong.Items.Clear();
        //    textbox_tienphong.Text = "";
        //    textBox_tiencoc.Text = "";
        //}


        //private void comboBox_tenphong_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (comboBox_tenphong.SelectedValue == null)
        //    {
        //        textbox_tienphong.Text = "";
        //        textBox_tiencoc.Text = "";
        //        return;
        //    }

        //    int roomID;

        //    if (!int.TryParse(comboBox_tenphong.SelectedValue.ToString(), out roomID))
        //        return;

        //    var room = roomBLL.FindByID(roomID);
        //    if (room == null) return;

        //    textbox_tienphong.Text = room.Price.ToString();
        //    textBox_tiencoc.Text = room.Deposit.ToString();
        //}


        //private void LoadKyThanhToan()
        //{
        //    comboBox_kythanhtoan.Items.Clear();
        //    comboBox_kythanhtoan.Items.Add("Tháng");
        //}

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        if (comboBox_tennhatro.SelectedItem == null)
        //        {
        //            MessageBox.Show("Vui lòng chọn Nhà trọ!");
        //            return;
        //        }

        //        if (comboBox_tenphong.SelectedItem == null)
        //        {
        //            MessageBox.Show("Vui lòng chọn Phòng!");
        //            return;
        //        }

        //        if (comboBox_khachthue.SelectedItem == null)
        //        {
        //            MessageBox.Show("Vui lòng chọn Khách thuê!");
        //            return;
        //        }

        //        if (string.IsNullOrWhiteSpace(comboBox_kythanhtoan.Text))
        //        {
        //            MessageBox.Show("Vui lòng chọn Kỳ thanh toán!");
        //            return;
        //        }

        //        if (numericUpDown_ngaychottien.Value <= 0)
        //        {
        //            MessageBox.Show("Ngày chốt tiền phải lớn hơn 0!");
        //            return;
        //        }

        //        int hostelID = Convert.ToInt32(comboBox_tennhatro.SelectedValue);
        //        int roomID = Convert.ToInt32(comboBox_tenphong.SelectedValue);
        //        int tenantID = Convert.ToInt32(comboBox_khachthue.SelectedValue);


        //        DateTime ngayBD = dateTimePicker_ngaybatdau.Value;
        //        DateTime ngayKT = dateTimePicker_ngayketthuc.Value;

        //        if (ngayKT <= ngayBD)
        //        {
        //            MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!");
        //            return;
        //        }
        //        if (string.IsNullOrWhiteSpace(textbox_tienphong.Text))
        //        {
        //            MessageBox.Show("Vui lòng nhập Tiền phòng!");
        //            return;
        //        }

        //        if (!decimal.TryParse(textbox_tienphong.Text, out decimal tienPhong))
        //        {
        //            MessageBox.Show("Tiền phòng không hợp lệ!");
        //            return;
        //        }

        //        if (string.IsNullOrWhiteSpace(textBox_tiencoc.Text))
        //        {
        //            MessageBox.Show("Vui lòng nhập Tiền cọc!");
        //            return;
        //        }

        //        if (!decimal.TryParse(textBox_tiencoc.Text, out decimal tienCoc))
        //        {
        //            MessageBox.Show("Tiền cọc không hợp lệ!");
        //            return;
        //        }
        //        int maxId = contractBLL.LayMaxContractID();
        //        string contractCode = "HD" + (maxId + 1).ToString("000");

        //        HopDongDTO hd = new HopDongDTO
        //        {
        //            ContractCode = contractCode,
        //            HostelID = hostelID,
        //            RoomID = roomID,
        //            TenantID = tenantID,

        //            NgayBatDau = ngayBD,
        //            NgayKetThuc = ngayKT,

        //            TienPhong = tienPhong,
        //            TienCoc = tienCoc,

        //            KyThanhToan = comboBox_kythanhtoan.Text,
        //            NgayChotTien = (int)numericUpDown_ngaychottien.Value,

        //            TrangThai = "Còn hạn",
        //            CreatedDate = DateTime.Now
        //        };

        //        contractBLL.ThemHopDong(hd);

        //        MessageBox.Show("Thêm hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi thêm hợp đồng: " + ex.Message);
        //    }
        //}


    }
}
