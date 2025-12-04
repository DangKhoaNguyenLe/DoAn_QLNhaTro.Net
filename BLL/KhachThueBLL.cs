using DTO;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachThueBLL: ConnectionBLL
    {
        public List<KhachThueDTO> LayDSKhachThue()
        {
            return khachThueDAL.GetListTenant();
        }

        public List<KhachThueDTO> getListById(int id)
        {
            return khachThueDAL.GetListTenant().Where(t => t.RoomId == id).ToList();
        }
        
        public List<KhachThueDTO> getDsKhachChuaDK()
        {
            return LayDSKhachThue().Where(t => t.RoomId == 0).ToList();
        }

        public bool add(KhachThueDTO kh)
        {
            try
            {
                khachThueDAL.Add(kh);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }

        public bool update(KhachThueDTO kh)
        {
            try
            {
                khachThueDAL.update(kh);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }

        public bool delete(int id)
        {
            try
            {
                khachThueDAL.delete(id);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }
    }
}
