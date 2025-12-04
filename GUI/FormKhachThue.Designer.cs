namespace GUI
{
    partial class FormKhachThue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachThue));
            this.dataGridView_khachthue = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.panel_themxoasua = new System.Windows.Forms.Panel();
            this.panel_datagv = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_tongsokhachthue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_xoa = new System.Windows.Forms.Button();
            this.button_suahopdong = new System.Windows.Forms.Button();
            this.Button_themkhachthue = new System.Windows.Forms.Button();
            this.textBox_lammoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_daynha = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_lammoi = new System.Windows.Forms.PictureBox();
            this.pictureBox_timkiem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachthue)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.panel_themxoasua.SuspendLayout();
            this.panel_datagv.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lammoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_timkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_khachthue
            // 
            this.dataGridView_khachthue.AllowUserToAddRows = false;
            this.dataGridView_khachthue.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_khachthue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_khachthue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_khachthue.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_khachthue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_khachthue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_khachthue.ColumnHeadersHeight = 50;
            this.dataGridView_khachthue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.FullName,
            this.Phone,
            this.Email,
            this.Address,
            this.CCCD,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_khachthue.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_khachthue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_khachthue.EnableHeadersVisualStyles = false;
            this.dataGridView_khachthue.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_khachthue.MultiSelect = false;
            this.dataGridView_khachthue.Name = "dataGridView_khachthue";
            this.dataGridView_khachthue.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_khachthue.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_khachthue.RowHeadersVisible = false;
            this.dataGridView_khachthue.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_khachthue.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_khachthue.RowTemplate.Height = 40;
            this.dataGridView_khachthue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_khachthue.Size = new System.Drawing.Size(1018, 231);
            this.dataGridView_khachthue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1022, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH KHÁCH THUÊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_bottom.Controls.Add(this.button_tongsokhachthue);
            this.panel_bottom.Controls.Add(this.label3);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 471);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1022, 77);
            this.panel_bottom.TabIndex = 2;
            // 
            // panel_themxoasua
            // 
            this.panel_themxoasua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_themxoasua.Controls.Add(this.pictureBox_lammoi);
            this.panel_themxoasua.Controls.Add(this.pictureBox_timkiem);
            this.panel_themxoasua.Controls.Add(this.textBox_lammoi);
            this.panel_themxoasua.Controls.Add(this.label2);
            this.panel_themxoasua.Controls.Add(this.comboBox_daynha);
            this.panel_themxoasua.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_themxoasua.Location = new System.Drawing.Point(0, 76);
            this.panel_themxoasua.Name = "panel_themxoasua";
            this.panel_themxoasua.Size = new System.Drawing.Size(1022, 62);
            this.panel_themxoasua.TabIndex = 3;
            // 
            // panel_datagv
            // 
            this.panel_datagv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_datagv.Controls.Add(this.tableLayoutPanel1);
            this.panel_datagv.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_datagv.Location = new System.Drawing.Point(0, 138);
            this.panel_datagv.Name = "panel_datagv";
            this.panel_datagv.Size = new System.Drawing.Size(1022, 98);
            this.panel_datagv.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dataGridView_khachthue);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1022, 235);
            this.panel4.TabIndex = 5;
            // 
            // button_tongsokhachthue
            // 
            this.button_tongsokhachthue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tongsokhachthue.Location = new System.Drawing.Point(319, 14);
            this.button_tongsokhachthue.Name = "button_tongsokhachthue";
            this.button_tongsokhachthue.Size = new System.Drawing.Size(75, 49);
            this.button_tongsokhachthue.TabIndex = 2;
            this.button_tongsokhachthue.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng số khách thuê";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.Button_xoa, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_suahopdong, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button_themkhachthue, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 94);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Button_xoa
            // 
            this.Button_xoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Button_xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_xoa.Location = new System.Drawing.Point(681, 3);
            this.Button_xoa.Name = "Button_xoa";
            this.Button_xoa.Size = new System.Drawing.Size(334, 88);
            this.Button_xoa.TabIndex = 2;
            this.Button_xoa.Text = " Xóa khách thuê";
            this.Button_xoa.UseVisualStyleBackColor = false;
            // 
            // button_suahopdong
            // 
            this.button_suahopdong.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_suahopdong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_suahopdong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_suahopdong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_suahopdong.Location = new System.Drawing.Point(342, 3);
            this.button_suahopdong.Name = "button_suahopdong";
            this.button_suahopdong.Size = new System.Drawing.Size(333, 88);
            this.button_suahopdong.TabIndex = 1;
            this.button_suahopdong.Text = "Sửa khách thuê";
            this.button_suahopdong.UseVisualStyleBackColor = false;
            // 
            // Button_themkhachthue
            // 
            this.Button_themkhachthue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Button_themkhachthue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_themkhachthue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_themkhachthue.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_themkhachthue.Location = new System.Drawing.Point(3, 3);
            this.Button_themkhachthue.Name = "Button_themkhachthue";
            this.Button_themkhachthue.Size = new System.Drawing.Size(333, 88);
            this.Button_themkhachthue.TabIndex = 0;
            this.Button_themkhachthue.Text = "Thêm khách thuê";
            this.Button_themkhachthue.UseVisualStyleBackColor = false;
            // 
            // textBox_lammoi
            // 
            this.textBox_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lammoi.Location = new System.Drawing.Point(610, 9);
            this.textBox_lammoi.Multiline = true;
            this.textBox_lammoi.Name = "textBox_lammoi";
            this.textBox_lammoi.Size = new System.Drawing.Size(257, 42);
            this.textBox_lammoi.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Khách thuê";
            // 
            // comboBox_daynha
            // 
            this.comboBox_daynha.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_daynha.FormattingEnabled = true;
            this.comboBox_daynha.Location = new System.Drawing.Point(215, 6);
            this.comboBox_daynha.Name = "comboBox_daynha";
            this.comboBox_daynha.Size = new System.Drawing.Size(285, 45);
            this.comboBox_daynha.TabIndex = 11;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng Thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa Chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Số Điện Thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ Tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // pictureBox_lammoi
            // 
            this.pictureBox_lammoi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_lammoi.Image")));
            this.pictureBox_lammoi.Location = new System.Drawing.Point(873, 9);
            this.pictureBox_lammoi.Name = "pictureBox_lammoi";
            this.pictureBox_lammoi.Size = new System.Drawing.Size(53, 42);
            this.pictureBox_lammoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_lammoi.TabIndex = 15;
            this.pictureBox_lammoi.TabStop = false;
            // 
            // pictureBox_timkiem
            // 
            this.pictureBox_timkiem.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_timkiem.Image")));
            this.pictureBox_timkiem.Location = new System.Drawing.Point(534, 9);
            this.pictureBox_timkiem.Name = "pictureBox_timkiem";
            this.pictureBox_timkiem.Size = new System.Drawing.Size(53, 42);
            this.pictureBox_timkiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_timkiem.TabIndex = 14;
            this.pictureBox_timkiem.TabStop = false;
            // 
            // FormKhachThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 548);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_datagv);
            this.Controls.Add(this.panel_themxoasua);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.label1);
            this.Name = "FormKhachThue";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_khachthue)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_themxoasua.ResumeLayout(false);
            this.panel_themxoasua.PerformLayout();
            this.panel_datagv.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_lammoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_timkiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_khachthue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_themxoasua;
        private System.Windows.Forms.Panel panel_datagv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_tongsokhachthue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Button_xoa;
        private System.Windows.Forms.Button button_suahopdong;
        private System.Windows.Forms.Button Button_themkhachthue;
        private System.Windows.Forms.PictureBox pictureBox_lammoi;
        private System.Windows.Forms.PictureBox pictureBox_timkiem;
        private System.Windows.Forms.TextBox textBox_lammoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_daynha;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}