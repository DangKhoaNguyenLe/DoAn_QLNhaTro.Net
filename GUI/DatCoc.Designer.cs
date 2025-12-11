namespace GUI
{
    partial class DatCoc
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenPhong;

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;

        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;

        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.TextBox txtTienCoc;

        private System.Windows.Forms.Label lblHanChot;
        private System.Windows.Forms.DateTimePicker dtpHanChot;

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();

            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();

            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();

            this.lblTienCoc = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();

            this.lblHanChot = new System.Windows.Forms.Label();
            this.dtpHanChot = new System.Windows.Forms.DateTimePicker();

            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Size = new System.Drawing.Size(360, 40);
            this.lblTitle.Text = "ĐẶT CỌC PHÒNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblTenPhong
            // 
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenPhong.Location = new System.Drawing.Point(20, 60);
            this.lblTenPhong.Size = new System.Drawing.Size(360, 30);
            this.lblTenPhong.Text = "Đặt cọc cho phòng: ...";
            this.lblTenPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblHoTen
            // 
            this.lblHoTen.Text = "Họ tên khách:";
            this.lblHoTen.Location = new System.Drawing.Point(20, 110);
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHoTen.Size = new System.Drawing.Size(120, 25);

            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(150, 110);
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHoTen.Size = new System.Drawing.Size(220, 27);

            // 
            // lblSDT
            // 
            this.lblSDT.Text = "Số điện thoại:";
            this.lblSDT.Location = new System.Drawing.Point(20, 155);
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSDT.Size = new System.Drawing.Size(120, 25);

            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(150, 155);
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSDT.Size = new System.Drawing.Size(220, 27);

            // 
            // lblTienCoc
            // 
            this.lblTienCoc.Text = "Tiền cọc (VNĐ):";
            this.lblTienCoc.Location = new System.Drawing.Point(20, 200);
            this.lblTienCoc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTienCoc.Size = new System.Drawing.Size(130, 25);

            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(150, 200);
            this.txtTienCoc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTienCoc.Size = new System.Drawing.Size(220, 27);

            // 
            // lblHanChot
            // 
            this.lblHanChot.Text = "Hạn chót:";
            this.lblHanChot.Location = new System.Drawing.Point(20, 245);
            this.lblHanChot.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblHanChot.Size = new System.Drawing.Size(120, 25);

            // 
            // dtpHanChot
            // 
            this.dtpHanChot.Location = new System.Drawing.Point(150, 245);
            this.dtpHanChot.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpHanChot.Size = new System.Drawing.Size(220, 27);
            this.dtpHanChot.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // 
            // btnLuu
            // 
            this.btnLuu.Text = "Lưu";
            this.btnLuu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(60, 300);
            this.btnLuu.Size = new System.Drawing.Size(120, 40);
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // 
            // btnHuy
            // 
            this.btnHuy.Text = "Hủy";
            this.btnHuy.BackColor = System.Drawing.Color.IndianRed;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(210, 300);
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // 
            // FormDatCoc
            // 
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTenPhong);

            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);

            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);

            this.Controls.Add(this.lblTienCoc);
            this.Controls.Add(this.txtTienCoc);

            this.Controls.Add(this.lblHanChot);
            this.Controls.Add(this.dtpHanChot);

            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Cọc Phòng";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
