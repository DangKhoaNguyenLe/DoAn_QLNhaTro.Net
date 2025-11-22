using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhSachHopDongDTO
    {
        //1.
        private int _contractID;
        private string _contractCode;
        private string _hostelName;
        private string _roomName;
        private string _fullName;
        private DateTime _ngayBatDau;
        private DateTime _ngayKetThuc;
        private decimal _tienPhong;
        private decimal _tienCoc;
        private string _trangThai;
        private DateTime _createdDate;

        //2.
        public int ContractID => _contractID;
        public string ContractCode => _contractCode;
        public string HostelName => _hostelName;
        public string RoomName => _roomName;
        public string FullName => _fullName;
        public DateTime NgayBatDau => _ngayBatDau;
        public DateTime NgayKetThuc => _ngayKetThuc;
        public decimal TienPhong => _tienPhong;
        public decimal TienCoc => _tienCoc;
        public string TrangThai => _trangThai;
        public DateTime CreatedDate => _createdDate;

        // 3. CONSTRUCTOR

        public DanhSachHopDongDTO()
        { }


        public DanhSachHopDongDTO(int contractID, string contractCode, string hostelName, string roomName, string fullName,
                                  DateTime ngayBatDau, DateTime ngayKetThuc,decimal tienPhong, decimal tienCoc,
                                  string trangThai, DateTime createdDate)
        {
            _contractID = contractID;
            _contractCode = contractCode;
            _hostelName = hostelName;
            _roomName = roomName;
            _fullName = fullName;
            _ngayBatDau = ngayBatDau;
            _ngayKetThuc = ngayKetThuc;
            _tienPhong = tienPhong;
            _tienCoc = tienCoc;
            _trangThai = trangThai;
            _createdDate = createdDate;
        }
    }
}
