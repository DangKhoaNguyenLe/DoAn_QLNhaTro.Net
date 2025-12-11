using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormKhachHang : Form
    {
        KhachHangBLL khBLL = new KhachHangBLL();
        bool themStatus = false;
        string pathMatTruoc = string.Empty;
        string pathMatSau = string.Empty;
        ImageProcess img = new ImageProcess();
        public FormKhachHang()
        {
            InitializeComponent();
            this.Load += FormKhachHang_Load;
            dgvDsKhachHang.SelectionChanged += DgvDsKhachHang_SelectionChanged;
            this.btnReset.Click += BtnReset_Click;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnSave.Click += BtnSave_Click;
            this.btnUpdate.Click += BtnUpdate_Click;
            this.btnCCCDtrc.Click += BtnCCCDtrc_Click;
            this.btnCCCDsau.Click += BtnCCCDsau_Click;
            this.dgvDsKhachHang.CellFormatting += DgvDsKhachHang_CellFormatting;
            this.btnXoa.Click += BtnXoa_Click;
            this.txtSearch.TextChanged += TxtSearch_TextChanged;
            
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            List<KhachHangDTO> dskh = khBLL.getList();
            dgvDsKhachHang.DataSource = dskh.Where(t => t.HoTen.Contains(search)).ToList();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKhachHang = int.Parse(txtMaKh.Text);
            kh.HoTen = txtHoten.Text;
            kh.CCCD = txtCCCD.Text;
            kh.SDT = txtsdt.Text;
            kh.QueQuan = txtQueQuan.Text;
            kh.GioiTinh = cmbGioiTinh.Text;
            kh.NgaySinh = txtNgaySinh.Value;
            kh.AnhMatTruoc = img.UploadImage(pathMatTruoc);
            kh.AnhMatSau = img.UploadImage(pathMatSau);
            if (khBLL.update(kh))
            {
                MessageBox.Show("Update thành công");

            }
            loadDs();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvDsKhachHang.SelectedRows[0].Cells["MaKhachHang"].Value.ToString());
            if (khBLL.delete(id))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Khách hàng này đang có trong hợp đồng thuê không thể xóa");
            }
            loadDs();
        }

        private void DgvDsKhachHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDsKhachHang.Columns[e.ColumnIndex].Name != "AnhMatTruoc" && dgvDsKhachHang.Columns[e.ColumnIndex].Name != "AnhMatSau")
                return;
            string rawPath = e.Value?.ToString();

            if (string.IsNullOrEmpty(rawPath))
            {
                e.Value = null;
                return;
            }

            Image img = null;

            try
            {

                if (rawPath.StartsWith("http"))
                {
                    using (var wc = new System.Net.WebClient())
                    {
                        byte[] bytes = wc.DownloadData(rawPath);
                        using (var ms = new MemoryStream(bytes))
                        {
                            img = Image.FromStream(ms);
                        }
                    }
                }
                else
                {
                   
                    string localPath = Path.Combine(Application.StartupPath, rawPath.Replace("/", "\\"));

                    if (File.Exists(localPath))
                    {
                        img = Image.FromFile(localPath);
                    }
                }
            }
            catch
            {
                img = null;
            }

           
            if (img != null)
            {
                e.Value = new Bitmap(img, new Size(80, 80));
                e.FormattingApplied = true;
            }
            else
            {
                e.Value = null;
            }
        }

        private void BtnCCCDsau_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pathMatTruoc = open.FileName;
                using (var fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                {
                    anhSau.Image = Image.FromStream(fs);
                }
            }
        }

        private void BtnCCCDtrc_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pathMatSau = open.FileName;
                using (var fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                {
                    anhTruoc.Image = Image.FromStream(fs);
                }
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (themStatus)
            {
                KhachHangDTO kh = new KhachHangDTO();

                kh.HoTen = txtHoten.Text;
                kh.CCCD = txtCCCD.Text;
                kh.SDT = txtsdt.Text;
                kh.QueQuan = txtQueQuan.Text;
                kh.GioiTinh = cmbGioiTinh.Text;
                kh.NgaySinh = txtNgaySinh.Value;
                kh.AnhMatTruoc = img.UploadImage(pathMatTruoc);
                kh.AnhMatSau = img.UploadImage(pathMatSau);
                MessageBox.Show(khBLL.ThemKhachHang(kh));
                themStatus = false;
            }
          
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            themStatus = true;
            resetForm();
            txtMaKh.Text = (khBLL.getList().Count() + 1) + "";
         



        }

        private void resetForm()
        {
            txtMaKh.Clear();
            txtHoten.Clear();
            txtCCCD.Clear();
            txtsdt.Clear();
            txtQueQuan.Clear();

            cmbGioiTinh.SelectedIndex = -1;   

            txtNgaySinh.Value = DateTime.Now; 

            anhTruoc.Image = null;
            anhSau.Image = null;
        }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void DgvDsKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            btnXoa.Enabled = true;
            if (dgvDsKhachHang.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dgvDsKhachHang.SelectedRows[0];

            txtMaKh.Text = row.Cells["MaKhachHang"].Value?.ToString() ?? "";
            txtHoten.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
            txtCCCD.Text = row.Cells["CCCD"].Value?.ToString() ?? "";
            txtsdt.Text = row.Cells["SDT"].Value?.ToString() ?? "";
            txtQueQuan.Text = row.Cells["QueQuan"].Value?.ToString() ?? "";

          
            string gt = row.Cells["GioiTinh"].Value?.ToString();
            if (gt != null)
                cmbGioiTinh.SelectedValue = row.Cells["GioiTinh"].Value;


            if (row.Cells["NgaySinh"].Value == DBNull.Value)
                txtNgaySinh.Value = DateTime.Now;
            else
                txtNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

            string anhMT = row.Cells["AnhMatTruoc"].Value?.ToString();
            if (!string.IsNullOrEmpty(anhMT))
            {
                try
                {
                    if (anhMT.StartsWith("http")) 
                    {
                        using (var wc = new System.Net.WebClient())
                        {
                            byte[] bytes = wc.DownloadData(anhMT);
                            using (var ms = new MemoryStream(bytes))
                            {
                                anhTruoc.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    else if (File.Exists(anhMT)) 
                    {
                        using (var fs = new FileStream(anhMT, FileMode.Open, FileAccess.Read))
                        {
                            anhTruoc.Image = Image.FromStream(fs);
                        }
                    }
                    else
                    {
                        anhTruoc.Image = null;
                    }
                }
                catch
                {
                    anhTruoc.Image = null;
                }
            }
            else
            {
                anhTruoc.Image = null;
            }

            string anhMS = row.Cells["AnhMatSau"].Value?.ToString();
            if (!string.IsNullOrEmpty(anhMS))
            {
                try
                {
                    if (anhMS.StartsWith("http"))
                    {
                        using (var wc = new System.Net.WebClient())
                        {
                            byte[] bytes = wc.DownloadData(anhMS);
                            using (var ms = new MemoryStream(bytes))
                            {
                                anhSau.Image = Image.FromStream(ms);
                            }
                        }
                    }
                    else if (File.Exists(anhMS))
                    {
                        using (var fs = new FileStream(anhMS, FileMode.Open, FileAccess.Read))
                        {
                            anhSau.Image = Image.FromStream(fs);
                        }
                    }
                    else
                    {
                        anhSau.Image = null;
                    }
                }
                catch
                {
                    anhSau.Image = null;
                }
            }
            else
            {
                anhSau.Image = null;
            }

        }

        private void loadDs()
        {
            dgvDsKhachHang.DataSource = khBLL.getList();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            cmbGioiTinh.DataSource = new[]
            {
                new { Text = "Nam", Value = "Nam" },
                new { Text = "Nữ", Value = "Nữ" }
            };
            cmbGioiTinh.DisplayMember = "Text";
            cmbGioiTinh.ValueMember = "Value";
            btnUpdate.Enabled = false;
            btnXoa.Enabled = false;
            txtMaKh.Enabled = false;
            loadDs();
        }
    }
}
