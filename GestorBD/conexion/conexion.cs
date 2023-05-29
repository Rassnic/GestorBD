using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace GestorBD.conexion
{
    public class conexion
    {
        private string con = "Server=127.0.0.1;Port=3306;Database=ejemplo;Uid=root;password=123456";
        public MySqlConnection connection = new MySqlConnection();

        private void connect()
        {
            connection = new MySqlConnection(con);

        }

        public conexion()
        {
            connect();
        }
         

        public MySqlConnection getCon()
        {
            return connection;
        }
    }
}