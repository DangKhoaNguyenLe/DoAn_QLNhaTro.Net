using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDongDTO
    {

            // ==============================
            // 1. PRIVATE FIELDS
            // ==============================
            private int _contractID;
            private string _contractCode;
            private int _hostelID;
            private int _roomID;
            private int _tenantID;
            private DateTime _ngayBatDau;
            private DateTime _ngayKetThuc;
            private decimal _tienPhong;
            private decimal _tienCoc;
            private string _kyThanhToan;
            private int _ngayChotTien;
            private string _trangThai;
            private DateTime _createdDate;

            public string RoomName { get; set; }
            public string TenantName { get; set; }


        // ==============================
        // 2. PUBLIC PROPERTIES
        // ==============================
        public int ContractID
            {
                get { return _contractID; }
                set { _contractID = value; }
            }

            public string ContractCode
            {
                get { return _contractCode; }
                set { _contractCode = value; }
            }

            public int HostelID
            {
                get { return _hostelID; }
                set { _hostelID = value; }
            }

            public int RoomID
            {
                get { return _roomID; }
                set { _roomID = value; }
            }

            public int TenantID
            {
                get { return _tenantID; }
                set { _tenantID = value; }
            }

            public DateTime NgayBatDau
            {
                get { return _ngayBatDau; }
                set { _ngayBatDau = value; }
            }

            public DateTime NgayKetThuc
            {
                get { return _ngayKetThuc; }
                set { _ngayKetThuc = value; }
            }

            public decimal TienPhong
            {
                get { return _tienPhong; }
                set { _tienPhong = value; }
            }

            public decimal TienCoc
            {
                get { return _tienCoc; }
                set { _tienCoc = value; }
            }

            public string KyThanhToan
            {
                get { return _kyThanhToan; }
                set { _kyThanhToan = value; }
            }

            public int NgayChotTien
            {
                get { return _ngayChotTien; }
                set { _ngayChotTien = value; }
            }

            public string TrangThai
            {
                get { return _trangThai; }
                set { _trangThai = value; }
            }

            public DateTime CreatedDate
            {
                get { return _createdDate; }
                set { _createdDate = value; }
            }


            // ==============================
            // 3. CONSTRUCTOR
            // ==============================

            public HopDongDTO() { }

            public HopDongDTO(int contractID, string contractCode, int hostelID, int roomID, int tenantID,
                               DateTime ngayBatDau, DateTime ngayKetThuc, decimal tienPhong,
                               decimal tienCoc, string kyThanhToan, int ngayChotTien, string trangThai,
                               DateTime createdDate)
            {
                _contractID = contractID;
                _contractCode = contractCode;
                _hostelID = hostelID;
                _roomID = roomID;
                _tenantID = tenantID;
                _ngayBatDau = ngayBatDau;
                _ngayKetThuc = ngayKetThuc;
                _tienPhong = tienPhong;
                _tienCoc = tienCoc;
                _kyThanhToan = kyThanhToan;
                _ngayChotTien = ngayChotTien;
                _trangThai = trangThai;
                _createdDate = createdDate;
            }

    }
}
