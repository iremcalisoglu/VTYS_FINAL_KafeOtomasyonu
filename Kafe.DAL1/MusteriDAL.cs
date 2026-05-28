using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kafe.DAL1
{
    public class MusteriDAL
    {
        public void MusteriEkle(
            string ad,
            string soyad,
            string tel)

        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Musteri_Ekle",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "ad",
                ad);

            cmd.Parameters.AddWithValue(
                "soy",
                soyad);

            cmd.Parameters.AddWithValue(
                "tel",
                tel);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

            public DataTable TumMusteriler()
            {
               MySqlConnection conn =
                  Veritabani.Baglanti();

              MySqlCommand cmd =
                new MySqlCommand(
                    "Tum_Musteriler",
                    conn
                );

                cmd.CommandType =
                CommandType.StoredProcedure;

               MySqlDataAdapter da =
                new MySqlDataAdapter(cmd);

               DataTable dt =
                new DataTable();

               da.Fill(dt);

               return dt;



            }
        public void MusteriGuncelle(int id,string ad,string soyad,string tel)
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Musteri_Guncelle",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "id",
                id);

            cmd.Parameters.AddWithValue(
                "ad",
                ad);

            cmd.Parameters.AddWithValue(
                "soy",
                soyad);

            cmd.Parameters.AddWithValue(
                "tel",
                tel);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void MusteriSil(int id)
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Musteri_Sil",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "id",
                id);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable MusteriBul(string filtre)
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Musteri_Bul",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "filtre",
                filtre);

            MySqlDataAdapter da =
                new MySqlDataAdapter(cmd);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            return dt;
        }
        public DataTable ComboMusteriler()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Tum_Musteriler",
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

    }
}
