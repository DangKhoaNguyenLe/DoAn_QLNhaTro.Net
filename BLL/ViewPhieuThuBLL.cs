using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ViewPhieuThuBLL: ConnectionBLL
    {
        public List<ViewPhieuThuDTO> LayDanhSachPhieuThu()
        {
            return v_phieuThuDAL.GetListPhieuThu();
        }

    }
}
