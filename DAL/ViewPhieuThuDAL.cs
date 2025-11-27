using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class ViewPhieuThuDAL : DbProcessDAL
    {
        public List<ViewPhieuThuDTO> GetListPhieuThu()
        {
            List<ViewPhieuThuDTO> list = new List<ViewPhieuThuDTO>();

            DataTable dt = v_PhieuThu.GetData();
            foreach (DataRow dr in dt.Rows)
            {
                DataNhaTro.RECEIPT_VOUCHERRow row = dr as DataNhaTro.RECEIPT_VOUCHERRow;

                ViewPhieuThuDTO p = new ViewPhieuThuDTO(
                    row.ReceiptID,
                    row.ReceiptCode,
                    row.BillID,       
                    row.ContractID,     
                    row.HostelID,      
                    row.RoomID,
                    row.TenantID,
                    row.ReceiptType,
                    row.Amount,
                    row.IsNoteNull() ? "" : row.Note,
                    row.ReceiptDate,
                    row.CreatedBy
                );

                list.Add(p);
            }

            return list;
        }
    }
}
