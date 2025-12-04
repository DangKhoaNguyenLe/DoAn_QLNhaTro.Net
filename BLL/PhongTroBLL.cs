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
    public class PhongTroBLL : ConnectionBLL
    {
        public List<PhongTroDTO> getListByHostel(int id)
        {
            return phongTroDAL.getList().Where(t => t.HostelID == id).ToList();
        }

        public List<PhongTroDTO> getList()
        {
            return phongTroDAL.getList().ToList();
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

        public List<PhongTroDTO> GetPhongChuaDuNguoi(int hostelID)
        {
            // lấy danh sách phòng theo dãy đã có
            var dsPhong = getListByHostel(hostelID);
            return dsPhong.Where(p => p.soNguoiDaThue < 2).ToList();
        }
    }
}