using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDAL : DbProcessDAL
    {
        public List<UserDTO> GetListUser()
        {
            List<UserDTO> users = new List<UserDTO>();
            DataTable dt = user.GetData();

            foreach (DataRow dr in dt.Rows)
            {
                DataNhaTro.USERSRow ht = dr as DataNhaTro.USERSRow;
                UserDTO d = new UserDTO(
                    ht.UserID,
                    ht.UserName,
                    ht.PasswordHash,
                    ht.FullName,
                    ht.Role,
                    ht.Phone,
                    ht.Email,
                    ht.CreatedDate,
                    ht.Status,
                    ht.LoginStatus
                    );
                users.Add(d);
            }
            return users;
        }

        // ĐĂNG NHẬP: duyệt từng dòng trong bảng USERS
        public bool DangNhap(string username, string password)
        {
            DataNhaTro.USERSDataTable dt = user.GetData();

            foreach (DataNhaTro.USERSRow row in dt.Rows)
            {
                if (row.UserName == username && row.PasswordHash == password)
                {
                    return true;    
                }
            }

            return false;           
        }

        public bool CheckUser(string username)
        {
            DataNhaTro.USERSDataTable dt = user.GetData();

            foreach (DataNhaTro.USERSRow row in dt.Rows)
            {
                if (row.UserName == username)
                {
                    return true;    
                }
            }

            return false;           
        }

        public bool DangKy(UserDTO userDTO)
        {
            try
            {
                user.DangKy(userDTO.Username, userDTO.PasswordHash, userDTO.FullName, userDTO.Email);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}


