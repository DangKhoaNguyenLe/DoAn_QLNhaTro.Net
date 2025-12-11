using DAL; // Gọi trực tiếp DAL cho nhanh, hoặc qua BLL tùy bạn
using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThuePhong : Form
    {
        private int _maPhong;
        private string _pathAnhTruoc = null;
        private string _pathAnhSau = null;

        public ThuePhong(int maPhong, string tenPhong)
        {
            InitializeComponent();
            _maPhong = maPhong;
            this.Text = "Ký hợp đồng thuê: " + tenPhong;
            dtpNgayVao.Value = DateTime.Now;
        }

        private void ChonAnh(PictureBox pic, ref string pathLuu)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pathLuu = open.FileName;
                pic.Image = Image.FromFile(pathLuu);
                pic.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnChonTruoc_Click(object sender, EventArgs e) => ChonAnh(picTruoc, ref _pathAnhTruoc);
        private void btnChonSau_Click(object sender, EventArgs e) => ChonAnh(picSau, ref _pathAnhSau);

        private string CopyAnh(string pathGoc)
        {
            if (string.IsNullOrEmpty(pathGoc)) return "";
            try
            {
                string folder = Path.Combine(Application.StartupPath, "Images");
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                string newName = Guid.NewGuid() + Path.GetExtension(pathGoc);
                File.Copy(pathGoc, Path.Combine(folder, newName), true);
                return @"Images\" + newName;
            }
            catch { return ""; }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtCCCD.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên và CCCD!");
                return;
            }

            KhachHangDTO kh = new KhachHangDTO();
            kh.HoTen = txtHoTen.Text;
            kh.CCCD = txtCCCD.Text;
            kh.SDT = txtSDT.Text;
            kh.QueQuan = txtQueQuan.Text;
            kh.GioiTinh = radNam.Checked ? "Nam" : "Nữ";


            kh.AnhMatTruoc = CopyAnh(_pathAnhTruoc);
            kh.AnhMatSau = CopyAnh(_pathAnhSau);

            decimal giaThue = 0;
            decimal.TryParse(txtGiaThue.Text, out giaThue);

            // 4. Gọi DAL để lưu tất cả
            ThuePhongDAL dal = new ThuePhongDAL();
            if (dal.ThuePhongMoi(kh, _maPhong, giaThue, dtpNgayVao.Value))
            {
                MessageBox.Show("Thuê phòng thành công!");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }
    }
}