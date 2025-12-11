using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        private string connStr = Properties.Settings.Default.QL_nhaTroConnectionString1;

        public bool KiemTraTonTaiCCCD(string cccd)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM KhachHang WHERE CCCD = @CCCD";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CCCD", cccd);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch { return false; }
            }
        }

        public bool ThemKhachHang(KhachHangDTO kh)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                try
                {
                    string query = @"INSERT INTO KhachHang (HoTen, CCCD, SDT, QueQuan, GioiTinh, NgaySinh, AnhMatTruoc, AnhMatSau)
                                     VALUES (@HoTen, @CCCD, @SDT, @QueQuan, @GioiTinh, @NgaySinh, @AnhTruoc, @AnhSau)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@HoTen", kh.HoTen);
                    cmd.Parameters.AddWithValue("@CCCD", kh.CCCD);
                    cmd.Parameters.AddWithValue("@SDT", kh.SDT);
                    cmd.Parameters.AddWithValue("@QueQuan", kh.QueQuan);
                    cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh);

                 
                    cmd.Parameters.AddWithValue("@AnhTruoc", kh.AnhMatTruoc ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@AnhSau", kh.AnhMatSau ?? (object)DBNull.Value);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    throw; 
                }
            }
        }
    }
}
