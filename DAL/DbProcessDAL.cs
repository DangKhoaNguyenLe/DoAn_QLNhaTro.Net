using DAL.DataNhaTroTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DbProcessDAL
    {
        protected HOSTELTableAdapter hostel;
        protected USERSTableAdapter user;
        protected GIADIENNUOCTableAdapter GiaDienNuoc;
        protected CONTRACTTableAdapter hopdong;
<<<<<<< HEAD

        protected DanhSachHopDong1TableAdapter dshopdong1;
=======
>>>>>>> origin/main
        protected ROOMTableAdapter room;
        protected DanhSachHopDongTableAdapter dshopdong;

        public DbProcessDAL() {
            hostel = new HOSTELTableAdapter();
            user = new USERSTableAdapter();
            GiaDienNuoc = new GIADIENNUOCTableAdapter();
            hopdong = new CONTRACTTableAdapter();
<<<<<<< HEAD
            dshopdong1 = new DanhSachHopDong1TableAdapter();
=======
>>>>>>> origin/main
            room = new ROOMTableAdapter();
            dshopdong = new DanhSachHopDongTableAdapter();
        }
    }
}
