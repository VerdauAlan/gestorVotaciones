using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorVotaciones_server
{
    internal class ConectarBD
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "jorgitoexclusivo";
        private string user = "root";
        private string password = "password";
        private string cadenaConexion;


        public ConectarBD()
        {
            cadenaConexion = "Database=" + database +
                "; DataSource=" + server +
                "; User Id= " + user +
                "; Password=" + password;
        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }

            return conexion;
        }
    }
}
