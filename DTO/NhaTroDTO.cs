using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class NhaTroDTO
    {
        public int RoomID { get; set; }
        public int HostelID { get; set; }
        public string RoomName { get; set; }
        public string Floor { get; set; }
        public decimal Area { get; set; }
        public int Capacity { get; set; }
        public int SoNguoiDaThue { get; set; }
        public decimal Price { get; set; }
        public decimal Deposit { get; set; }
        public string Status { get; set; } 
    }
}
