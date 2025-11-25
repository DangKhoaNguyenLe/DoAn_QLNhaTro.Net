using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ViewPhieuThuDTO
    {
        // ===== PRIVATE FIELDS =====
        private int receiptID;
        private string receiptCode;
        private int billID;
        private int contractID;
        private int hostelID;
        private int roomID;
        private int tenantID;
        private string receiptType;
        private decimal amount;
        private string note;
        private DateTime receiptDate;
        private string createdBy;

        // ===== PUBLIC PROPERTIES =====
        public int ReceiptID
        {
            get { return receiptID; }
            set { receiptID = value; }
        }

        public string ReceiptCode
        {
            get { return receiptCode; }
            set { receiptCode = value; }
        }

       public int BillID { get; set; }
       public int RoomID { get; set; }
        public int TenantID { get; set; }
        public int ContractID { get; set; }
        public int HostelID { get; set; }

        public string ReceiptType
        {
            get { return receiptType; }
            set { receiptType = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public DateTime ReceiptDate
        {
            get { return receiptDate; }
            set { receiptDate = value; }
        }

        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        // ===== CONSTRUCTOR =====
        public ViewPhieuThuDTO() { }

        public ViewPhieuThuDTO(int receiptID, string receiptCode, int billID, int contractID, int hostelID, int roomID, int tenantID, string receiptType, decimal amount, string note, DateTime receiptDate, string createdBy)
        {
            ReceiptID = receiptID;
            ReceiptCode = receiptCode;
            BillID = billID;
            ContractID = contractID;
            HostelID = hostelID;
            RoomID = roomID;
            TenantID = tenantID;
            ReceiptType = receiptType;
            Amount = amount;
            Note = note;
            ReceiptDate = receiptDate;
            CreatedBy = createdBy;
            ReceiptID = receiptID;
            ReceiptCode = receiptCode;
            ReceiptType = receiptType;
            Amount = amount;
            Note = note;
            ReceiptDate = receiptDate;
            CreatedBy = createdBy;
        }
    }
}



