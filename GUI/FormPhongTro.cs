using BLL;
using DAL;
using DTO;
using GUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL.PhongDAL;

namespace GUI
{
    public partial class FormPhongTro : Form
    {
        string _vaiTroHienTai;
        PhongBLL bll = new PhongBLL();
        string _duongDanAnhGoc = string.Empty;
        int _maPhongDangChon = 0;
        string _pathAnhCuDatabase = string.Empty;
        private RoomItem _itemDangChon = null;
        public FormPhongTro(string vaiTro)
        {
            _vaiTroHienTai = vaiTro;
            InitializeComponent();
            this.Load += FormPhongTro_Load;
            btnChonAnh.Click += BtnChonAnh_Click;
            btnThem.Click += BtnThem_Click;
            cboChiNhanh.SelectedIndexChanged += CboLoc_SelectedIndexChanged;
            cboLoaiPhong.SelectedIndexChanged += CboLoc_SelectedIndexChanged;
            txtTenPhong.TextChanged += TxtTenPhong_TextChanged;
            btnXoa.Click += BtnXoa_Click;
            btnSua.Click += BtnSua_Click;
            btnDatCoc.Click += BtnDatCoc_Click;
            btnHuyCoc.Click += BtnHuyCoc_Click;
            btnTraPhong.Click += BtnTraPhong_Click;
            btnThuePhong.Click += BtnThuePhong_Click;
        }

        private void BtnThuePhong_Click(object sender, EventArgs e)
        {
            if (_maPhongDangChon == 0)
            {
                MessageBox.Show("Chọn phòng muốn thuê trước!");
                return;
            }

            PhongDTO p = _itemDangChon.Tag as PhongDTO;
            if (p.TrangThai == "DaThue")
            {
                MessageBox.Show("Phòng này đang có người ở rồi!");
                return;
            }

            ThuePhong frm = new ThuePhong(_maPhongDangChon, p.TenPhong);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadHienThiPhong();
                ResetForm();
            }
        }

        private void BtnTraPhong_Click(object sender, EventArgs e)
        {
            if (_maPhongDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần trả!");
                return;
            }

            PhongDTO phong = _itemDangChon.Tag as PhongDTO;

            if (phong.TrangThai != "DaThue")
            {
                MessageBox.Show("Phòng này chưa cho thuê nên không thể trả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show($"Xác nhận trả phòng {phong.TenPhong}?\n(Hợp đồng sẽ kết thúc và phòng chuyển về trạng thái Trống)",
                                             "Trả phòng",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                if (bll.TraPhong(_maPhongDangChon))
                {
                    MessageBox.Show("Trả phòng thành công!");
                    LoadHienThiPhong(); 
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Lỗi khi trả phòng!");
                }
            }
        }

        private void PhanQuyen()
        {
            if (_vaiTroHienTai == "NHANVIEN")
            {
                btnThem.Visible = false;
                btnSua.Visible = false;
                btnXoa.Visible = false;

            }
            else
            {
                btnThem.Visible = true;
                btnSua.Visible = true;
                btnXoa.Visible = true;

            }
        }

        private void BtnHuyCoc_Click(object sender, EventArgs e)
        {
            if (_maPhongDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần hủy cọc!");
                return;
            }

            PhongDTO phongHienTai = _itemDangChon.Tag as PhongDTO;

            if (phongHienTai.TrangThai != "DaDatCoc")
            {
                MessageBox.Show("Phòng này chưa có cọc nên không thể hủy!\n(Chỉ hủy được phòng màu Vàng)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult r = MessageBox.Show($"Bạn có chắc chắn muốn hủy cọc phòng {phongHienTai.TenPhong} không?\nPhòng sẽ trở về trạng thái TRỐNG.",
                                             "Xác nhận hủy cọc",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                CocBLL cocBLL = new CocBLL(); 
                if (cocBLL.HuyDatCoc(_maPhongDangChon))
                {
                    MessageBox.Show("Đã hủy cọc thành công!");
                    LoadHienThiPhong();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Lỗi khi hủy cọc!");
                }
            }
        }

        private void BtnDatCoc_Click(object sender, EventArgs e)
        {
            if (_maPhongDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần đặt cọc!");
                return;
            }

            PhongDTO phongHienTai = _itemDangChon.Tag as PhongDTO;

            if (phongHienTai.TrangThai != "Trong")
            {
                MessageBox.Show("Chỉ có thể đặt cọc cho phòng TRỐNG!\nPhòng này đang " + phongHienTai.TrangThai);
                return;
            }

            DatCoc frm = new DatCoc(_maPhongDangChon, txtTenPhong.Text);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadHienThiPhong(); 
                ResetForm();
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (_maPhongDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
                return;
            }

            if (cboChiNhanh.SelectedValue == null || (int)cboChiNhanh.SelectedValue == 0)
            {
                MessageBox.Show("Vui lòng chọn Nhà!");
                return;
            }

            string pathFinal = _pathAnhCuDatabase;

            if (!string.IsNullOrEmpty(_duongDanAnhGoc))
            {
                try
                {
                    string folderImages = Path.Combine(Application.StartupPath, "Images");
                    if (!Directory.Exists(folderImages)) Directory.CreateDirectory(folderImages);

                    string tenFileMoi = Guid.NewGuid().ToString() + Path.GetExtension(_duongDanAnhGoc);

                    File.Copy(_duongDanAnhGoc, Path.Combine(folderImages, tenFileMoi), true);

                    pathFinal = @"Images\" + tenFileMoi;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xử lý ảnh: " + ex.Message);
                    return;
                }
            }

            PhongDTO p = new PhongDTO();
            p.MaPhong = _maPhongDangChon; 
            p.MaNha = Convert.ToInt32(cboChiNhanh.SelectedValue);
            p.MaLoaiPhong = Convert.ToInt32(cboLoaiPhong.SelectedValue);
            p.TenPhong = txtTenPhong.Text;
            p.GhiChu = txtGhiChu.Text;
            p.AnhDaiDien = pathFinal;

            int tang = 1;
            int.TryParse(txtTang.Text, out tang);
            p.Tang = tang;

            if (bll.SuaPhong(p))
            {
                MessageBox.Show("Cập nhật phòng thành công!");
                ResetForm(); 
                LoadHienThiPhong();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (_maPhongDangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn một phòng trên danh sách để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa phòng này không?\n(Dữ liệu ảnh và tài sản đi kèm sẽ bị mất hết)",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (bll.XoaPhong(_maPhongDangChon))
                {
                    MessageBox.Show("Xóa phòng thành công!");
                    ResetForm();
                    LoadHienThiPhong();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Có thể phòng đang có Hợp đồng thuê hoặc lỗi kết nối.");
                }
            }
        }

        private void ResetForm()
        {
            txtTenPhong.Clear();
            txtGhiChu.Clear();
            txtTang.Clear();
            picAnhPhong.Image = null;
            _maPhongDangChon = 0;
            _duongDanAnhGoc = null;
            cboChiNhanh.SelectedIndex = 0; 
            cboLoaiPhong.SelectedIndex = 0;
        }

        private void TxtTenPhong_TextChanged(object sender, EventArgs e)
        {
            int tang = LaySoTangTuTenPhong(txtTenPhong.Text);
            txtTang.Text = tang.ToString();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

            if (cboChiNhanh.SelectedValue == null || (int)cboChiNhanh.SelectedValue == 0)
            {
                MessageBox.Show("Vui lòng chọn Nhà (Chi nhánh) cụ thể!");
                return;
            }

            if (string.IsNullOrEmpty(txtTenPhong.Text.Trim()))
            {
                MessageBox.Show("Chưa nhập tên phòng!");
                return;
            }

            string tenPhong = txtTenPhong.Text.Trim();
            int maNha = Convert.ToInt32(cboChiNhanh.SelectedValue);

            
            PhongDAL dal = new PhongDAL();
            if (dal.KiemTraTenPhongTonTai(tenPhong, maNha))
            {
                MessageBox.Show($"Tên phòng '{tenPhong}' đã tồn tại trong nhà này rồi!\nVui lòng đặt tên khác.", "Cảnh báo trùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            int tangTuDong = LaySoTangTuTenPhong(tenPhong);


            txtTang.Text = tangTuDong.ToString();



            PhongDTO p = new PhongDTO();
            p.MaNha = maNha;
            p.MaLoaiPhong = Convert.ToInt32(cboLoaiPhong.SelectedValue);
            p.TenPhong = tenPhong;
            p.Tang = tangTuDong; // Dùng số tầng vừa tính được
            p.GhiChu = txtGhiChu.Text;

            // Xử lý ảnh (Code cũ của bạn)
            string pathLuuDatabase = "";
            if (!string.IsNullOrEmpty(_duongDanAnhGoc))
            {
                // ... (Giữ nguyên logic copy ảnh cũ của bạn) ...
                try
                {
                    string folderImages = Path.Combine(Application.StartupPath, "Images");
                    if (!Directory.Exists(folderImages)) Directory.CreateDirectory(folderImages);
                    string tenFileMoi = Guid.NewGuid().ToString() + Path.GetExtension(_duongDanAnhGoc);
                    File.Copy(_duongDanAnhGoc, Path.Combine(folderImages, tenFileMoi), true);
                    pathLuuDatabase = @"Images\" + tenFileMoi;
                }
                catch { }
            }
            p.AnhDaiDien = pathLuuDatabase;

            // Gọi hàm Thêm
            if (bll.ThemPhongMoi(p))
            {
                MessageBox.Show("Thêm phòng thành công!");
                LoadHienThiPhong();

                // Reset
                txtTenPhong.Clear();
                txtGhiChu.Clear();
                picAnhPhong.Image = null;
                _duongDanAnhGoc = null;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                _duongDanAnhGoc = open.FileName;

                picAnhPhong.Image = Image.FromFile(_duongDanAnhGoc);
            }
        }

        private void FormPhongTro_Load(object sender, EventArgs e)
        {
            LoadComboboxNha();
            LoadComboboxLoaiPhong();
            LoadHienThiPhong();
            PhanQuyen();
        }
        private Image LoadAnhTuDuongDan(string duongDanTuDB)
        {
            if (string.IsNullOrEmpty(duongDanTuDB)) return null;

            try
            {
                string cleanPath = duongDanTuDB.TrimStart('/', '\\');
                string fullPath = "";

                string pathInDebug = Path.Combine(Application.StartupPath, cleanPath);

                string pathInResources = "";
                DirectoryInfo projectDir = Directory.GetParent(Application.StartupPath)?.Parent;
                if (projectDir != null)
                {
                    pathInResources = Path.Combine(projectDir.FullName, "Resources", cleanPath);
                }

                if (File.Exists(pathInDebug))
                {
                    fullPath = pathInDebug;
                }
                else if (File.Exists(pathInResources))
                {
                    fullPath = pathInResources;
                }
                else
                {
                    return null;
                }

                using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    Image img = Image.FromStream(fs);
                    return new Bitmap(img);
                }
            }
            catch
            {
                return null;
            }
        }
        private void LoadHienThiPhong()
        {
            flpDanhSachPhong.Controls.Clear();

            List<PhongDTO> listPhong = bll.LayDSPhong();

            if (cboChiNhanh.SelectedValue != null)
            {
                int maNhaChon = Convert.ToInt32(cboChiNhanh.SelectedValue);
                if (maNhaChon > 0) 
                {
                    listPhong = listPhong.Where(p => p.MaNha == maNhaChon).ToList();
                }
            }

            if (cboLoaiPhong.SelectedValue != null)
            {
                int maLoaiChon = Convert.ToInt32(cboLoaiPhong.SelectedValue);
                if (maLoaiChon > 0)
                {
                    listPhong = listPhong.Where(p => p.MaLoaiPhong == maLoaiChon).ToList();
                }
            }

            foreach (PhongDTO phong in listPhong)
            {
                RoomItem item = new RoomItem();
                Image imgPhong = LoadAnhTuDuongDan(phong.AnhDaiDien);
                item.SetData(phong.TenPhong, phong.TrangThai, imgPhong);

                item.MaPhong = phong.MaPhong.ToString();
                item.Tag = phong;
                item.Click += RoomItem_Click;
                foreach (Control child in item.Controls) child.Click += (s, e) => RoomItem_Click(item, e);

                flpDanhSachPhong.Controls.Add(item);
            }
        }
        private void RoomItem_Click(object sender, EventArgs e)
        {
            RoomItem item = sender as RoomItem;
            if (item != null)
            {
                PhongDTO p = item.Tag as PhongDTO;
                if (p != null)
                {
                    if (_itemDangChon != null)
                    {
                        _itemDangChon.SetSelected(false);
                    }
                    _itemDangChon = item;
                    _itemDangChon.SetSelected(true);
                    _maPhongDangChon = p.MaPhong;

                    txtTenPhong.Text = p.TenPhong;
                    txtGhiChu.Text = p.GhiChu;
                    txtTang.Text = p.Tang.ToString();

                    cboChiNhanh.SelectedValue = p.MaNha;
                    cboLoaiPhong.SelectedValue = p.MaLoaiPhong;

                    if (!string.IsNullOrEmpty(p.AnhDaiDien))
                    {
                        _duongDanAnhGoc = null; 
                        picAnhPhong.Image = LoadAnhTuDuongDan(p.AnhDaiDien);
                    }
                    else
                    {
                        picAnhPhong.Image = null;
                    }
                }
            }
        }
        private void LoadComboboxNha()
        {
            DanhMucBLL danhMucBLL = new DanhMucBLL();
            DataTable dt = danhMucBLL.LayDSNha();
            DataRow dr = dt.NewRow();
            dr["MaNha"] = 0;
            dr["TenNha"] = "--- Tất cả Chi Nhánh ---";
            dt.Rows.InsertAt(dr, 0);

            cboChiNhanh.DataSource = dt;
            cboChiNhanh.DisplayMember = "TenNha";
            cboChiNhanh.ValueMember = "MaNha";

            cboChiNhanh.SelectedIndex = 0;
        }
        private void LoadComboboxLoaiPhong()
        {
            DanhMucBLL danhMucBLL = new DanhMucBLL();
            DataTable dt = danhMucBLL.LayDSLoaiPhong();

            DataRow dr = dt.NewRow();
            dr["MaLoaiPhong"] = 0;
            dr["TenLoai"] = "--- Tất cả Loại Phòng ---";
            dt.Rows.InsertAt(dr, 0);

            cboLoaiPhong.DataSource = dt;
            cboLoaiPhong.DisplayMember = "TenLoai";
            cboLoaiPhong.ValueMember = "MaLoaiPhong";

            cboLoaiPhong.SelectedIndex = 0;
        }

        private void CboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChiNhanh.SelectedValue != null && cboLoaiPhong.SelectedValue != null)
            {
                int test;
                if (int.TryParse(cboChiNhanh.SelectedValue.ToString(), out test) &&
                    int.TryParse(cboLoaiPhong.SelectedValue.ToString(), out test))
                {
                    LoadHienThiPhong();
                }
            }
        }

        private int LaySoTangTuTenPhong(string tenPhong)
        {
            Match match = Regex.Match(tenPhong, @"\d+");

            if (match.Success)
            {
                string numberStr = match.Value; 

                if (numberStr.Length >= 3)
                {
                    string tangStr = numberStr.Substring(0, numberStr.Length - 2);
                    int tang;
                    if (int.TryParse(tangStr, out tang))
                    {
                        return tang;
                    }
                }
                else if (numberStr.Length == 1) 
                {
                    return 1; 
                }
            }

            return 1; 
        }

    }
}

