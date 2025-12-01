using DAL;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class KhachThueDAL : DbProcessDAL
    {
        public List<KhachThueDTO> GetListTenant()
        {
            List<KhachThueDTO> list = new List<KhachThueDTO>();
            DataTable dt = khachthue.GetData();

            foreach (DataRow dr in dt.Rows)
            {
                DataNhaTro.TENANTRow t = dr as DataNhaTro.TENANTRow;

                KhachThueDTO kt = new KhachThueDTO(
                    t.TenantID,
                    t.UserID,
                    t.FullName,
                    t.Phone,
                    t.Email,
                    t.BirthDate,
                    t.Address,
                    t.CCCD,
                    t.NgayCap,
                    t.NoiCap,
                    t.Status,
                    t.RoomID
                );

                list.Add(kt);
            }

            return list;
        }
    }
}
