using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BillBLL : ConnectionBLL
    {
        public List<BillDTO> getBillByIdRoom(int id)
        {
            return billDAL.getList().Where(t => t.RoomID == id).ToList();  
        }
    }
}
