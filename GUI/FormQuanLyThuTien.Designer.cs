using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class FormQuanLyThuTien
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;

        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radDaThu;
        private System.Windows.Forms.RadioButton radChuaThu;

        private System.Windows.Forms.Button btnTim;

        private System.Windows.Forms.DataGridView dgvHoaDon;

        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radDaThu = new System.Windows.Forms.RadioButton();
            this.radChuaThu = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panelActions = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.cboThang);
            this.panelHeader.Controls.Add(this.cboNam);
            this.panelHeader.Controls.Add(this.radTatCa);
            this.panelHeader.Controls.Add(this.radDaThu);
            this.panelHeader.Controls.Add(this.radChuaThu);
            this.panelHeader.Controls.Add(this.btnTim);
            this.panelHeader.Location = new System.Drawing.Point(10, 10);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1080, 85);
            this.panelHeader.TabIndex = 0;
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.Location = new System.Drawing.Point(20, 30);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(100, 36);
            this.cboThang.TabIndex = 0;
            // 
            // cboNam
            // 
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.Location = new System.Drawing.Point(140, 30);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(120, 36);
            this.cboNam.TabIndex = 1;
            // 
            // radTatCa
            // 
            this.radTatCa.Location = new System.Drawing.Point(290, 32);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(104, 24);
            this.radTatCa.TabIndex = 2;
            this.radTatCa.Text = "Tất cả";
            // 
            // radDaThu
            // 
            this.radDaThu.Location = new System.Drawing.Point(399, 32);
            this.radDaThu.Name = "radDaThu";
            this.radDaThu.Size = new System.Drawing.Size(104, 24);
            this.radDaThu.TabIndex = 3;
            this.radDaThu.Text = "Đã thu";
            // 
            // radChuaThu
            // 
            this.radChuaThu.Location = new System.Drawing.Point(509, 35);
            this.radChuaThu.Name = "radChuaThu";
            this.radChuaThu.Size = new System.Drawing.Size(104, 24);
            this.radChuaThu.TabIndex = 4;
            this.radChuaThu.Text = "Chưa thu";
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(632, 26);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(110, 40);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToResizeRows = false;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.ColumnHeadersHeight = 34;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.Location = new System.Drawing.Point(10, 110);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 30;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1080, 500);
            this.dgvHoaDon.TabIndex = 1;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.btnThanhToan);
            this.panelActions.Controls.Add(this.btnXoa);
            this.panelActions.Location = new System.Drawing.Point(10, 620);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1080, 80);
            this.panelActions.TabIndex = 2;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(20, 20);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(150, 40);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(190, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa Hóa Đơn";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // FormQuanLyThuTien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 720);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.panelActions);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "FormQuanLyThuTien";
            this.Text = "Quản lý thu tiền";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
