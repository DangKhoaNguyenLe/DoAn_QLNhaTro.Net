using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    partial class FormDayNha
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDayNha));
            this.drvDayNha = new System.Windows.Forms.DataGridView();
            this.HostelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnFormAddDayNha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.drvDayNha)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // drvDayNha
            // 
            this.drvDayNha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvDayNha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.drvDayNha.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.drvDayNha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drvDayNha.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.drvDayNha.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvDayNha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.drvDayNha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvDayNha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HostelID,
            this.OwnerID,
            this.HostelName,
            this.Address,
            this.FullName,
            this.Phone,
            this.Description});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvDayNha.DefaultCellStyle = dataGridViewCellStyle5;
            this.drvDayNha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvDayNha.EnableHeadersVisualStyles = false;
            this.drvDayNha.GridColor = System.Drawing.SystemColors.ControlLight;
            this.drvDayNha.Location = new System.Drawing.Point(0, 0);
            this.drvDayNha.Name = "drvDayNha";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drvDayNha.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.drvDayNha.RowHeadersVisible = false;
            this.drvDayNha.RowHeadersWidth = 51;
            this.drvDayNha.RowTemplate.Height = 24;
            this.drvDayNha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvDayNha.Size = new System.Drawing.Size(1379, 796);
            this.drvDayNha.TabIndex = 2;
            // 
            // HostelID
            // 
            this.HostelID.DataPropertyName = "HostelID";
            this.HostelID.FillWeight = 15F;
            this.HostelID.HeaderText = "ID";
            this.HostelID.MinimumWidth = 6;
            this.HostelID.Name = "HostelID";
            this.HostelID.Visible = false;
            // 
            // OwnerID
            // 
            this.OwnerID.DataPropertyName = "OwnerID";
            this.OwnerID.HeaderText = "OwnerID";
            this.OwnerID.MinimumWidth = 6;
            this.OwnerID.Name = "OwnerID";
            this.OwnerID.Visible = false;
            // 
            // HostelName
            // 
            this.HostelName.DataPropertyName = "HostelName";
            this.HostelName.FillWeight = 55.82888F;
            this.HostelName.HeaderText = "Tên nhà trọ";
            this.HostelName.MinimumWidth = 6;
            this.HostelName.Name = "HostelName";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 55.82888F;
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.FillWeight = 55.82888F;
            this.FullName.HeaderText = "Chủ nhà";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 55.82888F;
            this.Phone.HeaderText = "Số điện thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 55.82888F;
            this.Description.HeaderText = "Mô tả";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số dãy nhà:";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(230, 13);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(35, 38);
            this.lbCount.TabIndex = 6;
            this.lbCount.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1379, 70);
            this.panel1.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSua,
            this.btnXoa,
            this.btnFormAddDayNha,
            this.toolStripSeparator1,
            this.txtSearch,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1379, 46);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 43);
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 43);
            this.btnXoa.Text = "Xóa";
            // 
            // btnFormAddDayNha
            // 
            this.btnFormAddDayNha.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFormAddDayNha.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormAddDayNha.Image = ((System.Drawing.Image)(resources.GetObject("btnFormAddDayNha.Image")));
            this.btnFormAddDayNha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFormAddDayNha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFormAddDayNha.Name = "btnFormAddDayNha";
            this.btnFormAddDayNha.Size = new System.Drawing.Size(123, 43);
            this.btnFormAddDayNha.Text = "Thêm";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 46);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 43);
            this.toolStripLabel1.Text = "Tìm kiếm";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(190, 43);
            this.toolStripLabel2.Text = "Dãy nhà trọ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.drvDayNha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1379, 796);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 866);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1379, 101);
            this.panel3.TabIndex = 10;
            // 
            // FormDayNha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 979);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDayNha";
            ((System.ComponentModel.ISupportInitialize)(this.drvDayNha)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView drvDayNha;
        private ContextMenuStrip contextMenuStrip1;
        private Label label2;
        private Label lbCount;
        private Panel panel1;
        private Panel panel2;
        private DataGridViewTextBoxColumn HostelID;
        private DataGridViewTextBoxColumn OwnerID;
        private DataGridViewTextBoxColumn HostelName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Description;
        private Panel panel3;
        private ToolStrip toolStrip1;
        private ToolStripButton btnFormAddDayNha;
        private ToolStripButton btnXoa;
        private ToolStripButton btnSua;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox txtSearch;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
    }
}
