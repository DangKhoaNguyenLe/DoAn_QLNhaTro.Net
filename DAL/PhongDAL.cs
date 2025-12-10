using DAL.DataNhaTroTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public  class PhongDAL
    {
        private PhongTableAdapter _adapter = new PhongTableAdapter();

        public List<PhongDTO> LayTatCaPhong()
        {
            List<PhongDTO> dsPhong = new List<PhongDTO>();

            // 1. Lấy chuỗi kết nối (Lấy từ Properties hoặc cấu hình của bạn)
            // Bạn có thể copy chuỗi kết nối trong file App.config dán vào đây cũng được
            string connectionString = Properties.Settings.Default.QL_nhaTroConnectionString1;

            // Câu lệnh SQL lấy luôn ảnh (Sub-query)
            string query = @"
        SELECT 
            p.MaPhong, p.MaNha, p.TenPhong, p.Tang, p.TrangThai, p.GhiChu,
            (SELECT TOP 1 t.DuongDanURL FROM ThuVienAnh t WHERE t.MaPhong = p.MaPhong) AS AnhDaiDien
        FROM Phong p";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Dùng SqlDataReader để đọc dữ liệu nhanh
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PhongDTO p = new PhongDTO();

                            // --- Mapping dữ liệu thủ công (An toàn tuyệt đối) ---
                            p.MaPhong = int.Parse(reader["MaPhong"].ToString());

                            // Kiểm tra null khi gán
                            p.MaNha = reader["MaNha"] != DBNull.Value ? int.Parse(reader["MaNha"].ToString()) : 0;
                            p.TenPhong = reader["TenPhong"].ToString();
                            p.Tang = reader["Tang"] != DBNull.Value ? int.Parse(reader["Tang"].ToString()) : 0;
                            p.TrangThai = reader["TrangThai"] != DBNull.Value ? reader["TrangThai"].ToString() : "Trong";
                            p.GhiChu = reader["GhiChu"] != DBNull.Value ? reader["GhiChu"].ToString() : "";

                            // --- QUAN TRỌNG: LẤY CỘT ẢNH ---
                            if (reader["AnhDaiDien"] != DBNull.Value)
                            {
                                p.AnhDaiDien = reader["AnhDaiDien"].ToString();
                            }
                            else
                            {
                                p.AnhDaiDien = ""; // Không có ảnh
                            }

                            dsPhong.Add(p);
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            return dsPhong;
        }

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
