using DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormQuanLyThuTien : Form
    {
        private HoaDonDAL dal = new HoaDonDAL();

        public FormQuanLyThuTien()
        {
            InitializeComponent();
            KhoiTaoDuLieuCombobox(); 

            this.Load += FormQuanLyThuTien_Load;
            btnThanhToan.Click += btnThanhToan_Click;
            btnXoa.Click += btnXoa_Click; 
            btnTim.Click += btnTim_Click; 
        }

        public FormQuanLyThuTien(int thangCanXem, int namCanXem) : this()
        {
            cboThang.Text = thangCanXem.ToString();
            cboNam.Text = namCanXem.ToString();
            radChuaThu.Checked = true;
        }

        private void FormQuanLyThuTien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboThang.Text)) cboThang.Text = DateTime.Now.Month.ToString();
            if (string.IsNullOrEmpty(cboNam.Text)) cboNam.Text = DateTime.Now.Year.ToString();

            LoadData();
        }

        private void KhoiTaoDuLieuCombobox()
        {
            cboThang.Items.Clear();
            for (int i = 1; i <= 12; i++) cboThang.Items.Add(i.ToString());

            cboNam.Items.Clear();
            int namHienTai = DateTime.Now.Year;
            for (int i = namHienTai - 5; i <= namHienTai + 5; i++) cboNam.Items.Add(i.ToString());
        }

        private void LoadData()
        {
            int thang = int.Parse(cboThang.Text);
            int nam = int.Parse(cboNam.Text);

            string trangThai = "All";
            if (radChuaThu.Checked) trangThai = "ChuaThanhToan";
            if (radDaThu.Checked) trangThai = "DaThanhToan";

            DataTable dt = dal.LayDanhSachHoaDon(thang, nam, trangThai);
            dgvHoaDon.DataSource = dt;

            if (dgvHoaDon.Columns["TongTien"] != null)
                dgvHoaDon.Columns["TongTien"].DefaultCellStyle.Format = "N0";

            if (dgvHoaDon.Columns["ConNo"] != null)
                dgvHoaDon.Columns["ConNo"].DefaultCellStyle.Format = "N0";

            if (dgvHoaDon.Columns["MaHoaDon"] != null)
                dgvHoaDon.Columns["MaHoaDon"].Visible = false;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần thanh toán!");
                return;
            }

            int maHD = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value);
            decimal conNo = Convert.ToDecimal(dgvHoaDon.SelectedRows[0].Cells["ConNo"].Value);
            string tenPhong = dgvHoaDon.SelectedRows[0].Cells["TenPhong"].Value.ToString();
            string trangThai = dgvHoaDon.SelectedRows[0].Cells["TrangThai"].Value.ToString();

            if (trangThai == "DaThanhToan" || conNo <= 0)
            {
                MessageBox.Show("Hóa đơn này đã thanh toán đủ rồi!");
                return;
            }

            if (MessageBox.Show($"Xác nhận thu tiền phòng {tenPhong}?\nSố tiền thu: {conNo:N0} VNĐ",
                                "Xác nhận thu tiền", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (dal.ThanhToanHoaDon(maHD, conNo))
                {
                    MessageBox.Show("Thanh toán thành công!");
                    LoadData(); 
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật thanh toán!");
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!");
                return;
            }

            int maHD = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells["MaHoaDon"].Value);
            string tenPhong = dgvHoaDon.SelectedRows[0].Cells["TenPhong"].Value.ToString();
            string trangThai = dgvHoaDon.SelectedRows[0].Cells["TrangThai"].Value.ToString();

            if (trangThai == "DaThanhToan")
            {
                if (MessageBox.Show("CẢNH BÁO: Hóa đơn này ĐÃ THU TIỀN!\nViệc xóa sẽ làm sai lệch doanh thu.\nBạn có chắc chắn muốn xóa không?",
                                    "Cảnh báo quan trọng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa hóa đơn của phòng {tenPhong}?\n(Dữ liệu chốt điện nước tháng này cũng sẽ bị xóa để lập lại)",
                                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dal.XoaHoaDon(maHD))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Có lỗi xảy ra.");
                }
            }
        }
    }
}