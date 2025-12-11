using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DataNhaTroTableAdapters;
using DTO;

namespace BLL
{
    public class ConnectionBLL
    {
   
        protected NguoiDungDAL nguoiDungDAL;
        protected GiaDienNuocDAL giaDienNuoc;
        protected HopDongDAL hopDongDAL;
     
        protected ViewPhieuThuDAL v_phieuThuDAL;
        protected BillDAL billDAL;
        public ConnectionBLL()
        {
   
            nguoiDungDAL = new NguoiDungDAL();
            hopDongDAL = new HopDongDAL();
            giaDienNuoc = new GiaDienNuocDAL();
 
            v_phieuThuDAL = new ViewPhieuThuDAL();
            billDAL = new BillDAL();
        }
    }
}
