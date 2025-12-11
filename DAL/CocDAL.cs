using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CocDAL
    {
        private string connStr = Properties.Settings.Default.QL_nhaTroConnectionString1;

        public bool ThemDatCoc(CocDTO coc)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                // Chỉ cần Insert, Trigger trong SQL sẽ tự update trạng thái phòng thành 'DaDatCoc'
                string query = @"INSERT INTO CocGiuCho (MaPhong, HoTenKhach, SDT, TienCoc, HanChotKyHopDong, TrangThai)
                                 VALUES (@MaPhong, @HoTen, @SDT, @TienCoc, @HanChot, 'DangGiu')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaPhong", coc.MaPhong);
                cmd.Parameters.AddWithValue("@HoTen", coc.HoTenKhach);
                cmd.Parameters.AddWithValue("@SDT", coc.SDT);
                cmd.Parameters.AddWithValue("@TienCoc", coc.TienCoc);
                cmd.Parameters.AddWithValue("@HanChot", coc.HanChot);

                return cmd.ExecuteNonQuery() > 0;
            }
        }



        public bool HuyDatCoc(int maPhong)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. CẬP NHẬT TRẠNG THÁI CỌC -> 'DaHuy'
                    // Chỉ hủy những phiếu cọc đang 'DangGiu' của phòng này
                    string sqlHuyCoc = @"UPDATE CocGiuCho 
                                 SET TrangThai = 'DaHuy' 
                                 WHERE MaPhong = @MaPhong AND TrangThai = 'DangGiu'";

                    SqlCommand cmdHuy = new SqlCommand(sqlHuyCoc, conn, transaction);
                    cmdHuy.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdHuy.ExecuteNonQuery();

                    // 2. TRẢ PHÒNG VỀ TRẠNG THÁI -> 'Trong'
                    string sqlTraPhong = @"UPDATE Phong 
                                   SET TrangThai = 'Trong' 
                                   WHERE MaPhong = @MaPhong";

                    SqlCommand cmdPhong = new SqlCommand(sqlTraPhong, conn, transaction);
                    cmdPhong.Parameters.AddWithValue("@MaPhong", maPhong);
                    cmdPhong.ExecuteNonQuery();

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
