using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kafe.DAL1;
using System.Data;

namespace Kafe.BL1
{
    public class SiparisBL
    {
        SiparisDAL dal =
           new SiparisDAL();

        public void SiparisEkle(
            int musteriID,
            int urunID,
            DateTime tarih,
            float toplam)
        {
            dal.SiparisEkle(
                musteriID,
                urunID,
                tarih,
                toplam);
        }

        public DataTable TumSiparisler()
        {
            return dal.TumSiparisler();
        }

        public int SonSiparisID()
        {
            return dal.SonSiparisID();
        }

        public void SiparisDetayEkle(
            int siparisID,
            int urunID)
        {
            dal.SiparisDetayEkle(
                siparisID,
                urunID);
        }
    }
}
