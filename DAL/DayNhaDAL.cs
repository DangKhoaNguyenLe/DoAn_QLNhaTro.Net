using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DayNhaDAL : DbProcessDAL
    {
        //public List<DayNhaDTO> GetList()
        //{
        //    List<DayNhaDTO> daynhas = new List<DayNhaDTO>();
        //    DataTable dt = hostel.GetData();

        //    foreach(DataRow dr in dt.Rows)
        //    {
        //        DataNhaTro.HOSTELRow ht = dr as DataNhaTro.HOSTELRow;
        //        DayNhaDTO d = new DayNhaDTO(
        //            ht.HostelID,
        //            ht.HostelName,
        //            ht.Address,
        //            ht.Description,
        //            ht.OwnerID);
        //        daynhas.Add(d);
        //    }
        //    return daynhas;
        //}

        //public bool Add(DayNhaDTO dayNha)
        //{
        //    try
        //    {
        //        hostel.Insert(dayNha.HostelName
        //            , dayNha.Address
        //            , dayNha.Description
        //            , dayNha.OwnerID);
        //        return true;
        //    }catch(SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL: " + ex.Message, ex);
        //    }
        //}

        //public bool delete(int id)
        //{
        //    try
        //    {
        //        hostel.deleteDayNha(id);
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL: " + ex.Message, ex);
        //    }
        //}

        //public bool update(DayNhaDTO dayNha)
        //{
        //    try
        //    {
        //        hostel.UpdateDayNha(dayNha.HostelName
        //            , dayNha.Address
        //            , dayNha.Description
        //            , dayNha.HostelID);
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL: " + ex.Message, ex);
        //    }
        //}
    }
}
