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
    public partial class FormSuaHopDong : Form
    {
        HopDongBLL hopDongBLL = new HopDongBLL();
        DayNhaBLL daynhabll = new DayNhaBLL();
        PhongTroBLL phongtrobll = new PhongTroBLL();
        KhachThueBLL khachThuebll = new KhachThueBLL();

        private int contractID;
        private HopDongDTO currentContract;

        public FormSuaHopDong(int id)
        {
            InitializeComponent();
            contractID = id;
            button_lưu.Click += button_luu_Click;
            this.Load += FormSuaHopDong_Load;
        }

        private void FormSuaHopDong_Load(object sender, EventArgs e)
        {
            LoadComboboxPhong();
            LoadContractInfo();
        }

        private void LoadComboboxPhong()
        {
            comboBox_tenphong.DisplayMember = "RoomName";
            comboBox_tenphong.ValueMember = "RoomID";
        }

        private void LoadContractInfo()
        {
            currentContract = hopDongBLL.LayHopDongTheoID(contractID);

            if (currentContract == null)
            {
                MessageBox.Show("Không tìm thấy hợp đồng!", "Lỗi");
                this.Close();
                return;
            }

            // Gán dữ liệu hiển thị
            textBox_mahopdong.Text = currentContract.ContractCode;

            // Lấy tên nhà trọ
            var hostel = daynhabll.getListByAdmin()
                                   .Find(x => x.HostelID == currentContract.HostelID);
            textBox_tennhatro.Text = hostel?.HostelName ?? "";

            // Load phòng theo nhà trọ
            var dsPhong = phongtrobll.getListByHostel(currentContract.HostelID);
            comboBox_tenphong.DataSource = dsPhong;
            comboBox_tenphong.SelectedValue = currentContract.RoomID;

            // Lấy tên khách thuê
            var tenant = khachThuebll.LayDSKhachThue()
                                     .Find(t => t.TenantID == currentContract.TenantID);
            textBox_khachthue.Text = tenant?.FullName ?? "";

            // Ngày – Tiền – Kỳ – Trạng thái
            dateTimePicker_ngaybatdau.Value = currentContract.NgayBatDau;
            dateTimePicker_ngayketthuc.Value = currentContract.NgayKetThuc;

            textbox_tienphong.Text = currentContract.TienPhong.ToString();
            textBox_tiencoc.Text = currentContract.TienCoc.ToString();

            comboBox_kythanhtoan.Text = currentContract.KyThanhToan;
            numericUpDown_ngaychottien.Value = currentContract.NgayChotTien;

            comboBox_trangthai.Text = currentContract.TrangThai;
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(textbox_tienphong.Text, out decimal tienPhong) ||
                    !decimal.TryParse(textBox_tiencoc.Text, out decimal tienCoc))
                {
                    MessageBox.Show("Tiền phòng hoặc tiền cọc không hợp lệ!");
                    return;
                }

                if (dateTimePicker_ngayketthuc.Value <= dateTimePicker_ngaybatdau.Value)
                {
                    MessageBox.Show("Ngày kết thúc phải > ngày bắt đầu!");
                    return;
                }

                HopDongDTO hd = new HopDongDTO
                {
                    ContractID = contractID,
                    ContractCode = textBox_mahopdong.Text,

                    HostelID = currentContract.HostelID,
                    RoomID = (int)comboBox_tenphong.SelectedValue,
                    TenantID = currentContract.TenantID,

                    NgayBatDau = dateTimePicker_ngaybatdau.Value,
                    NgayKetThuc = dateTimePicker_ngayketthuc.Value,

                    TienPhong = tienPhong,
                    TienCoc = tienCoc,

                    KyThanhToan = comboBox_kythanhtoan.Text,
                    NgayChotTien = (int)numericUpDown_ngaychottien.Value,

                    TrangThai = comboBox_trangthai.Text,
                    CreatedDate = currentContract.CreatedDate
                };

                bool result = hopDongBLL.CapNhatHopDong(hd);

                if (result)
                {
                    MessageBox.Show("Cập nhật hợp đồng thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
