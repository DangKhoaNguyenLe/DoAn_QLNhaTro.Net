
using DTO;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
        public bool Add(KhachThueDTO kh)
        {
            try
            {
                khachthue.Insert(
                    kh.UserID,
                    kh.FullName,
                    kh.Phone,
                    kh.Email,
                    kh.BirthDate,
                    kh.Address,
                    kh.CCCD,
                    kh.NgayCap,
                    kh.NoiCap,
                    "",
                    kh.Status,
                    kh.RoomId);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL: " + ex.Message, ex);
            }
        }

        public bool delete(int id)
        {
            try
            {
                khachthue.DeleteKH(id);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL: " + ex.Message, ex);
            }
        }

        public bool update(KhachThueDTO kh)
        {
            try
            {
                khachthue.UpdateKH(
                    kh.FullName,
                    kh.Phone,
                    kh.Email,
                    kh.BirthDate.ToString(),
                    kh.Address,
                    kh.CCCD,
                    kh.NgayCap.ToString(),
                    kh.NoiCap,
                    kh.Status,
                    kh.RoomId,
                    kh.TenantID);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL: " + ex.Message, ex);
            }
        }
    }

}
