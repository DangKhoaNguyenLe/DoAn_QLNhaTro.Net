using DAL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class FormTongQuan : Form
    {
        private HoaDonDAL hoaDonDAL = new HoaDonDAL();
        private PhongDAL phongDAL = new PhongDAL();

        public FormTongQuan()
        {
            InitializeComponent();

            this.BackColor = System.Drawing.Color.White;

            this.Load += FormTongQuan_Load;
        }

        private void FormTongQuan_Load(object sender, EventArgs e)
        {
            LoadTongQuanTaiChinh();
            LoadTongQuanPhong();
            VeBieuDoDoanhThu();
            VeBieuDoTrangThaiPhong();

        }


        private void LoadTongQuanTaiChinh()
        {
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;

            // 1. Tính Công Nợ Tháng Hiện Tại
            decimal tongCongNo = hoaDonDAL.TinhTongCongNo(thang, nam);
            lblCongNo.Text = tongCongNo.ToString("N0") + " VNĐ";

            lblCongNo.ForeColor = tongCongNo > 0 ? Color.Red : Color.DarkGreen;
        }


        private void LoadTongQuanPhong()
        {

            int daThue = phongDAL.DemSoPhongTheoTrangThai("DaThue");
            int trong = phongDAL.DemSoPhongTheoTrangThai("Trong");
            int daDatCoc = phongDAL.DemSoPhongTheoTrangThai("DaDatCoc");

            int tongSoPhong = daThue + trong + daDatCoc;


            lblPhongDaThue.Text = $"{daThue} phòng";
            lblPhongTrong.Text = $"{trong} phòng";

            lblTongPhong.Text = $"Tổng số: {daThue} đang thuê / {tongSoPhong} phòng";

        }


        private void VeBieuDoDoanhThu()
        {
            // Giả định dtDoanhThu là DataTable đã lấy từ DAL
            DataTable dtDoanhThu = hoaDonDAL.LayDoanhThu6ThangGanNhat();

            // Reset và Tiêu đề
            chartDoanhThu.Series.Clear();
            chartDoanhThu.Titles.Clear();

            // Thêm Tiêu đề với Font và Màu sắc chuyên nghiệp hơn
            Title titleDoanhThu = chartDoanhThu.Titles.Add("Doanh Thu 6 Tháng Gần Nhất");
            titleDoanhThu.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
            titleDoanhThu.ForeColor = Color.FromArgb(41, 128, 185);

            // Cấu hình ChartArea
            ChartArea area = chartDoanhThu.ChartAreas[0];
            area.BackColor = Color.Transparent;
            area.AxisY.LabelStyle.Format = "N0";
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.MajorGrid.Enabled = false; // Ẩn lưới dọc
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9f, FontStyle.Regular); // Font trục X

            // Cấu hình Series
            var series = chartDoanhThu.Series.Add("Tổng Thu");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(52, 152, 219); // Màu xanh dương sáng hơn (Flat UI)
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "N0";
            series.LabelAngle = -90;
            series.Font = new Font("Segoe UI", 8f, FontStyle.Bold);

            // Dữ liệu
            DataView dv = dtDoanhThu.DefaultView;
            dv.Sort = "Nam ASC, Thang ASC";

            foreach (DataRowView row in dv)
            {
                string thangNam = $"{row["Thang"]}/{row["Nam"]}";
                decimal tongThu = (decimal)row["TongThu"];
                series.Points.AddXY(thangNam, tongThu);
            }

            // Tùy chỉnh cột để trông đẹp hơn (bo góc)
            series["PointWidth"] = "0.6";
        }


        private void VeBieuDoTrangThaiPhong()
        {
            int daThue = phongDAL.DemSoPhongTheoTrangThai("DaThue");
            int trong = phongDAL.DemSoPhongTheoTrangThai("Trong");
            int daDatCoc = phongDAL.DemSoPhongTheoTrangThai("DaDatCoc");
            int tongSo = daThue + trong + daDatCoc;

            if (tongSo == 0) return;

            chartTrangThaiPhong.Series.Clear();
            chartTrangThaiPhong.Titles.Clear();

            // Thêm Tiêu đề
            Title titleTrangThai = chartTrangThaiPhong.Titles.Add("Tình Trạng Phòng");
            titleTrangThai.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
            titleTrangThai.ForeColor = Color.FromArgb(41, 128, 185);

            // Cấu hình Series
            var series = chartTrangThaiPhong.Series.Add("Phòng");
            series.ChartType = SeriesChartType.Doughnut;
            series.IsValueShownAsLabel = true;

            // --- ĐÃ THAY ĐỔI DÒNG NÀY ---
            series.LabelFormat = "N0"; // Hiển thị số nguyên (số lượng phòng) thay vì phần trăm (P1)

            series.LabelAngle = 0;
            series.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            series.LabelForeColor = Color.White;

            // Tùy chỉnh kích thước Donut 
            series["DoughnutRadius"] = "50";
            series.CustomProperties = "PieDrawingStyle=Concave";

            // Thêm dữ liệu và cấu hình màu/legend text
            series.Points.AddY(daThue);
            series.Points.AddY(trong);
            series.Points.AddY(daDatCoc);

            // Điểm 0: Đã Thuê
            series.Points[0].LegendText = $"Đã Thuê ({daThue})";
            series.Points[0].Color = Color.MediumSeaGreen;

            // Điểm 1: Trống
            series.Points[1].LegendText = $"Trống ({trong})";
            series.Points[1].Color = Color.FromArgb(231, 76, 60);

            // Điểm 2: Đã Đặt Cọc
            series.Points[2].LegendText = $"Đã Đặt Cọc ({daDatCoc})";
            series.Points[2].Color = Color.Orange;

            // Cấu hình Legend
            Legend legend = chartTrangThaiPhong.Legends[0];
            legend.Docking = Docking.Right;
            legend.Alignment = StringAlignment.Center;
            legend.Font = new Font("Segoe UI", 9f, FontStyle.Regular);

            // Đặt nền chart area trong suốt
            chartTrangThaiPhong.ChartAreas[0].BackColor = Color.Transparent;
        }


    }
}