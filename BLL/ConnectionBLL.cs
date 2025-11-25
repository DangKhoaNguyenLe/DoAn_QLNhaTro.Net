using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class ConnectionBLL
    {
        protected DayNhaDAL dayNha;
        protected UserDAL user;
        protected GiaDienNuocDAL giaDienNuoc;
        protected HopDongDAL hopDongDAL;
        protected PhongTroDAL phongTroDAL;
        protected KhachThueDAL khachThueDAL;
        protected ViewPhieuThuDAL v_phieuThuDAL;

        public ConnectionBLL() { 
            dayNha = new DayNhaDAL();
            user = new UserDAL();
            giaDienNuoc = new GiaDienNuocDAL();
            phongTroDAL = new PhongTroDAL();
            khachThueDAL = new KhachThueDAL();
            v_phieuThuDAL = new ViewPhieuThuDAL();
        }
    }
}
