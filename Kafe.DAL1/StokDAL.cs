using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kafe.DAL1
{
    public class StokDAL
    {
        public DataTable TumStok()
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                 new MySqlCommand(
                "Stok_Detay",
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

        public void StokGuncelle(
            int urunID,
            int stok)
        {
            MySqlConnection conn =
                Veritabani.Baglanti();

            MySqlCommand cmd =
                new MySqlCommand(
                    "Stok_Guncelle",
                    conn);

            cmd.CommandType =
                CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue(
                "id",
                urunID);

            cmd.Parameters.AddWithValue(
                "stok",
                stok);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
