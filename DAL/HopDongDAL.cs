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

        public bool XoaHopDong(int contractId)
        {
            try
            {
                hopdong.DeleteQuery(contractId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CapNhatHopDong(HopDongDTO hd)
        {
            int result = hopdong.UpdateQuery(
                hd.ContractCode,
                hd.HostelID,
                hd.RoomID,
                hd.TenantID,
                hd.NgayBatDau,
                hd.NgayKetThuc,
                hd.TienPhong,
                hd.TienCoc,
                hd.KyThanhToan,
                hd.NgayChotTien,
                hd.TrangThai,
                hd.CreatedDate,
                hd.ContractID
            );

            return result > 0;
        }

        public HopDongDTO LayHopDongTheoID(int id)
        {
            var dt = hopdong.GetDataByID(id);

            if (dt.Rows.Count == 0) return null;

            var r = dt[0];

            return new HopDongDTO(
                r.ContractID,
                r.ContractCode,
                r.HostelID,
                r.RoomID,
                r.TenantID,
                r.NgayBatDau,
                r.NgayKetThuc,
                r.TienPhong,
                r.TienCoc,
                r.KyThanhToan,
                r.NgayChotTien,
                r.TrangThai,
                r.CreatedDate
            );
        }


        public int GetMaxContractID()
        {
            var dt = hopdong.GetData();
            if (dt.Rows.Count == 0) return 0;
            return dt.AsEnumerable().Max(r => r.Field<int>("ContractID"));
        }

    }
}
