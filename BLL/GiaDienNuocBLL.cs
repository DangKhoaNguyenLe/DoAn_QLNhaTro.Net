using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GiaDienNuocBLL : ConnectionBLL
    {
        public bool add(GiaDienNuocDTO gdn)
        {
            try
            {
                giaDienNuoc.Add(gdn);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }

        public bool update(GiaDienNuocDTO gdn)
        {
            try
            {
                giaDienNuoc.update(gdn);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }

        public GiaDienNuocDTO FindByID(int id)
        {
            List<GiaDienNuocDTO> giaDienNuocs = giaDienNuoc.GetList();
            return giaDienNuocs.FirstOrDefault(t => t.HostelID == id);
        }
    }
}
