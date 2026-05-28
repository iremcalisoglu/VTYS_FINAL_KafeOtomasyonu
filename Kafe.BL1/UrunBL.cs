using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kafe.DAL1;
using System.Data;

namespace Kafe.BL1
{
    public class UrunBL
    {
        UrunDAL dal =
           new UrunDAL();

        public DataTable TumUrunler()
        {
            return dal.TumUrunler();
        }

        public void UrunEkle(
            string ad,
            string kategori,
            float fiyat)
        {
            dal.UrunEkle(
                ad,
                kategori,
                fiyat);
        }

        public void UrunGuncelle(
            int id,
            string ad,
            string kategori,
            float fiyat)
        {
            dal.UrunGuncelle(
                id,
                ad,
                kategori,
                fiyat);
        }

        public void UrunSil(int id)
        {
            dal.UrunSil(id);
        }

        public DataTable UrunBul(string filtre)
        {
            return dal.UrunBul(filtre);
        }

        public DataTable ComboUrunler()
        {
            return dal.ComboUrunler();
        }
    }
}
