using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kafe.DAL1
{
    public class OdemeDAL
    {
        public DataTable TumOdemeler()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Tum_Odemeler",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            MySqlDataAdapter da =
                new MySqlDataAdapter(cmd);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            return dt;
        }

        public void OdemeEkle(

            int musteriID,

            DateTime tarih,

            float tutar,

            string tur,

            string aciklama
        )
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Odeme_Ekle",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "oid",
                0);

            cmd.Parameters.AddWithValue(
                "mid",
                musteriID);

            cmd.Parameters.AddWithValue(
                "tarih",
                tarih);

            cmd.Parameters.AddWithValue(
                "tutar",
                tutar);

            cmd.Parameters.AddWithValue(
                "tur",
                tur);

            cmd.Parameters.AddWithValue(
                "aciklama",
                aciklama);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public float MusteriBakiye(
            int musteriID)
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Musteri_Bakiye",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "id",
                musteriID);

            conn.Open();

            object sonuc =
                cmd.ExecuteScalar();

            conn.Close();

            return Convert.ToSingle(
                sonuc);
        }

    }
}
