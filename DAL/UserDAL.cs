using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
