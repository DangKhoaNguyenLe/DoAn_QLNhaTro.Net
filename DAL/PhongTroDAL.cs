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
    public class PhongTroDAL : DbProcessDAL
    {
        //public List<PhongTroDTO> getList()
        //{
        //    List<PhongTroDTO> phongTros = new List<PhongTroDTO>();
        //    DataTable dt = room.GetData();

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        DataNhaTro.ROOMRow ht = dr as DataNhaTro.ROOMRow;
        //        PhongTroDTO d = new PhongTroDTO(
        //            ht.RoomID,
        //            ht.HostelID,
        //            ht.RoomName,
        //            ht.Floor,
        //            ht.Area,
        //            ht.Capacity,
        //            ht.soNguoiDaThue,
        //            ht.Price,
        //            ht.Deposit,
        //            ht.Status);
        //        phongTros.Add(d);
        //    }
        //    return phongTros;
        //}

        //public bool Add(PhongTroDTO p)
        //{
        //    try
        //    {
        //        room.Insert(p.HostelID
        //            , p.RoomName
        //            , p.Floor
        //            , p.Area
        //            , p.Capacity
        //            , p.soNguoiDaThue
        //            , p.Price
        //            , p.Deposit
        //            , p.Status);
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL: " + ex.Message, ex);
        //    }
        //}

        //public bool update(PhongTroDTO p)
        //{
        //    try
        //    {
        //        room.UpdateRoom(
        //            p.HostelID
        //            ,p.RoomName
        //            ,p.Floor
        //            ,p.Area
        //            ,p.Capacity
        //            ,p.soNguoiDaThue
        //            ,p.Price
        //            ,p.Deposit
        //            ,p.Status, p.RoomID);
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL: " + ex.Message, ex);
        //    }
        //}

        //public bool delete(int id)
        //{
        //    try
        //    {
        //        room.DeleteRoom(id);
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL: " + ex.Message, ex);
        //    }
        //}
    }
}
