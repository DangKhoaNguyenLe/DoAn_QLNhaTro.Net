using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL dal = new TaiKhoanDAL();

        public string DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi, string xacNhanMoi)
        {
            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi))
                return "Vui lòng nhập đầy đủ thông tin!";

            if (matKhauMoi != xacNhanMoi)
                return "Mật khẩu xác nhận không khớp!";

            if (matKhauCu == matKhauMoi)
                return "Mật khẩu mới không được trùng mật khẩu cũ!";

            if (!dal.KiemTraMatKhauCu(tenDangNhap, matKhauCu))
                return "Mật khẩu cũ không chính xác!";

            if (dal.CapNhatMatKhau(tenDangNhap, matKhauMoi))
                return "Success"; 
            else
                return "Lỗi hệ thống, không thể đổi mật khẩu!";
        }
    }
}
