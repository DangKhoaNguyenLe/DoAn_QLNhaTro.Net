using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillDTO
    {
        public int BillID { get; set; }
        public string BillCode { get; set; }
        public int ContractID { get; set; }
        public int HostelID { get; set; }
        public int RoomID { get; set; }
        public int TenantID { get; set; }
        public string BillMonth { get; set; }

        public decimal RoomPrice { get; set; } = 0;
        public decimal ServicePrice { get; set; } = 0;
        public decimal Discount { get; set; } = 0;
        public decimal PaidAmount { get; set; } = 0;

        public decimal TotalAmount { get; set; } = 0;
        public decimal RemainingAmount { get; set; } = 0;

        public string Status { get; set; }
        public DateTime? PaymentDate { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public BillDTO(int billID, string billCode, int contractID, int hostelID, int roomID, int tenantID, string billMonth, decimal roomPrice, decimal servicePrice, decimal discount, decimal paidAmount, decimal totalAmount, decimal remainingAmount, string status, DateTime? paymentDate, string createdBy, DateTime createdDate)
        {
            BillID = billID;
            BillCode = billCode;
            ContractID = contractID;
            HostelID = hostelID;
            RoomID = roomID;
            TenantID = tenantID;
            BillMonth = billMonth;
            RoomPrice = roomPrice;
            ServicePrice = servicePrice;
            Discount = discount;
            PaidAmount = paidAmount;
            TotalAmount = totalAmount;
            RemainingAmount = remainingAmount;
            Status = status;
            PaymentDate = paymentDate;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
        }
    }

}
