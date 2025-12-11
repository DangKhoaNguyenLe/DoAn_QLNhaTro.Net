using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThuePhongDAL
    {
        private string connStr = Properties.Settings.Default.QL_nhaTroConnectionString1;

        public bool ThuePhongMoi(KhachHangDTO kh, int maPhong, decimal giaThue, DateTime ngayBatDau)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {

                    string sqlKhach = @"INSERT INTO KhachHang (HoTen, CCCD, SDT, QueQuan, GioiTinh, AnhMatTruoc, AnhMatSau)
                                        VALUES (@HoTen, @CCCD, @SDT, @QueQuan, @GioiTinh, @AnhTruoc, @AnhSau);
                                        SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdKhach = new SqlCommand(sqlKhach, conn, trans);
                    cmdKhach.Parameters.AddWithValue("@HoTen", kh.HoTen);
                    cmdKhach.Parameters.AddWithValue("@CCCD", kh.CCCD);
                    cmdKhach.Parameters.AddWithValue("@SDT", kh.SDT);
                    cmdKhach.Parameters.AddWithValue("@QueQuan", kh.QueQuan);
                    cmdKhach.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
                    cmdKhach.Parameters.AddWithValue("@AnhTruoc", kh.AnhMatTruoc ?? (object)DBNull.Value);
                    cmdKhach.Parameters.AddWithValue("@AnhSau", kh.AnhMatSau ?? (object)DBNull.Value);

                    int maKhachMoi = Convert.ToInt32(cmdKhach.ExecuteScalar());

                    string sqlHD = @"INSERT INTO HopDong (MaPhong, MaKhachHang, NgayBatDau, GiaThueThucTe, TrangThai)
                                     VALUES (@MaPhong, @MaKhach, @NgayBD, @Gia, 'HieuLuc')";

                    SqlCommand cmdHD = new SqlCommand(sqlHD, conn, trans);
                    cmdHD.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdHD.Parameters.AddWithValue("@MaKhach", maKhachMoi);
                    cmdHD.Parameters.AddWithValue("@NgayBD", ngayBatDau);
                    cmdHD.Parameters.AddWithValue("@Gia", giaThue);

                    cmdHD.ExecuteNonQuery();


                    string sqlUpdatePhong = "UPDATE Phong SET TrangThai = 'DaThue' WHERE MaPhong = @MaPhong";
                    SqlCommand cmdP = new SqlCommand(sqlUpdatePhong, conn, trans);
                    cmdP.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdP.ExecuteNonQuery();

                    trans.Commit(); 
                    return true;
                }
                catch
                {
                    trans.Rollback(); 
                    return false;
                }
            }
        }
    }
}
