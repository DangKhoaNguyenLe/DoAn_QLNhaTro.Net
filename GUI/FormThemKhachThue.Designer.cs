namespace GUI
{
    partial class FormThemKhachThue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbname = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_ngaysnh = new System.Windows.Forms.DateTimePicker();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_gioitinh = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_them = new System.Windows.Forms.Button();
            this.textBox_hoten = new System.Windows.Forms.TextBox();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_CCCD = new System.Windows.Forms.TextBox();
            this.textBox_noicap = new System.Windows.Forms.TextBox();
            this.textBox_quequan = new System.Windows.Forms.TextBox();
            this.dateTimePickerngaycap = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.label3.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(493, 52);
            this.panel1.TabIndex = 13;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.Color.Navy;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbname.Location = new System.Drawing.Point(119, 7);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(247, 32);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Thêm khách thuê";
            this.lbname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox_gioitinh);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(252, 193);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(234, 57);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Giới tính (*)";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBox_noicap);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(252, 130);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(234, 57);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Nơi cấp (*)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_sdt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(252, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 59);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số điện thoại (*)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_CCCD);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 56);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CCCD (*)";
            // 
            // dateTimePicker_ngaysnh
            // 
            this.dateTimePicker_ngaysnh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_ngaysnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker_ngaysnh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaysnh.Location = new System.Drawing.Point(3, 23);
            this.dateTimePicker_ngaysnh.Name = "dateTimePicker_ngaysnh";
            this.dateTimePicker_ngaysnh.Size = new System.Drawing.Size(237, 27);
            this.dateTimePicker_ngaysnh.TabIndex = 15;
            this.dateTimePicker_ngaysnh.Value = new System.DateTime(2025, 12, 4, 1, 15, 45, 0);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dateTimePickerngaycap);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(3, 193);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(243, 57);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Ngày cấp (*)";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 551F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 58);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 315);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_ngaysnh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày sinh (*)";
            // 
            // comboBox_gioitinh
            // 
            this.comboBox_gioitinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_gioitinh.FormattingEnabled = true;
            this.comboBox_gioitinh.Location = new System.Drawing.Point(3, 23);
            this.comboBox_gioitinh.Name = "comboBox_gioitinh";
            this.comboBox_gioitinh.Size = new System.Drawing.Size(228, 28);
            this.comboBox_gioitinh.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_hoten);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 59);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Họ tên(*)";
            // 
            // label3
            // 
            this.label3.Controls.Add(this.textBox_quequan);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 57);
            this.label3.TabIndex = 5;
            this.label3.TabStop = false;
            this.label3.Text = "Quê quán (*)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_email);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(252, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 56);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email (*)";
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.Color.Navy;
            this.button_them.FlatAppearance.BorderSize = 0;
            this.button_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_them.Location = new System.Drawing.Point(169, 391);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(170, 57);
            this.button_them.TabIndex = 15;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = false;
            // 
            // textBox_hoten
            // 
            this.textBox_hoten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_hoten.Location = new System.Drawing.Point(3, 23);
            this.textBox_hoten.Name = "textBox_hoten";
            this.textBox_hoten.Size = new System.Drawing.Size(237, 27);
            this.textBox_hoten.TabIndex = 0;
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_sdt.Location = new System.Drawing.Point(3, 23);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(228, 27);
            this.textBox_sdt.TabIndex = 1;
            // 
            // textBox_email
            // 
            this.textBox_email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_email.Location = new System.Drawing.Point(3, 23);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(228, 27);
            this.textBox_email.TabIndex = 16;
            // 
            // textBox_CCCD
            // 
            this.textBox_CCCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_CCCD.Location = new System.Drawing.Point(3, 23);
            this.textBox_CCCD.Name = "textBox_CCCD";
            this.textBox_CCCD.Size = new System.Drawing.Size(237, 27);
            this.textBox_CCCD.TabIndex = 17;
            // 
            // textBox_noicap
            // 
            this.textBox_noicap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_noicap.Location = new System.Drawing.Point(3, 23);
            this.textBox_noicap.Name = "textBox_noicap";
            this.textBox_noicap.Size = new System.Drawing.Size(228, 27);
            this.textBox_noicap.TabIndex = 17;
            // 
            // textBox_quequan
            // 
            this.textBox_quequan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_quequan.Location = new System.Drawing.Point(3, 23);
            this.textBox_quequan.Name = "textBox_quequan";
            this.textBox_quequan.Size = new System.Drawing.Size(237, 27);
            this.textBox_quequan.TabIndex = 18;
            // 
            // dateTimePickerngaycap
            // 
            this.dateTimePickerngaycap.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerngaycap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerngaycap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerngaycap.Location = new System.Drawing.Point(3, 23);
            this.dateTimePickerngaycap.Name = "dateTimePickerngaycap";
            this.dateTimePickerngaycap.Size = new System.Drawing.Size(237, 27);
            this.dateTimePickerngaycap.TabIndex = 16;
            this.dateTimePickerngaycap.Value = new System.DateTime(2025, 12, 4, 1, 15, 45, 0);
            // 
            // FormThemKhachThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_them);
            this.Name = "FormThemKhachThue";
            this.Text = "FormThemKhachThue";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.label3.ResumeLayout(false);
            this.label3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysnh;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_gioitinh;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.TextBox textBox_hoten;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_CCCD;
        private System.Windows.Forms.TextBox textBox_noicap;
        private System.Windows.Forms.TextBox textBox_quequan;
        private System.Windows.Forms.DateTimePicker dateTimePickerngaycap;
    }
}