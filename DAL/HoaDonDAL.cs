using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class HoaDonDAL
    {
        private string connStr = Properties.Settings.Default.QL_nhaTroConnectionString1;

        public DataTable LayThongTinHopDong(int maPhong)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT MaHopDong, GiaThueThucTe, MaKhachHang 
                                 FROM HopDong 
                                 WHERE MaPhong = @MaPhong AND TrangThai = 'HieuLuc'";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhong", maPhong);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

       
        public DataTable LayLichSuHoaDon(int maHopDong)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"SELECT TOP 6 
                            MaHoaDon, 
                            Thang AS [Tháng], 
                            Nam AS [Năm], 
                            TongTien AS [Tổng Tiền], 
                            ConNo AS [Còn Nợ], 
                            TrangThai AS [Trạng Thái],
                            GhiChu AS [Chi Tiết]
                         FROM HoaDon 
                         WHERE MaHopDong = @MaHD 
                         ORDER BY Nam DESC, Thang DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHD", maHopDong);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public bool XoaHoaDon(int maHoaDon)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    SqlCommand cmdGet = new SqlCommand("SELECT MaHopDong, Thang, Nam FROM HoaDon WHERE MaHoaDon = @Ma", conn, trans);
                    cmdGet.Parameters.AddWithValue("@Ma", maHoaDon);
                    int maHD = 0, t = 0, n = 0;
                    using (SqlDataReader r = cmdGet.ExecuteReader()) { if (r.Read()) { maHD = (int)r[0]; t = (int)r[1]; n = (int)r[2]; } }

                    new SqlCommand("DELETE FROM ChiTietHoaDon WHERE MaHoaDon = " + maHoaDon, conn, trans).ExecuteNonQuery();

                    new SqlCommand("DELETE FROM HoaDon WHERE MaHoaDon = " + maHoaDon, conn, trans).ExecuteNonQuery();
                    if (maHD > 0)
                    {
                        SqlCommand cmdChot = new SqlCommand("DELETE FROM ChotDienNuoc WHERE MaHopDong=@M AND Thang=@T AND Nam=@N", conn, trans);
                        cmdChot.Parameters.AddWithValue("@M", maHD);
                        cmdChot.Parameters.AddWithValue("@T", t);
                        cmdChot.Parameters.AddWithValue("@N", n);
                        cmdChot.ExecuteNonQuery();
                    }
                    trans.Commit();
                    return true;
                }
                catch { trans.Rollback(); return false; }
            }
        }
        public DataTable LayDanhSachHoaDon(int thang, int nam, string trangThai)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"SELECT 
                                    h.MaHoaDon, p.TenPhong, h.Thang, h.Nam, 
                                    h.TongTien, h.ConNo, h.TrangThai 
                                 FROM HoaDon h
                                 JOIN HopDong hd ON h.MaHopDong = hd.MaHopDong
                                 JOIN Phong p ON hd.MaPhong = p.MaPhong
                                 WHERE h.Thang = @Thang AND h.Nam = @Nam";

                if (trangThai != "All") query += " AND h.TrangThai = @TrangThai";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Thang", thang);
                da.SelectCommand.Parameters.AddWithValue("@Nam", nam);
                if (trangThai != "All") da.SelectCommand.Parameters.AddWithValue("@TrangThai", trangThai);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool KiemTraDaChot(int maHD, int thang, int nam)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM ChotDienNuoc WHERE MaHopDong=@Ma AND Thang=@T AND Nam=@N";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", maHD);
                cmd.Parameters.AddWithValue("@T", thang);
                cmd.Parameters.AddWithValue("@N", nam);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
        public bool KiemTraTonTai(int maHopDong, int thang, int nam)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM HoaDon WHERE MaHopDong = @MaHD AND Thang = @Thang AND Nam = @Nam";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHD", maHopDong);
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam", nam);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public bool LuuHoaDonDayDu(ChotDienNuocDTO chot, HoaDonDTO hd, List<ChiTietHoaDonDTO> listChiTiet)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string sqlChot = @"INSERT INTO ChotDienNuoc (MaHopDong, Thang, Nam, ChiSoDienCu, ChiSoDienMoi, ChiSoNuocCu, ChiSoNuocMoi, NgayChot, NguoiChot)
                               VALUES (@MaHD, @Thang, @Nam, @DienCu, @DienMoi, @NuocCu, @NuocMoi, GETDATE(), @NguoiChot)";

                    SqlCommand cmdChot = new SqlCommand(sqlChot, conn, trans);
                    cmdChot.Parameters.AddWithValue("@MaHD", chot.MaHopDong);
                    cmdChot.Parameters.AddWithValue("@Thang", chot.Thang);
                    cmdChot.Parameters.AddWithValue("@Nam", chot.Nam);
                    cmdChot.Parameters.AddWithValue("@DienCu", chot.ChiSoDienCu);
                    cmdChot.Parameters.AddWithValue("@DienMoi", chot.ChiSoDienMoi);
                    cmdChot.Parameters.AddWithValue("@NuocCu", chot.ChiSoNuocCu);
                    cmdChot.Parameters.AddWithValue("@NuocMoi", chot.ChiSoNuocMoi);
                    cmdChot.Parameters.AddWithValue("@NguoiChot", hd.NguoiLap); 
                    cmdChot.ExecuteNonQuery();

                    string sqlHD = @"INSERT INTO HoaDon (MaHopDong, Thang, Nam, NgayLap, TongTien, SoTienDaTra, ConNo, TrangThai, NguoiLap, GhiChu)
                             VALUES (@MaHD, @Thang, @Nam, GETDATE(), @Tong, 0, @Tong, 'ChuaThanhToan', @Nguoi, @GhiChu);
                             SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdHD = new SqlCommand(sqlHD, conn, trans);
                    cmdHD.Parameters.AddWithValue("@MaHD", hd.MaHopDong);
                    cmdHD.Parameters.AddWithValue("@Thang", hd.Thang);
                    cmdHD.Parameters.AddWithValue("@Nam", hd.Nam);
                    cmdHD.Parameters.AddWithValue("@Tong", hd.TongTien);
                    cmdHD.Parameters.AddWithValue("@Nguoi", hd.NguoiLap);
                    cmdHD.Parameters.AddWithValue("@GhiChu", hd.GhiChu ?? "");

                    int maHoaDonMoi = Convert.ToInt32(cmdHD.ExecuteScalar());
                    string sqlChiTiet = @"INSERT INTO ChiTietHoaDon (MaHoaDon, TenMucThanhToan, SoLuongSuDung, DonGia, ThanhTien)
                                  VALUES (@MaHD, @Ten, @SL, @Gia, @ThanhTien)";

                    foreach (var item in listChiTiet)
                    {
                        SqlCommand cmdCT = new SqlCommand(sqlChiTiet, conn, trans);
                        cmdCT.Parameters.AddWithValue("@MaHD", maHoaDonMoi);
                        cmdCT.Parameters.AddWithValue("@Ten", item.TenMucThanhToan);
                        cmdCT.Parameters.AddWithValue("@SL", item.SoLuongSuDung);
                        cmdCT.Parameters.AddWithValue("@Gia", item.DonGia);
                        cmdCT.Parameters.AddWithValue("@ThanhTien", item.ThanhTien);
                        cmdCT.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback(); 
                    return false;
                }
            }
        }

        // Thanh toán hóa đơn (Cập nhật trạng thái)
        public bool ThanhToanHoaDon(int maHoaDon, decimal soTienTra)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = @"UPDATE HoaDon 
                                 SET TrangThai = 'DaThanhToan', 
                                     SoTienDaTra = SoTienDaTra + @TienTra,
                                     ConNo = TongTien - (SoTienDaTra + @TienTra)
                                 WHERE MaHoaDon = @Ma";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", maHoaDon);
                cmd.Parameters.AddWithValue("@TienTra", soTienTra);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}