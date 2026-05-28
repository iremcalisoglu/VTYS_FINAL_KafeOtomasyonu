using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kafe.DAL1;
using System.Data;

namespace Kafe.BL1
{
    public class OdemeBL
    {
        OdemeDAL dal =
           new OdemeDAL();

        public DataTable TumOdemeler()
        {
            return dal.TumOdemeler();
        }

        public void OdemeEkle(

            int musteriID,

            DateTime tarih,

            float tutar,

            string tur,

            string aciklama
        )
        {
            dal.OdemeEkle(

                musteriID,

                tarih,

                tutar,

                tur,

                aciklama
            );
        }

        public float MusteriBakiye(
            int musteriID)
        {
            return dal.MusteriBakiye(
                musteriID);
        }
    }
}
