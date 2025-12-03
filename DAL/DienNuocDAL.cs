using DAL.DataNhaTroTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DienNuocDAL
    {
        DIENNUOCTableAdapter adapter;
        HOSTELTableAdapter hostel;
        ROOMTableAdapter roomTableAdapter;
        CONTRACTTableAdapter conductTableAdapter;
        public DienNuocDAL()
        {
            adapter = new DIENNUOCTableAdapter();
            hostel = new HOSTELTableAdapter();
            roomTableAdapter = new ROOMTableAdapter();
            conductTableAdapter = new CONTRACTTableAdapter();
        }

        public DataTable loadDienNuoc()
        {
            return adapter.GetData();

        }

        public DataTable loadHopDong()
        {
            return conductTableAdapter.GetData();

        }

        public DataTable LoadNha()
        {
            return hostel.GetData();
        }

        public DataTable loadPhong()
        {
            return roomTableAdapter.GetData();
        }
    }
}
