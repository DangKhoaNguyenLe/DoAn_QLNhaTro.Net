using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CocBLL
    {
        private CocDAL dal = new CocDAL();

        public bool ThemDatCoc(CocDTO coc)
        {
            return dal.ThemDatCoc(coc);
        }

        public bool HuyDatCoc(int maPhong)
        {
            return dal.HuyDatCoc(maPhong);
        }




    }
}
