using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BillDAL : DbProcessDAL
    {
        //public List<BillDTO> getList()
        //{
        //    List<BillDTO> bills = new List<BillDTO>();
        //    DataTable dt = Bill.GetData();

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        DataNhaTro.BILLRow ht = dr as DataNhaTro.BILLRow;
        //        BillDTO d = new BillDTO(
        //            ht.BillID,
        //            ht.BillCode,
        //            ht.ContractID,
        //            ht.HostelID,
        //            ht.RoomID,
        //            ht.TenantID,
        //            ht.BillMonth,
        //            ht.RoomPrice,
        //            ht.ServicePrice,
        //            ht.Discount,
        //            ht.PaidAmount,
        //            ht.TotalAmount,
        //            ht.RemainingAmount,
        //            ht.Status,
        //             ht.IsPaymentDateNull() ? (DateTime?)null : ht.PaymentDate,
        //            ht.CreatedBy,
        //            ht.CreatedDate);
        //        bills.Add(d);
        //    }
        //    return bills;
        //}
    }
}
