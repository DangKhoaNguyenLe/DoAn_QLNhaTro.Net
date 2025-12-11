using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormLapHoaDon : Form
    {
         PhongDAL phongDAL = new PhongDAL();
         HoaDonDAL hoaDonDAL = new HoaDonDAL();
         DanhMucDAL danhMucDAL = new DanhMucDAL();
         int _maHopDongHienTai = 0;
         decimal _giaPhongHienTai = 0;
         int _nguoiLapID;
        public FormLapHoaDon(int maNguoiLap)
        {
            InitializeComponent();
            this._nguoiLapID = maNguoiLap;
            this.Load += FormLapHoaDon_Load;
            cboNha.SelectedIndexChanged += cboNha_SelectedIndexChanged;
            cboPhong.SelectedIndexChanged += cboPhong_SelectedIndexChanged;
            btnTinhTien.Click += btnTinhTien_Click;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            btnXoaLichSu.Click += btnXoaLichSu_Click;
            btnThanhToan.Click += BtnThanhToan_Click;
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;

            FormQuanLyThuTien frmThuTien = new FormQuanLyThuTien(thang, nam);
            frmThuTien.StartPosition = FormStartPosition.CenterScreen;

            frmThuTien.ShowDialog();

            this.Close();
        }

        private void FormLapHoaDon_Load(object sender, EventArgs e)
        {
            LoadComboboxNha();
            txtDonGiaDien.Text = "3500";
            txtDonGiaNuoc.Text = "15000";
        }

        private void LoadComboboxNha()
        {
            DataTable dt = danhMucDAL.LayDSNha();
            cboNha.DisplayMember = "TenNha";
            cboNha.ValueMember = "MaNha";
            cboNha.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                cboNha.SelectedIndex = 0;
                if (int.TryParse(cboNha.SelectedValue.ToString(), out int maNha))
                {
                    LoadPhongTheoNha(maNha);
                }
            }
        }

        private void cboNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNha.SelectedValue == null) return;

            if (int.TryParse(cboNha.SelectedValue.ToString(), out int maNha))
            {
                LoadPhongTheoNha(maNha);
            }
        }

        private void LoadPhongTheoNha(int maNha)
        {
            var listPhong = phongDAL.LayTatCaPhong()
                                    .FindAll(p => p.TrangThai == "DaThue" && p.MaNha == maNha);

            cboPhong.DataSource = null;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
            cboPhong.DataSource = listPhong;

            if (listPhong.Count == 0)
            {
                ResetThongTin();
                dgvLichSu.DataSource = null;
            }
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhong.SelectedValue == null) return;

            if (!int.TryParse(cboPhong.SelectedValue.ToString(), out int maPhong)) return;

            DataTable dt = hoaDonDAL.LayThongTinHopDong(maPhong);

            if (dt.Rows.Count > 0)
            {
                _maHopDongHienTai = int.Parse(dt.Rows[0]["MaHopDong"].ToString());
                _giaPhongHienTai = decimal.Parse(dt.Rows[0]["GiaThueThucTe"].ToString());

                lblGiaPhong.Text = _giaPhongHienTai.ToString("N0");
                lblThongBao.Text = "";
                LoadLichSu(_maHopDongHienTai);
            }
            else
            {
                ResetThongTin();
                lblThongBao.Text = "Lỗi: Phòng này chưa có Hợp đồng hiệu lực!";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
                dgvLichSu.DataSource = null;
            }
        }

        private void ResetThongTin()
        {
            lblGiaPhong.Text = "0";
            lblThanhTienDien.Text = "0";
            lblThanhTienNuoc.Text = "0";
            lblTongTien.Text = "0";
            _maHopDongHienTai = 0;
            _giaPhongHienTai = 0;
            lblThongBao.Text = "";
            txtDienCu.Text = "0";
            txtNuocCu.Text = "0";
            txtDienMoi.Text = "";
            txtNuocMoi.Text = "";
            txtTienDichVu.Text = "";
        }

        private void LoadLichSu(int maHopDong)
        {
            DataTable dt = hoaDonDAL.LayLichSuHoaDon(maHopDong);
            dgvLichSu.DataSource = dt;

            if (dgvLichSu.Columns["Tổng Tiền"] != null)
                dgvLichSu.Columns["Tổng Tiền"].DefaultCellStyle.Format = "N0";
            if (dgvLichSu.Columns["Còn Nợ"] != null)
                dgvLichSu.Columns["Còn Nợ"].DefaultCellStyle.Format = "N0";
            if (dgvLichSu.Columns["MaHoaDon"] != null)
                dgvLichSu.Columns["MaHoaDon"].Visible = false;

            if (dt.Rows.Count > 0)
            {
                try
                {
                    string ghiChu = dt.Rows[0]["Chi Tiết (Điện/Nước)"].ToString();

                    Match mDien = Regex.Match(ghiChu, @"Điện:\s*(\d+)");
                    if (mDien.Success) txtDienCu.Text = mDien.Groups[1].Value;
                    else txtDienCu.Text = "0";

                    Match mNuoc = Regex.Match(ghiChu, @"Nước:\s*(\d+)");
                    if (mNuoc.Success) txtNuocCu.Text = mNuoc.Groups[1].Value;
                    else txtNuocCu.Text = "0";
                }
                catch
                {
                    txtDienCu.Text = "0"; txtNuocCu.Text = "0";
                }
            }
            else
            {
                txtDienCu.Text = "0"; txtNuocCu.Text = "0";
            }
        }
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            TinhToan();
        }

        private void TinhToan()
        {
            try
            {
                decimal dienCu = decimal.Parse(txtDienCu.Text);
                decimal dienMoi = decimal.Parse(txtDienMoi.Text);
                decimal giaDien = decimal.Parse(txtDonGiaDien.Text);

                if (dienMoi < dienCu) { MessageBox.Show("Điện mới phải >= Điện cũ"); return; }
                decimal tienDien = (dienMoi - dienCu) * giaDien;
                lblThanhTienDien.Text = tienDien.ToString("N0");

                decimal nuocCu = decimal.Parse(txtNuocCu.Text);
                decimal nuocMoi = decimal.Parse(txtNuocMoi.Text);
                decimal giaNuoc = decimal.Parse(txtDonGiaNuoc.Text);

                if (nuocMoi < nuocCu) { MessageBox.Show("Nước mới phải >= Nước cũ"); return; }
                decimal tienNuoc = (nuocMoi - nuocCu) * giaNuoc;
                lblThanhTienNuoc.Text = tienNuoc.ToString("N0");

                decimal dichVu = string.IsNullOrEmpty(txtTienDichVu.Text) ? 0 : decimal.Parse(txtTienDichVu.Text);

                decimal tong = _giaPhongHienTai + tienDien + tienNuoc + dichVu;
                lblTongTien.Text = tong.ToString("N0");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số!");
            }
        }

        private void btnXoaLichSu_Click(object sender, EventArgs e)
        {
            if (dgvLichSu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng hóa đơn cần xóa!");
                return;
            }

            int maHoaDon = Convert.ToInt32(dgvLichSu.SelectedRows[0].Cells["MaHoaDon"].Value);
            string thang = dgvLichSu.SelectedRows[0].Cells["Tháng"].Value.ToString();
            string nam = dgvLichSu.SelectedRows[0].Cells["Năm"].Value.ToString();
            string trangThai = dgvLichSu.SelectedRows[0].Cells["Trạng Thái"].Value.ToString();

            if (trangThai == "DaThanhToan")
            {
                if (MessageBox.Show("Hóa đơn này ĐÃ THU TIỀN. Xóa sẽ làm sai lệch doanh thu.\nBạn có chắc chắn muốn xóa?",
                                    "Cảnh báo nghiêm trọng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            if (MessageBox.Show($"Xác nhận xóa hóa đơn Tháng {thang}/{nam}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (hoaDonDAL.XoaHoaDon(maHoaDon))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadLichSu(_maHopDongHienTai);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
                    {
            if (_maHopDongHienTai == 0)
            {
                MessageBox.Show("Chưa có thông tin hợp đồng!");
                return;
            }

            TinhToan();

            int thang = DateTime.Now.Month;
            int nam = DateTime.Now.Year;

            if (hoaDonDAL.KiemTraDaChot(_maHopDongHienTai, thang, nam))
            {
                MessageBox.Show($"Tháng {thang}/{nam} đã được lập hóa đơn rồi!");
                return;
            }

            try
            {
                ChotDienNuocDTO chot = new ChotDienNuocDTO();
                chot.MaHopDong = _maHopDongHienTai;
                chot.Thang = thang;
                chot.Nam = nam;
                chot.ChiSoDienCu = int.Parse(txtDienCu.Text);
                chot.ChiSoDienMoi = int.Parse(txtDienMoi.Text);
                chot.ChiSoNuocCu = int.Parse(txtNuocCu.Text);
                chot.ChiSoNuocMoi = int.Parse(txtNuocMoi.Text);

                HoaDonDTO hd = new HoaDonDTO();
                hd.MaHopDong = _maHopDongHienTai;
                hd.Thang = thang;
                hd.Nam = nam;
                string tongTienStr = lblTongTien.Text.Replace(".", "").Replace(",", "");
                hd.TongTien = decimal.Parse(tongTienStr);

                hd.NguoiLap = _nguoiLapID;

                hd.GhiChu = $"Điện: {txtDienMoi.Text}-{txtDienCu.Text}; Nước: {txtNuocMoi.Text}-{txtNuocCu.Text}; DV: {txtTienDichVu.Text}";

                List<ChiTietHoaDonDTO> listChiTiet = new List<ChiTietHoaDonDTO>();

                listChiTiet.Add(new ChiTietHoaDonDTO { TenMucThanhToan = "Tiền Phòng", SoLuongSuDung = 1, DonGia = _giaPhongHienTai, ThanhTien = _giaPhongHienTai });

                int soDien = chot.ChiSoDienMoi - chot.ChiSoDienCu;
                decimal donGiaDien = decimal.Parse(txtDonGiaDien.Text);
                listChiTiet.Add(new ChiTietHoaDonDTO { TenMucThanhToan = "Tiền Điện", SoLuongSuDung = soDien, DonGia = donGiaDien, ThanhTien = soDien * donGiaDien });

                int soNuoc = chot.ChiSoNuocMoi - chot.ChiSoNuocCu;
                decimal donGiaNuoc = decimal.Parse(txtDonGiaNuoc.Text);
                listChiTiet.Add(new ChiTietHoaDonDTO { TenMucThanhToan = "Tiền Nước", SoLuongSuDung = soNuoc, DonGia = donGiaNuoc, ThanhTien = soNuoc * donGiaNuoc });

                decimal tienDichVu = string.IsNullOrEmpty(txtTienDichVu.Text) ? 0 : decimal.Parse(txtTienDichVu.Text);
                if (tienDichVu > 0)
                {
                    listChiTiet.Add(new ChiTietHoaDonDTO { TenMucThanhToan = "Dịch vụ khác", SoLuongSuDung = 1, DonGia = tienDichVu, ThanhTien = tienDichVu });
                }

                if (hoaDonDAL.LuuHoaDonDayDu(chot, hd, listChiTiet))
                {
                    DialogResult r = MessageBox.Show("Lưu hóa đơn thành công!\nBạn có muốn chuyển sang màn hình THU TIỀN ngay không?",
                                                     "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        FormQuanLyThuTien frmThuTien = new FormQuanLyThuTien(thang, nam);
                        frmThuTien.StartPosition = FormStartPosition.CenterScreen;
                        frmThuTien.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lưu thất bại! (Lỗi logic không xác định)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống chi tiết:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}