
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaTroDAL: DbProcessDAL
    {
        public List<NhaTroDTO_Form_Moi> LayNhaTro()
        {
            var list = new List<NhaTroDTO_Form_Moi>();
            DataTable dt = nhaTro_adapter.GetData();  

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new NhaTroDTO_Form_Moi(
                    (int)row["MaNha"],
                    row["TenNha"].ToString(),
                    row["DiaChi"].ToString(),
                    row["NguoiQuanLy"] == DBNull.Value ? 0 : (int)row["NguoiQuanLy"],
                    row["GhiChu"].ToString()
                ));
            }
            return list;
        }

    }
}
