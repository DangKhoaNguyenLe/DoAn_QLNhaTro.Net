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
    public partial class DatCoc : Form
    {

            private int _maPhong;
            private CocBLL _bll = new CocBLL();

            // Constructor nhận vào Mã Phòng và Tên Phòng từ Form chính
            public DatCoc(int maPhong, string tenPhong)
            {
                InitializeComponent();
                _maPhong = maPhong;
                lblTenPhong.Text = "Đặt cọc cho phòng: " + tenPhong;

                // Mặc định hạn chót là 3 ngày sau
                dtpHanChot.Value = DateTime.Now.AddDays(3);
            }

            private void btnLuu_Click(object sender, EventArgs e)
            {
                // 1. Kiểm tra nhập liệu
                if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtTienCoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập Tên khách và Tiền cọc!");
                    return;
                }

                // 2. Tạo DTO
                CocDTO coc = new CocDTO();
                coc.MaPhong = _maPhong;
                coc.HoTenKhach = txtHoTen.Text;
                coc.SDT = txtSDT.Text;

                decimal tien;
                if (decimal.TryParse(txtTienCoc.Text, out tien)) coc.TienCoc = tien;
                else coc.TienCoc = 0;

                coc.HanChot = dtpHanChot.Value;

                // 3. Gọi BLL lưu
                if (_bll.ThemDatCoc(coc))
                {
                    MessageBox.Show("Đặt cọc thành công!");
                    this.DialogResult = DialogResult.OK; // Báo cho Form cha biết là OK
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }

            private void btnHuy_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }

