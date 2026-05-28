using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kafe.DAL1;
using System.Threading.Tasks;
using System.Data;

namespace Kafe.BL1
{
    public class MusteriBL
    {
        MusteriDAL dal =
           new MusteriDAL();

        public void MusteriEkle(
            string ad,
            string soyad,
            string tel)
        {
            dal.MusteriEkle(
                ad,
                soyad,
                tel);
        }
        public DataTable TumMusteriler()
        {
            return dal.TumMusteriler();
        }

        public void MusteriGuncelle(int id,string ad,string soyad,string tel)
        {
            dal.MusteriGuncelle(
                id,
                ad,
                soyad,
                tel
            );
        }

        public void MusteriSil(int id)
        {
            dal.MusteriSil(id);
        }

        public DataTable MusteriBul(string filtre)
        {
            return dal.MusteriBul(filtre);
        }

        public DataTable ComboMusteriler()
        {
            return dal.ComboMusteriler();
        }
    }
}
