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
        HopDongBLL contractBLL = new HopDongBLL();
        PhongTroBLL roomBLL = new PhongTroBLL();
        DayNhaBLL hostelBLL = new DayNhaBLL();
        KhachThueBLL tenantBLL = new KhachThueBLL();
        bool isLoading = false;



        public FormThemHopDong()
        {
            InitializeComponent();
            this.Load += FormThemHopDong_Load;
            comboBox_tenphong.SelectedIndexChanged += comboBox_tenphong_SelectedIndexChanged;
            button_them.Click += btnThem_Click;
        }

        private void FormThemHopDong_Load(object sender, EventArgs e)
        {
            LoadHostel();
            LoadTenant();
            LoadKyThanhToan();

            comboBox_tennhatro.SelectedIndexChanged += comboBox_tennhatro_SelectedIndexChanged;
        }


        private void LoadHostel()
        {
            isLoading = true;

            List<DayNhaDTO> list = hostelBLL.getListByAdmin();

            comboBox_tennhatro.DisplayMember = "HostelName";
            comboBox_tennhatro.ValueMember = "HostelID";

            comboBox_tennhatro.DataSource = list;

            isLoading = false;
        }


        private void LoadTenant()
        {
            List<KhachThueDTO> list = tenantBLL.LayDSKhachThue();
            list = list.Where(t => t.RoomId == 0).ToList();  // khách chưa ở phòng nào

            comboBox_khachthue.DataSource = list;
            comboBox_khachthue.DisplayMember = "FullName";
            comboBox_khachthue.ValueMember = "TenantID";
        }

        private void comboBox_tennhatro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading || comboBox_tennhatro.SelectedValue == null)
                return;

            // Xóa dữ liệu cũ khi đổi nhà trọ
            ClearRoomInfo();

            int hostelID = Convert.ToInt32(comboBox_tennhatro.SelectedValue);

            List<PhongTroDTO> phongConTrong = roomBLL.GetPhongChuaDuNguoi(hostelID);

            comboBox_tenphong.DataSource = null;  // Reset
            comboBox_tenphong.Items.Clear();

            if (phongConTrong.Count == 0)
            {
                MessageBox.Show("Nhà trọ này không có phòng trống!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            comboBox_tenphong.DataSource = phongConTrong;
            comboBox_tenphong.DisplayMember = "RoomName";
            comboBox_tenphong.ValueMember = "RoomID";
        }

        private void ClearRoomInfo()
        {
            comboBox_tenphong.DataSource = null;
            comboBox_tenphong.Items.Clear();
            textbox_tienphong.Text = "";
            textBox_tiencoc.Text = "";
        }


        private void comboBox_tenphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_tenphong.SelectedValue == null)
            {
                textbox_tienphong.Text = "";
                textBox_tiencoc.Text = "";
                return;
            }

            int roomID;

            if (!int.TryParse(comboBox_tenphong.SelectedValue.ToString(), out roomID))
                return;

            var room = roomBLL.FindByID(roomID);
            if (room == null) return;

            textbox_tienphong.Text = room.Price.ToString();
            textBox_tiencoc.Text = room.Deposit.ToString();
        }


        private void LoadKyThanhToan()
        {
            comboBox_kythanhtoan.Items.Clear();
            comboBox_kythanhtoan.Items.Add("Tháng");
            comboBox_kythanhtoan.Items.Add("Quý");
            comboBox_kythanhtoan.Items.Add("6 tháng");
            comboBox_kythanhtoan.Items.Add("1 năm");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HopDongDTO hd = new HopDongDTO();

                // Tạo mã hợp đồng
                DataTable danhSach = contractBLL.LayDanhSachHD();
                int nextId = danhSach.Rows.Count + 1;
                hd.ContractCode = "HD" + nextId.ToString("000");

                // Mapping dữ liệu
                hd.HostelID = (int)comboBox_tennhatro.SelectedValue;
                hd.RoomID = (int)comboBox_tenphong.SelectedValue;
                hd.TenantID = (int)comboBox_khachthue.SelectedValue;

                hd.NgayBatDau = dateTimePicker_ngaybatdau.Value;
                hd.NgayKetThuc = dateTimePicker_ngayketthuc.Value;

                hd.TienPhong = decimal.Parse(textbox_tienphong.Text);
                hd.TienCoc = decimal.Parse(textBox_tiencoc.Text);

                hd.KyThanhToan = comboBox_kythanhtoan.Text;
                hd.NgayChotTien = (int)numericUpDown_ngaychottien.Value;

                hd.TrangThai = "Còn hạn";
                hd.CreatedDate = DateTime.Now;

                // Thêm hợp đồng vào DB
                contractBLL.ThemHopDong(hd);

                // Cập nhật số người thuê phòng
                PhongTroDTO room = roomBLL.FindByID(hd.RoomID);
                room.soNguoiDaThue += 1;
                roomBLL.update(room);

                MessageBox.Show("Thêm hợp đồng thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm hợp đồng: " + ex.Message);
            }
        }
    }
}
