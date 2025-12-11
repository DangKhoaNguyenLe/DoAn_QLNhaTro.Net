using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI 
{
    public partial class FormDienNuoc : Form
    {

        //BindingSource bindingSource = new BindingSource();
        //DienNuocBLL bll = new DienNuocBLL();
        //DataTable dtGoc = new DataTable();
        //int _idDangSua = 0;
        //public FormDienNuoc()
        //{
        //    InitializeComponent();
        //    this.Load += FormDienNuoc_Load;
        //    this.btnLoc.Click += BtnLoc_Click;
        //    this.cmbLocNha.SelectedIndexChanged += CmbLocNha_SelectedIndexChanged;
        //    this.btnTimKiem.Click += BtnTimKiem_Click;
        //    this.cmbNha.SelectedIndexChanged += CmbNha_SelectedIndexChanged;
        //    this.cmbPhong.SelectedIndexChanged += CmbPhong_SelectedIndexChanged;
        //    this.btnHoanThanh.Click += BtnHoanThanh_Click;
        //    this.btnXoa.Click += BtnXoa_Click;
        //    this.dgvDienNuoc.CellClick += DgvDienNuoc_CellClick;
        //    this.btnSua.Click += BtnSua_Click;
        //}

        //private void BtnSua_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
               
        //        if (_idDangSua == 0)
        //        {
        //            MessageBox.Show("Vui lòng chọn một dòng trên lưới để sửa trước!");
        //            return;
        //        }


        //        DienNuocDTO dn = new DienNuocDTO();

        //        dn.HostelID = int.Parse(cmbNha.SelectedValue.ToString());
        //        dn.RoomID = int.Parse(cmbPhong.SelectedValue.ToString());
        //        dn.ContractID = int.Parse(cmbHopDong.SelectedValue.ToString());


        //        dn.MonthPeriod = dtpMonth.Value.ToString("MM/yyyy");
        //        dn.NgayChot = dtpNgayChot.Value;


        //        dn.SoDienDau = int.Parse(txtSoDienDau.Text);
        //        dn.SoDienCuoi = int.Parse(txtSoDienCuoi.Text);
        //        dn.SoNuocDau = int.Parse(txtSoNuocDau.Text);
        //        dn.SoNuocCuoi = int.Parse(txtSoNuocCuoi.Text);


              
        //        if (bll.SuaDienNuoc(dn, _idDangSua))
        //        {
        //            MessageBox.Show("Cập nhật thành công!", "Thông báo");
        //            LoadData();
        //            if (bindingSource.Count > 0) CapNhatThongKe();
        //            ResetForm(); 
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void DgvDienNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = dgvDienNuoc.Rows[e.RowIndex];

          
        //        _idDangSua = int.Parse(row.Cells[0].Value.ToString());

            
        //        cmbNha.SelectedValue = row.Cells[1].Value;

        //        cmbPhong.SelectedValue = row.Cells[2].Value;

        //        cmbHopDong.SelectedValue = row.Cells[3].Value;

        //        try
        //        {
        //            dtpMonth.Value = DateTime.ParseExact(row.Cells[4].Value.ToString(), "MM/yyyy", null);
        //        }
        //        catch { dtpMonth.Value = DateTime.Now; }

        //        dtpNgayChot.Value = Convert.ToDateTime(row.Cells[5].Value);

        //        // Các chỉ số
        //        txtSoDienDau.Text = row.Cells[6].Value.ToString();
        //        txtSoDienCuoi.Text = row.Cells[7].Value.ToString();
        //        txtSoNuocDau.Text = row.Cells[8].Value.ToString();
        //        txtSoNuocCuoi.Text = row.Cells[9].Value.ToString();

        //        btnSua.Enabled = true;
        //    }
        //}

        //private void BtnXoa_Click(object sender, EventArgs e)
        //{
        //try
        //    {
        //        // 1. KIỂM TRA: Người dùng đã chọn dòng nào chưa?
        //        if (dgvDienNuoc.CurrentRow == null || dgvDienNuoc.SelectedRows.Count == 0)
        //        {
        //            MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // 2. LẤY ID CỦA DÒNG ĐANG CHỌN
   
        //        var cellValue = dgvDienNuoc.CurrentRow.Cells[0].Value;

        //        if (cellValue == null || string.IsNullOrEmpty(cellValue.ToString())) return;

        //        int idCanXoa = int.Parse(cellValue.ToString());

        //        // 3. HỎI XÁC NHẬN
        //        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?",
        //                                              "Xác nhận xóa",
        //                                              MessageBoxButtons.YesNo,
        //                                              MessageBoxIcon.Question);

        //        if (result == DialogResult.Yes)
        //        {
        //            // 4. GỌI BLL ĐỂ XÓA
        //            if (bll.XoaDienNuoc(idCanXoa))
        //            {
        //                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                // 5. CẬP NHẬT LẠI GIAO DIỆN
        //                LoadData(); // Tải lại danh sách

        //                // Tính lại tiền (nếu còn dữ liệu)
        //                if (bindingSource.Count > 0)
        //                    CapNhatThongKe();
        //                else
        //                    HienThiSo0(); // Nếu xóa hết sạch thì về 0
        //            }
        //            else
        //            {
        //                MessageBox.Show("Xóa thất bại! Có thể dữ liệu đã bị thay đổi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // Bắt lỗi nếu tên cột sai hoặc lỗi SQL
        //        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        
        //private void CmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbPhong.SelectedIndex != -1 && cmbPhong.SelectedValue != null)
        //    {
        //        try
        //        {
        //            string idNha = "";
        //            string idPhong = "";

        //            if (cmbNha.SelectedValue.ToString() == "System.Data.DataRowView" ||
        //                cmbPhong.SelectedValue.ToString() == "System.Data.DataRowView")
        //            {
        //                return;
        //            }

 
        //            idNha = cmbNha.SelectedValue.ToString();
        //            idPhong = cmbPhong.SelectedValue.ToString();

        //            DataTable dtHopDong = bll.LayDanhSachHopDong(idNha, idPhong);

        //            // Đổ dữ liệu vào ComboBox Hợp đồng
        //            cmbHopDong.DataSource = dtHopDong;
        //            cmbHopDong.DisplayMember = "ContractCode";
        //            cmbHopDong.ValueMember = "ContractID";

    
        //            if (dtHopDong.Rows.Count > 0)
        //                cmbHopDong.SelectedIndex = 0;
        //            else
        //                cmbHopDong.SelectedIndex = -1;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //    {
             
        //        cmbHopDong.DataSource = null;
        //    }
        //}

        //private void CmbNha_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbNha.SelectedIndex != -1 && cmbNha.SelectedValue != null)
        //    {
        //        try
        //        {
        //            if (cmbNha.SelectedValue.ToString() == "System.Data.DataRowView") return;

        //            string idNha = cmbNha.SelectedValue.ToString();


        //            DataTable dtPhong = bll.LayDanhSachPhong(idNha);
        //            cmbPhong.DataSource = dtPhong;
        //            cmbPhong.DisplayMember = "RoomName";
        //            cmbPhong.ValueMember = "RoomID";
        //            cmbPhong.SelectedIndex = -1;
        //            cmbHopDong.DataSource = null;
        //        }
        //        catch (Exception ex) {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //    {
        //        cmbPhong.DataSource = null;
        //        cmbHopDong.DataSource = null;
        //    }
        //}
        //private void BtnHoanThanh_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
      
        //        if (cmbNha.SelectedIndex == -1 || cmbNha.SelectedIndex == -1 || cmbHopDong.SelectedIndex == -1)
        //        {
        //            MessageBox.Show("Vui lòng chọn Nhà, Phòng và Hợp đồng!");
        //            return;
        //        }


        //        DienNuocDTO dn = new DienNuocDTO();

        //        dn.HostelID = int.Parse(cmbNha.SelectedValue.ToString());
        //        dn.RoomID = int.Parse(cmbPhong.SelectedValue.ToString());

        //        dn.ContractID = int.Parse(cmbHopDong.SelectedValue.ToString());


        //        dn.MonthPeriod = dtpMonth.Value.ToString("MM/yyyy");
        //        dn.NgayChot = dtpNgayChot.Value;


        //        dn.SoDienDau = int.Parse(txtSoDienDau.Text);
        //        dn.SoDienCuoi = int.Parse(txtSoDienCuoi.Text);
        //        dn.SoNuocDau = int.Parse(txtSoNuocDau.Text);
        //        dn.SoNuocCuoi = int.Parse(txtSoNuocCuoi.Text);

                
        //            if (bll.Add(dn))
        //            {
        //                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                ResetForm();

        //                LoadData();
        //                if (bindingSource.Count > 0) CapNhatThongKe();
        //            }
               
        //    }
        //    catch (FormatException)
        //    {
        //        MessageBox.Show("Vui lòng nhập đầy đủ thông tin và đúng định dạng số!", "Lỗi nhập liệu");
        //    }
        //    catch (Exception ex)
        //    {
          
        //        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //public void ResetForm()
        //{
        //    cmbNha.SelectedIndex = -1;
        //    cmbPhong.SelectedIndex = -1;
        //    txtSoDienDau.Text = string.Empty; txtSoDienCuoi.Text = string.Empty;
        //    txtSoNuocDau.Text = string.Empty; txtSoNuocCuoi.Text = string.Empty;
        //    cmbNha.SelectedIndex = -1;
        //    _idDangSua = 0;


        //    btnHoanThanh.Enabled = true;   
        //    btnSua.Enabled = false;

        //}

        //private void BtnTimKiem_Click(object sender, EventArgs e)
        //{
         
        //    try
        //    {
        //        List<string> DieuKienLoc = new List<string>();

             
        //        if (!string.IsNullOrEmpty(txtTimNha.Text.Trim()))
        //        {
        //            string filterNha = string.Format("Convert(HostelID, 'System.String') LIKE '%{0}%'", txtTimNha.Text.Trim());
        //            DieuKienLoc.Add(filterNha);
        //        }

          
        //        if (!string.IsNullOrEmpty(txtTimPhong.Text.Trim()))
        //        {
                   
        //            string filterPhong = string.Format("Convert(RoomID, 'System.String') LIKE '%{0}%'", txtTimPhong.Text.Trim());
        //            DieuKienLoc.Add(filterPhong);
        //        }

                
        //        if (!string.IsNullOrEmpty(txtTimHopDong.Text.Trim()))
        //        {
                    
        //            DieuKienLoc.Add(string.Format("ContractID LIKE '%{0}%'", txtTimHopDong.Text.Trim()));
        //        }

    
        //        string filter = "";

        //        if (DieuKienLoc.Count > 0)
        //        {
                  
        //            filter = string.Join(" AND ", DieuKienLoc);
        //        }

        //        // Gán vào BindingSource
        //        bindingSource.Filter = filter;

        //        // Kiểm tra và hiển thị
        //        if (bindingSource.Count == 0)
        //        {
        
        //            HienThiSo0();
        //            MessageBox.Show("Không tìm thấy dữ liệu nào phù hợp!", "Thông báo");
        //        }
        //        else
        //        {
                  
        //            CapNhatThongKe();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
        //    }
        //}
  
        //public void CmbLocNha_SelectedIndexChanged(object sender, EventArgs e)
        //{
   
        //    if (cmbLocNha.SelectedIndex != -1 && cmbLocNha.SelectedValue != null)
        //    {
        //        try
        //        {
        //            string idNha = string.Empty;
        //            if (cmbLocNha.SelectedValue.ToString() == "System.Data.DataRowView")
        //            {
        //                return; 
        //            }
        //            else
        //            {
        //                idNha = cmbLocNha.SelectedValue.ToString();
        //            }


        //            DataTable dtPhong = bll.LayDanhSachPhong(idNha);

        //            cmbLocPhong.DataSource = dtPhong;
        //            cmbLocPhong.DisplayMember = "RoomName"; 
        //            cmbLocPhong.ValueMember = "RoomID";     

        //            cmbLocPhong.SelectedIndex = -1;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //    else
        //    {

        //        cmbLocPhong.DataSource = null;
        //    }
        //}
        //private void BtnLoc_Click(object sender, EventArgs e)
        //{
        //    dgvDienNuoc.ClearSelection();
        //    try
        //    {
               
        //        List<string> DieuKienLoc = new List<string>();

        //        // 1. ĐIỀU KIỆN NHÀ (Nếu có chọn)
        //        if (cmbLocNha.SelectedIndex != -1 && cmbLocNha.SelectedValue != null)
        //        {
                 
        //            DieuKienLoc.Add(string.Format("HostelID = '{0}'", cmbLocNha.SelectedValue));
        //        }

        //        if (cmbLocPhong.SelectedIndex != -1 && cmbLocPhong.SelectedValue != null)
        //        {

        //            DieuKienLoc.Add(string.Format("RoomID = '{0}'", cmbLocPhong.SelectedValue));
        //        }

        //        DateTime tuNgay = dtpChonNgayBD.Value.Date;

        //        DateTime denNgay = dtpChonNgayKT.Value.Date.AddDays(1).AddSeconds(-1);


        //        string locNgay = string.Format("[NgayChot] >= #{0:MM/dd/yyyy}# AND [NgayChot] <= #{1:MM/dd/yyyy}#",
        //                                       tuNgay, denNgay);

        //        DieuKienLoc.Add(locNgay);


  
        //        string filter = string.Empty;
        //        if (DieuKienLoc.Count > 0)
        //        {
        //            // Nối các điều kiện bằng chữ AND
        //            filter = string.Join(" AND ", DieuKienLoc);
        //        }

        //        // Gán vào BindingSource
        //        bindingSource.Filter = filter;


        //        if (bindingSource.Count > 0)
        //        {
        //            CapNhatThongKe();
        //        }
        //        else
        //        {
        //            HienThiSo0();
        //            MessageBox.Show("Không tìm thấy dữ liệu nào trong khoảng thời gian này!");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
        //    }
        //}
        //private void FormDienNuoc_Load(object sender, EventArgs e)
        //{
            
          
        //    dtpMonth.Format = DateTimePickerFormat.Custom;
        //    dtpMonth.CustomFormat = "MM/yyyy";
        //    dtpMonth.ShowUpDown = true;


        //    dtpNgayChot.Format = DateTimePickerFormat.Custom;
        //    dtpNgayChot.CustomFormat = "dd/MM/yyyy";

        //    dtpChonNgayBD.Format = DateTimePickerFormat.Custom;
        //    dtpChonNgayBD.CustomFormat = "dd/MM/yyyy";

        //    dtpChonNgayKT.Format = DateTimePickerFormat.Custom;
        //    dtpChonNgayKT.CustomFormat = "dd/MM/yyyy";
        //    // Load dữ liệu ban đầu
        //    LoadData();

        //}
        //public void LoadData()
        //{
        //    try
        //    {
        //        dtGoc = bll.LayDSDienNuocCuaToi();
        //        bindingSource.DataSource = dtGoc;
        //        dgvDienNuoc.DataSource = bindingSource;
        //        HienThiSo0();
        //        dgvDienNuoc.ClearSelection();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
        //    }
        //    ToMauHeader();
        //    LoadComboBoxNha();
        //}
        //private void HienThiSo0()
        //{
        //    cardTongSoDien.SetData("TỔNG SỐ ĐIỆN", 0, Color.FromArgb(229, 57, 53), false);
        //    cardTongSoNuoc.SetData("TỔNG SỐ NƯỚC", 0, Color.FromArgb(0, 150, 136), false);
        //    cardTongThuDien.SetData("TỔNG THU ĐIỆN", 0, Color.FromArgb(3, 169, 244), true);
        //    cardTongThuNuoc.SetData("TỔNG THU NƯỚC", 0, Color.FromArgb(3, 169, 244), true);
        //}
        //private void CapNhatThongKe()
        //{
        //    try
        //    {
            
        //        if (dtGoc == null || dtGoc.Rows.Count == 0) return;

       
        //        DataTable dtDangHienThi = dtGoc.Clone();


        //        foreach (DataRowView drv in bindingSource)
        //        {
        //            dtDangHienThi.ImportRow(drv.Row);
        //        }


        //        ThongKeDienNuocDTO ketQua = bll.TinhToanSoLieu(dtDangHienThi);

     
        //        cardTongSoDien.SetData("TỔNG SỐ ĐIỆN", ketQua.TongSoDien, Color.FromArgb(229, 57, 53), false);
        //        cardTongSoNuoc.SetData("TỔNG SỐ NƯỚC", ketQua.TongSoNuoc, Color.FromArgb(0, 150, 136), false);
        //        cardTongThuDien.SetData("TỔNG THU ĐIỆN", ketQua.TongThuDien, Color.FromArgb(3, 169, 244), true);
        //        cardTongThuNuoc.SetData("TỔNG THU NƯỚC", ketQua.TongThuNuoc, Color.FromArgb(3, 169, 244), true);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi tính toán: " + ex.Message);
        //    }
        //}
        //public void ToMauHeader()
        //{
        //    dgvDienNuoc.EnableHeadersVisualStyles = false; 
        //    dgvDienNuoc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
        //    dgvDienNuoc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    dgvDienNuoc.RowsDefaultCellStyle.BackColor = Color.White;
        //    dgvDienNuoc.RowsDefaultCellStyle.ForeColor = Color.Black;
        //    dgvDienNuoc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 245, 245);
        //    dgvDienNuoc.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
        //    dgvDienNuoc.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(33, 150, 243);
        //    dgvDienNuoc.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
        //}
        //public void LoadComboBoxNha()
        //{

        //    DataTable dtNha = bll.LayDanhSachNhaCuaToi();

        //    cmbLocNha.DataSource = dtNha;
        //    cmbLocNha.DisplayMember = "HostelName"; 
        //    cmbLocNha.ValueMember = "HostelID";
        //    cmbLocNha.SelectedIndex = -1;
        //    cmbNha.DataSource = dtNha;
        //    cmbNha.DisplayMember = "HostelName";
        //    cmbNha.ValueMember = "HostelID";
        //    cmbNha.SelectedIndex = -1;
        //}
    }

}