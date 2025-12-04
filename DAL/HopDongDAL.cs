using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;

namespace DAL
{
    public class HopDongDAL : DbProcessDAL
    {

        public DataTable LayDSHD()
        {
            return hopdong.GetData();
        }
        public List<DanhSachHopDongDTO> GetDanhSachHopDong()
        {
            List<DanhSachHopDongDTO> list = new List<DanhSachHopDongDTO>();

            DataTable dt = dshopdong1.GetData();

            foreach (DataRow dr in dt.Rows)
            {
                var row = dr as DataNhaTro.DanhSachHopDong1Row;
                if (row == null) continue;

                DanhSachHopDongDTO c = new DanhSachHopDongDTO(
                    row.ContractID,
                    row.ContractCode,
                    row.HostelName,
                    row.RoomName,
                    row.FullName,
                    row.NgayBatDau,
                    row.NgayKetThuc,
                    row.TienPhong,
                    row.TienCoc,
                    row.TrangThai,
                    row.CreatedDate
                );

                list.Add(c);
            }

            return list;
        }

        public List<HopDongDTO> GetDanhSachHD()
        {
            List<HopDongDTO> list = new List<HopDongDTO>();

            DataTable dt = hopdong.GetData();

            foreach (DataRow dr in dt.Rows)
            {
                var row = dr as DataNhaTro.CONTRACTRow;

                HopDongDTO c = new HopDongDTO(
                    row.ContractID,
                    row.ContractCode,
                    int.Parse(row.HostelID.ToString()),
                    int.Parse(row.RoomID.ToString()),
                    int.Parse(row.TenantID.ToString()),
                    row.NgayBatDau,
                    row.NgayKetThuc,
                    row.TienPhong,
                    row.TienCoc,
                    row.KyThanhToan,
                    int.Parse(row.NgayChotTien.ToString()),
                    row.TrangThai,
                    row.CreatedDate

                );

                list.Add(c);
            }

            return list;
        }

        // Thêm hợp đồng
        public bool Insert(HopDongDTO c)
        {
            try
            {
                hopdong.Insert(
                    c.ContractCode,
                    c.HostelID,
                    c.RoomID,
                    c.TenantID,
                    c.NgayBatDau,
                    c.NgayKetThuc,
                    c.TienPhong,
                    c.TienCoc,
                    c.KyThanhToan,
                    c.NgayChotTien,
                    c.TrangThai,
                    c.CreatedDate
                );
                return true;
            }
            catch
            {
                return false;
            }
        }
        // Xoá hợp đồng
        public bool XoaHopDong(int id)
        {
            try
            {
                // Lấy RoomID từ Contract trước khi xóa
                var r = hopdong.GetData().FirstOrDefault(c => c.ContractID == id);
                int roomID = r.RoomID;

                // Xóa hợp đồng
                hopdong.DeleteHopDong(id);

                // Trừ số người thuê
                room.UpdateSoNguoiDaThue(-1, roomID);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
