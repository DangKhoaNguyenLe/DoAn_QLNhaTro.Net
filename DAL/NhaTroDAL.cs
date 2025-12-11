using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;   // THÊM USING NÀY
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaTroDAL : DbProcessDAL
    {
        public List<NhaTroDTO_Form_Moi> LayNhaTro()
        {
            var list = new List<NhaTroDTO_Form_Moi>();

            // Lấy dữ liệu nhà trọ bằng TableAdapter (như cũ)
            DataTable dt = nhaTro_adapter.GetData();

            // Lấy connection string từ chính TableAdapter
            string connectionString = nhaTro_adapter.Connection.ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataRow row in dt.Rows)
                {
                    int maNha = (int)row["MaNha"];

                    // GỌI FUNCTION SQL ĐỂ LẤY ĐƯỜNG DẪN ẢNH ĐẠI DIỆN
                    string urlAnh = LayAnhDaiDien_NhaTro(conn, maNha);

                    // Tạo DTO (nhớ là DTO phải có thêm thuộc tính/param ảnh)
                    var dto = new NhaTroDTO_Form_Moi(
                        maNha,
                        row["TenNha"].ToString(),
                        row["DiaChi"].ToString(),
                        row["NguoiQuanLy"] == DBNull.Value ? 0 : (int)row["NguoiQuanLy"],
                        row["GhiChu"].ToString(),
                        urlAnh           // đường dẫn ảnh lấy từ function
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

                return "";  // Không có ảnh thì trả chuỗi rỗng
            }
        }
    }
}
