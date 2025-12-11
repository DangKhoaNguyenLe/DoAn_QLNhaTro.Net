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
        protected DayNhaDAL dayNha;
        protected NguoiDungDAL nguoiDungDAL;
        protected GiaDienNuocDAL giaDienNuoc;
        protected HopDongDAL hopDongDAL;
        protected BillDAL billDAL;
        public ConnectionBLL()
        {
            dayNha = new DayNhaDAL();
            nguoiDungDAL = new NguoiDungDAL();
            hopDongDAL = new HopDongDAL();
            giaDienNuoc = new GiaDienNuocDAL();
            billDAL = new BillDAL();
        }
    }
}
