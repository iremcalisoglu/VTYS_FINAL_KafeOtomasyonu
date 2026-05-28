using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kafe.DAL1
{
    public class SiparisDAL
    {
        public void SiparisEkle(
            int musteriID,
            int urunID,
            DateTime tarih,
            float toplam)
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Siparis_Ekle",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "mid",
                musteriID);

            cmd.Parameters.AddWithValue(
                "uid",
                urunID);

            cmd.Parameters.AddWithValue(
                "tarih",
                tarih);

            cmd.Parameters.AddWithValue(
                "fiyat",
                toplam);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public DataTable TumSiparisler()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Tum_Siparisler",
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

        public int SonSiparisID()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Son_Siparis_ID",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            conn.Open();

            int id =
                Convert.ToInt32(
                    cmd.ExecuteScalar());

            conn.Close();

            return id;
        }

        public void SiparisDetayEkle(
    int siparisID,
    int urunID)
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "SiparisDetay_Ekle",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "sid",
                siparisID);

            cmd.Parameters.AddWithValue(
                "uid",
                urunID);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
