using BLL;
using DTO;
using GUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

        private void LoadHienThiPhong()
        {
            flpDanhSachPhong.Controls.Clear();

            List<PhongDTO> listPhong = bll.LayDSPhong();

            foreach (PhongDTO phong in listPhong)
            {
                RoomItem item = new RoomItem();

                item.SetData(phong.TenPhong, phong.TrangThai, null);

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

