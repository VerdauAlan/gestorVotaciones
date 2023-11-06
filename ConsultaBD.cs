using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestorVotaciones_server
{
    internal class ConsultaBD
    {
        public bool iniciarSesion(String email, String contrasenia)
        {
            try
            {
                ArrayList result = new ArrayList();
                ConectarBD conectarBD = new ConectarBD();
                MySqlDataReader mySqlDataReader = null;
                string consulta = "SELECT * FROM usuario WHERE email = '" + email + "' AND contrasenia = '" + contrasenia + "'";


                if (conectarBD.getConexion() != null)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = conectarBD.getConexion();
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        result.Add(mySqlDataReader.GetString("nombre"));
                    }
                }
                if (result.Count >= 1)
                {
                    return true;
                }
                return false; ;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string iniciarSesion_obtenerDNI(String email, String contrasenia)
        {
            try
            {
                String result = "";
                ConectarBD conectarBD = new ConectarBD();
                MySqlDataReader mySqlDataReader = null;
                string consulta = "SELECT DNI FROM usuario WHERE email = '" + email + "' AND contrasenia = '" + contrasenia + "'";


                if (conectarBD.getConexion() != null)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = conectarBD.getConexion();
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        result = (mySqlDataReader.GetString("nombre"));
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public bool registrarse(String email, String contrasenia, String DNI, String nombre, String apellido)
        {
            try
            {
                ConectarBD conectarBD = new ConectarBD();
                MySqlDataReader mySqlDataReader = null;
                string consulta = "INSERT INTO usuario (`DNI`, `nombre`, `apellido`, `email`, `contrasenia`) VALUES '"+DNI+"' ,'"+nombre+"' ,'"+apellido+"' ,'"+email+"' ,'"+contrasenia+"'";


                if (conectarBD.getConexion() != null)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = conectarBD.getConexion();
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    return true;
                }
                return false;
                    
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool crearVoto(String titulo, String tematica, String fechaInicio, String fechaFin, String descripcion){
            try
            {
                ConectarBD conectarBD = new ConectarBD();
                MySqlDataReader mySqlDataReader = null;
                string consulta = "INSERT INTO voto (`titulo`, `tematica`, `fechaInicio`, `fechaFin`, `Descripción`)  VALUES ('" + titulo + "', '" + tematica + "', '" + fechaInicio + "', '" + fechaFin + "', '" + descripcion + "')";


                if (conectarBD.getConexion() != null)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = conectarBD.getConexion();
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
