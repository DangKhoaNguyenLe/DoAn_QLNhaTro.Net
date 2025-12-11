namespace GUI
{
    partial class FormLapHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox cboNha;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label lblNha;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.Label lblThongBao;

        private System.Windows.Forms.Panel panelNhapLieu;
        private System.Windows.Forms.Label lblDienCu;
        private System.Windows.Forms.TextBox txtDienCu;
        private System.Windows.Forms.Label lblDienMoi;
        private System.Windows.Forms.TextBox txtDienMoi;
        private System.Windows.Forms.Label lblDonGiaDien;
        private System.Windows.Forms.TextBox txtDonGiaDien;
        private System.Windows.Forms.Label lblThanhTienDien;

        private System.Windows.Forms.Label lblNuocCu;
        private System.Windows.Forms.TextBox txtNuocCu;
        private System.Windows.Forms.Label lblNuocMoi;
        private System.Windows.Forms.TextBox txtNuocMoi;
        private System.Windows.Forms.Label lblDonGiaNuoc;
        private System.Windows.Forms.TextBox txtDonGiaNuoc;
        private System.Windows.Forms.Label lblThanhTienNuoc;

        private System.Windows.Forms.Label lblTienDichVu;
        private System.Windows.Forms.TextBox txtTienDichVu;
        private System.Windows.Forms.Label lblGiaPhong;
        private System.Windows.Forms.Label lblTongTien;

        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.Button btnXoaLichSu;

        private System.Windows.Forms.DataGridView dgvLichSu;

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
            this.panelTop = new System.Windows.Forms.Panel();
            this.cboNha = new System.Windows.Forms.ComboBox();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblNha = new System.Windows.Forms.Label();
            this.lblPhong = new System.Windows.Forms.Label();
            this.panelNhapLieu = new System.Windows.Forms.Panel();
            this.lblDienCu = new System.Windows.Forms.Label();
            this.txtDienCu = new System.Windows.Forms.TextBox();
            this.lblDienMoi = new System.Windows.Forms.Label();
            this.txtDienMoi = new System.Windows.Forms.TextBox();
            this.lblDonGiaDien = new System.Windows.Forms.Label();
            this.txtDonGiaDien = new System.Windows.Forms.TextBox();
            this.lblThanhTienDien = new System.Windows.Forms.Label();
            this.lblNuocCu = new System.Windows.Forms.Label();
            this.txtNuocCu = new System.Windows.Forms.TextBox();
            this.lblNuocMoi = new System.Windows.Forms.Label();
            this.txtNuocMoi = new System.Windows.Forms.TextBox();
            this.lblDonGiaNuoc = new System.Windows.Forms.Label();
            this.txtDonGiaNuoc = new System.Windows.Forms.TextBox();
            this.lblThanhTienNuoc = new System.Windows.Forms.Label();
            this.lblTienDichVu = new System.Windows.Forms.Label();
            this.txtTienDichVu = new System.Windows.Forms.TextBox();
            this.lblGiaPhong = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.btnXoaLichSu = new System.Windows.Forms.Button();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panelTop.Controls.Add(this.cboNha);
            this.panelTop.Controls.Add(this.cboPhong);
            this.panelTop.Controls.Add(this.lblThongBao);
            this.panelTop.Controls.Add(this.lblNha);
            this.panelTop.Controls.Add(this.lblPhong);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 80);
            this.panelTop.TabIndex = 0;
            // 
            // cboNha
            // 
            this.cboNha.Location = new System.Drawing.Point(70, 18);
            this.cboNha.Name = "cboNha";
            this.cboNha.Size = new System.Drawing.Size(180, 36);
            this.cboNha.TabIndex = 1;
            // 
            // cboPhong
            // 
            this.cboPhong.Location = new System.Drawing.Point(340, 18);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(180, 36);
            this.cboPhong.TabIndex = 3;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblThongBao.Location = new System.Drawing.Point(550, 22);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(0, 28);
            this.lblThongBao.TabIndex = 4;
            // 
            // lblNha
            // 
            this.lblNha.Location = new System.Drawing.Point(20, 20);
            this.lblNha.Name = "lblNha";
            this.lblNha.Size = new System.Drawing.Size(100, 23);
            this.lblNha.TabIndex = 0;
            this.lblNha.Text = "Nhà:";
            // 
            // lblPhong
            // 
            this.lblPhong.Location = new System.Drawing.Point(270, 20);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(100, 23);
            this.lblPhong.TabIndex = 2;
            this.lblPhong.Text = "Phòng:";
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panelNhapLieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNhapLieu.Controls.Add(this.lblDienCu);
            this.panelNhapLieu.Controls.Add(this.txtDienCu);
            this.panelNhapLieu.Controls.Add(this.lblDienMoi);
            this.panelNhapLieu.Controls.Add(this.txtDienMoi);
            this.panelNhapLieu.Controls.Add(this.lblDonGiaDien);
            this.panelNhapLieu.Controls.Add(this.txtDonGiaDien);
            this.panelNhapLieu.Controls.Add(this.lblThanhTienDien);
            this.panelNhapLieu.Controls.Add(this.lblNuocCu);
            this.panelNhapLieu.Controls.Add(this.txtNuocCu);
            this.panelNhapLieu.Controls.Add(this.lblNuocMoi);
            this.panelNhapLieu.Controls.Add(this.txtNuocMoi);
            this.panelNhapLieu.Controls.Add(this.lblDonGiaNuoc);
            this.panelNhapLieu.Controls.Add(this.txtDonGiaNuoc);
            this.panelNhapLieu.Controls.Add(this.lblThanhTienNuoc);
            this.panelNhapLieu.Controls.Add(this.lblTienDichVu);
            this.panelNhapLieu.Controls.Add(this.txtTienDichVu);
            this.panelNhapLieu.Controls.Add(this.lblGiaPhong);
            this.panelNhapLieu.Controls.Add(this.lblTongTien);
            this.panelNhapLieu.Location = new System.Drawing.Point(20, 100);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(1060, 260);
            this.panelNhapLieu.TabIndex = 1;
            // 
            // lblDienCu
            // 
            this.lblDienCu.Location = new System.Drawing.Point(20, 20);
            this.lblDienCu.Name = "lblDienCu";
            this.lblDienCu.Size = new System.Drawing.Size(100, 23);
            this.lblDienCu.TabIndex = 0;
            this.lblDienCu.Text = "Điện cũ:";
            // 
            // txtDienCu
            // 
            this.txtDienCu.Location = new System.Drawing.Point(120, 18);
            this.txtDienCu.Name = "txtDienCu";
            this.txtDienCu.Size = new System.Drawing.Size(100, 34);
            this.txtDienCu.TabIndex = 1;
            // 
            // lblDienMoi
            // 
            this.lblDienMoi.Location = new System.Drawing.Point(20, 60);
            this.lblDienMoi.Name = "lblDienMoi";
            this.lblDienMoi.Size = new System.Drawing.Size(100, 23);
            this.lblDienMoi.TabIndex = 2;
            this.lblDienMoi.Text = "Điện mới:";
            // 
            // txtDienMoi
            // 
            this.txtDienMoi.Location = new System.Drawing.Point(120, 58);
            this.txtDienMoi.Name = "txtDienMoi";
            this.txtDienMoi.Size = new System.Drawing.Size(100, 34);
            this.txtDienMoi.TabIndex = 3;
            // 
            // lblDonGiaDien
            // 
            this.lblDonGiaDien.Location = new System.Drawing.Point(20, 100);
            this.lblDonGiaDien.Name = "lblDonGiaDien";
            this.lblDonGiaDien.Size = new System.Drawing.Size(100, 23);
            this.lblDonGiaDien.TabIndex = 4;
            this.lblDonGiaDien.Text = "Đơn giá điện:";
            // 
            // txtDonGiaDien
            // 
            this.txtDonGiaDien.Location = new System.Drawing.Point(120, 98);
            this.txtDonGiaDien.Name = "txtDonGiaDien";
            this.txtDonGiaDien.Size = new System.Drawing.Size(100, 34);
            this.txtDonGiaDien.TabIndex = 5;
            // 
            // lblThanhTienDien
            // 
            this.lblThanhTienDien.Location = new System.Drawing.Point(20, 140);
            this.lblThanhTienDien.Name = "lblThanhTienDien";
            this.lblThanhTienDien.Size = new System.Drawing.Size(100, 23);
            this.lblThanhTienDien.TabIndex = 6;
            this.lblThanhTienDien.Text = "Tiền điện: 0";
            // 
            // lblNuocCu
            // 
            this.lblNuocCu.Location = new System.Drawing.Point(350, 20);
            this.lblNuocCu.Name = "lblNuocCu";
            this.lblNuocCu.Size = new System.Drawing.Size(100, 23);
            this.lblNuocCu.TabIndex = 7;
            this.lblNuocCu.Text = "Nước cũ:";
            // 
            // txtNuocCu
            // 
            this.txtNuocCu.Location = new System.Drawing.Point(450, 18);
            this.txtNuocCu.Name = "txtNuocCu";
            this.txtNuocCu.Size = new System.Drawing.Size(100, 34);
            this.txtNuocCu.TabIndex = 8;
            // 
            // lblNuocMoi
            // 
            this.lblNuocMoi.Location = new System.Drawing.Point(350, 60);
            this.lblNuocMoi.Name = "lblNuocMoi";
            this.lblNuocMoi.Size = new System.Drawing.Size(100, 23);
            this.lblNuocMoi.TabIndex = 9;
            this.lblNuocMoi.Text = "Nước mới:";
            // 
            // txtNuocMoi
            // 
            this.txtNuocMoi.Location = new System.Drawing.Point(450, 58);
            this.txtNuocMoi.Name = "txtNuocMoi";
            this.txtNuocMoi.Size = new System.Drawing.Size(100, 34);
            this.txtNuocMoi.TabIndex = 10;
            // 
            // lblDonGiaNuoc
            // 
            this.lblDonGiaNuoc.Location = new System.Drawing.Point(350, 100);
            this.lblDonGiaNuoc.Name = "lblDonGiaNuoc";
            this.lblDonGiaNuoc.Size = new System.Drawing.Size(100, 23);
            this.lblDonGiaNuoc.TabIndex = 11;
            this.lblDonGiaNuoc.Text = "Đơn giá nước:";
            // 
            // txtDonGiaNuoc
            // 
            this.txtDonGiaNuoc.Location = new System.Drawing.Point(450, 98);
            this.txtDonGiaNuoc.Name = "txtDonGiaNuoc";
            this.txtDonGiaNuoc.Size = new System.Drawing.Size(100, 34);
            this.txtDonGiaNuoc.TabIndex = 12;
            // 
            // lblThanhTienNuoc
            // 
            this.lblThanhTienNuoc.Location = new System.Drawing.Point(350, 140);
            this.lblThanhTienNuoc.Name = "lblThanhTienNuoc";
            this.lblThanhTienNuoc.Size = new System.Drawing.Size(100, 23);
            this.lblThanhTienNuoc.TabIndex = 13;
            this.lblThanhTienNuoc.Text = "Tiền nước: 0";
            // 
            // lblTienDichVu
            // 
            this.lblTienDichVu.Location = new System.Drawing.Point(750, 20);
            this.lblTienDichVu.Name = "lblTienDichVu";
            this.lblTienDichVu.Size = new System.Drawing.Size(100, 23);
            this.lblTienDichVu.TabIndex = 14;
            this.lblTienDichVu.Text = "Dịch vụ khác:";
            // 
            // txtTienDichVu
            // 
            this.txtTienDichVu.Location = new System.Drawing.Point(870, 18);
            this.txtTienDichVu.Name = "txtTienDichVu";
            this.txtTienDichVu.Size = new System.Drawing.Size(100, 34);
            this.txtTienDichVu.TabIndex = 15;
            // 
            // lblGiaPhong
            // 
            this.lblGiaPhong.Location = new System.Drawing.Point(750, 70);
            this.lblGiaPhong.Name = "lblGiaPhong";
            this.lblGiaPhong.Size = new System.Drawing.Size(100, 23);
            this.lblGiaPhong.TabIndex = 16;
            this.lblGiaPhong.Text = "Tiền phòng: 0";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTongTien.Location = new System.Drawing.Point(750, 120);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(100, 43);
            this.lblTongTien.TabIndex = 17;
            this.lblTongTien.Text = "Tổng tiền: 0";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnTinhTien.ForeColor = System.Drawing.Color.White;
            this.btnTinhTien.Location = new System.Drawing.Point(20, 380);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(150, 40);
            this.btnTinhTien.TabIndex = 2;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnLuuHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnLuuHoaDon.Location = new System.Drawing.Point(190, 380);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(150, 40);
            this.btnLuuHoaDon.TabIndex = 3;
            this.btnLuuHoaDon.Text = "Lưu hóa đơn";
            this.btnLuuHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnXoaLichSu
            // 
            this.btnXoaLichSu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnXoaLichSu.ForeColor = System.Drawing.Color.White;
            this.btnXoaLichSu.Location = new System.Drawing.Point(360, 380);
            this.btnXoaLichSu.Name = "btnXoaLichSu";
            this.btnXoaLichSu.Size = new System.Drawing.Size(150, 40);
            this.btnXoaLichSu.TabIndex = 4;
            this.btnXoaLichSu.Text = "Xóa lịch sử";
            this.btnXoaLichSu.UseVisualStyleBackColor = false;
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichSu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLichSu.ColumnHeadersHeight = 34;
            this.dgvLichSu.Location = new System.Drawing.Point(20, 440);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersWidth = 62;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(1060, 260);
            this.dgvLichSu.TabIndex = 5;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(535, 380);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(150, 40);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "btnThanhToan";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Visible = false;
            // 
            // FormLapHoaDon
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.btnLuuHoaDon);
            this.Controls.Add(this.btnXoaLichSu);
            this.Controls.Add(this.dgvLichSu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormLapHoaDon";
            this.Text = "Lập Hóa Đơn";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnThanhToan;
    }
}
