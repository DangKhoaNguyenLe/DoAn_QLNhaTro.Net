using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaDienNuocDTO
    {
        public int id {  get; set; } 
        public int HostelID { get; set; }

        public decimal GiaDien { get; set; }
        public decimal GiaNuoc { get; set; }
        public DateTime NgayApDung { get; set; } 
        public bool TrangThai { get; set; } 

        public GiaDienNuocDTO(int hostelID, decimal giaDien, decimal giaNuoc, DateTime ngayApDung, bool trangThai)
        {
            HostelID = hostelID;
            GiaDien = giaDien;
            GiaNuoc = giaNuoc;
            NgayApDung = ngayApDung;
            TrangThai = trangThai;
        }

    }
}
