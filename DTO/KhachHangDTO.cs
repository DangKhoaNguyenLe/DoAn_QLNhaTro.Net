using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public int MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; } // "Nam" hoặc "Nữ"
        public DateTime? NgaySinh { get; set; }
        public string AnhMatTruoc { get; set; } // Đường dẫn ảnh
        public string AnhMatSau { get; set; }   // Đường dẫn ảnh
    }
}
