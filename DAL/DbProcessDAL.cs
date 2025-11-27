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
        protected DanhSachHopDong1TableAdapter dshopdong1;
        protected ROOMTableAdapter room;
        protected TENANTTableAdapter khachthue;
        protected RECEIPT_VOUCHERTableAdapter v_PhieuThu;
        protected BILLTableAdapter Bill;

        public DbProcessDAL() {
            hostel = new HOSTELTableAdapter();
            user = new USERSTableAdapter();
            GiaDienNuoc = new GIADIENNUOCTableAdapter();
            hopdong = new CONTRACTTableAdapter();
            dshopdong1 = new DanhSachHopDong1TableAdapter();
            room = new ROOMTableAdapter();
            khachthue = new TENANTTableAdapter();
            v_PhieuThu = new RECEIPT_VOUCHERTableAdapter();
            Bill = new BILLTableAdapter();  
        }
    }
}
