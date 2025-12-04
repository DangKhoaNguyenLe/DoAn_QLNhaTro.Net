using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DienNuocDTO
    {
        int _ID;
        int _HostelID;
        int _RoomID;
        int _ContractID;
        string _MonthPeriod;
        DateTime _NgayChot;
        int _SoDienDau;
        int _SoDienCuoi;
        int _SoNuocDau;
        int _SoNuocCuoi;
        decimal _TienDien;
        decimal _TienNuoc;
        public int ID { get => _ID; set => _ID = value; }
        public int HostelID { get => _HostelID; set => _HostelID = value; }
        public int RoomID { get => _RoomID; set => _RoomID = value; }
        public int ContractID { get => _ContractID; set => _ContractID = value; }
        public string MonthPeriod { get => _MonthPeriod; set => _MonthPeriod = value; }
        public DateTime NgayChot { get => _NgayChot; set => _NgayChot = value; }
        public int SoDienDau { get => _SoDienDau; set => _SoDienDau = value; }
        public int SoDienCuoi { get => _SoDienCuoi; set => _SoDienCuoi = value; }
        public int SoNuocDau { get => _SoNuocDau; set => _SoNuocDau = value; }
        public int SoNuocCuoi { get => _SoNuocCuoi; set => _SoNuocCuoi = value; }
        public decimal TienNuoc { get => _TienNuoc; set => _TienNuoc = value; }
        public decimal TienDien { get => _TienDien; set => _TienDien = value; }

        public DienNuocDTO( int hostelID, int roomID, int contractID, string monthPeriod, DateTime ngayChot, int soDienDau, int soDienCuoi, int soNuocDau, int soNuocCuoi, decimal tienDien, decimal tienNuoc, int iD)
        {
            ID = iD;
            HostelID = hostelID;
            RoomID = roomID;
            ContractID = contractID;
            MonthPeriod = monthPeriod;
            NgayChot = ngayChot;
            SoDienDau = soDienDau;
            SoDienCuoi = soDienCuoi;
            SoNuocDau = soNuocDau;
            SoNuocCuoi = soNuocCuoi;
            TienDien = tienDien;
            TienNuoc = tienNuoc;        
        }

        public DienNuocDTO()
        {

        }
    }
}
