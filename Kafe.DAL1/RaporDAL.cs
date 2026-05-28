using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.DAL1
{
    public class RaporDAL
    {
        public float ToplamSiparis()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Siparisler_Toplam",
                    conn);

            cmd.CommandType =
                System.Data.CommandType.StoredProcedure;

            conn.Open();

            object sonuc =
                cmd.ExecuteScalar();

            conn.Close();

            return Convert.ToSingle(
                sonuc);
        }

        public float ToplamOdeme()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Odemeler_Toplam",
                    conn);

            cmd.CommandType =
                System.Data.CommandType.StoredProcedure;

            conn.Open();

            object sonuc =
                cmd.ExecuteScalar();

            conn.Close();

            return Convert.ToSingle(
                sonuc);
        }

        public int ToplamMusteri()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Toplam_Musteri",
                    conn);

            cmd.CommandType =
                System.Data.CommandType.StoredProcedure;

            conn.Open();

            object sonuc =
                cmd.ExecuteScalar();

            conn.Close();

            return Convert.ToInt32(
                sonuc);
        }

        public int ToplamUrun()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Toplam_Urun",
                    conn);

            cmd.CommandType =
                System.Data.CommandType.StoredProcedure;

            conn.Open();

            object sonuc =
                cmd.ExecuteScalar();

            conn.Close();

            return Convert.ToInt32(
                sonuc);
        }

        public float KDVliSiparis()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "KDVli_Siparis",
                    conn);

            cmd.CommandType =
                System.Data.CommandType.StoredProcedure;

            conn.Open();

            object sonuc =
                cmd.ExecuteScalar();

            conn.Close();

            return Convert.ToSingle(
                sonuc);
        }
    }
}
