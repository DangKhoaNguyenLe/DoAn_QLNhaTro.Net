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
    public partial class FormThemNhaTro : Form
    {
        string _duongDanAnhGoc = string.Empty;
        NguoiDungBLL nguoiDung = new NguoiDungBLL();
        string thaoTac = string.Empty;
        int idNha = 0;
        NhaTroBLL nhaTroBLL = new NhaTroBLL();
        ImageProcess img = new ImageProcess();
        public FormThemNhaTro(string thaoTac, int id)
        {
            InitializeComponent();
            this.thaoTac = thaoTac;
            this.idNha = id;
            this.btnChonAnh.Click += BtnChonAnh_Click;
            this.button_them.Click += Button_them_Click;
            this.Load += FormThemNhaTro_Load;
            this.btnEdit.Click += BtnEdit_Click;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            NhaTroDTO nt = new NhaTroDTO();
            nt.MaNha = idNha;
            nt.TenNha = textBox_ten_nha_tro.Text;
            nt.DiaChi = textBox_dia_chi.Text;
            nt.GhiChu = txtGhiChu.Text;
            nt.NguoiQuanLy = int.Parse(cmbQuanLy.SelectedValue.ToString());
            nt.AnhDaiDien = img.UploadImage(_duongDanAnhGoc);
            if (nhaTroBLL.update(nt))
            {
                MessageBox.Show("Thêm thành công", "Success");
                resetForm();
            }
        }

        private void loadFormEdit()
        {
            NhaTroDTO dsNha = nhaTroBLL.LayNhaTro().FirstOrDefault(t => t.MaNha == idNha);
            textBox_ten_nha_tro.Text = dsNha.TenNha;
            textBox_dia_chi.Text = dsNha.DiaChi;
            txtGhiChu.Text = dsNha.GhiChu;

            string fullPath = Path.Combine(Application.StartupPath, dsNha.AnhDaiDien.Replace("/", "\\"));

            if (File.Exists(fullPath))
            {
                using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    anhNhaTro.Image = Image.FromStream(fs);
                }
            }
            else
            {
                anhNhaTro.Image = null;
            }

        }

      


        private void FormThemNhaTro_Load(object sender, EventArgs e)
        {
            button_them.Visible = true;
            btnEdit.Visible = false;
            cmbQuanLy.DataSource = nguoiDung.getNguoiDungByAdmin();
            cmbQuanLy.ValueMember = "MaNguoiDung";
            cmbQuanLy.DisplayMember = "HoTen";

            if(thaoTac == "edit")
            {
                loadFormEdit();
                button_them.Visible = false;
                btnEdit.Visible = true;
                lbname.Text = "Cập nhật thông tin";

            }

        }
        private void resetForm()
        {
            textBox_ten_nha_tro.Clear();
            textBox_dia_chi.Clear();
            txtGhiChu.Clear();
            _duongDanAnhGoc = null;
            anhNhaTro.Image = null;
        }
        private void Button_them_Click(object sender, EventArgs e)
        {
            NhaTroDTO nt = new NhaTroDTO();
            nt.TenNha = textBox_ten_nha_tro.Text;
            nt.DiaChi = textBox_dia_chi.Text;
            nt.GhiChu = txtGhiChu.Text;
            nt.NguoiQuanLy = int.Parse(cmbQuanLy.SelectedValue.ToString());
            
            nt.AnhDaiDien = img.UploadImage(_duongDanAnhGoc);
            if (nhaTroBLL.add(nt))
            {
                MessageBox.Show("Thêm thành công","Success");
                resetForm();
            }
        }

        private void BtnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                _duongDanAnhGoc = open.FileName;

                anhNhaTro.Image = Image.FromFile(_duongDanAnhGoc);
            }
        }

    }
}
