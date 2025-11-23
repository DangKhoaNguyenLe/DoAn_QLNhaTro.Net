using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;

namespace DAL
{
    public class HopDongDAL : DbProcessDAL
    {
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

        //// Sửa hợp đồng
        //public bool Update(HopDongDTO c)
        //{
        //    try
        //    {
        //        hopdong.Update(
        //            c.ContractCode,
        //            c.HostelID,
        //            c.RoomID,
        //            c.TenantID,
        //            c.NgayBatDau,
        //            c.NgayKetThuc,
        //            c.TienPhong,
        //            c.TienCoc,
        //            c.KyThanhToan,
        //            c.NgayChotTien,
        //            c.TrangThai,
        //            c.ContractID       // WHERE ContractID
        //        );
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //// Xoá hợp đồng
        //public bool Delete(int id)
        //{
        //    try
        //    {
        //        contract.Delete(id);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //// Lấy hợp đồng theo ID
        //public ContractDTO GetByID(int id)
        //{
        //    DataTable dt = contract.GetDataByID(id);

        //    if (dt.Rows.Count == 0) return null;

        //    DataNhaTro.CONTRACTRow row = dt.Rows[0] as DataNhaTro.CONTRACTRow;

        //    ContractDTO c = new ContractDTO
        //    {
        //        ContractID = row.ContractID,
        //        ContractCode = row.ContractCode,
        //        HostelID = row.HostelID,
        //        RoomID = row.RoomID,
        //        TenantID = row.TenantID,
        //        NgayBatDau = row.NgayBatDau,
        //        NgayKetThuc = row.NgayKetThuc,
        //        TienPhong = row.TienPhong,
        //        TienCoc = row.TienCoc,
        //        KyThanhToan = row.KyThanhToan,
        //        NgayChotTien = row.NgayChotTien,
        //        TrangThai = row.TrangThai,
        //        CreatedDate = row.CreatedDate
        //    };

        //    return c;
        //}
    }
}
