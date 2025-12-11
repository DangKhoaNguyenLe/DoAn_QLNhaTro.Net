using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;

namespace DAL
{
    public class HopDongDAL : DbProcessDAL
    {
        string connectionString = DAL.Properties.Settings.Default.QL_nhaTroConnectionString1;

        public List<HopDongDTO> LayDanhSachHopDong()
        {
            List<HopDongDTO> list = new List<HopDongDTO>();
            // string connectionString = nhaTro_adapter.Connection.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_LayDanhSachHopDong", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                HopDongDTO item = new HopDongDTO();
                                item.MaHopDong = int.Parse(reader["MaHopDong"].ToString());
                                item.MaPhong = reader["MaPhong"] != DBNull.Value ? (int)reader["MaPhong"] : 0;
                                item.TenPhong = reader["TenPhong"].ToString();
                                item.TenNhaTro = reader["TenNhaTro"].ToString();
                                item.MaKhachHang = reader["MaKhachHang"] != DBNull.Value ? (int)reader["MaKhachHang"] : 0;
                                // item.TenKhachHang = reader["TenKhachHang"].ToString();
                                item.NgayBatDau = (DateTime)reader["NgayBatDau"];
                                if (reader["NgayKetThuc"] != DBNull.Value)
                                    item.NgayKetThuc = (DateTime)reader["NgayKetThuc"];
                                item.TienCoc = reader["TienCoc"] != DBNull.Value ? (decimal)reader["TienCoc"] : 0;
                                item.GiaThueThucTe = (decimal)reader["GiaThueThucTe"];
                                item.ChuKyThanhToan = reader["ChuKyThanhToan"] != DBNull.Value ? (int)reader["ChuKyThanhToan"] : 1;
                                item.TrangThai = reader["TrangThai"].ToString();
                                item.HoTenNguoiLapPhieu = reader["HoTenNguoiLapPhieu"].ToString();

                                list.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi DAL khi gọi Procedure: " + ex.Message);
                }
            }
            return list;
        }

        public bool ThemHopDong(HopDongDTO hd, out string errorMessage)
        {
            errorMessage = "";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_ThemHopDong", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // TRUYỀN THAM SỐ ĐẦU VÀO
                cmd.Parameters.AddWithValue("@MaPhong", hd.MaPhong);
                cmd.Parameters.AddWithValue("@MaKhachHang", hd.MaKhachHang);
                cmd.Parameters.AddWithValue("@NguoiLapPhieu", hd.NguoiLapPhieu);
                cmd.Parameters.AddWithValue("@NgayBatDau", hd.NgayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", hd.NgayKetThuc ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TienCoc", hd.TienCoc);
                cmd.Parameters.AddWithValue("@GiaThueThucTe", hd.GiaThueThucTe);
                cmd.Parameters.AddWithValue("@ChuKyThanhToan", hd.ChuKyThanhToan);
                cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);

                // TRẢ KẾT QUẢ TỪ SP
                SqlParameter pResult = new SqlParameter("@Result", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                SqlParameter pMsg = new SqlParameter("@Message", SqlDbType.NVarChar, 200)
                {
                    Direction = ParameterDirection.Output
                };

                cmd.Parameters.Add(pResult);
                cmd.Parameters.Add(pMsg);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    int result = (int)pResult.Value;
                    errorMessage = pMsg.Value?.ToString();

                    return result == 1;
                }
                catch (SqlException ex)
                {
                    errorMessage = "Lỗi DAL: " + ex.Message;
                    return false;
                }
            }
        }


        public bool SuaHopDong(HopDongDTO hd, out string errorMessage)
        {
            errorMessage = "";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_SuaHopDong", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHopDong", hd.MaHopDong);
                cmd.Parameters.AddWithValue("@MaPhongMoi", hd.MaPhong);
                cmd.Parameters.AddWithValue("@MaKhachHang", hd.MaKhachHang);
                cmd.Parameters.AddWithValue("@NgayBatDau", hd.NgayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", hd.NgayKetThuc ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TienCoc", hd.TienCoc);
                cmd.Parameters.AddWithValue("@GiaThue", hd.GiaThueThucTe);
                cmd.Parameters.AddWithValue("@ChuKyThanhToan", hd.ChuKyThanhToan);
                cmd.Parameters.AddWithValue("@TrangThai", hd.TrangThai);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    errorMessage = ex.Message;
                    return false;
                }
            }
        }


    }
}
