using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormHopDong : Form
    {

        private HopDongBLL hopDongBLL = new HopDongBLL();
        private PhongBLL phongBLL = new PhongBLL();
        private NhaTroBLL nhaTroBLL = new NhaTroBLL(); 
        private KhachHangBLL khachBLL = new KhachHangBLL(); 

        public List<HopDongDTO> listOriginal = new List<HopDongDTO>(); 
        private bool isEditing = false;

        public FormHopDong()
        {
            InitializeComponent();

            dgvHopDong.AutoGenerateColumns = false;
            this.Load += FormHopDong_Load;
            this.dgvHopDong.CellClick += DgvHopDong_CellClick;
            this.btnLamMoi.Click += (s, e) => { ClearInputs(); ReloadData(); };
            this.btnTimKiem.Click += BtnTimKiem_Click;
            this.btnHuyLoc.Click += (s, e) => { ResetFilter(); };
            this.btnThem.Click += Btn_Them_Click;
            this.btnSua.Click += Btn_Sua_Click;
            this.btnLuu.Click += Btn_Luu_Click;
            txtTimKiem.Enter += TxtTimKiem_Enter;
            txtTimKiem.Leave += TxtTimKiem_Leave;
            LockInputs();


        }
        private void LockInputs()
        {
            cboPhong.Enabled = false;
            cboTrangThai.Enabled = false;
            cboKhachHang.Enabled = false;
            txtTienCoc.Enabled = false;
            txtGiaThue.Enabled = false;
            dtpNgayBatDau.Enabled = false;
            dtpNgayKetThuc.Enabled = false;
            numChuKy.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Visible = true;
            btnLuu.Visible = false;
        }

        private void UnlockInputs()
        {
            cboPhong.Enabled = true;
            cboTrangThai.Enabled = true;
            cboKhachHang.Enabled = true;
            txtTienCoc.Enabled = true;
            txtGiaThue.Enabled = true;
            dtpNgayBatDau.Enabled = true;
            dtpNgayKetThuc.Enabled = true;
            numChuKy.Enabled = true;
        }

        private void TxtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Mã HĐ" || txtTimKiem.ForeColor == Color.Gray)
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void TxtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Mã HĐ";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        // ======================================================
        // CHỨC NĂNG THAO TÁC DATA
        // ======================================================

        private void ReloadData()
        {
            try
            {
                listOriginal = hopDongBLL.LayDanhSachHopDong();
                dgvHopDong.DataSource = listOriginal;
                dgvHopDong.Refresh();
                UpdateSoLuong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách hợp đồng: " + ex.Message);
            }
        }

        private void LoadCombobox()
        {
            try
            {
                // 1. Cbo Phòng (Chi tiết)
                List<PhongDTO> listPhong = phongBLL.LayDSPhong(); // Giả sử PhongBLL có LayDSPhong()
                cboPhong.DataSource = new BindingSource(listPhong, null);
                cboPhong.DisplayMember = "TenPhong";
                cboPhong.ValueMember = "MaPhong";
                cboPhong.SelectedIndex = -1;

                // 2. Cbo Khách hàng (Chi tiết)
                var listKhach = khachBLL.LayDanhSachKhachHang();
                cboKhachHang.DataSource = new BindingSource(listKhach, null);
                cboKhachHang.DisplayMember = "HoTen";
                cboKhachHang.ValueMember = "MaKhachHang";
                cboKhachHang.SelectedIndex = -1;

                // 3. Cbo Nhà Trọ (Tìm kiếm)
                List<NhaTroDTO_Form_Moi> listNha = nhaTroBLL.LayNhaTro();
                cboTimNhaTro.DataSource = new BindingSource(listNha, null);
                cboTimNhaTro.DisplayMember = "TenNha";
                cboTimNhaTro.ValueMember = "TenNha";
                cboTimNhaTro.SelectedIndex = -1;
                cboTimNhaTro.Text = "Chọn Nhà Trọ...";

                // 4. Cbo Trạng thái (Tìm kiếm)
                cboTimTrangThai.SelectedIndex = 0;
            }
            catch { }
        }

        // ======================================================
        // SỰ KIỆN CỦA FORM VÀ NÚT BẤM
        // ======================================================

        private void FormHopDong_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            ReloadData();
            LockInputs();
            btnLuu.Visible = false; 
        }

        private void DgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvHopDong.Rows[e.RowIndex];

            txtMaHopDong.Text = row.Cells["colMaHopDong"].Value?.ToString();

            if (DateTime.TryParse(row.Cells["colNgayBatDau"].Value?.ToString(), out DateTime bd))
                dtpNgayBatDau.Value = bd;
            else
                dtpNgayBatDau.Value = DateTime.Now;

            if (row.Cells["colNgayKetThuc"].Value != DBNull.Value &&
                DateTime.TryParse(row.Cells["colNgayKetThuc"].Value?.ToString(), out DateTime kt))
                dtpNgayKetThuc.Value = kt;
            else
                dtpNgayKetThuc.Value = DateTime.Now;

            decimal tienCoc = 0; decimal.TryParse(row.Cells["colTienCoc"].Value?.ToString(), out tienCoc);
            decimal giaThue = 0; decimal.TryParse(row.Cells["colGiaThue"].Value?.ToString(), out giaThue);

            txtTienCoc.Text = tienCoc.ToString("N0");
            txtGiaThue.Text = giaThue.ToString("N0");

            if (row.Cells["colTrangThai"].Value != null)
                cboTrangThai.Text = row.Cells["colTrangThai"].Value.ToString();

            int chuKy = 1;
            if (row.Cells["colChuKy"].Value != DBNull.Value &&
                int.TryParse(row.Cells["colChuKy"].Value?.ToString(), out chuKy))
                numChuKy.Value = chuKy;

            if (row.Cells["colMaPhong"].Value != null && cboPhong.DataSource != null)
                cboPhong.SelectedValue = row.Cells["colMaPhong"].Value;

            if (row.Cells["colMaKhachHang"].Value != null && cboKhachHang.DataSource != null)
                cboKhachHang.SelectedValue = row.Cells["colMaKhachHang"].Value;

            LockInputs();
            btnSua.Visible = true;
            btnLuu.Visible = false;
        }
        private void Btn_Them_Click(object sender, EventArgs e)
        {
            FormThemHopDong frm = new FormThemHopDong();
            frm.StartPosition = FormStartPosition.CenterParent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                ReloadData();
            }
        }


        public void Btn_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHopDong.Text))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần sửa!");
                return;
            }

            isEditing = true;
            UnlockInputs();
            cboKhachHang.Enabled = false;
            cboPhong.Enabled = false; 

            btnSua.Visible = false;
            btnLuu.Visible = true;
        }

        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtTienCoc.Text.Replace(",", ""), out decimal tienCoc))
                {
                    MessageBox.Show("Tiền cọc không hợp lệ."); return;
                }
                if (!decimal.TryParse(txtGiaThue.Text.Replace(",", ""), out decimal giaThue))
                {
                    MessageBox.Show("Giá thuê không hợp lệ."); return;
                }

                HopDongDTO dto = GetDTO_FromInput();
                string errorMessage = "";
                bool ok = false;

                if (isEditing)
                {
                    ok = hopDongBLL.SuaHopDong(dto, out errorMessage);
                }
                else
                {
                    ok = hopDongBLL.ThemHopDong(dto, out errorMessage);
                }

                if (!ok)
                {
                    MessageBox.Show(errorMessage, "Lỗi nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(isEditing ? "Sửa hợp đồng thành công!" : "Thêm hợp đồng thành công!");

                ReloadData();
                LockInputs();
                btnLuu.Visible = false;
                btnSua.Visible = true;
                isEditing = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hợp đồng: " + ex.Message);
            }
        }



        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            if (listOriginal == null || listOriginal.Count == 0) return;

            IEnumerable<HopDongDTO> result = listOriginal.AsEnumerable();
            string keyword = txtTimKiem.Text.Trim();

            if (!string.IsNullOrEmpty(keyword) && keyword != "Mã HĐ")
            {
                result = result.Where(x => x.MaHopDong.ToString().Contains(keyword));
            }
            if (cboTimNhaTro.SelectedIndex >= 0)
            {
                string tenNha = cboTimNhaTro.Text;
                result = result.Where(x => x.TenNhaTro == tenNha);
            }
            if (cboTimTrangThai.SelectedIndex > 0)
            {
                string status = cboTimTrangThai.Text;
                result = result.Where(x => x.TrangThai == status);
            }

            dgvHopDong.DataSource = result.ToList();
        }

        private void ResetFilter()
        {
            txtTimKiem.Text = "Mã HĐ";
            txtTimKiem.ForeColor = Color.Gray;
            cboTimNhaTro.SelectedIndex = -1;
            cboTimTrangThai.SelectedIndex = 0;
            dgvHopDong.DataSource = listOriginal;
        }

        private HopDongDTO GetDTO_FromInput()
        {
            // Lấy ID nếu đang sửa, 0 nếu đang thêm mới
            int maHD = 0;
            int.TryParse(txtMaHopDong.Text, out maHD);
            decimal tienCoc = decimal.Parse(txtTienCoc.Text.Replace(",", ""));
            decimal giaThue = decimal.Parse(txtGiaThue.Text.Replace(",", ""));

            DateTime? ngayKT = null;
            if (dtpNgayKetThuc.Checked)
                ngayKT = dtpNgayKetThuc.Value;

            return new HopDongDTO
            {
                MaHopDong = maHD,
                MaPhong = (int)cboPhong.SelectedValue,
                MaKhachHang = (int)cboKhachHang.SelectedValue,
                NgayBatDau = dtpNgayBatDau.Value,
                NgayKetThuc = ngayKT,
                TienCoc = tienCoc,
                GiaThueThucTe = giaThue,
                ChuKyThanhToan = (int)numChuKy.Value,
                TrangThai = cboTrangThai.Text,
            };
        }

        private void ClearInputs()
        {
            txtMaHopDong.Clear();
            cboPhong.SelectedIndex = -1;
            cboKhachHang.SelectedIndex = -1;

            txtTienCoc.Text = "0";
            txtGiaThue.Text = "0";

            numChuKy.Value = 1;
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            cboTrangThai.SelectedIndex = 0;

            isEditing = false;
            LockInputs();
        }

        private void UpdateSoLuong()
        {
            button_soluong.Text = dgvHopDong.Rows.Count.ToString();
        }

    }
}
