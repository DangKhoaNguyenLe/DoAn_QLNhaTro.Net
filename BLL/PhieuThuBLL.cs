using DAL;
using DAL.DataNhaTroTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuThuBLL:ConnectionBLL
    {
            private PhieuThuDAL dal = new PhieuThuDAL();
            private UserBLL userBLL = new UserBLL(); 

            // 1. Lấy danh sách
            public DataTable LayDSPhieuThu()
            {
                int ownerID = userBLL.getUserAdminLogin().UserID;
                return dal.GetListByOwner(ownerID);
            }

        public DataTable LayDanhSachPhong(string hostelID)
        {
            DataTable dtPhong = dal.loadPhong();


            var rows = dtPhong.AsEnumerable()
                              .Where(r => r.Field<object>("HostelID").ToString() == hostelID);

            if (rows.Any()) return rows.CopyToDataTable();
            return dtPhong.Clone();
        }

        public DataTable LayDanhSachHopDong(string hostelID, string roomID)
        {
            DataTable dtHopDong = dal.loadHopDong();


            var rows = dtHopDong.AsEnumerable()
                              .Where(r => r.Field<object>("HostelID").ToString() == hostelID && r.Field<object>("RoomID").ToString() == roomID);

            if (rows.Any()) return rows.CopyToDataTable();
            return dtHopDong.Clone();
        }

        public DataTable LayDanhSachNhaCuaToi()
        {
            int currentUserID = userBLL.getUserAdminLogin().UserID;

            DataTable dtAll = dal.LoadNha();

            var filteredRows = dtAll.AsEnumerable()
                                    .Where(row => row.Field<int>("OwnerID") == currentUserID);

            if (filteredRows.Any())
                return filteredRows.CopyToDataTable();
            else
                return dtAll.Clone();
        }

        public decimal TinhSoTienCanThu(string loaiPhieu, int roomID, string monthPeriod)
        {
            decimal tongTien = 0;
            decimal tienDien = 0;
            decimal tienNuoc = 0;
            decimal tienNha = 0;



             DIENNUOCTableAdapter dienNuocAdapter = new DIENNUOCTableAdapter();
             CONTRACTTableAdapter contractAdapter = new CONTRACTTableAdapter();

            if (loaiPhieu == "Tiền điện" || loaiPhieu == "Tiền nước" || loaiPhieu == "Tất cả")
            {
                DataTable dtDN = dienNuocAdapter.GetTienDienNuocByRoomMonth(roomID, monthPeriod);
                if (dtDN.Rows.Count > 0)
                {
                    tienDien = Convert.ToDecimal(dtDN.Rows[0]["TienDien"]);
                    tienNuoc = Convert.ToDecimal(dtDN.Rows[0]["TienNuoc"]);
                }
            }

            if (loaiPhieu == "Tiền nhà" || loaiPhieu == "Tất cả")
            {
                decimal? giaPhongTimDuoc = contractAdapter.GetGiaPhongByRoom(roomID);
                if (giaPhongTimDuoc.HasValue)
                {
                    tienNha = giaPhongTimDuoc.Value;
                }
                else
                {
                    tienNha = 0; 
                }
            }

            switch (loaiPhieu)
            {
                case "Tiền điện":
                    tongTien = tienDien;
                    break;
                case "Tiền nước":
                    tongTien = tienNuoc;
                    break;
                case "Tiền nhà":
                    tongTien = tienNha;
                    break;
                case "Tất cả":
                    tongTien = tienDien + tienNuoc + tienNha;
                    break;
                default:
                    tongTien = 0;
                    break;
            }

            return tongTien;
        }

        RECEIPT_VOUCHERTableAdapter adapter = new RECEIPT_VOUCHERTableAdapter();
        public bool ThemPhieuThu(PhieuThuDTO pt)
        {
            try
            {
                

                if (string.IsNullOrEmpty(pt.ReceiptType))
                    throw new Exception("Vui lòng chọn loại phiếu thu!");

                pt.ReceiptCode = "PT" + DateTime.Now.ToString("yyyyMMddHHmmss");

                var currentUser = userBLL.getUserAdminLogin();
                pt.CreatedBy = currentUser != null ? currentUser.FullName : "Admin";


              

                adapter.InsertQuery(
                      pt.ReceiptCode    
                    , pt.BillID       
                    , pt.ContractID    
                    , pt.HostelID       
                    , pt.RoomID              
                    , pt.ReceiptType  
                    , pt.Amount         
                    , pt.ReceiptDate   
                    , pt.CreatedBy      
                );

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi thêm phiếu thu: " + ex.Message);
            }
        }

        public DataTable TimPhieuThu(int? hostelID, int? roomID, int? contractID, string loaiPhieu, string monthPeriod)
        {
            return adapter.Search(
        hostelID,
        roomID,
        contractID,
        loaiPhieu,
        monthPeriod);

        }

        public bool KiemTraTonTaiPhieuThu(int contractId, string loaiPhieu, string monthPeriod)
        {
          
            DataTable dt = adapter.KiemTraPhieuTonTai(contractId, loaiPhieu, monthPeriod);
            return dt.Rows.Count > 0;
        }

        public bool XoaPhieuThu(int receiptId)
        {

            try
            {
                adapter.DeleteReceipt(receiptId);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SuaPhieuThu(PhieuThuDTO pt)
        {
            
            try
            {
                adapter.UpdatePhieuThu(
                    pt.HostelID,
                    pt.RoomID,
                    pt.ContractID,
                    pt.ReceiptType,
                    pt.ReceiptDate,
                    pt.Amount,
                    pt.ReceiptID
                );
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
