using BLL;
using DTO;
using DTO.DTO;
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
    public partial class FormDSPhieuThu : Form
    {
        ViewPhieuThuBLL viewPhieuThuBLL = new ViewPhieuThuBLL();
        DayNhaBLL dayNhaBLL;
        PhongTroBLL phongTroBLL;
        KhachThueBLL khachThueBLL;
        public FormDSPhieuThu()
        {
            InitializeComponent();
            dayNhaBLL = new DayNhaBLL();
            phongTroBLL = new PhongTroBLL();
            khachThueBLL = new KhachThueBLL();
            dataGridView_dsphieuthu.AutoGenerateColumns = false;
            this.Shown += (s, e) =>
            {
                LoadDSKhachThue();
                AddSTT();
            };
        }

        public void LoadDSKhachThue()
        {
            List<ViewPhieuThuDTO> phieuthus = viewPhieuThuBLL.LayDanhSachPhieuThu();
            List<DayNhaDTO> daynhas = dayNhaBLL.getList();
            List<PhongTroDTO> phongtros = phongTroBLL.getList();
            List<KhachThueDTO> khachthues = khachThueBLL.LayDSKhachThue();

            var query =
                from p in phieuthus
                join d in daynhas on p.HostelID equals d.HostelID
                join t in phongtros on p.RoomID equals t.RoomID
                join k in khachthues on p.TenantID equals k.TenantID
                select new
                {
                    p.ReceiptCode,      
                    TenantName = k.FullName,
                    RoomName = t.RoomName,
                    HostelName = d.HostelName,
                    p.ReceiptType,
                    p.Amount,
                    p.ReceiptDate,
                    p.Note,
                    p.CreatedBy
                };

            dataGridView_dsphieuthu.DataSource = query.ToList();
        }

        public void AddSTT()
        {
            for (int i = 0; i < dataGridView_dsphieuthu.Rows.Count; i++)
            {
                dataGridView_dsphieuthu.Rows[i].Cells["STT"].Value = i + 1;
            }
        }
    }
}
