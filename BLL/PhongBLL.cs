using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class PhongBLL
    {
        private PhongDAL dal = new PhongDAL();

        public List<PhongDTO> LayDSPhong()
        {
            return dal.LayTatCaPhong();
        }

        public bool ThemPhongMoi(PhongDTO p)
        {
            // Có thể kiểm tra nghiệp vụ: Tên phòng có trùng không, v.v.
            return dal.ThemPhong(p);
        }
    }
}
