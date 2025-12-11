using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DanhMucBLL
    {
        private DanhMucDAL dal = new DanhMucDAL();

        public DataTable LayDSNha() => dal.LayDSNha();
        public DataTable LayDSLoaiPhong() => dal.LayDSLoaiPhong();
    }
}
