using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormQuanLyNhanVien : Form
    {
        private NguoiDungBLL bll = new NguoiDungBLL();
        private int _maDangChon = 0;

        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            this.Load += FormQuanLyNhanVien_Load;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            btnThem.Click += btnThem_Click;
            btnXoa.Click += btnXoa_Click;
            btnSua.Click += btnSua_Click;
            btnLamMoi.Click += btnLamMoi_Click;

        }


        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            cboVaiTro.Items.Clear();
            cboVaiTro.Items.Add("NHANVIEN");
            cboVaiTro.Items.Add("ADMIN");
            cboVaiTro.SelectedIndex = 0;
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            List<NguoiDungDTO> list = bll.LayDSNhanVien();
            dgvNhanVien.DataSource = list;

            if (dgvNhanVien.Columns["MatKhau"] != null)
                dgvNhanVien.Columns["MatKhau"].Visible = false;

            if (dgvNhanVien.Columns["MaNguoiDung"] != null)
            {
                dgvNhanVien.Columns["MaNguoiDung"].HeaderText = "Mã NV";
                dgvNhanVien.Columns["MaNguoiDung"].Width = 60;
            }

            if (dgvNhanVien.Columns["TenDangNhap"] != null)
                dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Tài khoản";

            if (dgvNhanVien.Columns["HoTen"] != null)
            {
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvNhanVien.Columns["HoTen"].Width = 150;
            }

            if (dgvNhanVien.Columns["VaiTro"] != null)
                dgvNhanVien.Columns["VaiTro"].HeaderText = "Chức vụ";

            if (dgvNhanVien.Columns["SDT"] != null)
                dgvNhanVien.Columns["SDT"].HeaderText = "SĐT";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                _maDangChon = Convert.ToInt32(row.Cells["MaNguoiDung"].Value);
                txtTenDangNhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value != null ? row.Cells["SDT"].Value.ToString() : "";

                string role = row.Cells["VaiTro"].Value.ToString();
                if (cboVaiTro.Items.Contains(role))
                    cboVaiTro.SelectedItem = role;

                txtTenDangNhap.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập Tài khoản và Mật khẩu!");
                return;
            }

            NguoiDungDTO nd = new NguoiDungDTO();
            nd.TenDangNhap = txtTenDangNhap.Text;
            nd.MatKhau = txtMatKhau.Text;
            nd.HoTen = txtHoTen.Text;
            nd.SDT = txtSDT.Text;
            nd.VaiTro = cboVaiTro.SelectedItem.ToString();

            string kq = bll.ThemNhanVien(nd);
            if (kq == "Success")
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadDanhSach();
                ResetForm();
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_maDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
                return;
            }

            NguoiDungDTO nd = new NguoiDungDTO();
            nd.MaNguoiDung = _maDangChon;
            nd.HoTen = txtHoTen.Text;
            nd.MatKhau = txtMatKhau.Text;
            nd.SDT = txtSDT.Text;
            nd.VaiTro = cboVaiTro.SelectedItem.ToString();

            if (bll.SuaNhanVien(nd))
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
                LoadDanhSach();
                ResetForm();
            }
            else MessageBox.Show("Lỗi cập nhật!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_maDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bll.XoaNhanVien(_maDangChon))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDanhSach();
                    ResetForm();
                }
                else MessageBox.Show("Lỗi khi xóa!");
            }
        }

        private void ResetForm()
        {
            txtTenDangNhap.Enabled = true; 
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            cboVaiTro.SelectedIndex = 0;
            _maDangChon = 0;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}