using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class HopDongBLL:ConnectionBLL
    {


        private KhachHangDAL khachDal = new KhachHangDAL();

        public List<HopDongDTO> LayDanhSachHopDong()
        {
            return hopDongDAL.LayDanhSachHopDong();
        }


        public bool ThemHopDong(HopDongDTO hd, out string errorMessage)
        {
            if (hd.MaPhong <= 0)
            {
                errorMessage = "Vui lòng chọn phòng!";
                return false;
            }
            if (hd.MaKhachHang <= 0)
            {
                errorMessage = "Vui lòng chọn khách hàng!";
                return false;
            }
            if (hd.TienCoc < 0 || hd.GiaThueThucTe < 0)
            {
                errorMessage = "Giá thuê và tiền cọc phải ≥ 0!";
                return false;
            }

            return hopDongDAL.ThemHopDong(hd, out errorMessage);
        }
        public bool SuaHopDong(HopDongDTO hd, out string errorMessage)
        {
            return hopDongDAL.SuaHopDong(hd, out errorMessage);
        }

    }
}