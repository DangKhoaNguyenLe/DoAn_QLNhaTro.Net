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

        public List<PhongDTO> LayDSPhong() => dal.LayTatCaPhong();
        public bool ThemPhongMoi(PhongDTO p) => dal.ThemPhong(p);

        public List<PhongDTO> GetListPhongTrong()
        {
            List<PhongDTO> listAll = dal.LayTatCaPhong();
            return listAll.Where(p => p.TrangThai == "Trong").ToList();
        }

        public bool XoaPhong(int maPhong)
        {
            return dal.XoaPhong(maPhong);
        }


        public bool SuaPhong(PhongDTO p)
        {
            // Có thể thêm kiểm tra logic nếu cần
            return dal.SuaPhong(p);
        }

        public bool TraPhong(int maPhong)
        {
            // Có thể thêm logic tính tiền điện nước cuối cùng ở đây nếu cần
            PhongDAL dal = new PhongDAL();
            return dal.TraPhong(maPhong);
        }


    }
}
