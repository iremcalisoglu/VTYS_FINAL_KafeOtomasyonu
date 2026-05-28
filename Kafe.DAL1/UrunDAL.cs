using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kafe.DAL1
{
    public class UrunDAL
    {
        public DataTable TumUrunler()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Tum_Urunler",
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

        public void UrunEkle(
            string ad,
            string kategori,
            float fiyat)
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Urun_Ekle",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "ad",
                ad);

            cmd.Parameters.AddWithValue(
                "kategori",
                kategori);

            cmd.Parameters.AddWithValue(
                "fiyat",
                fiyat);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void UrunGuncelle(
            int id,
            string ad,
            string kategori,
            float fiyat)
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Urun_Guncelle",
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
                "kategori",
                kategori);

            cmd.Parameters.AddWithValue(
                "fiyat",
                fiyat);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void UrunSil(int id)
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Urun_Sil",
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

        public DataTable UrunBul(string filtre)
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Urun_Bul",
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

        public DataTable ComboUrunler()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Tum_Urunler",
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
