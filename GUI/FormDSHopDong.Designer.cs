using System.Windows.Forms;

namespace GUI
{
    partial class FormDSHopDong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDSHopDong));
            this.panel_title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_dshopdong = new System.Windows.Forms.DataGridView();
            this.ContractCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_daynha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_lammoi = new System.Windows.Forms.PictureBox();
            this.pictureBox_timkiem = new System.Windows.Forms.PictureBox();
            this.textBox_lammoi = new System.Windows.Forms.TextBox();
            this.panel_themxoasua = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_xoahopdong = new System.Windows.Forms.Button();
            this.button_suahopdong = new System.Windows.Forms.Button();
            this.button_themhopdong = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_tongsohopdong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_dtgv = new System.Windows.Forms.Panel();
            this.panel_timkiem = new System.Windows.Forms.Panel();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dshopdong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lammoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_timkiem)).BeginInit();
            this.panel_themxoasua.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.panel_dtgv.SuspendLayout();
            this.panel_timkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.Color.Turquoise;
            this.panel_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_title.Controls.Add(this.label1);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1019, 78);
            this.panel_title.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1017, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HỢP ĐỒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_dshopdong
            // 
            this.dataGridView_dshopdong.AllowUserToAddRows = false;
            this.dataGridView_dshopdong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_dshopdong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_dshopdong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_dshopdong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_dshopdong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_dshopdong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_dshopdong.ColumnHeadersHeight = 50;
            this.dataGridView_dshopdong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContractCode,
            this.ContractID,
            this.RoomName,
            this.FullName,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.TienPhong,
            this.TienCoc,
            this.TrangThai,
            this.CreatedDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_dshopdong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_dshopdong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_dshopdong.EnableHeadersVisualStyles = false;
            this.dataGridView_dshopdong.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_dshopdong.MultiSelect = false;
            this.dataGridView_dshopdong.Name = "dataGridView_dshopdong";
            this.dataGridView_dshopdong.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_dshopdong.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_dshopdong.RowHeadersVisible = false;
            this.dataGridView_dshopdong.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_dshopdong.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_dshopdong.RowTemplate.Height = 40;
            this.dataGridView_dshopdong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_dshopdong.Size = new System.Drawing.Size(1015, 345);
            this.dataGridView_dshopdong.TabIndex = 6;
            // 
            // ContractCode
            // 
            this.ContractCode.DataPropertyName = "ContractCode";
            this.ContractCode.FillWeight = 101.0934F;
            this.ContractCode.HeaderText = "Mã hợp đồng";
            this.ContractCode.MinimumWidth = 6;
            this.ContractCode.Name = "ContractCode";
            this.ContractCode.ReadOnly = true;
            // 
            // ContractID
            // 
            this.ContractID.DataPropertyName = "ContractID";
            this.ContractID.HeaderText = "ContractID";
            this.ContractID.MinimumWidth = 6;
            this.ContractID.Name = "ContractID";
            this.ContractID.ReadOnly = true;
            this.ContractID.Visible = false;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.FillWeight = 100.1654F;
            this.RoomName.HeaderText = "Phòng";
            this.RoomName.MinimumWidth = 6;
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.FillWeight = 101.1302F;
            this.FullName.HeaderText = "Khách thuê";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.FillWeight = 101.0924F;
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.MinimumWidth = 6;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.FillWeight = 100.1644F;
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            // 
            // TienPhong
            // 
            this.TienPhong.DataPropertyName = "TienPhong";
            this.TienPhong.FillWeight = 101.1294F;
            this.TienPhong.HeaderText = "Tiền phòng";
            this.TienPhong.MinimumWidth = 6;
            this.TienPhong.Name = "TienPhong";
            this.TienPhong.ReadOnly = true;
            // 
            // TienCoc
            // 
            this.TienCoc.DataPropertyName = "TienCoc";
            this.TienCoc.FillWeight = 101.0916F;
            this.TienCoc.HeaderText = "Tiền cọc";
            this.TienCoc.MinimumWidth = 6;
            this.TienCoc.Name = "TienCoc";
            this.TienCoc.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.FillWeight = 100.1638F;
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.FillWeight = 93.96925F;
            this.CreatedDate.HeaderText = "Ngày tạo";
            this.CreatedDate.MinimumWidth = 6;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // comboBox_daynha
            // 
            this.comboBox_daynha.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_daynha.FormattingEnabled = true;
            this.comboBox_daynha.Location = new System.Drawing.Point(145, 2);
            this.comboBox_daynha.Name = "comboBox_daynha";
            this.comboBox_daynha.Size = new System.Drawing.Size(285, 45);
            this.comboBox_daynha.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhà trọ";
            // 
            // pictureBox_lammoi
            // 
            this.pictureBox_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_lammoi.Image")));
            this.pictureBox_lammoi.Location = new System.Drawing.Point(802, 6);
            this.pictureBox_lammoi.Name = "pictureBox_lammoi";
            this.pictureBox_lammoi.Size = new System.Drawing.Size(53, 42);
            this.pictureBox_lammoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_lammoi.TabIndex = 10;
            this.pictureBox_lammoi.TabStop = false;
            // pictureBox_timkiem
            // 
            this.pictureBox_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_timkiem.Image")));
            this.pictureBox_timkiem.Location = new System.Drawing.Point(454, 6);
            this.pictureBox_timkiem.Name = "pictureBox_timkiem";
            this.pictureBox_timkiem.Size = new System.Drawing.Size(53, 42);
            this.pictureBox_timkiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_timkiem.TabIndex = 9;
            this.pictureBox_timkiem.TabStop = false;
            // 
            // textBox_lammoi
            // 
            this.textBox_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lammoi.Location = new System.Drawing.Point(524, 6);
            this.textBox_lammoi.Multiline = true;
            this.textBox_lammoi.Name = "textBox_lammoi";
            this.textBox_lammoi.Size = new System.Drawing.Size(257, 42);
            this.textBox_lammoi.TabIndex = 8;
            // 
            // panel_themxoasua
            // 
            this.panel_themxoasua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_themxoasua.Controls.Add(this.tableLayoutPanel1);
            this.panel_themxoasua.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_themxoasua.Location = new System.Drawing.Point(0, 132);
            this.panel_themxoasua.Name = "panel_themxoasua";
            this.panel_themxoasua.Size = new System.Drawing.Size(1019, 106);
            this.panel_themxoasua.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button_xoahopdong, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_suahopdong, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_themhopdong, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1015, 102);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // button_xoahopdong
            // 
            this.button_xoahopdong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_xoahopdong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_xoahopdong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoahopdong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoahopdong.Location = new System.Drawing.Point(679, 3);
            this.button_xoahopdong.Name = "button_xoahopdong";
            this.button_xoahopdong.Size = new System.Drawing.Size(333, 96);
            this.button_xoahopdong.TabIndex = 2;
            this.button_xoahopdong.Text = " Xóa hợp đồng";
            this.button_xoahopdong.UseVisualStyleBackColor = false;
            // 
            // button_suahopdong
            // 
            this.button_suahopdong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_suahopdong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_suahopdong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_suahopdong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_suahopdong.Location = new System.Drawing.Point(341, 3);
            this.button_suahopdong.Name = "button_suahopdong";
            this.button_suahopdong.Size = new System.Drawing.Size(332, 96);
            this.button_suahopdong.TabIndex = 1;
            this.button_suahopdong.Text = "Sửa hợp đồng";
            this.button_suahopdong.UseVisualStyleBackColor = false;
            // 
            // button_themhopdong
            // 
            this.button_themhopdong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_themhopdong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_themhopdong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_themhopdong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_themhopdong.Location = new System.Drawing.Point(3, 3);
            this.button_themhopdong.Name = "button_themhopdong";
            this.button_themhopdong.Size = new System.Drawing.Size(332, 96);
            this.button_themhopdong.TabIndex = 0;
            this.button_themhopdong.Text = "Thêm hợp đồng";
            this.button_themhopdong.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button_tongsohopdong
            // 
            this.button_tongsohopdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tongsohopdong.Location = new System.Drawing.Point(276, 8);
            this.button_tongsohopdong.Name = "button_tongsohopdong";
            this.button_tongsohopdong.Size = new System.Drawing.Size(75, 49);
            this.button_tongsohopdong.TabIndex = 0;
            this.button_tongsohopdong.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng số hợp đồng";
            // 
            // panel_bottom
            // 
            this.panel_bottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_bottom.Controls.Add(this.button_tongsohopdong);
            this.panel_bottom.Controls.Add(this.label3);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 587);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1019, 66);
            this.panel_bottom.TabIndex = 12;
            // 
            // panel_dtgv
            // 
            this.panel_dtgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_dtgv.Controls.Add(this.dataGridView_dshopdong);
            this.panel_dtgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dtgv.Location = new System.Drawing.Point(0, 238);
            this.panel_dtgv.Name = "panel_dtgv";
            this.panel_dtgv.Size = new System.Drawing.Size(1019, 349);
            this.panel_dtgv.TabIndex = 13;
            // 
            // panel_timkiem
            // 
            this.panel_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_timkiem.Controls.Add(this.pictureBox_lammoi);
            this.panel_timkiem.Controls.Add(this.pictureBox_timkiem);
            this.panel_timkiem.Controls.Add(this.textBox_lammoi);
            this.panel_timkiem.Controls.Add(this.label2);
            this.panel_timkiem.Controls.Add(this.comboBox_daynha);
            this.panel_timkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_timkiem.Location = new System.Drawing.Point(0, 78);
            this.panel_timkiem.Name = "panel_timkiem";
            this.panel_timkiem.Size = new System.Drawing.Size(1019, 54);
            this.panel_timkiem.TabIndex = 9;
            // 
            // FormDSHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 653);
            this.Controls.Add(this.panel_dtgv);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_themxoasua);
            this.Controls.Add(this.panel_timkiem);
            this.Controls.Add(this.panel_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDSHopDong";
            this.Text = "FormDSHopDong";
            this.panel_title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dshopdong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lammoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_timkiem)).EndInit();
            this.panel_themxoasua.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_dtgv.ResumeLayout(false);
            this.panel_timkiem.ResumeLayout(false);
            this.panel_timkiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_title;
        private DataGridView dataGridView_dshopdong;
        private Label label1;
        private ComboBox comboBox_daynha;
        private Label label2;
        private Panel panel_themxoasua;
        private TextBox textBox_lammoi;
        private PictureBox pictureBox_timkiem;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox_lammoi;
        private Label label3;
        private Button button_tongsohopdong;
        private Panel panel_bottom;
        private Panel panel_dtgv;
        private Button button_themhopdong;
        private Button button_xoahopdong;
        private Button button_suahopdong;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel_timkiem;
        private DataGridViewTextBoxColumn ContractCode;
        private DataGridViewTextBoxColumn ContractID;
        private DataGridViewTextBoxColumn RoomName;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayKetThuc;
        private DataGridViewTextBoxColumn TienPhong;
        private DataGridViewTextBoxColumn TienCoc;
        private DataGridViewTextBoxColumn TrangThai;
        private DataGridViewTextBoxColumn CreatedDate;
    }
}
