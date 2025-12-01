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
    }
}
