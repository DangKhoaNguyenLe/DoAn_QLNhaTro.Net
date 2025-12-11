using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormNhaTro : Form
    {
        NhaTroBLL nhatrobll = new NhaTroBLL();
        

        public FormNhaTro()
        {
            InitializeComponent();
            dataGridView_nha_Tro.AutoGenerateColumns = false;
            this.Load += FormNhaTro_Load;
            this.dataGridView_nha_Tro.CellFormatting += DataGridView_nha_Tro_CellFormatting;
            this.dataGridView_nha_Tro.RowPostPaint += dataGridView_nha_Tro_RowPostPaint;
            this.button_them_nha_tro.Click += Button_them_nha_tro_Click;
            this.btnXoa.Click += BtnXoa_Click;
            this.btnEdit.Click += BtnEdit_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView_nha_Tro.SelectedRows[0].Cells["MaNha"].Value.ToString());
            try
            {
                if (nhatrobll.delete(id))
                {
                    MessageBox.Show("Xóa thành công", "Success");
                }
            }catch
            {
                MessageBox.Show("Không thể xóa dãy nhà này do đã có các phòng trọ và hợp đồng liên quan", "Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            LoadDataGirdView();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView_nha_Tro.SelectedRows[0].Cells["MaNha"].Value.ToString());
            FormThemNhaTro formThemNhaTro = new FormThemNhaTro("edit", id);
            formThemNhaTro.ShowDialog();
            LoadDataGirdView();
        }

        private void LoadDataGirdView()
        {
            List<NhaTroDTO> list = nhatrobll.LayNhaTro();
            dataGridView_nha_Tro.DataSource = list;
            label_tat_Ca.Text = "Tất cả (" + list.Count + ")";
        }
        private void Button_them_nha_tro_Click(object sender, EventArgs e)
        {
            FormThemNhaTro formThemNhaTro = new FormThemNhaTro("Them", 0);

            formThemNhaTro.ShowDialog();
            LoadDataGirdView();

        }

        private void FormNhaTro_Load(object sender, EventArgs e)
        {
            LoadDataGirdView();

        }

        private void DataGridView_nha_Tro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_nha_Tro.Columns[e.ColumnIndex].Name != "AnhDaiDien")
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
                    // Nếu là đường dẫn local → build lại đường dẫn từ thư mục Debug
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

            // Resize ảnh cho vừa DataGridView
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

        //STT
        private void dataGridView_nha_Tro_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView_nha_Tro.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

    }
}