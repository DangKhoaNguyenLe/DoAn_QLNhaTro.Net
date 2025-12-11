using DAL;
using DAL.DataNhaTroTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BLL
{
    public class DienNuocBLL
    {
 
            //private DienNuocDAL dal = new DienNuocDAL();
            //private UserBLL userBLL = new UserBLL(); 
            //DIENNUOCTableAdapter dienNuocAdapter = new DIENNUOCTableAdapter();
            //GIADIENNUOCTableAdapter giaAdapter = new GIADIENNUOCTableAdapter();

        //public bool SuaDienNuoc(DienNuocDTO dn, int idCanSua)
        //{
        //    try
        //    {
        //        DateTime kyThanhToan;
        //        if (!DateTime.TryParseExact(dn.MonthPeriod, "MM/yyyy",
        //            System.Globalization.CultureInfo.InvariantCulture,
        //            System.Globalization.DateTimeStyles.None, out kyThanhToan))
        //        {
        //            throw new Exception("Định dạng tháng không hợp lệ (Phải là MM/yyyy)");
        //        }


        //        if (dn.NgayChot.Date < kyThanhToan.Date)
        //        {
        //            throw new Exception(string.Format("Lỗi thời gian: Bạn đang tính tiền cho tháng {0}, \nnhưng ngày chốt ({1:dd/MM/yyyy}) lại nằm ở quá khứ!",
        //                dn.MonthPeriod, dn.NgayChot));
        //        }

        //        DateTime gioiHanTuyetDoi = kyThanhToan.AddMonths(2);

        //        if (dn.NgayChot >= gioiHanTuyetDoi)
        //        {
        //            throw new Exception(string.Format("Lỗi thời gian: Ngày chốt ({0:dd/MM/yyyy}) quá xa so với tháng tính tiền ({1}). \nChỉ được chốt trong tháng đó hoặc tháng kế tiếp.",
        //               dn.NgayChot, dn.MonthPeriod));
        //        }

        //        int tieuThuDien = dn.SoDienCuoi - dn.SoDienDau;
        //        int tieuThuNuoc = dn.SoNuocCuoi - dn.SoNuocDau;

        //        if (tieuThuDien < 0) throw new Exception("Số điện cuối phải lớn hơn số đầu!");
        //        if (tieuThuNuoc < 0) throw new Exception("Số nước cuối phải lớn hơn số đầu!");


        //        decimal giaDien = 3500;
        //        decimal giaNuoc = 15000;

        //        DataTable dtGia = giaAdapter.GetGiaMoiNhat(dn.HostelID);
        //        if (dtGia.Rows.Count > 0)
        //        {
        //            giaDien = decimal.Parse(dtGia.Rows[0]["GiaDien"].ToString());
        //            giaNuoc = decimal.Parse(dtGia.Rows[0]["GiaNuoc"].ToString());
        //        }

        //        dn.TienDien = tieuThuDien * giaDien;
        //        dn.TienNuoc = tieuThuNuoc * giaNuoc;

  
        //        dienNuocAdapter.UpdateQuery(
        //              dn.HostelID
        //            , dn.RoomID
        //            , dn.ContractID
        //            , dn.MonthPeriod
        //            , dn.NgayChot.ToString("yyyy-MM-dd")
        //            , dn.SoDienDau
        //            , dn.SoDienCuoi
        //            , dn.SoNuocDau
        //            , dn.SoNuocCuoi
        //            , dn.TienDien
        //            , dn.TienNuoc
        //            , idCanSua 
        //        );

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi cập nhật: " + ex.Message);
        //    }
        //}

        //public bool Add(DienNuocDTO dn)
        //{
        //    try
        //    {
        //        DateTime kyThanhToan;
        //        if (!DateTime.TryParseExact(dn.MonthPeriod, "MM/yyyy",
        //            System.Globalization.CultureInfo.InvariantCulture,
        //            System.Globalization.DateTimeStyles.None, out kyThanhToan))
        //        {
        //            throw new Exception("Định dạng tháng không hợp lệ (Phải là MM/yyyy)");
        //        }


        //        if (dn.NgayChot.Date < kyThanhToan.Date)
        //        {
        //            throw new Exception(string.Format("Lỗi thời gian: Bạn đang tính tiền cho tháng {0}, \nnhưng ngày chốt ({1:dd/MM/yyyy}) lại nằm ở quá khứ!",
        //                dn.MonthPeriod, dn.NgayChot));
        //        }

        //        DateTime gioiHanTuyetDoi = kyThanhToan.AddMonths(2);

        //        if (dn.NgayChot >= gioiHanTuyetDoi)
        //        {
        //            throw new Exception(string.Format("Lỗi thời gian: Ngày chốt ({0:dd/MM/yyyy}) quá xa so với tháng tính tiền ({1}). \nChỉ được chốt trong tháng đó hoặc tháng kế tiếp.",
        //               dn.NgayChot, dn.MonthPeriod));
        //        }

        //        int soLuong = (int)dienNuocAdapter.KiemTraTrungThang(dn.RoomID, dn.MonthPeriod);

        //        if (soLuong > 0)
        //        {
              
        //            throw new Exception(string.Format("Phòng này đã chốt điện nước tháng {0} rồi! Không thể thêm nữa.", dn.MonthPeriod));
        //        }

        //        int tieuThuDien = dn.SoDienCuoi - dn.SoDienDau;
        //        int tieuThuNuoc = dn.SoNuocCuoi - dn.SoNuocDau;

        //        decimal giaDien = 0;
        //        decimal giaNuoc = 0;

                
        //        DataTable dtGia = giaAdapter.GetGiaMoiNhat(dn.HostelID);

        //        if (dtGia.Rows.Count > 0)
        //        {
        //            giaDien = Convert.ToDecimal(dtGia.Rows[0]["GiaDien"]);
        //            giaNuoc = Convert.ToDecimal(dtGia.Rows[0]["GiaNuoc"]);
        //        }
        //        else
        //        {

        //            MessageBox.Show("Bạn chưa cập nhật giá điện, nước");
        //        }

        //        if (tieuThuDien < 0) throw new Exception("Số điện cuối phải lớn hơn số đầu!");
        //        if (tieuThuNuoc < 0) throw new Exception("Số nước cuối phải lớn hơn số đầu!");

        //        dn.TienDien = tieuThuDien * giaDien;
        //        dn.TienNuoc = tieuThuNuoc * giaNuoc;


        //        dienNuocAdapter.Insert(
        //              dn.HostelID
        //            , dn.RoomID
        //            , dn.ContractID  
        //            , dn.MonthPeriod
        //            , dn.NgayChot
        //            , dn.SoDienDau
        //            , dn.SoDienCuoi
        //            , dn.SoNuocDau
        //            , dn.SoNuocCuoi
        //            , dn.TienDien
        //            , dn.TienNuoc
        //        );

        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
                
        //        if (ex.Message.Contains("FK__DIENNUOC__Contra"))
        //            throw new Exception("Lỗi: Phòng này chưa có Hợp đồng hoặc Hợp đồng không hợp lệ!");

        //        if (ex.Message.Contains("PK__DIENNUOC"))
        //            throw new Exception("Tháng này phòng này đã nhập rồi!");

        //        throw new Exception("Lỗi CSDL: " + ex.Message);
        //    }
        //}

        //public bool XoaDienNuoc(int id)
        //{
        //    try
        //    {
        //        // Gọi hàm Delete trong DataSet
        //        if (dienNuocAdapter.DeleteQuery(id) > 0)
        //            return true;
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi xóa dữ liệu: " + ex.Message);
        //    }
        //}
        //public DataTable LayDanhSachNhaCuaToi()
        //{
        //   int currentUserID = userBLL.getUserAdminLogin().UserID;

        //    DataTable dtAll = dal.LoadNha();

        //    var filteredRows = dtAll.AsEnumerable()
        //                            .Where(row => row.Field<int>("OwnerID") == currentUserID);

        //    if (filteredRows.Any())
        //        return filteredRows.CopyToDataTable();
        //    else
        //        return dtAll.Clone();
        //}


        //public DataTable LayDSDienNuocCuaToi()
        //    {
        //        int currentUserID = userBLL.getUserAdminLogin().UserID;

               
        //        DataTable dtNhaToi = LayDanhSachNhaCuaToi();

        //        List<string> myHostelIDs = dtNhaToi.AsEnumerable()
        //                                          .Select(r => r.Field<object>("HostelID").ToString())
        //                                          .ToList();

        //        DataTable dtDienNuoc = dal.loadDienNuoc(); 


        //        var filteredRows = dtDienNuoc.AsEnumerable()
        //                                     .Where(row => myHostelIDs.Contains(row.Field<object>("HostelID").ToString()));

        //        if (filteredRows.Any())
        //            return filteredRows.CopyToDataTable();
        //        else
        //            return dtDienNuoc.Clone();
        //    }


        //    public DataTable LayDanhSachPhong(string hostelID)
        //    {
        //        DataTable dtPhong = dal.loadPhong(); 

            
        //        var rows = dtPhong.AsEnumerable()
        //                          .Where(r => r.Field<object>("HostelID").ToString() == hostelID);

        //        if (rows.Any()) return rows.CopyToDataTable();
        //        return dtPhong.Clone();
        //    }

        //    public DataTable LayDanhSachHopDong(string hostelID,string roomID)
        //    {
        //        DataTable dtHopDong = dal.loadHopDong();


        //        var rows = dtHopDong.AsEnumerable()
        //                          .Where(r => r.Field<object>("HostelID").ToString() == hostelID&&  r.Field<object>("RoomID").ToString() == roomID);

        //        if (rows.Any()) return rows.CopyToDataTable();
        //        return dtHopDong.Clone();
        //    }

        //public ThongKeDienNuocDTO TinhToanSoLieu(DataTable dt)
        //    {
        //    ThongKeDienNuocDTO kq = new ThongKeDienNuocDTO();
        //        if (dt != null && dt.Rows.Count > 0)
        //        {
        //            foreach (DataRow row in dt.Rows)
        //            {
        //                double dDau = 0, dCuoi = 0;
        //                double.TryParse(row["SoDienDau"].ToString(), out dDau);
        //                double.TryParse(row["SoDienCuoi"].ToString(), out dCuoi);
        //                kq.TongSoDien += (dCuoi - dDau);

        //                double nDau = 0, nCuoi = 0;
        //                double.TryParse(row["SoNuocDau"].ToString(), out nDau);
        //                double.TryParse(row["SoNuocCuoi"].ToString(), out nCuoi);
        //                kq.TongSoNuoc += (nCuoi - nDau);

        //                double tDien = 0, tNuoc = 0;
        //                double.TryParse(row["TienDien"].ToString(), out tDien);
        //                double.TryParse(row["TienNuoc"].ToString(), out tNuoc);
        //                kq.TongThuDien += tDien;
        //                kq.TongThuNuoc += tNuoc;
        //            }
        //        }
        //        return kq;
        //    }

        }
}
