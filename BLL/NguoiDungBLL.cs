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

        private NguoiDungDAL dal = new NguoiDungDAL();

        public List<NguoiDungDTO> LayDSNhanVien()
        {
            return dal.LayDSNguoiDung();
        }

        public List<NguoiDungDTO> getNguoiDungByAdmin()
        {
            return dal.LayDSNguoiDung().Where(t => t.VaiTro == "ADMIN").ToList() ;
        }

        public string ThemNhanVien(NguoiDungDTO nd)
        {
            if (string.IsNullOrEmpty(nd.TenDangNhap) || string.IsNullOrEmpty(nd.MatKhau))
                return "Tên đăng nhập và mật khẩu không được để trống!";

            if (dal.ThemNguoiDung(nd)) return "Success";
            else return "Tên đăng nhập đã tồn tại hoặc lỗi hệ thống!";
        }

        public bool SuaNhanVien(NguoiDungDTO nd)
        {
            return dal.SuaNguoiDung(nd);
        }

        public bool XoaNhanVien(int ma)
        {
            return dal.XoaNguoiDung(ma);
        }
    }
}
