using DAL.DataNhaTroTableAdapters;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;    //THÊM USING NÀY
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaTroDAL : DbProcessDAL
    {
        NhaTroTableAdapter nhaTro = new NhaTroTableAdapter();
        ThuVienAnhTableAdapter images = new ThuVienAnhTableAdapter();
        public List<NhaTroDTO> LayNhaTro()
        {
            var list = new List<NhaTroDTO>();

             //Lấy dữ liệu nhà trọ bằng TableAdapter (như cũ)
            DataTable dt = nhaTro_adapter.GetData();

            // Lấy connection string từ chính TableAdapter
            string connectionString = nhaTro_adapter.Connection.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataRow row in dt.Rows)
                {
                    int maNha = (int)row["MaNha"];

                     //GỌI FUNCTION SQL ĐỂ LẤY ĐƯỜNG DẪN ẢNH ĐẠI DIỆN
                    string urlAnh = LayAnhDaiDien_NhaTro(conn, maNha);

                    // Tạo DTO (nhớ là DTO phải có thêm thuộc tính/param ảnh)
                    var dto = new NhaTroDTO(
                        maNha,
                        row["TenNha"].ToString(),
                        row["DiaChi"].ToString(),
                        row["NguoiQuanLy"] == DBNull.Value ? 0 : (int)row["NguoiQuanLy"],
                        row["GhiChu"].ToString(),
                        urlAnh            
                    );

                    list.Add(dto);
                }
            }

            return list;
        }

        // Hàm private gọi fn_LayAnhDaiDien_NhaTro trong SQL
        private string LayAnhDaiDien_NhaTro(SqlConnection conn, int maNha)
        {
            using (SqlCommand cmd = new SqlCommand(
                "SELECT dbo.fn_LayAnhDaiDien_NhaTro(@MaNha)", conn))
            {
                cmd.Parameters.AddWithValue("@MaNha", maNha);

                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    return result.ToString();

                return "";   //Không có ảnh thì trả chuỗi rỗng
            }
        }

        public bool Add(NhaTroDTO NhaTro)
        {
            try
            {
                nhaTro.Insert(NhaTro.TenNha
                    , NhaTro.DiaChi
                    , NhaTro.NguoiQuanLy
                    , NhaTro.GhiChu);
                if (!string.IsNullOrEmpty(NhaTro.AnhDaiDien))
                {

                    images.InsertImage(NhaTro.AnhDaiDien, (LayNhaTro().Last().MaNha) , true);
                }
                return true;
            }catch(SqlException ex)
            {
                throw new Exception("Lỗi CSDL: " + ex.Message, ex);
            }
        }

        public bool delete(int id)
        {
            try
            {
                nhaTro.Delete1(id);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL: " + ex.Message, ex);
            }
        }

        public bool update(NhaTroDTO dayNha)
        {
            try
            {
                nhaTro.Update1(dayNha.TenNha
                    , dayNha.DiaChi
                    , dayNha.NguoiQuanLy
                    , dayNha.GhiChu,
                    dayNha.MaNha);
                images.UpdateQuery(dayNha.AnhDaiDien, dayNha.MaNha);
                return true;
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi CSDL: " + ex.Message, ex);
            }
        }
    }

}
