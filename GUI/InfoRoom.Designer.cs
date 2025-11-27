namespace GUI
{
    partial class InfoRoom
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
            this.dgvDsKH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDsKH
            // 
            this.dgvDsKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsKH.Location = new System.Drawing.Point(0, 0);
            this.dgvDsKH.Name = "dgvDsKH";
            this.dgvDsKH.RowHeadersWidth = 51;
            this.dgvDsKH.RowTemplate.Height = 24;
            this.dgvDsKH.Size = new System.Drawing.Size(977, 401);
            this.dgvDsKH.TabIndex = 0;
            // 
            // InfoRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDsKH);
            this.Name = "InfoRoom";
            this.Size = new System.Drawing.Size(977, 401);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDsKH;
    }
}
