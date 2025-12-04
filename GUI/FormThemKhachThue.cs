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
    public partial class FormThemKhachThue : Form
    {

        KhachThueBLL khachThueBLL = new KhachThueBLL();
        PhongTroBLL phongTroBLL = new PhongTroBLL();
        public FormThemKhachThue()
        {
            InitializeComponent();

            this.Load += new EventHandler(FormThemKhachThue_Load);

            this.button_them.Click += Button_them_Click;

        }

        private void Button_them_Click(object sender, EventArgs e)
        {
            // 1. Validate dữ liệu (Bắt buộc nhập)
            if (string.IsNullOrWhiteSpace(textBox_hoten.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên khách thuê!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_hoten.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox_sdt.Text) && string.IsNullOrWhiteSpace(textBox_CCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập SĐT hoặc CCCD để tạo tài khoản!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Gom dữ liệu từ giao diện vào DTO
            KhachThueDTO kh = new KhachThueDTO();
            kh.FullName = textBox_hoten.Text.Trim();
            kh.Phone = textBox_sdt.Text.Trim();
            kh.CCCD = textBox_CCCD.Text.Trim();
            kh.Email = textBox_email.Text.Trim();
            kh.BirthDate = dateTimePicker_ngaysnh.Value;
            kh.Address = textBox_quequan.Text.Trim();
            kh.NoiCap = textBox_noicap.Text.Trim();
            kh.NgayCap = dateTimePickerngaycap.Value; 

            // 4. Gọi BLL để thêm vào CSDL
            try
            {
                bool ketQua = khachThueBLL.ThemKhachThue(kh);
                if (ketQua)
                {
                    MessageBox.Show("Thêm khách thuê thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormThemKhachThue_Load(object sender, EventArgs e)
        {
            comboBox_gioitinh.Items.Clear(); 
            comboBox_gioitinh.Items.Add("Nam");
            comboBox_gioitinh.Items.Add("Nữ");
            comboBox_gioitinh.SelectedIndex = 0; 
        }

    }
}
