namespace GUI
{
    partial class FormThemHopDong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNhaTro = new System.Windows.Forms.Label();
            this.cboNhaTro = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.lblGiaThue = new System.Windows.Forms.Label();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblChuKy = new System.Windows.Forms.Label();
            this.numChuKy = new System.Windows.Forms.NumericUpDown();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numChuKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(102, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THÊM HỢP ĐỒNG MỚI";
            // 
            // lblNhaTro
            // 
            this.lblNhaTro.AutoSize = true;
            this.lblNhaTro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNhaTro.Location = new System.Drawing.Point(41, 73);
            this.lblNhaTro.Name = "lblNhaTro";
            this.lblNhaTro.Size = new System.Drawing.Size(75, 23);
            this.lblNhaTro.TabIndex = 1;
            this.lblNhaTro.Text = "Nhà Trọ:";
            // 
            // cboNhaTro
            // 
            this.cboNhaTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhaTro.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboNhaTro.Location = new System.Drawing.Point(151, 63);
            this.cboNhaTro.Name = "cboNhaTro";
            this.cboNhaTro.Size = new System.Drawing.Size(250, 39);
            this.cboNhaTro.TabIndex = 9;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhong.Location = new System.Drawing.Point(41, 128);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(104, 23);
            this.lblPhong.TabIndex = 2;
            this.lblPhong.Text = "Phòng thuê:";
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboPhong.Location = new System.Drawing.Point(151, 118);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(250, 39);
            this.cboPhong.TabIndex = 10;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKhachHang.Location = new System.Drawing.Point(41, 183);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(105, 23);
            this.lblKhachHang.TabIndex = 3;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboKhachHang.Location = new System.Drawing.Point(151, 173);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(250, 39);
            this.cboKhachHang.TabIndex = 11;
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTienCoc.Location = new System.Drawing.Point(41, 238);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(80, 23);
            this.lblTienCoc.TabIndex = 4;
            this.lblTienCoc.Text = "Tiền Cọc:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtTienCoc.Location = new System.Drawing.Point(151, 228);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(250, 39);
            this.txtTienCoc.TabIndex = 12;
            // 
            // lblGiaThue
            // 
            this.lblGiaThue.AutoSize = true;
            this.lblGiaThue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiaThue.Location = new System.Drawing.Point(41, 293);
            this.lblGiaThue.Name = "lblGiaThue";
            this.lblGiaThue.Size = new System.Drawing.Size(87, 23);
            this.lblGiaThue.TabIndex = 5;
            this.lblGiaThue.Text = "Giá Thuê: ";
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtGiaThue.Location = new System.Drawing.Point(151, 283);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(250, 39);
            this.txtGiaThue.TabIndex = 13;
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayBatDau.Location = new System.Drawing.Point(41, 348);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(81, 23);
            this.lblNgayBatDau.TabIndex = 6;
            this.lblNgayBatDau.Text = "Ngày BĐ:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(151, 338);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(250, 39);
            this.dtpNgayBatDau.TabIndex = 14;
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayKetThuc.Location = new System.Drawing.Point(41, 406);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(78, 23);
            this.lblNgayKetThuc.TabIndex = 7;
            this.lblNgayKetThuc.Text = "Ngày KT:";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(151, 393);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.ShowCheckBox = true;
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(250, 39);
            this.dtpNgayKetThuc.TabIndex = 15;
            // 
            // lblChuKy
            // 
            this.lblChuKy.AutoSize = true;
            this.lblChuKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChuKy.Location = new System.Drawing.Point(41, 453);
            this.lblChuKy.Name = "lblChuKy";
            this.lblChuKy.Size = new System.Drawing.Size(126, 23);
            this.lblChuKy.TabIndex = 8;
            this.lblChuKy.Text = "Chu kỳ (tháng):";
            // 
            // numChuKy
            // 
            this.numChuKy.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numChuKy.Location = new System.Drawing.Point(173, 444);
            this.numChuKy.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numChuKy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChuKy.Name = "numChuKy";
            this.numChuKy.Size = new System.Drawing.Size(80, 39);
            this.numChuKy.TabIndex = 16;
            this.numChuKy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(101, 489);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(250, 40);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "LƯU HỢP ĐỒNG";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.SlateGray;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(101, 535);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(250, 35);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormThemHopDong
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(440, 591);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNhaTro);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.lblTienCoc);
            this.Controls.Add(this.lblGiaThue);
            this.Controls.Add(this.lblNgayBatDau);
            this.Controls.Add(this.lblNgayKetThuc);
            this.Controls.Add(this.lblChuKy);
            this.Controls.Add(this.cboNhaTro);
            this.Controls.Add(this.cboPhong);
            this.Controls.Add(this.cboKhachHang);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.txtGiaThue);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.numChuKy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormThemHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.numChuKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        // Khai báo biến
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhaTro;
        private System.Windows.Forms.ComboBox cboNhaTro;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label lblGiaThue;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label lblChuKy;
        private System.Windows.Forms.NumericUpDown numChuKy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}