using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DayNhaDTO
    {
        public int HostelID { get; set; }
        public string HostelName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int OwnerID { get; set; }
        public virtual UserDTO User { get; set; }

        public DayNhaDTO(string hostelName, string address, string description, int ownerID)
        {
            HostelName = hostelName;
            Address = address;
            Description = description;
            OwnerID = ownerID;
        }
        
        public DayNhaDTO(int hostelID, string hostelName, string address, string description, int ownerID)
        {
            HostelID = hostelID;
            HostelName = hostelName;
            Address = address;
            Description = description;
            OwnerID = ownerID;
        }

  
    }
}
