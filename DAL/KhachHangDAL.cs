using DAL.DataNhaTroTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class KhachHangDAL
    {
        private string connStr = Properties.Settings.Default.QL_nhaTroConnectionString1;
        KhachHangTableAdapter khachHangs = new KhachHangTableAdapter();
        public List<KhachHangDTO> GetList()
        {
            List<KhachHangDTO> daynhas = new List<KhachHangDTO>();
            DataTable dt = khachHangs.GetData();

<<<<<<< HEAD
            foreach(DataRow dr in dt.Rows)
            {
                DataNhaTro.KhachHangRow ht = dr as DataNhaTro.KhachHangRow;
                KhachHangDTO d = new KhachHangDTO();
                d.MaKhachHang = ht.MaKhachHang;
                d.HoTen = ht.HoTen ?? " ";
                d.CCCD = ht.CCCD ?? " ";
                d.SDT = ht.SDT ?? " ";
                d.QueQuan = ht.QueQuan ?? " ";
                d.GioiTinh = ht.GioiTinh ?? " ";
                d.NgaySinh = ht.IsNgaySinhNull() ? DateTime.ParseExact("01/01/1753", "dd/MM/yyyy", null) : ht.NgaySinh;
                d.AnhMatTruoc = ht.IsAnhMatTruocNull() ? "" : ht.AnhMatTruoc;
                d.AnhMatSau = ht.IsAnhMatSauNull() ? "" : ht.AnhMatSau;
                daynhas.Add(d);
            }
            return daynhas;
=======
        public DataTable LayDanhSachKhachHang()
        {
            DataTable dt = new DataTable();
            string connectionString = DAL.Properties.Settings.Default.QL_nhaTroConnectionString1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaKhachHang, HoTen FROM KhachHang";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }
                catch { }
            }
            return dt;
>>>>>>> d2459924a6a5283f3cba13e2dbb0d2973b9c4ba8
        }
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

        public bool delete(int id)
        {
            try
            {
                khachHangs.DeleteQuery(id);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL: " + ex.Message, ex);
            }
        }

        public bool update(KhachHangDTO kh)
        {
            try
            {
                khachHangs.UpdateQuery(
                    kh.HoTen,
                    kh.CCCD,
                    kh.SDT,
                    kh.QueQuan,
                    kh.GioiTinh,
                    kh.NgaySinh.ToString(),
                    kh.AnhMatSau,
                    kh.AnhMatSau,
                    kh.MaKhachHang);
                
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL: " + ex.Message, ex);
            }
        }
    }

}
