using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaTroDTO_Form_Moi
    {

        private int maNha;
        private string tenNha;
        private string diaChi;
        private int nguoiQuanLy;
        private string ghiChu;
        string anhDaiDien;


        public int MaNha
        {
            get { return maNha; }
            set { maNha = value; }
        }

        public string TenNha
        {
            get { return tenNha; }
            set { tenNha = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public int NguoiQuanLy
        {
            get { return nguoiQuanLy; }
            set { nguoiQuanLy = value; }
        }

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public string AnhDaiDien { get => anhDaiDien; set => anhDaiDien = value; }

        public NhaTroDTO_Form_Moi() { }

        public NhaTroDTO_Form_Moi( int maNha, string tenNha,string diaChi, int nguoiQuanLy,string ghiChu,string anhdaidien
        )
        {
            this.maNha = maNha;
            this.tenNha = tenNha;
            this.diaChi = diaChi;
            this.nguoiQuanLy = nguoiQuanLy;
            this.ghiChu = ghiChu;
            this.anhDaiDien = anhdaidien;
        }
    }
}

