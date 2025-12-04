using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class PhieuThuDAL:DbProcessDAL
    {
        public DataTable GetListByOwner(int ownerID)
        {
            return phieuThu.GetPhieuThuByOwner(ownerID);
        }

        public DataTable loadHopDong()
        {
            return hopdong.GetData();

        }

        public DataTable LoadNha()
        {
            return hostel.GetData();
        }

        public DataTable loadPhong()
        {
            return room.GetData();
        }

    }
}
