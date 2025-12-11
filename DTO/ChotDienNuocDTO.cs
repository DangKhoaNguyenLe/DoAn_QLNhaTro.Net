using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChotDienNuocDTO
    {
        public int MaChot { get; set; }
        public int MaHopDong { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int ChiSoDienCu { get; set; }
        public int ChiSoDienMoi { get; set; }
        public int ChiSoNuocCu { get; set; }
        public int ChiSoNuocMoi { get; set; }
        public DateTime NgayChot { get; set; }
    }
}
