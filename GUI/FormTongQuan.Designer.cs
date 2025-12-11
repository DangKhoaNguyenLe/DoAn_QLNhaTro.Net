namespace GUI
{
    partial class FormTongQuan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelKPI = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCongNo = new System.Windows.Forms.Panel();
            this.lblCongNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPhongDaThue = new System.Windows.Forms.Panel();
            this.lblPhongDaThue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPhongTrong = new System.Windows.Forms.Panel();
            this.lblPhongTrong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTongPhong = new System.Windows.Forms.Panel();
            this.lblTongPhong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCharts = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelCharts = new System.Windows.Forms.TableLayoutPanel();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTrangThaiPhong = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelKPI.SuspendLayout();
            this.panelCongNo.SuspendLayout();
            this.panelPhongDaThue.SuspendLayout();
            this.panelPhongTrong.SuspendLayout();
            this.panelTongPhong.SuspendLayout();
            this.groupBoxCharts.SuspendLayout();
            this.tableLayoutPanelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrangThaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.panelKPI, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxCharts, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.49479F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.50521F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1614, 1017);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelKPI
            // 
            this.panelKPI.Controls.Add(this.panelCongNo);
            this.panelKPI.Controls.Add(this.panelPhongDaThue);
            this.panelKPI.Controls.Add(this.panelPhongTrong);
            this.panelKPI.Controls.Add(this.panelTongPhong);
            this.panelKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKPI.Location = new System.Drawing.Point(4, 5);
            this.panelKPI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelKPI.Name = "panelKPI";
            this.panelKPI.Size = new System.Drawing.Size(1606, 144);
            this.panelKPI.TabIndex = 0;
            // 
            // panelCongNo
            // 
            this.panelCongNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCongNo.Controls.Add(this.lblCongNo);
            this.panelCongNo.Controls.Add(this.label1);
            this.panelCongNo.Location = new System.Drawing.Point(15, 15);
            this.panelCongNo.Margin = new System.Windows.Forms.Padding(15);
            this.panelCongNo.Name = "panelCongNo";
            this.panelCongNo.Size = new System.Drawing.Size(299, 107);
            this.panelCongNo.TabIndex = 0;
            // 
            // lblCongNo
            // 
            this.lblCongNo.AutoSize = true;
            this.lblCongNo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCongNo.Location = new System.Drawing.Point(15, 54);
            this.lblCongNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCongNo.Name = "lblCongNo";
            this.lblCongNo.Size = new System.Drawing.Size(103, 38);
            this.lblCongNo.TabIndex = 1;
            this.lblCongNo.Text = "0 VNĐ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Công Nợ (T/T)";
            // 
            // panelPhongDaThue
            // 
            this.panelPhongDaThue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPhongDaThue.Controls.Add(this.lblPhongDaThue);
            this.panelPhongDaThue.Controls.Add(this.label3);
            this.panelPhongDaThue.Location = new System.Drawing.Point(344, 15);
            this.panelPhongDaThue.Margin = new System.Windows.Forms.Padding(15);
            this.panelPhongDaThue.Name = "panelPhongDaThue";
            this.panelPhongDaThue.Size = new System.Drawing.Size(299, 107);
            this.panelPhongDaThue.TabIndex = 1;
            // 
            // lblPhongDaThue
            // 
            this.lblPhongDaThue.AutoSize = true;
            this.lblPhongDaThue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPhongDaThue.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPhongDaThue.Location = new System.Drawing.Point(15, 54);
            this.lblPhongDaThue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhongDaThue.Name = "lblPhongDaThue";
            this.lblPhongDaThue.Size = new System.Drawing.Size(126, 38);
            this.lblPhongDaThue.TabIndex = 1;
            this.lblPhongDaThue.Text = "0 phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Phòng Đã Thuê";
            // 
            // panelPhongTrong
            // 
            this.panelPhongTrong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPhongTrong.Controls.Add(this.lblPhongTrong);
            this.panelPhongTrong.Controls.Add(this.label5);
            this.panelPhongTrong.Location = new System.Drawing.Point(673, 15);
            this.panelPhongTrong.Margin = new System.Windows.Forms.Padding(15);
            this.panelPhongTrong.Name = "panelPhongTrong";
            this.panelPhongTrong.Size = new System.Drawing.Size(299, 107);
            this.panelPhongTrong.TabIndex = 2;
            // 
            // lblPhongTrong
            // 
            this.lblPhongTrong.AutoSize = true;
            this.lblPhongTrong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPhongTrong.ForeColor = System.Drawing.Color.LightCoral;
            this.lblPhongTrong.Location = new System.Drawing.Point(15, 54);
            this.lblPhongTrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhongTrong.Name = "lblPhongTrong";
            this.lblPhongTrong.Size = new System.Drawing.Size(126, 38);
            this.lblPhongTrong.TabIndex = 1;
            this.lblPhongTrong.Text = "0 phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phòng Trống";
            // 
            // panelTongPhong
            // 
            this.panelTongPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTongPhong.Controls.Add(this.lblTongPhong);
            this.panelTongPhong.Controls.Add(this.label2);
            this.panelTongPhong.Location = new System.Drawing.Point(1002, 15);
            this.panelTongPhong.Margin = new System.Windows.Forms.Padding(15);
            this.panelTongPhong.Name = "panelTongPhong";
            this.panelTongPhong.Size = new System.Drawing.Size(547, 107);
            this.panelTongPhong.TabIndex = 3;
            // 
            // lblTongPhong
            // 
            this.lblTongPhong.AutoSize = true;
            this.lblTongPhong.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongPhong.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTongPhong.Location = new System.Drawing.Point(15, 54);
            this.lblTongPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongPhong.Name = "lblTongPhong";
            this.lblTongPhong.Size = new System.Drawing.Size(205, 38);
            this.lblTongPhong.TabIndex = 1;
            this.lblTongPhong.Text = "Tổng số: 0 / 0 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng Quan";
            // 
            // groupBoxCharts
            // 
            this.groupBoxCharts.Controls.Add(this.tableLayoutPanelCharts);
            this.groupBoxCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCharts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxCharts.Location = new System.Drawing.Point(4, 159);
            this.groupBoxCharts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCharts.Name = "groupBoxCharts";
            this.groupBoxCharts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCharts.Size = new System.Drawing.Size(1606, 607);
            this.groupBoxCharts.TabIndex = 1;
            this.groupBoxCharts.TabStop = false;
            this.groupBoxCharts.Text = "Phân Tích Dữ Liệu";
            // 
            // tableLayoutPanelCharts
            // 
            this.tableLayoutPanelCharts.ColumnCount = 2;
            this.tableLayoutPanelCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelCharts.Controls.Add(this.chartDoanhThu, 0, 0);
            this.tableLayoutPanelCharts.Controls.Add(this.chartTrangThaiPhong, 1, 0);
            this.tableLayoutPanelCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCharts.Location = new System.Drawing.Point(4, 37);
            this.tableLayoutPanelCharts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelCharts.Name = "tableLayoutPanelCharts";
            this.tableLayoutPanelCharts.RowCount = 1;
            this.tableLayoutPanelCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCharts.Size = new System.Drawing.Size(1598, 565);
            this.tableLayoutPanelCharts.TabIndex = 0;
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(4, 5);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(1030, 555);
            this.chartDoanhThu.TabIndex = 0;
            this.chartDoanhThu.Text = "chart1";
            // 
            // chartTrangThaiPhong
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTrangThaiPhong.ChartAreas.Add(chartArea2);
            this.chartTrangThaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartTrangThaiPhong.Legends.Add(legend2);
            this.chartTrangThaiPhong.Location = new System.Drawing.Point(1042, 5);
            this.chartTrangThaiPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartTrangThaiPhong.Name = "chartTrangThaiPhong";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTrangThaiPhong.Series.Add(series2);
            this.chartTrangThaiPhong.Size = new System.Drawing.Size(552, 555);
            this.chartTrangThaiPhong.TabIndex = 1;
            this.chartTrangThaiPhong.Text = "chart2";
            // 
            // FormTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 1017);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTongQuan";
            this.Text = "Tổng Quan Hệ Thống";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelKPI.ResumeLayout(false);
            this.panelCongNo.ResumeLayout(false);
            this.panelCongNo.PerformLayout();
            this.panelPhongDaThue.ResumeLayout(false);
            this.panelPhongDaThue.PerformLayout();
            this.panelPhongTrong.ResumeLayout(false);
            this.panelPhongTrong.PerformLayout();
            this.panelTongPhong.ResumeLayout(false);
            this.panelTongPhong.PerformLayout();
            this.groupBoxCharts.ResumeLayout(false);
            this.tableLayoutPanelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrangThaiPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel panelKPI;
        private System.Windows.Forms.Panel panelCongNo;
        private System.Windows.Forms.Label lblCongNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPhongDaThue;
        private System.Windows.Forms.Label lblPhongDaThue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPhongTrong;
        private System.Windows.Forms.Label lblPhongTrong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxCharts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrangThaiPhong;
        private System.Windows.Forms.Panel panelTongPhong;
        private System.Windows.Forms.Label lblTongPhong;
        private System.Windows.Forms.Label label2;
    }
}