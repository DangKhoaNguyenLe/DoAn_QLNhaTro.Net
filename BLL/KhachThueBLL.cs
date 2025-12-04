using DAL;
using DTO;
using DTO.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class KhachThueBLL: ConnectionBLL
    {


        // Hàm mới để lọc theo dãy nhà
        public List<KhachThueDTO> LayKhachThueTheoDay(int hostelID)
        {
            return khachThueDAL.GetListTenantByHostel(hostelID);
        }

        public List<KhachThueDTO> TimKiemTheoTen(string keyword, int hostelID)
        {
            List<KhachThueDTO> list = khachThueDAL.GetListTenantByHostel(hostelID);
            return list.FindAll(x => x.FullName.ToLower().Contains(keyword.ToLower()));
        }


        public List<KhachThueDTO> LayDSKhachThue()
        {
            return khachThueDAL.GetListTenant();
        }

        public List<KhachThueDTO> getListById(int id)
        {
            return khachThueDAL.GetListTenant().Where(t => t.RoomId == id).ToList();
        }
        
        public List<KhachThueDTO> getDsKhachChuaDK()
        {
            return LayDSKhachThue().Where(t => t.RoomId == 0).ToList();
        }


        public bool ThemKhachThue(KhachThueDTO kh)
        {
            if (string.IsNullOrEmpty(kh.FullName))
            {
                throw new ArgumentException("Tên khách thuê không được để trống.");
            }

            if (string.IsNullOrEmpty(kh.CCCD) && string.IsNullOrEmpty(kh.Phone))
            {
                throw new ArgumentException("Cần nhập ít nhất Số điện thoại hoặc CCCD để tạo tài khoản.");
            }

            return khachThueDAL.AddKhachThue(kh);
        }

        // Trong class KhachThueBLL
        public bool XoaKhachThue(int tenantID)
        {
            // Có thể thêm logic kiểm tra nợ tiền trước khi xóa nếu cần
            return khachThueDAL.DeleteKhachThue(tenantID);
        }
        public bool add(KhachThueDTO kh)
        {
            try
            {
                khachThueDAL.Add(kh);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }

        public bool update(KhachThueDTO kh)
        {
            try
            {
                khachThueDAL.update(kh);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }

        public bool delete(int id)
        {
            try
            {
                khachThueDAL.delete(id);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL " + ex.Message, ex);
            }
        }
    }
}
