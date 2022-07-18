using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyecto.Controller
{
    public abstract class ConnectionToMySQL
    {
        /// <summary>
        /// Conexion a base de datos
        /// </summary>
        private readonly string connectionString;

        public ConnectionToMySQL()
        {
            string server = "localhost";
            //string server = "db4free.net";
            string database = "repues_tos1";
            string username = "root";
            string password = "";
            string port = "3306";
            connectionString = ($"server={server};database={database};username={username};password={password};port={port}");
        
        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

    }
}