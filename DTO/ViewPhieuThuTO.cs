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
        private int _receiptID;
        private string _receiptCode;
        private int _billID;
        private int _contractID;
        private int _hostelID;
        private int _roomID;
        private int _tenantID;
        private string _receiptType;
        private decimal _amount;
        private string _note;
        private DateTime _receiptDate;
        private string _createdBy;

        // ===== PUBLIC PROPERTIES =====
        public int ReceiptID
        {
            get => _receiptID;
            set => _receiptID = value;
        }

        public string ReceiptCode
        {
            get => _receiptCode;
            set => _receiptCode = value;
        }

        public int BillID
        {
            get => _billID;
            set => _billID = value;
        }

        public int ContractID
        {
            get => _contractID;
            set => _contractID = value;
        }

        public int HostelID
        {
            get => _hostelID;
            set => _hostelID = value;
        }

        public int RoomID
        {
            get => _roomID;
            set => _roomID = value;
        }

        public int TenantID
        {
            get => _tenantID;
            set => _tenantID = value;
        }

        public string ReceiptType
        {
            get => _receiptType;
            set => _receiptType = value;
        }

        public decimal Amount
        {
            get => _amount;
            set => _amount = value;
        }

        public string Note
        {
            get => _note;
            set => _note = value;
        }

        public DateTime ReceiptDate
        {
            get => _receiptDate;
            set => _receiptDate = value;
        }

        public string CreatedBy
        {
            get => _createdBy;
            set => _createdBy = value;
        }

        // ===== CONSTRUCTORS =====
        public ViewPhieuThuDTO() { }

        public ViewPhieuThuDTO(
            int receiptID,
            string receiptCode,
            int billID,
            int contractID,
            int hostelID,
            int roomID,
            int tenantID,
            string receiptType,
            decimal amount,
            string note,
            DateTime receiptDate,
            string createdBy
        )
        {
            _receiptID = receiptID;
            _receiptCode = receiptCode;
            _billID = billID;
            _contractID = contractID;
            _hostelID = hostelID;
            _roomID = roomID;
            _tenantID = tenantID;
            _receiptType = receiptType;
            _amount = amount;
            _note = note;
            _receiptDate = receiptDate;
            _createdBy = createdBy;
        }
    }
}
