using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HopDongBLL
    {
        private HopDongDAL dal = new HopDongDAL();

        public List<DanhSachHopDongDTO> GetDanhSachHopDong()
        {
            return dal.GetDanhSachHopDong();
        }


        //public List<HopDongDTO> GetDanhSachHopDong()
        //{
        //    return dal.GetDanhSachHopDong();
        //}

    }

}
//    public string Insert(ContractDTO c)
//    {
//        if (c.NgayBatDau >= c.NgayKetThuc)
//            return "Ngày bắt đầu phải nhỏ hơn ngày kết thúc!";

//        return dal.Insert(c) ? "OK" : "Lỗi khi thêm hợp đồng";
//    }

//    public string Update(ContractDTO c)
//    {
//        if (c.NgayBatDau >= c.NgayKetThuc)
//            return "Ngày bắt đầu phải nhỏ hơn ngày kết thúc!";

//        return dal.Update(c) ? "OK" : "Lỗi khi cập nhật hợp đồng";
//    }

//    public bool Delete(int id)
//    {
//        return dal.Delete(id);
//    }

//    public ContractDTO GetByID(int id)
//    {
//        return dal.GetByID(id);
//    }
//}
