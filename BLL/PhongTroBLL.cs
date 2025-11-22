using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class PhongTroBLL : ConnectionBLL
    {
        public List<PhongTroDTO> getListByHostel(int id)
        {
            return phongTroDAL.getList().Where(t => t.HostelID == id).ToList();
        }

        public PhongTroDTO FindByID(int id)
        {
            return phongTroDAL.getList().FirstOrDefault(t => t.RoomID == id);
        }

        public bool add(PhongTroDTO p)
        {
            try
            {
                phongTroDAL.Add(p);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }

        public bool update(PhongTroDTO p)
        {
            try
            {
                phongTroDAL.update(p);
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
                phongTroDAL.delete(id);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }
    }
}