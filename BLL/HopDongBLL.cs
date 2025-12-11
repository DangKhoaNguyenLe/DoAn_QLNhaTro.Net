using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HopDongBLL
    {
        //private HopDongDAL dal = new HopDongDAL();
        //private DayNhaBLL dayNhaBLL = new DayNhaBLL();

        //public bool XoaHopDong(int contractID)
        //{
        //    return dal.XoaHopDong(contractID);
        //}

        //public DataTable LayDanhSachHD()
        //{
        //    return dal.LayDSHD();
        //}

        //public List<DanhSachHopDongDTO> LayDanhSachHopDong()
        //{
        //    List<DayNhaDTO> danhSachDay = dayNhaBLL.getListByAdmin();

        //    List<DanhSachHopDongDTO> all = dal.GetDanhSachHopDong();

        //    List<string> tenDay = danhSachDay.Select(t => t.HostelName).ToList();

        //    return all.Where(hd => tenDay.Contains(hd.HostelName)).ToList();

        //}

        //public List<DanhSachHopDongDTO> LayHopDongTheoDay(string hostelName)
        //{
        //    List<DanhSachHopDongDTO> dshd = dal.GetDanhSachHopDong();
        //    return dshd.Where(t => t.HostelName == hostelName).ToList();
        //}

        //public List<DanhSachHopDongDTO> TimKiemTheoTen(string keyword, string tenDay)
        //{
        //    List<DanhSachHopDongDTO> dsTheoDay = LayHopDongTheoDay(tenDay);

        //    return dsTheoDay.Where(hd => hd.FullName != null &&hd.FullName.ToLower().Contains(keyword.ToLower())).ToList();
        //}

        //public bool ThemHopDong(HopDongDTO c)
        //{
        //    return dal.Insert(c);
        //}

        //public bool CapNhatHopDong(HopDongDTO hd)
        //{
        //    return dal.CapNhatHopDong(hd);
        //}

        //public HopDongDTO LayHopDongTheoID(int id)
        //{
        //    return dal.LayHopDongTheoID(id);
        //}


        //public int LayMaxContractID()
        //{
        //    return dal.GetMaxContractID();
        //}
    }

}