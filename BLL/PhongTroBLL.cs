using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class PhongTroBLL : ConnectionBLL
    {
        public List<PhongTroDTO> getListByHostel(int id)
        {
            return phongTroDAL.getList().Where(t => t.HostelID == id).ToList();
        }
    }
}