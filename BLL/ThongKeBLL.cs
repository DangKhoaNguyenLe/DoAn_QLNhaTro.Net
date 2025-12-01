using DTO;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL : ConnectionBLL
    {
        DayNhaBLL daynhas = new DayNhaBLL();
        PhongTroBLL phongs = new PhongTroBLL();
        KhachThueBLL khachs = new KhachThueBLL();
        BillBLL Bill = new BillBLL();
        public int CountDayNha()
        {
            return daynhas.getListByAdmin().Count();
        }


        public List<PhongTroDTO> getListPhongTro()
        {
            List<PhongTroDTO> p = new List<PhongTroDTO>();
            foreach (var i in daynhas.getListByAdmin())
            {
                foreach (var j in phongs.getListByHostel(i.HostelID))
                {
                    p.Add(j);
                }
            }
            return p;
        }

        public List<KhachThueDTO> getKhachThueByTro()
        {
            List<KhachThueDTO> k = new List<KhachThueDTO>();
            foreach (var i in getListPhongTro())
            {
                foreach (var j in khachs.getListById(i.RoomID))
                {
                    k.Add(j);
                }
            }
            return k;
        }

        public List<BillDTO> getBillThanhToan()
        {
            List<BillDTO> bill = new List<BillDTO>();
            foreach (var i in getListPhongTro())
            {
                foreach(var j in Bill.getBillByIdRoom(i.RoomID).Where(t => t.Status == "Đã thanh toán"))
                {
                    bill.Add(j);
                }
            }
            return bill;
        }

        public int CountPhong()
        {
            return getListPhongTro().Count();
        }


        public int CountKhachHang()
        {
            return getKhachThueByTro().Count();
        }

        public decimal SumDoanhThu()
        {
            return getBillThanhToan().Sum(t => t.TotalAmount);
        }

        public List<BillDTO> sortBillByTime()
        {
            return getBillThanhToan().OrderByDescending(t => t.PaymentDate).ToList();
        }
    }
}
