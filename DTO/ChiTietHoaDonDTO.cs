using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        public int ID { get; set; }
        public int MaHoaDon { get; set; }
        public string TenMucThanhToan { get; set; } 
        public int SoLuongSuDung { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
