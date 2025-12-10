using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class DayNhaBLL : ConnectionBLL
    { 
        //public List<DayNhaDTO> getList()
        //{
        //    return dayNha.GetList();
        //}

        //public List<DayNhaDTO> getListByAdmin()
        //{
        //    UserBLL userBLL = new UserBLL();
        //    return dayNha.GetList().Where(t => t.OwnerID == userBLL.getUserAdminLogin().UserID).ToList();
        //}

        //public List<DayNhaDTO> searchByName(string name)
        //{
        //    List<DayNhaDTO> dayNha = getListByAdmin();
            
        //    if(name == null)
        //    {
        //        return dayNha;
        //    }
            
        //    var filler = dayNha.Where(t => t.HostelName.Contains(name)).ToList();
        //    return filler;
        //}

        //public DayNhaDTO FindByID(int id)
        //{
        //    List<DayNhaDTO> dayNha = getList();
        //    return dayNha.FirstOrDefault(t => t.HostelID == id);
        //}

        //public DayNhaDTO FindByFullInfo(DayNhaDTO d)
        //{
        //    List<DayNhaDTO> dayNha = getList();
        //    return dayNha.FirstOrDefault(t => t.HostelName == d.HostelName
        //        && t.Address == d.Address);
        //}

        //public bool add(DayNhaDTO dn)
        //{
        //    try
        //    {
        //        dayNha.Add(dn); 
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL " + ex.Message, ex);
        //    }
        //}

        //public bool update(DayNhaDTO dn)
        //{
        //    try
        //    {
        //        dayNha.update(dn);
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL " + ex.Message, ex);
        //    }
        //}

        //public bool delete(int id)
        //{
        //    try
        //    {
        //        dayNha.delete(id);
        //        return true;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Exception("Lỗi CSDL " + ex.Message, ex);
        //    }
        //}
    }
}
