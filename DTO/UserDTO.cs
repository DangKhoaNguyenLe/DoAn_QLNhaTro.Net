using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; } 
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; } 
        public bool LoginStatus { get; set; }

        public UserDTO() { }
        public UserDTO(int userID, string userName, string passwordHash, string fullName, string role, string phone, string email, DateTime createdDate, string status, bool loginStatus)
        {
            UserID = userID;
            UserName = userName;
            PasswordHash = passwordHash;
            FullName = fullName;
            Role = role;
            Phone = phone;
            Email = email;
            CreatedDate = createdDate;
            Status = status;
            LoginStatus = loginStatus;
        }
    }
}
