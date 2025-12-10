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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhaTro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_title = new System.Windows.Forms.Panel();
            this.button_them_nha_tro = new System.Windows.Forms.Button();
            this.label_nhatro = new System.Windows.Forms.Label();
            this.label_tat_Ca = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_nha_Tro = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuongDanURL = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_title.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nha_Tro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_title
            // 
            this.panel_title.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_title.Controls.Add(this.label_tat_Ca);
            this.panel_title.Controls.Add(this.button_them_nha_tro);
            this.panel_title.Controls.Add(this.label_nhatro);
            this.panel_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_title.Location = new System.Drawing.Point(0, 0);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1845, 200);
            this.panel_title.TabIndex = 0;
            // 
            // button_them_nha_tro
            // 
            this.button_them_nha_tro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them_nha_tro.ForeColor = System.Drawing.Color.Blue;
            this.button_them_nha_tro.Location = new System.Drawing.Point(144, 12);
            this.button_them_nha_tro.Name = "button_them_nha_tro";
            this.button_them_nha_tro.Size = new System.Drawing.Size(88, 35);
            this.button_them_nha_tro.TabIndex = 1;
            this.button_them_nha_tro.Text = "Thêm";
            this.button_them_nha_tro.UseVisualStyleBackColor = true;
            // 
            // label_nhatro
            // 
            this.label_nhatro.AutoSize = true;
            this.label_nhatro.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nhatro.Location = new System.Drawing.Point(12, 9);
            this.label_nhatro.Name = "label_nhatro";
            this.label_nhatro.Size = new System.Drawing.Size(117, 38);
            this.label_nhatro.TabIndex = 0;
            this.label_nhatro.Text = "Nhà Trọ";
            // 
            // label_tat_Ca
            // 
            this.label_tat_Ca.AutoSize = true;
            this.label_tat_Ca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_tat_Ca.ForeColor = System.Drawing.Color.Blue;
            this.label_tat_Ca.Location = new System.Drawing.Point(15, 62);
            this.label_tat_Ca.Name = "label_tat_Ca";
            this.label_tat_Ca.Size = new System.Drawing.Size(91, 28);
            this.label_tat_Ca.TabIndex = 2;
            this.label_tat_Ca.Text = "Tất cả (0)";
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(0, 200);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(1845, 358);
            this.panel_right.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_nha_Tro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1800, 358);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView_nha_Tro
            // 
            this.dataGridView_nha_Tro.AllowUserToAddRows = false;
            this.dataGridView_nha_Tro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_nha_Tro.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_nha_Tro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_nha_Tro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_nha_Tro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_nha_Tro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_nha_Tro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaAnh,
            this.DuongDanURL,
            this.MaNha,
            this.TenNha,
            this.DiaChi,
            this.NguoiQuanLy,
            this.GhiChu});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_nha_Tro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_nha_Tro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_nha_Tro.EnableHeadersVisualStyles = false;
            this.dataGridView_nha_Tro.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView_nha_Tro.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_nha_Tro.Name = "dataGridView_nha_Tro";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_nha_Tro.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_nha_Tro.RowHeadersVisible = false;
            this.dataGridView_nha_Tro.RowHeadersWidth = 50;
            this.dataGridView_nha_Tro.RowTemplate.Height = 60;
            this.dataGridView_nha_Tro.Size = new System.Drawing.Size(1800, 358);
            this.dataGridView_nha_Tro.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaAnh
            // 
            this.MaAnh.HeaderText = "MaAnh";
            this.MaAnh.MinimumWidth = 6;
            this.MaAnh.Name = "MaAnh";
            this.MaAnh.Visible = false;
            // 
            // DuongDanURL
            // 
            this.DuongDanURL.FillWeight = 120F;
            this.DuongDanURL.HeaderText = "Ảnh";
            this.DuongDanURL.Image = ((System.Drawing.Image)(resources.GetObject("DuongDanURL.Image")));
            this.DuongDanURL.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DuongDanURL.MinimumWidth = 6;
            this.DuongDanURL.Name = "DuongDanURL";
            this.DuongDanURL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DuongDanURL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaNha
            // 
            this.MaNha.HeaderText = "MaNha";
            this.MaNha.MinimumWidth = 6;
            this.MaNha.Name = "MaNha";
            this.MaNha.Visible = false;
            // 
            // TenNha
            // 
            this.TenNha.DataPropertyName = "TenNha";
            this.TenNha.HeaderText = "Tên Nhà";
            this.TenNha.MinimumWidth = 6;
            this.TenNha.Name = "TenNha";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // NguoiQuanLy
            // 
            this.NguoiQuanLy.DataPropertyName = "NguoiQuanLy";
            this.NguoiQuanLy.HeaderText = "Người Quản Lý";
            this.NguoiQuanLy.MinimumWidth = 6;
            this.NguoiQuanLy.Name = "NguoiQuanLy";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            // 
            // FormNhaTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1845, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_title);
            this.Name = "FormNhaTro";
            this.Text = "FormNhaTro";
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_nha_Tro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Button button_them_nha_tro;
        private System.Windows.Forms.Label label_nhatro;
        private System.Windows.Forms.Label label_tat_Ca;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_nha_Tro;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaAnh;
        private System.Windows.Forms.DataGridViewImageColumn DuongDanURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiQuanLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}