using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class FormDoiMatKhau
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Label lblMKCu;
        private TextBox txtMatKhauCu;

        private Label lblMKMoi;
        private TextBox txtMatKhauMoi;

        private Label lblXacNhan;
        private TextBox txtXacNhan;

        private Button btnLuu;
        private Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();

            this.lblMKCu = new Label();
            this.txtMatKhauCu = new TextBox();

            this.lblMKMoi = new Label();
            this.txtMatKhauMoi = new TextBox();

            this.lblXacNhan = new Label();
            this.txtXacNhan = new TextBox();

            this.btnLuu = new Button();
            this.btnHuy = new Button();

            this.SuspendLayout();

            // ================= TITLE =================
            this.lblTitle.Text = "ĐỔI MẬT KHẨU";
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.DarkBlue;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Location = new Point(10, 10);
            this.lblTitle.Size = new Size(380, 45);

            int leftLabel = 30;
            int leftInput = 160;

            // =============== MẬT KHẨU CŨ =================
            this.lblMKCu.Text = "Mật khẩu cũ:";
            this.lblMKCu.Font = new Font("Segoe UI", 12F);
            this.lblMKCu.Location = new Point(leftLabel, 80);
            this.lblMKCu.Size = new Size(130, 30);

            this.txtMatKhauCu.Font = new Font("Segoe UI", 12F);
            this.txtMatKhauCu.Location = new Point(leftInput, 80);
            this.txtMatKhauCu.Size = new Size(180, 30);
            this.txtMatKhauCu.PasswordChar = '•';

            // =============== MẬT KHẨU MỚI =================
            this.lblMKMoi.Text = "Mật khẩu mới:";
            this.lblMKMoi.Font = new Font("Segoe UI", 12F);
            this.lblMKMoi.Location = new Point(leftLabel, 130);
            this.lblMKMoi.Size = new Size(130, 30);

            this.txtMatKhauMoi.Font = new Font("Segoe UI", 12F);
            this.txtMatKhauMoi.Location = new Point(leftInput, 130);
            this.txtMatKhauMoi.Size = new Size(180, 30);
            this.txtMatKhauMoi.PasswordChar = '•';

            // =============== XÁC NHẬN MẬT KHẨU ================
            this.lblXacNhan.Text = "Xác nhận lại:";
            this.lblXacNhan.Font = new Font("Segoe UI", 12F);
            this.lblXacNhan.Location = new Point(leftLabel, 180);
            this.lblXacNhan.Size = new Size(130, 30);

            this.txtXacNhan.Font = new Font("Segoe UI", 12F);
            this.txtXacNhan.Location = new Point(leftInput, 180);
            this.txtXacNhan.Size = new Size(180, 30);
            this.txtXacNhan.PasswordChar = '•';

            // ================= BUTTON LƯU =================
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnLuu.BackColor = Color.MediumSeaGreen;
            this.btnLuu.ForeColor = Color.White;
            this.btnLuu.FlatStyle = FlatStyle.Flat;
            this.btnLuu.Location = new Point(60, 240);
            this.btnLuu.Size = new Size(120, 45);
            this.btnLuu.Click += new EventHandler(this.btnLuu_Click);

            // ================= BUTTON HỦY =================
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnHuy.BackColor = Color.IndianRed;
            this.btnHuy.ForeColor = Color.White;
            this.btnHuy.FlatStyle = FlatStyle.Flat;
            this.btnHuy.Location = new Point(210, 240);
            this.btnHuy.Size = new Size(120, 45);
            this.btnHuy.Click += new EventHandler(this.btnHuy_Click);

            // =============== FORM =====================
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 320);
            this.Controls.Add(this.lblTitle);

            this.Controls.Add(this.lblMKCu);
            this.Controls.Add(this.txtMatKhauCu);

            this.Controls.Add(this.lblMKMoi);
            this.Controls.Add(this.txtMatKhauMoi);

            this.Controls.Add(this.lblXacNhan);
            this.Controls.Add(this.txtXacNhan);

            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
