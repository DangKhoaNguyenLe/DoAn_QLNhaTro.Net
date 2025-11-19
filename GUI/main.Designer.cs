namespace GUI
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThongKe = new System.Windows.Forms.ToolStripButton();
            this.btnDayNha = new System.Windows.Forms.ToolStripButton();
            this.btnPhongTro = new System.Windows.Forms.ToolStripButton();
            this.panel = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThongKe,
            this.btnDayNha,
            this.btnPhongTro});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1397, 53);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.LightCyan;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(116, 50);
            this.btnThongKe.Text = "Thống kê";
            // 
            // btnDayNha
            // 
            this.btnDayNha.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDayNha.ForeColor = System.Drawing.Color.LightCyan;
            this.btnDayNha.Image = ((System.Drawing.Image)(resources.GetObject("btnDayNha.Image")));
            this.btnDayNha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDayNha.Name = "btnDayNha";
            this.btnDayNha.Size = new System.Drawing.Size(106, 50);
            this.btnDayNha.Text = "Dãy nhà";
            // 
            // btnPhongTro
            // 
            this.btnPhongTro.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhongTro.ForeColor = System.Drawing.Color.LightCyan;
            this.btnPhongTro.Image = ((System.Drawing.Image)(resources.GetObject("btnPhongTro.Image")));
            this.btnPhongTro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPhongTro.Name = "btnPhongTro";
            this.btnPhongTro.Size = new System.Drawing.Size(121, 50);
            this.btnPhongTro.Text = "Phòng trọ";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 53);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1397, 683);
            this.panel.TabIndex = 1;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1397, 736);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPhongTro;
        private System.Windows.Forms.ToolStripButton btnThongKe;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripButton btnDayNha;
    }
}

