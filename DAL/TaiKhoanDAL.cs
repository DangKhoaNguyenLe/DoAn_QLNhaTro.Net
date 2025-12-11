using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TaiKhoanDAL
    {


            private string connStr = Properties.Settings.Default.QL_nhaTroConnectionString1;

            public bool KiemTraMatKhauCu(string tenDangNhap, string matKhauCu)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @Ten AND MatKhau = @MatKhau";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ten", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhauCu);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            public bool CapNhatMatKhau(string tenDangNhap, string matKhauMoi)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = "UPDATE NguoiDung SET MatKhau = @MatKhauMoi WHERE TenDangNhap = @Ten";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ten", tenDangNhap);
                    cmd.Parameters.AddWithValue("@MatKhauMoi", matKhauMoi);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }






        }
    }

