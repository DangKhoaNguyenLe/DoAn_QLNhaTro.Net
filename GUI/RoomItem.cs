using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class RoomItem : UserControl
    {
        // 1. Khai báo màu sắc (Phải nằm TRONG class)
        private Color _mauVienChon = Color.Blue;       // Màu viền khi được chọn
        private Color _mauNenMacDinh = Color.WhiteSmoke; // Màu nền bình thường (White hoặc WhiteSmoke)

        public string MaPhong { get; set; }

        public RoomItem()
        {
            InitializeComponent();

            // 2. QUAN TRỌNG: Chuyển sự kiện Click từ con ra cha
            // Để khi người dùng bấm vào cái ảnh hay cái chữ, thì Form vẫn nhận được sự kiện Click
            this.pictureBox.Click += (s, e) => this.OnClick(e);
            this.lblTenPhong.Click += (s, e) => this.OnClick(e);
            this.panelStatus.Click += (s, e) => this.OnClick(e);
        }

        // 3. Hàm hiển thị dữ liệu (Code cũ của bạn)
        public void SetData(string tenPhong, string trangThai, Image img)
        {
            lblTenPhong.Text = tenPhong;

            // Xử lý ảnh
            if (img != null)
            {
                pictureBox.Image = img;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Co giãn ảnh cho đẹp
            }
            else
            {
                pictureBox.Image = null; // Hoặc ảnh mặc định
                pictureBox.BackColor = Color.LightGray;
            }

            // Xử lý màu trạng thái
            switch (trangThai)
            {
                case "Trong":
                    panelStatus.BackColor = Color.FromArgb(0, 200, 83);  // Xanh lá
                    break;
                case "DaDatCoc":
                    panelStatus.BackColor = Color.FromArgb(255, 193, 7); // Vàng
                    break;
                case "DaThue":
                    panelStatus.BackColor = Color.FromArgb(244, 67, 54); // Đỏ
                    break;
                default:
                    panelStatus.BackColor = Color.Gray;
                    break;
            }
        }

        // 4. HÀM MỚI: Xử lý Hiệu ứng chọn (Highlight)
        public void SetSelected(bool isSelected)
        {
            if (isSelected)
            {
                // Khi được chọn: Đổi nền thành màu Xanh và tăng Padding để tạo viền
                this.BackColor = _mauVienChon;
                this.Padding = new Padding(3); // Viền dày 3px
            }
            else
            {
                // Khi bỏ chọn: Trả về như cũ
                this.BackColor = _mauNenMacDinh;
                this.Padding = new Padding(0); // Không có viền
            }
        }
    }
}
