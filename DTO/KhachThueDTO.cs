using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    using System;

    namespace DTO
    {
        public class KhachThueDTO
        {
            // ===== PRIVATE FIELDS =====
            private int tenantID;
            private int roomID;
            private int userID;
            private string fullName;
            private string phone;
            private string email;
            private DateTime birthDate;
            private string address;
            private string cccd;
            private DateTime ngayCap;
            private string noiCap;
            private string status;

            // ===== PUBLIC PROPERTIES =====
            public int TenantID
            {
                get { return tenantID; }
                set { tenantID = value; }
            }
            public int RoomId
            {
                get { return roomID; }
                set { roomID = value; }
            }
            public int UserID
            {
                get { return userID; }
                set { userID = value; }
            }

            public string FullName
            {
                get { return fullName; }
                set { fullName = value; }
            }

            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public DateTime BirthDate
            {
                get { return birthDate; }
                set { birthDate = value; }
            }

            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            public string CCCD
            {
                get { return cccd; }
                set { cccd = value; }
            }

            public DateTime NgayCap
            {
                get { return ngayCap; }
                set { ngayCap = value; }
            }

            public string NoiCap
            {
                get { return noiCap; }
                set { noiCap = value; }
            }

            public string Status
            {
                get { return status; }
                set { status = value; }
            }

            // ===== CONSTRUCTORS =====

            public KhachThueDTO() { }

            public KhachThueDTO( int tenantID,int userID,string fullName, string phone,string email, DateTime birthDate,
                string address, string cccd,DateTime ngayCap,string noiCap, string status, int RoomId
            )
            {
                this.TenantID = tenantID;
                this.UserID = userID;
                this.FullName = fullName;
                this.Phone = phone;
                this.Email = email;
                this.BirthDate = birthDate;
                this.Address = address;
                this.CCCD = cccd;
                this.NgayCap = ngayCap;
                this.NoiCap = noiCap;
                this.Status = status;
                this.roomID = RoomId;
            }
        }
    }

}
