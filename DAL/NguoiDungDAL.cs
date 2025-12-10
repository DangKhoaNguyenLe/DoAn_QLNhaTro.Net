using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDungDAL : DbProcessDAL
    {
        public NguoiDungDTO KiemTraDangNhap(string user, string pass)
        {
            try
            {
                var dataTable = nguoiDung_adapter.DangNhap(user, pass);

                if (dataTable.Rows.Count > 0)
                {
                    var row = dataTable[0];
                    NguoiDungDTO dto = new NguoiDungDTO();

                    dto.MaNguoiDung = row.MaNguoiDung;
                    dto.TenDangNhap = row.TenDangNhap;
                    dto.MatKhau = row.MatKhau;
                    dto.HoTen = row.HoTen;
                    dto.TrangThai = row.TrangThai;

                    if (!row.IsVaiTroNull())
                    {
                        dto.VaiTro = row.VaiTro;
                    }
                    else
                    {
                        dto.VaiTro = "NHANVIEN";
                    }

                    return dto;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return null;
        }

        public bool ThemNguoiDung(NguoiDungDTO dto)
        {
            try
            {
  
                int result = nguoiDung_adapter.ThemNguoiDung(dto.TenDangNhap, dto.MatKhau, dto.HoTen, dto.SDT);

                return result > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
