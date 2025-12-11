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
    public class PhongDAL
    {
        private string connStr = Properties.Settings.Default.QL_nhaTroConnectionString1;

        public int DemSoPhongTheoTrangThai(string trangThai)
        {
            if (trangThai == "TatCa")
            {
                return LayTatCaPhong().Count;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Phong WHERE TrangThai = @TT";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TT", trangThai);

                return (int)cmd.ExecuteScalar();
            }
        }

        public List<PhongDTO> LayTatCaPhong()
        {
            List<PhongDTO> dsPhong = new List<PhongDTO>();
            string query = @"
                SELECT p.MaPhong, p.MaNha, p.MaLoaiPhong, p.TenPhong, p.Tang, p.TrangThai, p.GhiChu,
                (SELECT TOP 1 t.DuongDanURL FROM ThuVienAnh t WHERE t.MaPhong = p.MaPhong) AS AnhDaiDien
                FROM Phong p";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PhongDTO p = new PhongDTO();
                            p.MaPhong = int.Parse(reader["MaPhong"].ToString());
                            p.TenPhong = reader["TenPhong"].ToString();
                            p.MaNha = reader["MaNha"] != DBNull.Value ? int.Parse(reader["MaNha"].ToString()) : 0;
                            p.MaLoaiPhong = reader["MaLoaiPhong"] != DBNull.Value ? int.Parse(reader["MaLoaiPhong"].ToString()) : 0;
                            p.Tang = reader["Tang"] != DBNull.Value ? int.Parse(reader["Tang"].ToString()) : 0;
                            p.TrangThai = reader["TrangThai"] != DBNull.Value ? reader["TrangThai"].ToString() : "Trong";
                            p.GhiChu = reader["GhiChu"] != DBNull.Value ? reader["GhiChu"].ToString() : "";
                            p.AnhDaiDien = reader["AnhDaiDien"] != DBNull.Value ? reader["AnhDaiDien"].ToString() : "";
                            dsPhong.Add(p);
                        }
                    }
                }
                catch { throw; }
            }
            return dsPhong;
        }

        public bool ThemPhong(PhongDTO p)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string sqlPhong = @"INSERT INTO Phong (MaNha, MaLoaiPhong, TenPhong, Tang, TrangThai, GhiChu) 
                                        VALUES (@MaNha, @MaLoaiPhong, @TenPhong, @Tang, 'Trong', @GhiChu);
                                        SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(sqlPhong, conn, trans);
                    cmd.Parameters.AddWithValue("@MaNha", p.MaNha);
                    cmd.Parameters.AddWithValue("@MaLoaiPhong", p.MaLoaiPhong);
                    cmd.Parameters.AddWithValue("@TenPhong", p.TenPhong);
                    cmd.Parameters.AddWithValue("@Tang", p.Tang);
                    cmd.Parameters.AddWithValue("@GhiChu", p.GhiChu ?? (object)DBNull.Value);

                    int maPhong = Convert.ToInt32(cmd.ExecuteScalar());

                    if (!string.IsNullOrEmpty(p.AnhDaiDien))
                    {
                        string sqlAnh = "INSERT INTO ThuVienAnh (MaPhong, DuongDanURL, LaAnhDaiDien, NgayTaiLen) VALUES (@Ma, @Url, 1, GETDATE())";
                        SqlCommand cmdAnh = new SqlCommand(sqlAnh, conn, trans);
                        cmdAnh.Parameters.AddWithValue("@Ma", maPhong);
                        cmdAnh.Parameters.AddWithValue("@Url", p.AnhDaiDien);
                        cmdAnh.ExecuteNonQuery();
                    }
                    trans.Commit();
                    return true;
                }
                catch { trans.Rollback(); return false; }
            }
        }

        public bool KiemTraTenPhongTonTai(string tenPhong, int maNha)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM Phong WHERE TenPhong = @Ten AND MaNha = @Nha";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Ten", tenPhong);
                    cmd.Parameters.AddWithValue("@Nha", maNha);
                    return (int)cmd.ExecuteScalar() > 0;
                }
                catch { return false; }
            }
        }

        public bool XoaPhong(int maPhong)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                  
                    string query = "DELETE FROM Phong WHERE MaPhong = @MaPhong";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool SuaPhong(PhongDTO p)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string sqlPhong = @"UPDATE Phong 
                                SET MaNha = @MaNha, 
                                    MaLoaiPhong = @MaLoaiPhong, 
                                    TenPhong = @TenPhong, 
                                    Tang = @Tang, 
                                    GhiChu = @GhiChu
                                WHERE MaPhong = @MaPhong";

                    SqlCommand cmdPhong = new SqlCommand(sqlPhong, conn, transaction);
                    cmdPhong.Parameters.AddWithValue("@MaPhong", p.MaPhong); 
                    cmdPhong.Parameters.AddWithValue("@MaNha", p.MaNha);
                    cmdPhong.Parameters.AddWithValue("@MaLoaiPhong", p.MaLoaiPhong);
                    cmdPhong.Parameters.AddWithValue("@TenPhong", p.TenPhong);
                    cmdPhong.Parameters.AddWithValue("@Tang", p.Tang);
                    cmdPhong.Parameters.AddWithValue("@GhiChu", p.GhiChu ?? (object)DBNull.Value);

                    cmdPhong.ExecuteNonQuery();

   
                    if (!string.IsNullOrEmpty(p.AnhDaiDien))
                    {
                      
                        string sqlAnh = @"
                    IF EXISTS (SELECT 1 FROM ThuVienAnh WHERE MaPhong = @MaPhong)
                    BEGIN
                        UPDATE ThuVienAnh SET DuongDanURL = @Url, NgayTaiLen = GETDATE() 
                        WHERE MaPhong = @MaPhong
                    END
                    ELSE
                    BEGIN
                        INSERT INTO ThuVienAnh (MaPhong, DuongDanURL, LaAnhDaiDien, NgayTaiLen)
                        VALUES (@MaPhong, @Url, 1, GETDATE())
                    END";

                        SqlCommand cmdAnh = new SqlCommand(sqlAnh, conn, transaction);
                        cmdAnh.Parameters.AddWithValue("@MaPhong", p.MaPhong);
                        cmdAnh.Parameters.AddWithValue("@Url", p.AnhDaiDien);
                        cmdAnh.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public bool TraPhong(int maPhong)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {

                    string sqlHopDong = @"UPDATE HopDong 
                                  SET NgayKetThuc = GETDATE(), TrangThai = 'KetThuc' 
                                  WHERE MaPhong = @MaPhong AND TrangThai = 'HieuLuc'";

                    SqlCommand cmdHD = new SqlCommand(sqlHopDong, conn, transaction);
                    cmdHD.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdHD.ExecuteNonQuery();

                    string sqlPhong = @"UPDATE Phong 
                                SET TrangThai = 'Trong' 
                                WHERE MaPhong = @MaPhong";

                    SqlCommand cmdPhong = new SqlCommand(sqlPhong, conn, transaction);
                    cmdPhong.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdPhong.ExecuteNonQuery();

                    string sqlKhach = @"UPDATE KhachO 
                                SET DangO = 0, NgayRa = GETDATE() 
                                WHERE DangO = 1 AND MaHopDong IN (SELECT MaHopDong FROM HopDong WHERE MaPhong = @MaPhong)";
                    SqlCommand cmdKhach = new SqlCommand(sqlKhach, conn, transaction);
                    cmdKhach.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdKhach.ExecuteNonQuery();

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }


    }
}
