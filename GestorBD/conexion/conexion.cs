using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using GestorBD.WF;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace GestorBD.conexion
{
    public class conexion
    {
        WF.Login Login = new WF.Login();
        public string user;
        public string password;      
        

        public MySqlConnection connection = new MySqlConnection();

        private void connect(string cadcon)
        {
            connection = new MySqlConnection(cadcon);

        }

        public conexion(string cadcon)
        {
            connect(cadcon);
        }
         

        public MySqlConnection getCon()
        {
            return connection;
        }
    }
}