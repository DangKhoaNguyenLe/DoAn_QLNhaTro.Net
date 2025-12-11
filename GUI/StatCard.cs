using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class StatCard : UserControl
    {
        private Label lblValue; // Số to
        private Label lblTitle; // Tiêu đề nhỏ
        private TableLayoutPanel layoutTable; // Khung chia dòng

        public StatCard()
        {
            // 1. Cài đặt khung thẻ
            this.Size = new Size(250, 110);
            this.BackColor = Color.White;
            this.Padding = new Padding(10); // Căn lề xung quanh

            InitControls();
        }

        private void InitControls()
        {
            // 2. Tạo TableLayout chia làm 2 dòng
            layoutTable = new TableLayoutPanel();
            layoutTable.Dock = DockStyle.Fill;
            layoutTable.RowCount = 2;
            layoutTable.ColumnCount = 1;

            // Dòng 1 (Chứa số): Chiếm 70% chiều cao
            layoutTable.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            // Dòng 2 (Chứa tiêu đề): Chiếm 30% chiều cao
            layoutTable.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));

            // 3. Tạo Label SỐ LIỆU (Nằm ở dòng 1)
            lblValue = new Label();
            lblValue.Text = "0";
            lblValue.ForeColor = Color.Red;
            // Giảm cỡ chữ xuống 20 cho vừa vặn, không bị quá to
            lblValue.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblValue.Dock = DockStyle.Fill;
            // Căn lề: Nằm giữa bên trái (Tránh bị dính xuống đáy quá)
            lblValue.TextAlign = ContentAlignment.MiddleLeft;

            // 4. Tạo Label TIÊU ĐỀ (Nằm ở dòng 2)
            lblTitle = new Label();
            lblTitle.Text = "TIÊU ĐỀ";
            lblTitle.ForeColor = Color.Gray;
            lblTitle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTitle.Dock = DockStyle.Fill;
            // Căn lề: Nằm trên cùng bên trái (Để sát với số liệu)
            lblTitle.TextAlign = ContentAlignment.TopLeft;

            // 5. Thêm vào bảng (Số dòng 0, Tiêu đề dòng 1)
            layoutTable.Controls.Add(lblValue, 0, 0);
            layoutTable.Controls.Add(lblTitle, 0, 1);

            // Thêm bảng vào UserControl
            this.Controls.Add(layoutTable);
        }

        public void SetData(string title, double value, Color color, bool isMoney)
        {
            lblTitle.Text = title.ToUpper();
            lblValue.ForeColor = color;

            if (isMoney)
                lblValue.Text = value.ToString("N0") + "đ";
            else
                lblValue.Text = value.ToString("N0");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // StatCard
            // 
            this.Name = "StatCard";
            this.Size = new System.Drawing.Size(285, 245);
            this.ResumeLayout(false);

        }
    }
}
