using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls
{
    public partial class RoomItem : UserControl
    {
        public string MaPhong { get; set; }

        public RoomItem()
        {
            InitializeComponent();
        }

        public void SetData(string tenPhong, string trangThai, Image img)
        {
            lblTenPhong.Text = tenPhong;

            if (img != null)
                pictureBox.Image = img;

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
    }
}
