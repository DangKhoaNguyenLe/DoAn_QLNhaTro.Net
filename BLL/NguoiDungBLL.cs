using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class NguoiDungBLL : ConnectionBLL
    {
        public NguoiDungDTO KiemTraDangNhap(string user, string pass)
        {

            if (string.IsNullOrEmpty(user))
            {
                return null;
            }

            if (string.IsNullOrEmpty(pass))
            {
                return null;
            }

            return nguoiDungDAL.KiemTraDangNhap(user, pass);
        }

        public string DangKyTaiKhoan(NguoiDungDTO dto, string xacNhanMatKhau)
        {
            if (string.IsNullOrEmpty(dto.TenDangNhap) || string.IsNullOrEmpty(dto.MatKhau))
                return "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!";

            if (string.IsNullOrEmpty(dto.HoTen))
                return "Vui lòng nhập họ tên!";

            if (dto.MatKhau != xacNhanMatKhau)
                return "Mật khẩu xác nhận không khớp!";

            if (nguoiDungDAL.ThemNguoiDung(dto))
                return "ThanhCong";
            else
                return "Lỗi hệ thống, không thể đăng ký!";
        }
    }
}
