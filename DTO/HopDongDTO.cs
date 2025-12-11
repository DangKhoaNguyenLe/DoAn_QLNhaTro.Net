using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongDTO
    {
        // ====== Thuộc tính gốc của bảng Hợp đồng ======
        public int MaHopDong { get; set; }
        public int MaPhong { get; set; }
        public int MaKhachHang { get; set; }

        public DateTime NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public decimal TienCoc { get; set; }
        public decimal GiaThueThucTe { get; set; }
        public int ChuKyThanhToan { get; set; }
        public string TrangThai { get; set; }
        public int NguoiLapPhieu { get; set; }
        public string TenPhong { get; set; }
        public string TenNhaTro { get; set; }
        public string HoTenNguoiLapPhieu { get; set; }
    }

}


