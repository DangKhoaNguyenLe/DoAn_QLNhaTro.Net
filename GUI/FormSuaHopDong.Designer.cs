namespace GUI
{
    partial class FormSuaHopDong
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbname = new System.Windows.Forms.Label();
            this.numericUpDown_ngaychottien = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_ngayketthuc = new System.Windows.Forms.DateTimePicker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboBox_trangthai = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_mahopdong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_kythanhtoan = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_ngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_tenphong = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textbox_tienphong = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBox_tiencoc = new System.Windows.Forms.TextBox();
            this.button_lưu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_tennhatro = new System.Windows.Forms.TextBox();
            this.textBox_khachthue = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ngaychottien)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.label3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 52);
            this.panel1.TabIndex = 13;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.Color.Navy;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbname.Location = new System.Drawing.Point(136, 7);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(203, 32);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Sửa hợp đồng";
            this.lbname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_ngaychottien
            // 
            this.numericUpDown_ngaychottien.Location = new System.Drawing.Point(3, 23);
            this.numericUpDown_ngaychottien.Name = "numericUpDown_ngaychottien";
            this.numericUpDown_ngaychottien.Size = new System.Drawing.Size(228, 27);
            this.numericUpDown_ngaychottien.TabIndex = 19;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numericUpDown_ngaychottien);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(252, 256);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(234, 57);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ngày chốt tiền (*)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_khachthue);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 56);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Khách thuê (*)";
            // 
            // dateTimePicker_ngayketthuc
            // 
            this.dateTimePicker_ngayketthuc.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngayketthuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_ngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngayketthuc.Location = new System.Drawing.Point(3, 23);
            this.dateTimePicker_ngayketthuc.Name = "dateTimePicker_ngayketthuc";
            this.dateTimePicker_ngayketthuc.Size = new System.Drawing.Size(237, 27);
            this.dateTimePicker_ngayketthuc.TabIndex = 15;
            this.dateTimePicker_ngayketthuc.Value = new System.DateTime(2025, 12, 4, 1, 15, 45, 0);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dateTimePicker_ngayketthuc);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(3, 193);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(243, 57);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Ngày kết thúc (*)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 551F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox10, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 379);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.comboBox_trangthai);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(3, 321);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(243, 55);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Trạng thái (*)";
            // 
            // comboBox_trangthai
            // 
            this.comboBox_trangthai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_trangthai.FormattingEnabled = true;
            this.comboBox_trangthai.Location = new System.Drawing.Point(3, 23);
            this.comboBox_trangthai.Name = "comboBox_trangthai";
            this.comboBox_trangthai.Size = new System.Drawing.Size(237, 28);
            this.comboBox_trangthai.TabIndex = 13;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_mahopdong);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(252, 68);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(234, 56);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mã hợp đồng (*)";
            // 
            // textBox_mahopdong
            // 
            this.textBox_mahopdong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_mahopdong.Location = new System.Drawing.Point(3, 23);
            this.textBox_mahopdong.Name = "textBox_mahopdong";
            this.textBox_mahopdong.ReadOnly = true;
            this.textBox_mahopdong.Size = new System.Drawing.Size(228, 27);
            this.textBox_mahopdong.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_kythanhtoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 59);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kỳ thanh toán (*)";
            // 
            // comboBox_kythanhtoan
            // 
            this.comboBox_kythanhtoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_kythanhtoan.FormattingEnabled = true;
            this.comboBox_kythanhtoan.Location = new System.Drawing.Point(3, 23);
            this.comboBox_kythanhtoan.Name = "comboBox_kythanhtoan";
            this.comboBox_kythanhtoan.Size = new System.Drawing.Size(237, 28);
            this.comboBox_kythanhtoan.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_tennhatro);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 59);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tên nhà trọ(*)";
            // 
            // label3
            // 
            this.label3.Controls.Add(this.dateTimePicker_ngaybatdau);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 57);
            this.label3.TabIndex = 5;
            this.label3.TabStop = false;
            this.label3.Text = "Ngày bắt đầu (*)";
            // 
            // dateTimePicker_ngaybatdau
            // 
            this.dateTimePicker_ngaybatdau.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngaybatdau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaybatdau.Location = new System.Drawing.Point(3, 23);
            this.dateTimePicker_ngaybatdau.Name = "dateTimePicker_ngaybatdau";
            this.dateTimePicker_ngaybatdau.Size = new System.Drawing.Size(237, 27);
            this.dateTimePicker_ngaybatdau.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_tenphong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(252, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 59);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tên phòng(*)";
            // 
            // comboBox_tenphong
            // 
            this.comboBox_tenphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_tenphong.FormattingEnabled = true;
            this.comboBox_tenphong.Location = new System.Drawing.Point(3, 23);
            this.comboBox_tenphong.Name = "comboBox_tenphong";
            this.comboBox_tenphong.Size = new System.Drawing.Size(228, 28);
            this.comboBox_tenphong.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textbox_tienphong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(252, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 56);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiền phòng (*)";
            // 
            // textbox_tienphong
            // 
            this.textbox_tienphong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox_tienphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_tienphong.Location = new System.Drawing.Point(3, 23);
            this.textbox_tienphong.Name = "textbox_tienphong";
            this.textbox_tienphong.Size = new System.Drawing.Size(228, 28);
            this.textbox_tienphong.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox_tiencoc);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(252, 193);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(234, 56);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tiền cọc (*)";
            // 
            // textBox_tiencoc
            // 
            this.textBox_tiencoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_tiencoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tiencoc.Location = new System.Drawing.Point(3, 23);
            this.textBox_tiencoc.Name = "textBox_tiencoc";
            this.textBox_tiencoc.Size = new System.Drawing.Size(228, 28);
            this.textBox_tiencoc.TabIndex = 0;
            // 
            // button_lưu
            // 
            this.button_lưu.BackColor = System.Drawing.Color.Navy;
            this.button_lưu.FlatAppearance.BorderSize = 0;
            this.button_lưu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lưu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lưu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_lưu.Location = new System.Drawing.Point(156, 485);
            this.button_lưu.Name = "button_lưu";
            this.button_lưu.Size = new System.Drawing.Size(170, 57);
            this.button_lưu.TabIndex = 15;
            this.button_lưu.Text = "Lưu";
            this.button_lưu.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_tennhatro
            // 
            this.textBox_tennhatro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_tennhatro.Location = new System.Drawing.Point(3, 23);
            this.textBox_tennhatro.Name = "textBox_tennhatro";
            this.textBox_tennhatro.ReadOnly = true;
            this.textBox_tennhatro.Size = new System.Drawing.Size(237, 27);
            this.textBox_tennhatro.TabIndex = 16;
            // 
            // textBox_khachthue
            // 
            this.textBox_khachthue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_khachthue.Location = new System.Drawing.Point(3, 23);
            this.textBox_khachthue.Name = "textBox_khachthue";
            this.textBox_khachthue.Size = new System.Drawing.Size(237, 27);
            this.textBox_khachthue.TabIndex = 0;
            // 
            // FormSuaHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_lưu);
            this.Name = "FormSuaHopDong";
            this.Text = "FormSuaHopDong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ngaychottien)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.label3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.NumericUpDown numericUpDown_ngaychottien;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayketthuc;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaybatdau;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textbox_tienphong;
        private System.Windows.Forms.Button button_lưu;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_tenphong;
        private System.Windows.Forms.TextBox textBox_mahopdong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox comboBox_trangthai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_kythanhtoan;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBox_tiencoc;
        private System.Windows.Forms.TextBox textBox_tennhatro;
        private System.Windows.Forms.TextBox textBox_khachthue;
    }
}