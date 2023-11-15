using System;
using MySql.Data.MySqlClient;

namespace proyecto
{
    class conex
    {
        private MySqlConnection conexion;
        private string server = "127.0.0.1";
        private string database = "dominico";
        private string user = "root";
        private string password = "";
        private string port = "3306";

        private string cConex;

        public conex()
        {
            cConex = $"server={server}; port={port}; user={user}; password={password}; database={database};";
        }

        public MySqlConnection GetConnection()
        {
            if (conexion == null)
            {
                try
                {
                    conexion = new MySqlConnection(cConex);
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                }
            }
            return conexion;
        }

        public void CloseConnection()
        {
            if (conexion != null)
            {
                conexion.Close();
                conexion = null;
            }
        }
    }
}
