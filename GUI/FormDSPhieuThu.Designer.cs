namespace GUI
{
    partial class FormDSPhieuThu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_dsphieuthu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dsphieuthu)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 393F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView_dsphieuthu, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.12351F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.8765F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 554);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView_dsphieuthu
            // 
            this.dataGridView_dsphieuthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_dsphieuthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dsphieuthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ReceiptCode,
            this.TenantName,
            this.RoomName,
            this.HostelName,
            this.ReceiptType,
            this.Amount,
            this.ReceiptDate,
            this.Note,
            this.CreatedBy});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView_dsphieuthu, 3);
            this.dataGridView_dsphieuthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_dsphieuthu.Location = new System.Drawing.Point(3, 94);
            this.dataGridView_dsphieuthu.Name = "dataGridView_dsphieuthu";
            this.dataGridView_dsphieuthu.RowHeadersWidth = 51;
            this.dataGridView_dsphieuthu.RowTemplate.Height = 24;
            this.dataGridView_dsphieuthu.Size = new System.Drawing.Size(939, 382);
            this.dataGridView_dsphieuthu.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // ReceiptCode
            // 
            this.ReceiptCode.DataPropertyName = "ReceiptCode";
            this.ReceiptCode.HeaderText = "Mã phiếu thu";
            this.ReceiptCode.MinimumWidth = 6;
            this.ReceiptCode.Name = "ReceiptCode";
            // 
            // TenantName
            // 
            this.TenantName.DataPropertyName = "TenantName";
            this.TenantName.HeaderText = "Khách thuê";
            this.TenantName.MinimumWidth = 6;
            this.TenantName.Name = "TenantName";
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "RoomName";
            this.RoomName.HeaderText = "Phòng";
            this.RoomName.MinimumWidth = 6;
            this.RoomName.Name = "RoomName";
            // 
            // HostelName
            // 
            this.HostelName.DataPropertyName = "HostelName";
            this.HostelName.HeaderText = "Dãy trọ";
            this.HostelName.MinimumWidth = 6;
            this.HostelName.Name = "HostelName";
            // 
            // ReceiptType
            // 
            this.ReceiptType.DataPropertyName = "ReceiptType";
            this.ReceiptType.HeaderText = "Loại phiếu thu";
            this.ReceiptType.MinimumWidth = 6;
            this.ReceiptType.Name = "ReceiptType";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Số tiền";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // ReceiptDate
            // 
            this.ReceiptDate.DataPropertyName = "ReceiptDate";
            this.ReceiptDate.HeaderText = "Ngày thu";
            this.ReceiptDate.MinimumWidth = 6;
            this.ReceiptDate.Name = "ReceiptDate";
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Ghi chú";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "Người tạo";
            this.CreatedBy.MinimumWidth = 6;
            this.CreatedBy.Name = "CreatedBy";
            // 
            // FormDSPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormDSPhieuThu";
            this.Text = "FormDSPhieuThu";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dsphieuthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView_dsphieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HostelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
    }
}