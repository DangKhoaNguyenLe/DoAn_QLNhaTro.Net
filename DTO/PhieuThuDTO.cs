using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuDTO
    {
        public int ReceiptID { get; set; }
        public string ReceiptCode { get; set; } 
        public int? BillID { get; set; }        
        public int ContractID { get; set; }
        public int HostelID { get; set; }
        public int RoomID { get; set; }
        public int? TenantID { get; set; }     
        public string ReceiptType { get; set; } 
        public decimal Amount { get; set; }     
        public string Note { get; set; }       
        public DateTime ReceiptDate { get; set; }
        public string CreatedBy { get; set; }   

       
        public string HostelName { get; set; }
        public string RoomName { get; set; }

        public PhieuThuDTO() { }
    }
}
