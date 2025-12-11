using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public int MaHoaDon { get; set; }
        public int MaHopDong { get; set; } // Liên kết với Hợp đồng (thay vì Mã Phòng)
        public int Thang { get; set; }
        public int Nam { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
        public decimal SoTienDaTra { get; set; }
        public decimal ConNo { get; set; }
        public string TrangThai { get; set; } // "ChuaThanhToan", "DaThanhToan"
        public int NguoiLap { get; set; }
        public string GhiChu { get; set; }
    }
}
