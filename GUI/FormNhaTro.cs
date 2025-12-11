using BLL;
using DTO;
using System;
using System.Collections.Generic;
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
        }

        private void FormNhaTro_Load(object sender, EventArgs e)
        {
            List<NhaTroDTO_Form_Moi> list = nhatrobll.LayNhaTro();
            dataGridView_nha_Tro.DataSource = list;
            label_tat_Ca.Text = "Tất cả (" + list.Count + ")";

        }

        private void DataGridView_nha_Tro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView_nha_Tro.Columns[e.ColumnIndex].Name != "AnhDaiDien")
                return;

            if (e.Value is string rawPath && !string.IsNullOrEmpty(rawPath))
            {
                string fullPath = null;

                try
                {
                    // 1. Lấy vị trí thư mục hiện tại của file .exe (Ví dụ: C:\...\GUI\bin\Debug)
                    string currentAssemblyPath = Application.StartupPath;

                    // 2. Đi ngược lên 2 cấp để đến thư mục Project GUI
                    // currentAssemblyPath -> bin -> GUI Project folder
                    // Lưu ý: Nếu bạn đang chạy ứng dụng đã Build (không phải Debug), cần kiểm tra kỹ số cấp Parent.

                    // Thư mục GUI Project: D:\BanCuaThinh\GUI
                    DirectoryInfo projectDir = Directory.GetParent(currentAssemblyPath)?.Parent;

                    if (projectDir == null)
                    {
                        e.Value = null;
                        return;
                    }

                    // 3. Nối tới thư mục Resources: D:\BanCuaThinh\GUI\Resources
                    string resourcesPath = Path.Combine(projectDir.FullName, "Resources");

                    // 4. Kiểm tra và xây dựng đường dẫn ảnh cuối cùng
                    // fullPath = D:\BanCuaThinh\GUI\Resources\Images\nha1.jpg
                    fullPath = Path.Combine(resourcesPath, rawPath.Replace("/", "\\"));
                }
                catch
                {
                    // Lỗi xảy ra trong quá trình tìm đường dẫn
                    e.Value = null;
                    return;
                }

                // --- LOAD ẢNH ---
                if (File.Exists(fullPath))
                {
                    try
                    {
                        using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            Image img = Image.FromStream(fs);
                            e.Value = new Bitmap(img, new Size(80, 80));
                            e.FormattingApplied = true;
                        }
                    }
                    catch
                    {
                        e.Value = null;
                    }
                }
                else
                {
                    e.Value = null;
                }
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