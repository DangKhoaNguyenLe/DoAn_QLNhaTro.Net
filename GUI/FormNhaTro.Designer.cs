using System.Windows.Forms;

namespace GUI
{
    partial class FormNhaTro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_title = new System.Windows.Forms.Panel();
            this.label_tat_Ca = new System.Windows.Forms.Label();
            this.button_them_nha_tro = new System.Windows.Forms.Button();
            this.label_nhatro = new System.Windows.Forms.Label();
            this.panel_datagv = new System.Windows.Forms.Panel();
            this.dataGridView_nha_Tro = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhDaiDien = new System.Windows.Forms.DataGridViewImageColumn();
            this.TenNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel_body = new System.Windows.Forms.TableLayoutPanel();
            this.panel_title.SuspendLayout();
            this.panel_datagv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nha_Tro)).BeginInit();
            this.tableLayoutPanel_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_title.Controls.Add(this.label_tat_Ca);
            this.panel_title.Controls.Add(this.button_them_nha_tro);
            this.panel_title.Controls.Add(this.label_nhatro);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1123, 120);
            this.panel_title.TabIndex = 0;
            // 
            // label_tat_Ca
            // 
            this.label_tat_Ca.AutoSize = true;
            this.label_tat_Ca.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label_tat_Ca.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_tat_Ca.Location = new System.Drawing.Point(14, 85);
            this.label_tat_Ca.Name = "label_tat_Ca";
            this.label_tat_Ca.Size = new System.Drawing.Size(111, 32);
            this.label_tat_Ca.TabIndex = 2;
            this.label_tat_Ca.Text = "Tất cả (0)";
            // 
            // button_them_nha_tro
            // 
            this.button_them_nha_tro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_them_nha_tro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them_nha_tro.ForeColor = System.Drawing.Color.White;
            this.button_them_nha_tro.Location = new System.Drawing.Point(169, 15);
            this.button_them_nha_tro.Name = "button_them_nha_tro";
            this.button_them_nha_tro.Size = new System.Drawing.Size(95, 43);
            this.button_them_nha_tro.TabIndex = 1;
            this.button_them_nha_tro.Text = "Thêm";
            this.button_them_nha_tro.UseVisualStyleBackColor = false;
            // 
            // label_nhatro
            // 
            this.label_nhatro.AutoSize = true;
            this.label_nhatro.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label_nhatro.Location = new System.Drawing.Point(12, 12);
            this.label_nhatro.Name = "label_nhatro";
            this.label_nhatro.Size = new System.Drawing.Size(142, 46);
            this.label_nhatro.TabIndex = 0;
            this.label_nhatro.Text = "Nhà Trọ";
            // 
            // panel_datagv
            // 
            this.panel_datagv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel_body.SetColumnSpan(this.panel_datagv, 2);
            this.panel_datagv.Controls.Add(this.dataGridView_nha_Tro);
            this.panel_datagv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_datagv.Location = new System.Drawing.Point(3, 3);
            this.panel_datagv.Name = "panel_datagv";
            this.panel_datagv.Size = new System.Drawing.Size(1117, 650);
            this.panel_datagv.TabIndex = 2;
            // 
            // dataGridView_nha_Tro
            // 
            this.dataGridView_nha_Tro.AllowUserToAddRows = false;
            this.dataGridView_nha_Tro.AllowUserToDeleteRows = false;
            this.dataGridView_nha_Tro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_nha_Tro.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_nha_Tro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_nha_Tro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_nha_Tro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nha_Tro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.AnhDaiDien,
            this.TenNha,
            this.DiaChi,
            this.NguoiQuanLy,
            this.GhiChu,
            this.MaNha,
            this.MaAnh});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_nha_Tro.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_nha_Tro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_nha_Tro.EnableHeadersVisualStyles = false;
            this.dataGridView_nha_Tro.GridColor = System.Drawing.Color.Black;
            this.dataGridView_nha_Tro.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_nha_Tro.Name = "dataGridView_nha_Tro";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_nha_Tro.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_nha_Tro.RowHeadersVisible = false;
            this.dataGridView_nha_Tro.RowHeadersWidth = 50;
            this.dataGridView_nha_Tro.RowTemplate.Height = 70;
            this.dataGridView_nha_Tro.Size = new System.Drawing.Size(1113, 646);
            this.dataGridView_nha_Tro.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 60;
            this.STT.Name = "STT";
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.STT.Width = 150;
            // 
            // AnhDaiDien
            // 
            this.AnhDaiDien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AnhDaiDien.DataPropertyName = "AnhDaiDien";
            this.AnhDaiDien.FillWeight = 206.7032F;
            this.AnhDaiDien.HeaderText = "Ảnh";
            this.AnhDaiDien.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.AnhDaiDien.MinimumWidth = 6;
            this.AnhDaiDien.Name = "AnhDaiDien";
            this.AnhDaiDien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AnhDaiDien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.AnhDaiDien.Width = 200;
            // 
            // TenNha
            // 
            this.TenNha.DataPropertyName = "TenNha";
            this.TenNha.FillWeight = 95.40147F;
            this.TenNha.HeaderText = "Tên Nhà";
            this.TenNha.MinimumWidth = 6;
            this.TenNha.Name = "TenNha";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.FillWeight = 95.40147F;
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // NguoiQuanLy
            // 
            this.NguoiQuanLy.DataPropertyName = "NguoiQuanLy";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NguoiQuanLy.DefaultCellStyle = dataGridViewCellStyle3;
            this.NguoiQuanLy.FillWeight = 95.40147F;
            this.NguoiQuanLy.HeaderText = "Quản Lý";
            this.NguoiQuanLy.MinimumWidth = 6;
            this.NguoiQuanLy.Name = "NguoiQuanLy";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.FillWeight = 95.40147F;
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // MaNha
            // 
            this.MaNha.DataPropertyName = "MaNha";
            this.MaNha.HeaderText = "MaNha";
            this.MaNha.MinimumWidth = 6;
            this.MaNha.Name = "MaNha";
            this.MaNha.Visible = false;
            // 
            // MaAnh
            // 
            this.MaAnh.DataPropertyName = "MaAnh";
            this.MaAnh.HeaderText = "MaAnh";
            this.MaAnh.MinimumWidth = 6;
            this.MaAnh.Name = "MaAnh";
            this.MaAnh.Visible = false;
            // 
            // tableLayoutPanel_body
            // 
            this.tableLayoutPanel_body.ColumnCount = 1;
            this.tableLayoutPanel_body.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_body.Controls.Add(this.panel_datagv, 0, 0);
            this.tableLayoutPanel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_body.Location = new System.Drawing.Point(0, 120);
            this.tableLayoutPanel_body.Name = "tableLayoutPanel_body";
            this.tableLayoutPanel_body.RowCount = 1;
            this.tableLayoutPanel_body.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_body.Size = new System.Drawing.Size(1123, 656);
            this.tableLayoutPanel_body.TabIndex = 3;
            // 
            // FormNhaTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1123, 776);
            this.Controls.Add(this.tableLayoutPanel_body);
            this.Controls.Add(this.panel_title);
            this.Name = "FormNhaTro";
            this.Text = "FormNhaTro";
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel_datagv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nha_Tro)).EndInit();
            this.tableLayoutPanel_body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Button button_them_nha_tro;
        private System.Windows.Forms.Label label_nhatro;
        private System.Windows.Forms.Label label_tat_Ca;
        private System.Windows.Forms.Panel panel_datagv;
        private System.Windows.Forms.DataGridView dataGridView_nha_Tro;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewImageColumn AnhDaiDien;
        private DataGridViewTextBoxColumn TenNha;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn NguoiQuanLy;
        private DataGridViewTextBoxColumn GhiChu;
        private DataGridViewTextBoxColumn MaNha;
        private DataGridViewTextBoxColumn MaAnh;
        private TableLayoutPanel tableLayoutPanel_body;
    }
}