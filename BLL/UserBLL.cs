using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL
    {
        UserDAL userDAL = new UserDAL();

        //public string LayMatKhau(string username, string email)
        //{
        //    return userDAL.GetPasswordByUserAndEmail(username, email);
        //}


        //public UserDTO getUserAdminLogin()
        //{
        //    List<UserDTO> users = userDAL.GetListUser();
        //    return users.FirstOrDefault(t => t.Role == "Chủ trọ" && t.LoginStatus);
        //}

        //public List<UserDTO> GetList()
        //{
        //    return userDAL.GetListUser();
        //}

        //public bool DangNhap(string username, string password)
        //{
        //    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        //        return false;
        //    return userDAL.DangNhap(username, password);
        //}

        //private bool IsValidEmail(string email)
        //{
        //    if (string.IsNullOrWhiteSpace(email))
        //        return false;
        //    string pattern = @"^[A-Za-z0-9._%+-]+@gmail\.com$";
        //    return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        //}

        //public bool KiemTraSoDienThoai(string phone)
        //{
        //    if (string.IsNullOrWhiteSpace(phone))
        //        return false;

        //    // Regex chuẩn 10 số, bắt đầu bằng 0
        //    return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^0\d{9}$");
        //}

        //public int DangKy(UserDTO user)
        //{
        //    if (user == null ||
        //        string.IsNullOrWhiteSpace(user.Username) ||
        //        string.IsNullOrWhiteSpace(user.PasswordHash) ||
        //        string.IsNullOrWhiteSpace(user.FullName) ||
        //        string.IsNullOrWhiteSpace(user.Email) ||
        //        string.IsNullOrWhiteSpace(user.Phone))
        //    {
        //        return 1; // Thiếu dữ liệu
        //    }

        //    if (userDAL.CheckUser(user.Username))
        //    {
        //        return 2; // Tài khoản đã tồn tại
        //    }

        //    if (!IsValidEmail(user.Email))
        //    {
        //        return 3; // Email sai cấu trúc
        //    }

        //    // 🔥 THÊM KIỂM TRA SỐ ĐIỆN THOẠI
        //    if (!KiemTraSoDienThoai(user.Phone))
        //    {
        //        return 4; // Số điện thoại không hợp lệ
        //    }

        //    bool success = userDAL.DangKy(user);
        //    return success ? 5 : 0; // 4 thành công, 0 lỗi DB
        //}


        //public void getLogout()
        //{
        //    UserDTO user = getUserAdminLogin();
        //    userDAL.setLogout(user.UserID);
        //}
    }
}
