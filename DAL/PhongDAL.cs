using DAL.DataNhaTroTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using DTO;

namespace DAL
{
    public  class PhongDAL
    {
        private PhongTableAdapter _adapter = new PhongTableAdapter();

        public List<PhongDTO> LayTatCaPhong()
        {
            List<PhongDTO> dsPhong = new List<PhongDTO>();

            try
            {
                // Lấy DataTable từ TableAdapter
                var dt = _adapter.GetData();

                foreach (var row in dt)
                {
                    PhongDTO p = new PhongDTO();

                    // Map dữ liệu từ Row sang DTO
                    p.MaPhong = row.MaPhong;
                    p.MaNha = row.MaNha;

                    // Kiểm tra null an toàn (vì DataSet sinh ra các hàm Is...Null)
                    p.MaLoaiPhong = row.IsMaLoaiPhongNull() ? 0 : row.MaLoaiPhong;
                    p.TenPhong = row.TenPhong;
                    p.Tang = row.IsTangNull() ? 0 : row.Tang;
                    p.TrangThai = row.IsTrangThaiNull() ? "Trong" : row.TrangThai;
                    p.GhiChu = row.IsGhiChuNull() ? "" : row.GhiChu;

                    dsPhong.Add(p);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi kết nối nếu cần
                throw ex;
            }

            return dsPhong;
        }

        // Các hàm Thêm, Xóa, Sửa dùng TableAdapter
        public bool ThemPhong(PhongDTO p)
        {
            try
            {
                _adapter.Insert(p.MaNha, p.MaLoaiPhong, p.TenPhong, p.Tang, "Trong", p.GhiChu);
                return true;
            }
            catch { return false; }
        }

    }
}
