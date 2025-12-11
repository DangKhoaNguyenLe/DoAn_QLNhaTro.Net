namespace GUI
{
    partial class FormHopDong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.colMaHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNhaTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiLapPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChiTiet = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_soluong = new System.Windows.Forms.Button();
            this.label_slhd = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.numChuKy = new System.Windows.Forms.NumericUpDown();
            this.lblChuKy = new System.Windows.Forms.Label();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.lblGiaThue = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblNgayBD = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhach = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtMaHopDong = new System.Windows.Forms.TextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnHuyLoc = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboTimTrangThai = new System.Windows.Forms.ComboBox();
            this.cboTimNhaTro = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.grpChiTiet.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChuKy)).BeginInit();
            this.grpTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.SteelBlue;
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1200, 60);
            this.panelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ HỢP ĐỒNG THUÊ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.splitContainerMain);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 60);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(10);
            this.panelBody.Size = new System.Drawing.Size(1200, 849);
            this.panelBody.TabIndex = 1;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerMain.Location = new System.Drawing.Point(10, 10);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.grpDanhSach);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.grpChiTiet);
            this.splitContainerMain.Panel2.Controls.Add(this.grpTimKiem);
            this.splitContainerMain.Size = new System.Drawing.Size(1180, 829);
            this.splitContainerMain.SplitterDistance = 750;
            this.splitContainerMain.SplitterWidth = 10;
            this.splitContainerMain.TabIndex = 0;
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Controls.Add(this.dgvHopDong);
            this.grpDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDanhSach.ForeColor = System.Drawing.Color.SteelBlue;
            this.grpDanhSach.Location = new System.Drawing.Point(0, 0);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(750, 829);
            this.grpDanhSach.TabIndex = 0;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách hợp đồng";
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AllowUserToAddRows = false;
            this.dgvHopDong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvHopDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.BackgroundColor = System.Drawing.Color.White;
            this.dgvHopDong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHopDong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvHopDong.ColumnHeadersHeight = 40;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHopDong,
            this.colTenNhaTro,
            this.colTenPhong,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            this.colTienCoc,
            this.colGiaThue,
            this.colTrangThai,
            this.colChuKy,
            this.colNguoiLap,
            this.colMaPhong,
            this.colMaKhachHang,
            this.NguoiLapPhieu});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHopDong.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHopDong.EnableHeadersVisualStyles = false;
            this.dgvHopDong.GridColor = System.Drawing.Color.LightGray;
            this.dgvHopDong.Location = new System.Drawing.Point(3, 26);
            this.dgvHopDong.MultiSelect = false;
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.RowHeadersVisible = false;
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.RowTemplate.Height = 35;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(744, 800);
            this.dgvHopDong.TabIndex = 0;
            // 
            // colMaHopDong
            // 
            this.colMaHopDong.DataPropertyName = "MaHopDong";
            this.colMaHopDong.FillWeight = 40F;
            this.colMaHopDong.HeaderText = "Mã";
            this.colMaHopDong.MinimumWidth = 6;
            this.colMaHopDong.Name = "colMaHopDong";
            this.colMaHopDong.ReadOnly = true;
            // 
            // colTenNhaTro
            // 
            this.colTenNhaTro.DataPropertyName = "TenNhaTro";
            this.colTenNhaTro.HeaderText = "Nhà Trọ";
            this.colTenNhaTro.MinimumWidth = 6;
            this.colTenNhaTro.Name = "colTenNhaTro";
            this.colTenNhaTro.ReadOnly = true;
            this.colTenNhaTro.Visible = false;
            // 
            // colTenPhong
            // 
            this.colTenPhong.DataPropertyName = "TenPhong";
            this.colTenPhong.FillWeight = 60F;
            this.colTenPhong.HeaderText = "Phòng";
            this.colTenPhong.MinimumWidth = 6;
            this.colTenPhong.Name = "colTenPhong";
            this.colTenPhong.ReadOnly = true;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.DataPropertyName = "NgayBatDau";
            dataGridViewCellStyle10.Format = "dd/MM/yyyy";
            this.colNgayBatDau.DefaultCellStyle = dataGridViewCellStyle10;
            this.colNgayBatDau.HeaderText = "Bắt đầu";
            this.colNgayBatDau.MinimumWidth = 6;
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.ReadOnly = true;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.DataPropertyName = "NgayKetThuc";
            dataGridViewCellStyle11.Format = "dd/MM/yyyy";
            this.colNgayKetThuc.DefaultCellStyle = dataGridViewCellStyle11;
            this.colNgayKetThuc.HeaderText = "Kết thúc";
            this.colNgayKetThuc.MinimumWidth = 6;
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.ReadOnly = true;
            // 
            // colTienCoc
            // 
            this.colTienCoc.DataPropertyName = "TienCoc";
            dataGridViewCellStyle12.Format = "N0";
            this.colTienCoc.DefaultCellStyle = dataGridViewCellStyle12;
            this.colTienCoc.HeaderText = "Cọc";
            this.colTienCoc.MinimumWidth = 6;
            this.colTienCoc.Name = "colTienCoc";
            this.colTienCoc.ReadOnly = true;
            // 
            // colGiaThue
            // 
            this.colGiaThue.DataPropertyName = "GiaThueThucTe";
            dataGridViewCellStyle13.Format = "N0";
            this.colGiaThue.DefaultCellStyle = dataGridViewCellStyle13;
            this.colGiaThue.HeaderText = "Giá Thuê";
            this.colGiaThue.MinimumWidth = 6;
            this.colGiaThue.Name = "colGiaThue";
            this.colGiaThue.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // colChuKy
            // 
            this.colChuKy.DataPropertyName = "ChuKyThanhToan";
            this.colChuKy.HeaderText = "Chu kỳ";
            this.colChuKy.MinimumWidth = 6;
            this.colChuKy.Name = "colChuKy";
            this.colChuKy.ReadOnly = true;
            this.colChuKy.Visible = false;
            // 
            // colNguoiLap
            // 
            this.colNguoiLap.DataPropertyName = "HoTenNguoiLapPhieu";
            this.colNguoiLap.HeaderText = "Người lập";
            this.colNguoiLap.MinimumWidth = 6;
            this.colNguoiLap.Name = "colNguoiLap";
            this.colNguoiLap.ReadOnly = true;
            this.colNguoiLap.Visible = false;
            // 
            // colMaPhong
            // 
            this.colMaPhong.DataPropertyName = "MaPhong";
            this.colMaPhong.HeaderText = "";
            this.colMaPhong.MinimumWidth = 6;
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.ReadOnly = true;
            this.colMaPhong.Visible = false;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.DataPropertyName = "MaKhachHang";
            this.colMaKhachHang.HeaderText = "";
            this.colMaKhachHang.MinimumWidth = 6;
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.ReadOnly = true;
            this.colMaKhachHang.Visible = false;
            // 
            // NguoiLapPhieu
            // 
            this.NguoiLapPhieu.DataPropertyName = "NguoiLapPhieu";
            this.NguoiLapPhieu.HeaderText = "NguoiLapPhieu";
            this.NguoiLapPhieu.MinimumWidth = 6;
            this.NguoiLapPhieu.Name = "NguoiLapPhieu";
            this.NguoiLapPhieu.ReadOnly = true;
            this.NguoiLapPhieu.Visible = false;
            // 
            // grpChiTiet
            // 
            this.grpChiTiet.BackColor = System.Drawing.Color.White;
            this.grpChiTiet.Controls.Add(this.panel1);
            this.grpChiTiet.Controls.Add(this.panelButtons);
            this.grpChiTiet.Controls.Add(this.cboTrangThai);
            this.grpChiTiet.Controls.Add(this.lblTrangThai);
            this.grpChiTiet.Controls.Add(this.numChuKy);
            this.grpChiTiet.Controls.Add(this.lblChuKy);
            this.grpChiTiet.Controls.Add(this.txtGiaThue);
            this.grpChiTiet.Controls.Add(this.lblGiaThue);
            this.grpChiTiet.Controls.Add(this.txtTienCoc);
            this.grpChiTiet.Controls.Add(this.lblTienCoc);
            this.grpChiTiet.Controls.Add(this.dtpNgayKetThuc);
            this.grpChiTiet.Controls.Add(this.lblNgayKT);
            this.grpChiTiet.Controls.Add(this.dtpNgayBatDau);
            this.grpChiTiet.Controls.Add(this.lblNgayBD);
            this.grpChiTiet.Controls.Add(this.cboKhachHang);
            this.grpChiTiet.Controls.Add(this.lblKhach);
            this.grpChiTiet.Controls.Add(this.cboPhong);
            this.grpChiTiet.Controls.Add(this.lblPhong);
            this.grpChiTiet.Controls.Add(this.txtMaHopDong);
            this.grpChiTiet.Controls.Add(this.lblMaHD);
            this.grpChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpChiTiet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpChiTiet.ForeColor = System.Drawing.Color.SteelBlue;
            this.grpChiTiet.Location = new System.Drawing.Point(0, 138);
            this.grpChiTiet.Name = "grpChiTiet";
            this.grpChiTiet.Padding = new System.Windows.Forms.Padding(15);
            this.grpChiTiet.Size = new System.Drawing.Size(420, 691);
            this.grpChiTiet.TabIndex = 1;
            this.grpChiTiet.TabStop = false;
            this.grpChiTiet.Text = "Thông tin chi tiết";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_soluong);
            this.panel1.Controls.Add(this.label_slhd);
            this.panel1.Location = new System.Drawing.Point(199, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 101);
            this.panel1.TabIndex = 19;
            // 
            // button_soluong
            // 
            this.button_soluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_soluong.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_soluong.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_soluong.Location = new System.Drawing.Point(117, 6);
            this.button_soluong.Name = "button_soluong";
            this.button_soluong.Size = new System.Drawing.Size(81, 78);
            this.button_soluong.TabIndex = 2;
            this.button_soluong.Text = "0";
            this.button_soluong.UseVisualStyleBackColor = true;
            // 
            // label_slhd
            // 
            this.label_slhd.AutoSize = true;
            this.label_slhd.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_slhd.Location = new System.Drawing.Point(12, 39);
            this.label_slhd.Name = "label_slhd";
            this.label_slhd.Size = new System.Drawing.Size(99, 45);
            this.label_slhd.TabIndex = 1;
            this.label_slhd.Text = "Tổng";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnLuu);
            this.panelButtons.Controls.Add(this.btnLamMoi);
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(15, 572);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(390, 104);
            this.panelButtons.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(0, 55);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(335, 40);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "LƯU HỢP ĐỒNG";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.SlateGray;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(234, 9);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 40);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Reset";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(34, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(134, 9);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 40);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(38, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Items.AddRange(new object[] {
            "HieuLuc",
            "KetThuc",
            "Huy"});
            this.cboTrangThai.Location = new System.Drawing.Point(167, 461);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(210, 31);
            this.cboTrangThai.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.Black;
            this.lblTrangThai.Location = new System.Drawing.Point(45, 461);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(91, 23);
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // numChuKy
            // 
            this.numChuKy.Location = new System.Drawing.Point(167, 419);
            this.numChuKy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChuKy.Name = "numChuKy";
            this.numChuKy.Size = new System.Drawing.Size(80, 30);
            this.numChuKy.TabIndex = 3;
            this.numChuKy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblChuKy
            // 
            this.lblChuKy.AutoSize = true;
            this.lblChuKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChuKy.ForeColor = System.Drawing.Color.Black;
            this.lblChuKy.Location = new System.Drawing.Point(45, 421);
            this.lblChuKy.Name = "lblChuKy";
            this.lblChuKy.Size = new System.Drawing.Size(126, 23);
            this.lblChuKy.TabIndex = 4;
            this.lblChuKy.Text = "Chu kỳ (tháng):";
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Location = new System.Drawing.Point(167, 381);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(210, 30);
            this.txtGiaThue.TabIndex = 5;
            this.txtGiaThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGiaThue
            // 
            this.lblGiaThue.AutoSize = true;
            this.lblGiaThue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGiaThue.ForeColor = System.Drawing.Color.Black;
            this.lblGiaThue.Location = new System.Drawing.Point(45, 381);
            this.lblGiaThue.Name = "lblGiaThue";
            this.lblGiaThue.Size = new System.Drawing.Size(82, 23);
            this.lblGiaThue.TabIndex = 6;
            this.lblGiaThue.Text = "Giá Thuê:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(167, 338);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(210, 30);
            this.txtTienCoc.TabIndex = 7;
            this.txtTienCoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTienCoc.ForeColor = System.Drawing.Color.Black;
            this.lblTienCoc.Location = new System.Drawing.Point(45, 341);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(80, 23);
            this.lblTienCoc.TabIndex = 8;
            this.lblTienCoc.Text = "Tiền Cọc:";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(167, 295);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(210, 30);
            this.dtpNgayKetThuc.TabIndex = 9;
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayKT.ForeColor = System.Drawing.Color.Black;
            this.lblNgayKT.Location = new System.Drawing.Point(45, 301);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(78, 23);
            this.lblNgayKT.TabIndex = 10;
            this.lblNgayKT.Text = "Ngày KT:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(167, 252);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(210, 30);
            this.dtpNgayBatDau.TabIndex = 11;
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNgayBD.ForeColor = System.Drawing.Color.Black;
            this.lblNgayBD.Location = new System.Drawing.Point(45, 261);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(81, 23);
            this.lblNgayBD.TabIndex = 12;
            this.lblNgayBD.Text = "Ngày BĐ:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Location = new System.Drawing.Point(167, 213);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(210, 31);
            this.cboKhachHang.TabIndex = 13;
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKhach.ForeColor = System.Drawing.Color.Black;
            this.lblKhach.Location = new System.Drawing.Point(45, 221);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(105, 23);
            this.lblKhach.TabIndex = 14;
            this.lblKhach.Text = "Khách hàng:";
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.Location = new System.Drawing.Point(167, 173);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(210, 31);
            this.cboPhong.TabIndex = 15;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhong.ForeColor = System.Drawing.Color.Black;
            this.lblPhong.Location = new System.Drawing.Point(45, 181);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(64, 23);
            this.lblPhong.TabIndex = 16;
            this.lblPhong.Text = "Phòng:";
            // 
            // txtMaHopDong
            // 
            this.txtMaHopDong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaHopDong.Location = new System.Drawing.Point(167, 134);
            this.txtMaHopDong.Name = "txtMaHopDong";
            this.txtMaHopDong.ReadOnly = true;
            this.txtMaHopDong.Size = new System.Drawing.Size(210, 30);
            this.txtMaHopDong.TabIndex = 17;
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMaHD.ForeColor = System.Drawing.Color.Black;
            this.lblMaHD.Location = new System.Drawing.Point(45, 141);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(67, 23);
            this.lblMaHD.TabIndex = 18;
            this.lblMaHD.Text = "Mã HĐ:";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.btnHuyLoc);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.cboTimTrangThai);
            this.grpTimKiem.Controls.Add(this.cboTimNhaTro);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Controls.Add(this.lblTimKiem);
            this.grpTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTimKiem.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.grpTimKiem.Location = new System.Drawing.Point(0, 0);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(420, 138);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm & Lọc";
            // 
            // btnHuyLoc
            // 
            this.btnHuyLoc.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnHuyLoc.FlatAppearance.BorderSize = 0;
            this.btnHuyLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyLoc.ForeColor = System.Drawing.Color.White;
            this.btnHuyLoc.Location = new System.Drawing.Point(175, 96);
            this.btnHuyLoc.Name = "btnHuyLoc";
            this.btnHuyLoc.Size = new System.Drawing.Size(80, 30);
            this.btnHuyLoc.TabIndex = 0;
            this.btnHuyLoc.Text = "Hủy lọc";
            this.btnHuyLoc.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(80, 96);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 30);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // cboTimTrangThai
            // 
            this.cboTimTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTimTrangThai.Items.AddRange(new object[] {
            "Tất cả trạng thái",
            "HieuLuc",
            "KetThuc",
            "Huy"});
            this.cboTimTrangThai.Location = new System.Drawing.Point(80, 62);
            this.cboTimTrangThai.Name = "cboTimTrangThai";
            this.cboTimTrangThai.Size = new System.Drawing.Size(160, 28);
            this.cboTimTrangThai.TabIndex = 3;
            // 
            // cboTimNhaTro
            // 
            this.cboTimNhaTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimNhaTro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTimNhaTro.Location = new System.Drawing.Point(249, 62);
            this.cboTimNhaTro.Name = "cboTimNhaTro";
            this.cboTimNhaTro.Size = new System.Drawing.Size(165, 28);
            this.cboTimNhaTro.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.txtTimKiem.Location = new System.Drawing.Point(80, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 30);
            this.txtTimKiem.TabIndex = 5;
            this.txtTimKiem.Text = "Nhập mã số...";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTimKiem.Location = new System.Drawing.Point(10, 36);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(59, 20);
            this.lblTimKiem.TabIndex = 6;
            this.lblTimKiem.Text = "Mã HĐ:";
            // 
            // FormHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1200, 909);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Name = "FormHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Hợp đồng";
            this.panelTitle.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.grpChiTiet.ResumeLayout(false);
            this.grpChiTiet.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numChuKy)).EndInit();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Biến thành viên
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvHopDong;
        private System.Windows.Forms.GroupBox grpChiTiet;
        private System.Windows.Forms.GroupBox grpTimKiem;

        // --- Controls Tìm Kiếm Mới ---
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.ComboBox cboTimNhaTro;
        private System.Windows.Forms.ComboBox cboTimTrangThai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHuyLoc;

        // --- Controls Chi Tiết ---
        private System.Windows.Forms.Label lblMaHD; private System.Windows.Forms.TextBox txtMaHopDong;
        private System.Windows.Forms.Label lblPhong;         private System.Windows.Forms.Label lblKhach;         private System.Windows.Forms.Label lblNgayBD; private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label lblNgayKT; private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label lblTienCoc; private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.Label lblGiaThue; private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label lblChuKy; private System.Windows.Forms.NumericUpDown numChuKy;
        private System.Windows.Forms.Label lblTrangThai; private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNhaTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiLapPhieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_soluong;
        private System.Windows.Forms.Label label_slhd;
    }
}