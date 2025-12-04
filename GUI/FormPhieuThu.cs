using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPhieuThu : Form
    {
        BindingSource bindingSource = new BindingSource();
        PhieuThuBLL bll = new PhieuThuBLL();
        decimal soTien;
        public FormPhieuThu()
        {
            InitializeComponent();
            this.Load += FormPhieuThu_Load;
            this.cmbNha.SelectedIndexChanged += CmbNha_SelectedIndexChanged;
            this.cmbPhong.SelectedIndexChanged += CmbPhong_SelectedIndexChanged;
            this.dgvPhieuThu.CellClick += DgvPhieuThu_CellClick;
            this.btnThem.Click += BtnThem_Click;
            this.btnTimKiem.Click += BtnTimKiem_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnSua.Click += BtnSua_Click;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem đã chọn phiếu chưa
                if (dgvPhieuThu.CurrentRow == null || dgvPhieuThu.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Vui lòng chọn phiếu thu cần sửa!");
                    return;
                }


                if (!KiemTraDuLieu()) return;

         
                PhieuThuDTO pt = new PhieuThuDTO();
                pt.ReceiptID = ID;
                pt.HostelID = Convert.ToInt32(cmbNha.SelectedValue);
                pt.RoomID = Convert.ToInt32(cmbPhong.SelectedValue);
                pt.ContractID = Convert.ToInt32(cmbHopDong.SelectedValue);
                pt.ReceiptType = cmbLoaiPhieu.Text;
                pt.ReceiptDate = dtpNgayThu.Value;
                pt.Amount = soTien;

                if (bll.SuaPhieuThu(pt))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật phiếu thu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPhieuThu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn phiếu thu cần xóa!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                int receiptId = (int)dgvPhieuThu.SelectedRows[0].Cells[0].Value;


                if (MessageBox.Show("Bạn có chắc muốn xóa phiếu thu này?",
                                    "Xác nhận",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                    return;


                if (bll.XoaPhieuThu(receiptId))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể xóa phiếu thu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                int? hostelID = null;
                int? roomID = null;
                int? contractID = null;
                string loaiPhieu = null;
                string monthPeriod = null;


                if (cmbNha.SelectedValue != null && cmbNha.SelectedIndex != -1)
                    hostelID = Convert.ToInt32(cmbNha.SelectedValue);

                if (cmbPhong.SelectedValue != null && cmbPhong.SelectedIndex != -1)
                    roomID = Convert.ToInt32(cmbPhong.SelectedValue);

                if (cmbHopDong.SelectedValue != null && cmbHopDong.SelectedIndex != -1)
                    contractID = Convert.ToInt32(cmbHopDong.SelectedValue);

                if (cmbLoaiPhieu.SelectedIndex != -1)
                    loaiPhieu = cmbLoaiPhieu.Text;


                monthPeriod = dtpNgayThu.Value.ToString("yyyy-MM");

                // Gọi BLL
                DataTable dt = bll.TimPhieuThu(
                    hostelID,
                    roomID,
                    contractID,
                    loaiPhieu,
                    monthPeriod
                );

                dgvPhieuThu.DataSource = dt;
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!KiemTraDuLieu()) return;

                int contractId = (int)cmbHopDong.SelectedValue;
                string loaiPhieu = cmbLoaiPhieu.Text;
                string monthPeriod = dtpNgayThu.Value.ToString("yyyy-MM");

                if (bll.KiemTraTonTaiPhieuThu(contractId, loaiPhieu, monthPeriod))
                {
                    MessageBox.Show("Phiếu thu này đã tồn tại trong tháng!",
                                    "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                PhieuThuDTO pt = new PhieuThuDTO();
                pt.HostelID = (int)cmbNha.SelectedValue;
                pt.RoomID = (int)cmbPhong.SelectedValue;
                pt.ReceiptType = cmbLoaiPhieu.Text;
                pt.ReceiptDate = dtpNgayThu.Value;
                pt.Amount = soTien;
                pt.ContractID = (int)cmbHopDong.SelectedValue;
  

                if (bll.ThemPhieuThu(pt))
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadData();

                    cmbLoaiPhieu.SelectedIndex = -1;
                    cmbHopDong.SelectedIndex = -1;
                    cmbPhong.SelectedIndex = -1;
                    soTien = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int ID;
        private void DgvPhieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex < 0 || e.RowIndex >= dgvPhieuThu.Rows.Count) return;

            try
            {
                DataGridViewRow row = dgvPhieuThu.Rows[e.RowIndex];

                ID = (int)row.Cells[0].Value;

                if (row.Cells[8].Value != DBNull.Value)
                    dtpNgayThu.Value = Convert.ToDateTime(row.Cells[8].Value);


                string hostelID = row.Cells[5].Value.ToString();
                cmbNha.SelectedValue = hostelID;
                string roomID = row.Cells[6].Value.ToString();

                DataTable dtPhong = bll.LayDanhSachPhong(hostelID);
                cmbPhong.DataSource = dtPhong;
                cmbPhong.DisplayMember = "RoomName";
                cmbPhong.ValueMember = "RoomID";
                cmbPhong.SelectedValue = roomID;

                if (row.Cells[4].Value != DBNull.Value)
                {
                    string contractID = row.Cells[4].Value.ToString();
                    DataTable dtHopDong = bll.LayDanhSachHopDong(hostelID, roomID);
                    cmbHopDong.DataSource = dtHopDong;
                    cmbHopDong.DisplayMember = "ContractCode";
                    cmbHopDong.ValueMember = "ContractID";

                    cmbHopDong.SelectedValue = contractID;
                }
                else
                {
                    cmbHopDong.DataSource = null;
                }
            }
            catch (Exception ex)
            {
             
            }
        }

        public bool KiemTraDuLieu()
        {
           
            if (cmbNha.SelectedIndex == -1 || cmbNha.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Nhà!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNha.Focus();
                return false;
            }

            if (cmbPhong.SelectedIndex == -1 || cmbPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Phòng!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPhong.Focus();
                return false;
            }

   
            if (cmbHopDong.SelectedIndex == -1 || cmbHopDong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Hợp đồng!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHopDong.Focus();
                return false;
            }

           
            if (cmbLoaiPhieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Loại phiếu thu!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoaiPhieu.Focus();
                return false;
            }

           
          

            return true; 
        }

        private void CmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cmbPhong.SelectedIndex != -1 && cmbPhong.SelectedValue != null)
            {
                try
                {
                    string idNha = "";
                    string idPhong = "";

                    if (cmbNha.SelectedValue.ToString() == "System.Data.DataRowView" ||
                        cmbPhong.SelectedValue.ToString() == "System.Data.DataRowView")
                    {
                        return;
                    }


                    idNha = cmbNha.SelectedValue.ToString();
                    idPhong = cmbPhong.SelectedValue.ToString();

                    DataTable dtHopDong = bll.LayDanhSachHopDong(idNha, idPhong);

                    cmbHopDong.DataSource = dtHopDong;
                    cmbHopDong.DisplayMember = "ContractCode";
                    cmbHopDong.ValueMember = "ContractID";


                    if (dtHopDong.Rows.Count > 0)
                        cmbHopDong.SelectedIndex = 0;
                    else
                        cmbHopDong.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                }
            }
            else
            {

                cmbHopDong.DataSource = null;
            }
        }
        

        private void CmbNha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNha.SelectedIndex != -1 && cmbNha.SelectedValue != null)
            {
                try
                {
                    if (cmbNha.SelectedValue.ToString() == "System.Data.DataRowView") return;

                    string idNha = cmbNha.SelectedValue.ToString();


                    DataTable dtPhong = bll.LayDanhSachPhong(idNha);
                    cmbPhong.DataSource = dtPhong;
                    cmbPhong.DisplayMember = "RoomName";
                    cmbPhong.ValueMember = "RoomID";
                    cmbPhong.SelectedIndex = -1;
                    cmbHopDong.DataSource = null;
                }
                catch (Exception ex) { }
            }
            else
            {
                cmbPhong.DataSource = null;
                cmbHopDong.DataSource = null;
            }
        }

        private void FormPhieuThu_Load(object sender, EventArgs e)
        {
            dtpNgayThu.Format = DateTimePickerFormat.Custom;
            dtpNgayThu.CustomFormat = "dd/MM/yyyy";

            LoadData();
            LoadComboBoxNha();

            cmbLoaiPhieu.Items.Clear();
            cmbLoaiPhieu.Items.Add("Tiền nhà");
            cmbLoaiPhieu.Items.Add("Tiền điện");
            cmbLoaiPhieu.Items.Add("Tiền nước");
            cmbLoaiPhieu.Items.Add("Tất cả");
            cmbLoaiPhieu.SelectedIndex = -1;

            cmbLoaiPhieu.SelectedIndexChanged += TuDongTinhTien;
            dtpNgayThu.ValueChanged += TuDongTinhTien;

            dgvPhieuThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuThu.MultiSelect = false;
        }


        private void TuDongTinhTien(object sender, EventArgs e)
        {
            try
            {
                if (cmbPhong.SelectedValue == null || cmbLoaiPhieu.SelectedIndex == -1)
                    return;

                // Lấy thông tin
                int roomID = int.Parse(cmbPhong.SelectedValue.ToString());
                string loaiPhieu = cmbLoaiPhieu.Text;


                string monthPeriod = dtpNgayThu.Value.ToString("yyyy-MM");

                // Gọi BLL tính
                PhieuThuBLL bll = new PhieuThuBLL();
                soTien = bll.TinhSoTienCanThu(loaiPhieu, roomID, monthPeriod);


            }
            catch (Exception)
            {

            }
        }

        public void LoadData()
        {
            try
            {
              
                dgvPhieuThu.AutoGenerateColumns = false;
                var dt = bll.LayDSPhieuThu();
                bindingSource.DataSource = dt;
                dgvPhieuThu.DataSource = bindingSource;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }

        public void LoadComboBoxNha()
        {

            DataTable dtNha = bll.LayDanhSachNhaCuaToi();
            cmbNha.DataSource = dtNha;
            cmbNha.DisplayMember = "HostelName";
            cmbNha.ValueMember = "HostelID";
            cmbNha.SelectedIndex = -1;
        }
    }
}
