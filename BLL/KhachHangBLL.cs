using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL dal = new KhachHangDAL();

        public string ThemKhachHang(KhachHangDTO kh)
        {

            if (dal.KiemTraTonTaiCCCD(kh.CCCD))
            {
                return "Số CCCD này đã tồn tại trong hệ thống!";
            }

            if (dal.ThemKhachHang(kh))
            {
                return "Success"; 
            }
            else
            {
                return "Lỗi khi thêm vào CSDL!";
            }
        }
        public List<KhachHangDTO> getList()
        {
            return dal.GetList();
        }
        public bool update(KhachHangDTO kh)
        {
            try
            {
                dal.update(kh);
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
                dal.delete(id);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }
    }
}
