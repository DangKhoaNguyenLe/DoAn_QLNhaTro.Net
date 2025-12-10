namespace GUI.Controls
{
    partial class RoomItem
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Panel panelStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // pictureBox
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Height = 90;
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.BackColor = System.Drawing.Color.LightGray;

            // lblTenPhong
            this.lblTenPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenPhong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTenPhong.Height = 35;
            this.lblTenPhong.Text = "Phòng";

            // panelStatus
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Height = 12;
            this.panelStatus.BackColor = System.Drawing.Color.Silver;

            // RoomItem
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.lblTenPhong);
            this.Controls.Add(this.pictureBox);

            this.Size = new System.Drawing.Size(150, 150);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
