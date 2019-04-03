using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace AdoDotNet
{
    static class ConnectionJoyeuxAnniversaire
    {
        static private MySqlConnection connection;
        static private string sConnection;

        static ConnectionJoyeuxAnniversaire() {
            sConnection = "user=root;password=siojjr;database=anniversaire;host=localhost";
            connection = new MySqlConnection(sConnection);
        }

        static public MySqlConnection GetConnection(){
            return ConnectionJoyeuxAnniversaire.connection;
        }


    }
}
