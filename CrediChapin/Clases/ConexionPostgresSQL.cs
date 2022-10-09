using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CrediChapin.Clases
{
    class ConexionPostgresSQL
    {
        NpgsqlConnection conexion = new NpgsqlConnection();

        static string server = "localhost";
        static string date = "postgres";
        static string user = "postgres";
        static string password = "123456";
        static string puerto = "5432";

        string respuesta = "server=" + server + ";" + "port=" + puerto + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + date + ";";

        public NpgsqlConnection conectar () 
        {
            try
            {
                conexion.ConnectionString = respuesta;
                conexion.Open();
                MessageBox.Show("Se conectar correctamente a la Base de Datos");
            }
            catch(NpgsqlException e) 
            {
                MessageBox.Show("Error no se pudo conectar a la Base de Datos: " + e.ToString());
            }

            return conexion;
        }

    }
}
