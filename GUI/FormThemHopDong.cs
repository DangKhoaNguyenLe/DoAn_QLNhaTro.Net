using BLL;
using DTO;
using DTO.DTO;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormThemHopDong : Form
    {
        // Tận dụng BLL đã có
        NhaTroBLL nhaTroBLL = new NhaTroBLL();
        PhongBLL phongBLL = new PhongBLL();
        KhachHangBLL khBLL = new KhachHangBLL();
        HopDongBLL hopDongBLL = new HopDongBLL();

        public FormThemHopDong()
        {
            InitializeComponent();
            this.Load += FormThemHopDong_Load;
        }

        // ============================================================
        // 1. LOAD FORM
        // ============================================================
        private void FormThemHopDong_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNhaTro();
                LoadKhachHang();

                // sự kiện chọn nhà trọ → load phòng
                cboNhaTro.SelectedIndexChanged += CboNhaTro_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Load dữ liệu: " + ex.Message);
            }
        }

        // ============================================================
        // 2. LOAD NHÀ TRỌ
        // ============================================================
        private void LoadNhaTro()
        {
            var ds = nhaTroBLL.LayNhaTro();
            if (ds == null) return;

            cboNhaTro.DataSource = ds;
            cboNhaTro.DisplayMember = "TenNha";
            cboNhaTro.ValueMember = "MaNha";
            cboNhaTro.SelectedIndex = -1;
        }

        // ============================================================
        // 3. KHI CHỌN NHÀ TRỌ → LOAD PHÒNG THEO NHÀ
        // ============================================================
        private void CboNhaTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNhaTro.SelectedValue == null)
                    return;

                int maNha = 0;
                int.TryParse(cboNhaTro.SelectedValue.ToString(), out maNha);
                if (maNha == 0) return;

                var allPhong = phongBLL.LayDSPhong();
                if (allPhong == null) return;
                var dsPhong = allPhong
                    .Where(p => p.MaNha == maNha && p.TrangThai == "Trong")
                    .ToList();

                cboPhong.DataSource = dsPhong;
                cboPhong.DisplayMember = "TenPhong";
                cboPhong.ValueMember = "MaPhong";
                cboPhong.SelectedIndex = -1;
            }
            catch { }
        }

        // 4. LOAD KHÁCH HÀNG (tận dụng FormHopDong)
        private void LoadKhachHang()
        {
            var dsKH = khBLL.LayDanhSachKhachHang();
            if (dsKH == null) return;

            cboKhachHang.DataSource = dsKH;
            cboKhachHang.DisplayMember = "HoTen";
            cboKhachHang.ValueMember = "MaKhachHang";
            cboKhachHang.SelectedIndex = -1;
        }

        // 5. BẤM NÚT LƯU HỢP ĐỒNG
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput(out string error))
                {
                    MessageBox.Show(error, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                HopDongDTO hd = GetHopDongDTO();
                string errorMsg = "";

                if (!hopDongBLL.ThemHopDong(hd, out errorMsg))
                {
                    MessageBox.Show(errorMsg, "Lỗi nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Thêm hợp đồng thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hợp đồng: " + ex.Message);
            }
        }
        // 6. VALIDATE INPUT
        private bool ValidateInput(out string error)
        {
            error = "";

            if (cboNhaTro.SelectedIndex < 0)
            {
                error = "Vui lòng chọn nhà trọ!";
                return false;
            }
            if (cboPhong.SelectedIndex < 0)
            {
                error = "Vui lòng chọn phòng!";
                return false;
            }
            if (cboKhachHang.SelectedIndex < 0)
            {
                error = "Vui lòng chọn khách hàng!";
                return false;
            }

            if (!decimal.TryParse(txtTienCoc.Text, out decimal tienCoc) || tienCoc < 0)
            {
                error = "Tiền cọc không hợp lệ!";
                return false;
            }

            if (!decimal.TryParse(txtGiaThue.Text, out decimal giaThue) || giaThue < 0)
            {
                error = "Giá thuê không hợp lệ!";
                return false;
            }

            if (dtpNgayKetThuc.Checked && dtpNgayKetThuc.Value < dtpNgayBatDau.Value)
            {
                error = "Ngày kết thúc phải ≥ ngày bắt đầu!";
                return false;
            }

            return true;
        }

        // 7. LẤY DỮ LIỆU TỪ INPUT → DTO

        private HopDongDTO GetHopDongDTO()
        {
            return new HopDongDTO
            {
                MaHopDong = (int)cboNhaTro.SelectedValue,
                MaPhong = (int)cboPhong.SelectedValue,
                MaKhachHang = (int)cboKhachHang.SelectedValue,
                NguoiLapPhieu = UserSession.MaNguoiDung ,
                TienCoc = decimal.Parse(txtTienCoc.Text),
                GiaThueThucTe = decimal.Parse(txtGiaThue.Text),
                NgayBatDau = dtpNgayBatDau.Value,
                NgayKetThuc = dtpNgayKetThuc.Checked ? dtpNgayKetThuc.Value : (DateTime?)null,
                ChuKyThanhToan = (int)numChuKy.Value,
                TrangThai = "HieuLuc"
            };
        }

        // 8. NÚT HỦY
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
