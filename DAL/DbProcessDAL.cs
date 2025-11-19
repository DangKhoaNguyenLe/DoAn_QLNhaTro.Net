using DAL.DataNhaTroTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbProcessDAL
    {
        protected HOSTELTableAdapter hostel;
        protected USERSTableAdapter user;
        protected GIADIENNUOCTableAdapter GiaDienNuoc;
        public DbProcessDAL() {
            hostel = new HOSTELTableAdapter();
            user = new USERSTableAdapter();
            GiaDienNuoc = new GIADIENNUOCTableAdapter();
        }
    }
}
