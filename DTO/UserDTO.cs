using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        int _UserID;
        string _Username;
        string _PasswordHash;
        string _FullName;
        string _Role;
        string _Phone;
        string _Email;
        DateTime _CreatedDate;
        string _Status;
        bool _LoginStatus;
        public int UserID { get => _UserID; set => _UserID = value; }
        public string Username { get => _Username; set => _Username = value; }
        public string PasswordHash { get => _PasswordHash; set => _PasswordHash = value; }
        public string FullName { get => _FullName; set => _FullName = value; }
        public string Role { get => _Role; set => _Role = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public string Email { get => _Email; set => _Email = value; }
        public DateTime CreatedDate { get => _CreatedDate; set => _CreatedDate = value; }
        public string Status { get => _Status; set => _Status = value; }
        public bool LoginStatus { get => _LoginStatus; set => _LoginStatus = value; }

        //PTKT không tham số
        public UserDTO() { }

        //PTKT có tham số
        public UserDTO(string username, string passwordHash, string fullName, string email)
        {
            Username = username;
            PasswordHash = passwordHash;
            FullName = fullName;
            Email = email;
        }

        //PTKT có tham số, không có UserID
        public UserDTO(string username, string passwordHash, string fullName,
               string role, string phone, string email,
               DateTime createdDate, string status, bool loginStatus)
        {
            Username = username;
            PasswordHash = passwordHash;
            FullName = fullName;
            Role = role;
            Phone = phone;
            Email = email;
            CreatedDate = createdDate;
            Status = status;
            LoginStatus = loginStatus;
        }

        //PTKT có tham số, có UserID
        public UserDTO(int userID, string username, string passwordHash, string fullName, string role, string phone, string email, DateTime createdDate, string status, bool loginStatus)
        {
            UserID = userID;
            Username = username;
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
