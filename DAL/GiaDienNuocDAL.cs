using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GiaDienNuocDAL : DbProcessDAL
    {
        public List<GiaDienNuocDTO> GetList()
        {
            List<GiaDienNuocDTO> giaDienNuocs = new List<GiaDienNuocDTO>();
            DataTable dt = GiaDienNuoc.GetData();

            foreach (DataRow dr in dt.Rows)
            {
                DataNhaTro.GIADIENNUOCRow ht = dr as DataNhaTro.GIADIENNUOCRow;
                GiaDienNuocDTO d = new GiaDienNuocDTO(
                    ht.HostelID,
                    ht.GiaDien,
                    ht.GiaNuoc,
                    ht.NgayApDung,
                    ht.TrangThai);
                giaDienNuocs.Add(d);
            }
            return giaDienNuocs;
        }

        public bool Add(GiaDienNuocDTO gdn)
        {
            try
            {
                GiaDienNuoc.Insert(
                    gdn.HostelID,
                    gdn.GiaDien,
                    gdn.GiaNuoc,
                    gdn.NgayApDung,
                    gdn.TrangThai)
                    ;
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi thêm nhà trọ vào CSDL: " + ex.Message, ex);
            }
        }

        public bool update(GiaDienNuocDTO gdn)
        {
            try
            {
                /*GiaDienNuoc.UpdateGiaDienNuoc(
                     gdn.GiaDien
                    , gdn.GiaNuoc
                    , gdn.TrangThai
                    , gdn.HostelID);*/
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL: " + ex.Message, ex);
            }
        }
    }
}
