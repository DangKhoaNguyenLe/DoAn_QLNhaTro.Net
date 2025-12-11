using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL dal = new KhachHangDAL();

        public DataTable LayDanhSachKhachHang()
        {
            return dal.LayDanhSachKhachHang();
        }
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
    }
}
