using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaTroBLL
    {
        DAL.NhaTroDAL nhaTroDAL = new DAL.NhaTroDAL();
        public List<NhaTroDTO> LayNhaTro()
        {
            return nhaTroDAL.LayNhaTro();
        }

        public bool add(NhaTroDTO nt)
        {
            try
            {
                nhaTroDAL.Add(nt);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }

        public bool update(NhaTroDTO nt)
        {
            try
            {
                nhaTroDAL.update(nt);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }

        public bool delete(int id)
        {
            try
            {
                nhaTroDAL.delete(id);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }
    }
}
