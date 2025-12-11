namespace GUI
{
    partial class FormThemNhaTro
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
            this.button_them = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox_ten_nha_tro = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_dia_chi = new System.Windows.Forms.TextBox();
            this.textBox_khachthue = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGhiChu = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbQuanLy = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.anhNhaTro = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.btnGhiChu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhNhaTro)).BeginInit();
            this.SuspendLayout();
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.Color.Navy;
            this.button_them.FlatAppearance.BorderSize = 0;
            this.button_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_them.Location = new System.Drawing.Point(115, 447);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(170, 57);
            this.button_them.TabIndex = 18;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = false;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.Color.Navy;
            this.lbname.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbname.Location = new System.Drawing.Point(95, 7);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(224, 38);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "THÊM NHÀ TRỌ";
            this.lbname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 52);
            this.panel1.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox_ten_nha_tro);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(400, 68);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tên Nhà Trọ (*)";
            // 
            // textBox_ten_nha_tro
            // 
            this.textBox_ten_nha_tro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ten_nha_tro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_ten_nha_tro.Location = new System.Drawing.Point(3, 26);
            this.textBox_ten_nha_tro.Name = "textBox_ten_nha_tro";
            this.textBox_ten_nha_tro.Size = new System.Drawing.Size(394, 34);
            this.textBox_ten_nha_tro.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_dia_chi);
            this.groupBox4.Controls.Add(this.textBox_khachthue);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.Location = new System.Drawing.Point(3, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 68);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Địa Chỉ (*)";
            // 
            // textBox_dia_chi
            // 
            this.textBox_dia_chi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_dia_chi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox_dia_chi.Location = new System.Drawing.Point(3, 26);
            this.textBox_dia_chi.Name = "textBox_dia_chi";
            this.textBox_dia_chi.Size = new System.Drawing.Size(395, 34);
            this.textBox_dia_chi.TabIndex = 1;
            // 
            // textBox_khachthue
            // 
            this.textBox_khachthue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_khachthue.Location = new System.Drawing.Point(3, 26);
            this.textBox_khachthue.Name = "textBox_khachthue";
            this.textBox_khachthue.Size = new System.Drawing.Size(395, 30);
            this.textBox_khachthue.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Controls.Add(this.groupBox4);
            this.flowLayoutPanel1.Controls.Add(this.btnGhiChu);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(403, 383);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGhiChu
            // 
            this.btnGhiChu.Controls.Add(this.txtGhiChu);
            this.btnGhiChu.Controls.Add(this.textBox2);
            this.btnGhiChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGhiChu.Location = new System.Drawing.Point(3, 151);
            this.btnGhiChu.Name = "btnGhiChu";
            this.btnGhiChu.Size = new System.Drawing.Size(401, 68);
            this.btnGhiChu.TabIndex = 21;
            this.btnGhiChu.TabStop = false;
            this.btnGhiChu.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGhiChu.Location = new System.Drawing.Point(3, 26);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(395, 34);
            this.txtGhiChu.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(395, 30);
            this.textBox2.TabIndex = 0;
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Location = new System.Drawing.Point(15, 91);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(122, 38);
            this.btnChonAnh.TabIndex = 1;
            this.btnChonAnh.Text = "Chọn Ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý";
            // 
            // cmbQuanLy
            // 
            this.cmbQuanLy.FormattingEnabled = true;
            this.cmbQuanLy.Location = new System.Drawing.Point(9, 46);
            this.cmbQuanLy.Name = "cmbQuanLy";
            this.cmbQuanLy.Size = new System.Drawing.Size(232, 24);
            this.cmbQuanLy.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.anhNhaTro);
            this.panel2.Controls.Add(this.cmbQuanLy);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnChonAnh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 142);
            this.panel2.TabIndex = 20;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Navy;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(115, 447);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(170, 57);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // anhNhaTro
            // 
            this.anhNhaTro.Location = new System.Drawing.Point(241, 0);
            this.anhNhaTro.Name = "anhNhaTro";
            this.anhNhaTro.Size = new System.Drawing.Size(153, 139);
            this.anhNhaTro.TabIndex = 2;
            this.anhNhaTro.TabStop = false;
            // 
            // FormThemNhaTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 507);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormThemNhaTro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.btnGhiChu.ResumeLayout(false);
            this.btnGhiChu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.anhNhaTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_ten_nha_tro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_dia_chi;
        private System.Windows.Forms.TextBox textBox_khachthue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox btnGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbQuanLy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox anhNhaTro;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnEdit;
    }
}