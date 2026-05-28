using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kafe.DAL1;
using System.Data;

namespace Kafe.BL1
{
    public class StokBL
    {
        StokDAL dal =
           new StokDAL();

        public DataTable TumStok()
        {
            return dal.TumStok();
        }

        public void StokGuncelle(
            int urunID,
            int stok)
        {
            dal.StokGuncelle(
                urunID,
                stok);
        }
    }
}
