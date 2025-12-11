using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class ThuePhong
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Label lblHoTen;
        private TextBox txtHoTen;

        private Label lblCCCD;
        private TextBox txtCCCD;

        private Label lblSDT;
        private TextBox txtSDT;

        private Label lblQueQuan;
        private TextBox txtQueQuan;

        private Label lblGioiTinh;
        private RadioButton radNam;
        private RadioButton radNu;

        private Label lblGiaThue;
        private TextBox txtGiaThue;

        private Label lblNgayVao;
        private DateTimePicker dtpNgayVao;

        private PictureBox picTruoc;
        private PictureBox picSau;

        private Button btnChonTruoc;
        private Button btnChonSau;

        private Button btnLuu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lblGiaThue = new System.Windows.Forms.Label();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.lblNgayVao = new System.Windows.Forms.Label();
            this.dtpNgayVao = new System.Windows.Forms.DateTimePicker();
            this.picTruoc = new System.Windows.Forms.PictureBox();
            this.picSau = new System.Windows.Forms.PictureBox();
            this.btnChonTruoc = new System.Windows.Forms.Button();
            this.btnChonSau = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTruoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSau)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(760, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = " ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(40, 70);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(120, 25);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(160, 70);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(220, 26);
            this.txtHoTen.TabIndex = 2;
            // 
            // lblCCCD
            // 
            this.lblCCCD.Location = new System.Drawing.Point(40, 115);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(120, 25);
            this.lblCCCD.TabIndex = 3;
            this.lblCCCD.Text = "CCCD:";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(160, 115);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(220, 26);
            this.txtCCCD.TabIndex = 4;
            // 
            // lblSDT
            // 
            this.lblSDT.Location = new System.Drawing.Point(40, 160);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(120, 25);
            this.lblSDT.TabIndex = 5;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(160, 160);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(220, 26);
            this.txtSDT.TabIndex = 6;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.Location = new System.Drawing.Point(40, 205);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(120, 25);
            this.lblQueQuan.TabIndex = 7;
            this.lblQueQuan.Text = "Quê quán:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(160, 205);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(220, 26);
            this.txtQueQuan.TabIndex = 8;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Location = new System.Drawing.Point(40, 250);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(120, 25);
            this.lblGioiTinh.TabIndex = 9;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // radNam
            // 
            this.radNam.Location = new System.Drawing.Point(160, 250);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(104, 24);
            this.radNam.TabIndex = 10;
            this.radNam.Text = "Nam";
            // 
            // radNu
            // 
            this.radNu.Location = new System.Drawing.Point(160, 250);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(104, 24);
            this.radNu.TabIndex = 11;
            this.radNu.Text = "Nữ";
            // 
            // lblGiaThue
            // 
            this.lblGiaThue.Location = new System.Drawing.Point(40, 295);
            this.lblGiaThue.Name = "lblGiaThue";
            this.lblGiaThue.Size = new System.Drawing.Size(120, 25);
            this.lblGiaThue.TabIndex = 12;
            this.lblGiaThue.Text = "Giá thuê (VNĐ):";
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Location = new System.Drawing.Point(160, 295);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(220, 26);
            this.txtGiaThue.TabIndex = 13;
            // 
            // lblNgayVao
            // 
            this.lblNgayVao.Location = new System.Drawing.Point(40, 340);
            this.lblNgayVao.Name = "lblNgayVao";
            this.lblNgayVao.Size = new System.Drawing.Size(120, 25);
            this.lblNgayVao.TabIndex = 14;
            this.lblNgayVao.Text = "Ngày vào:";
            // 
            // dtpNgayVao
            // 
            this.dtpNgayVao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayVao.Location = new System.Drawing.Point(160, 340);
            this.dtpNgayVao.Name = "dtpNgayVao";
            this.dtpNgayVao.Size = new System.Drawing.Size(220, 26);
            this.dtpNgayVao.TabIndex = 15;
            // 
            // picTruoc
            // 
            this.picTruoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTruoc.Location = new System.Drawing.Point(450, 70);
            this.picTruoc.Name = "picTruoc";
            this.picTruoc.Size = new System.Drawing.Size(260, 180);
            this.picTruoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTruoc.TabIndex = 16;
            this.picTruoc.TabStop = false;
            // 
            // picSau
            // 
            this.picSau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSau.Location = new System.Drawing.Point(450, 310);
            this.picSau.Name = "picSau";
            this.picSau.Size = new System.Drawing.Size(260, 180);
            this.picSau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSau.TabIndex = 17;
            this.picSau.TabStop = false;
            // 
            // btnChonTruoc
            // 
            this.btnChonTruoc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChonTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonTruoc.ForeColor = System.Drawing.Color.White;
            this.btnChonTruoc.Location = new System.Drawing.Point(450, 260);
            this.btnChonTruoc.Name = "btnChonTruoc";
            this.btnChonTruoc.Size = new System.Drawing.Size(260, 35);
            this.btnChonTruoc.TabIndex = 18;
            this.btnChonTruoc.Text = "Chọn ảnh trước";
            this.btnChonTruoc.UseVisualStyleBackColor = false;
            this.btnChonTruoc.Click += new System.EventHandler(this.btnChonTruoc_Click);
            // 
            // btnChonSau
            // 
            this.btnChonSau.BackColor = System.Drawing.Color.SteelBlue;
            this.btnChonSau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonSau.ForeColor = System.Drawing.Color.White;
            this.btnChonSau.Location = new System.Drawing.Point(450, 500);
            this.btnChonSau.Name = "btnChonSau";
            this.btnChonSau.Size = new System.Drawing.Size(260, 35);
            this.btnChonSau.TabIndex = 19;
            this.btnChonSau.Text = "Chọn ảnh sau";
            this.btnChonSau.UseVisualStyleBackColor = false;
            this.btnChonSau.Click += new System.EventHandler(this.btnChonSau_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(180, 400);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 45);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 560);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.lblGiaThue);
            this.Controls.Add(this.txtGiaThue);
            this.Controls.Add(this.lblNgayVao);
            this.Controls.Add(this.dtpNgayVao);
            this.Controls.Add(this.picTruoc);
            this.Controls.Add(this.picSau);
            this.Controls.Add(this.btnChonTruoc);
            this.Controls.Add(this.btnChonSau);
            this.Controls.Add(this.btnLuu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ThuePhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thuê phòng";
            ((System.ComponentModel.ISupportInitialize)(this.picTruoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
