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
<<<<<<< HEAD
     
        protected ViewPhieuThuDAL v_phieuThuDAL;
=======
>>>>>>> d2459924a6a5283f3cba13e2dbb0d2973b9c4ba8
        protected BillDAL billDAL;
        public ConnectionBLL()
        {
   
            nguoiDungDAL = new NguoiDungDAL();
            hopDongDAL = new HopDongDAL();
            giaDienNuoc = new GiaDienNuocDAL();
<<<<<<< HEAD
 
            v_phieuThuDAL = new ViewPhieuThuDAL();
=======
>>>>>>> d2459924a6a5283f3cba13e2dbb0d2973b9c4ba8
            billDAL = new BillDAL();
        }
    }
}
