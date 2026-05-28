using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Kafe.DAL1
{
    public class Veritabani
    {
        public static MySqlConnection Baglanti()
        {
            MySqlConnection conn =
                new MySqlConnection(
                    "Server=localhost;Database=Kafe;Uid=root;Pwd=Karaelmas67+;"
                );

            return conn;
        }
    }
}
