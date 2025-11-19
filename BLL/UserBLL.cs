using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL : ConnectionBLL
    {
        public UserDTO getUserAdminLogin()
        {
            List<UserDTO> users = user.GetListUser();
            return users.FirstOrDefault(t => t.Role == "Chủ trọ" && t.LoginStatus);
        }
    }
}
