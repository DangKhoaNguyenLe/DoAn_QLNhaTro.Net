using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongTroDTO
    {
        public int RoomID { get; set; }
        public int HostelID { get; set; }
        public string RoomName { get; set; }
        public string Floor { get; set; }
        public decimal Area { get; set; }
        public int Capacity { get; set; }
        public int soNguoiDaThue { get; set; }
        public decimal Price { get; set; }
        public decimal Deposit { get; set; }
        public string Status { get; set; }

        public PhongTroDTO() { }
        public PhongTroDTO(int roomID, int hostelID, string roomName, string floor, decimal area, int capacity, int soNguoiDaThue, decimal price, decimal deposit, string status)
        {
            RoomID = roomID;
            HostelID = hostelID;
            RoomName = roomName;
            Floor = floor;
            Area = area;
            Capacity = capacity;
            this.soNguoiDaThue = soNguoiDaThue;
            Price = price;
            Deposit = deposit;
            Status = status;
        }
    }
}
