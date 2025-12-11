using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaTroBLL
    {
        public List<NhaTroDTO_Form_Moi> LayNhaTro()
        {
            DAL.NhaTroDAL nhaTroDAL = new DAL.NhaTroDAL();
            return nhaTroDAL.LayNhaTro();
        }
    }
}
