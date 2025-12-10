using BLL;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormPhongTro : Form
    {
        PhongBLL bll = new PhongBLL();

        public FormPhongTro()
        {
            InitializeComponent();
            this.Load += FormPhongTro_Load;
        }

        private void FormPhongTro_Load(object sender, EventArgs e)
        {
            LoadHienThiPhong();
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

            foreach (PhongDTO phong in listPhong)
            {
                RoomItem item = new RoomItem();

                System.Drawing.Image imgPhong = LoadAnhTuDuongDan(phong.AnhDaiDien);

                item.SetData(phong.TenPhong, phong.TrangThai, imgPhong);

                item.MaPhong = phong.MaPhong.ToString();
                item.Tag = phong;
                item.Click += RoomItem_Click;
                foreach (Control child in item.Controls)
                {
                    child.Click += (s, e) => RoomItem_Click(item, e);
                }

                flpDanhSachPhong.Controls.Add(item);
            }
        }

        private void RoomItem_Click(object sender, EventArgs e)
        {
            RoomItem clickedItem = sender as RoomItem;

            if (clickedItem != null)
            {
                PhongDTO phongInfo = clickedItem.Tag as PhongDTO;

                if (phongInfo != null)
                {
                    MessageBox.Show($"Bạn đã chọn: {phongInfo.TenPhong} - Trạng thái: {phongInfo.TrangThai}");
                }
            }

        }
    }
    }

