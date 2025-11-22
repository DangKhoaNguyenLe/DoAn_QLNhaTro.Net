using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class PhongTroDAL : DbProcessDAL
    {
        public List<PhongTroDTO> getList()
        {
            List<PhongTroDTO> phongTros = new List<PhongTroDTO>();
            DataTable dt = room.GetData();

            foreach (DataRow dr in dt.Rows)
            {
                DataNhaTro.ROOMRow ht = dr as DataNhaTro.ROOMRow;
                PhongTroDTO d = new PhongTroDTO(
                    ht.RoomID,
                    ht.HostelID,
                    ht.RoomName,
                    ht.Floor,
                    ht.Area,
                    ht.Capacity,
                    ht.soNguoiDaThue,
                    ht.Price,
                    ht.Deposit,
                    ht.Status);
                phongTros.Add(d);
            }
            return phongTros;
        }
    }
}
