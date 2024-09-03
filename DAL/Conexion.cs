using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexion
    {

        private string _Base;
        private string _Server;
        private bool _Seguridad;
        private static Conexion Con = null;

        // Constructor de la BD
        private Conexion()
        {
            // Nombre de la BD
            this._Base = "LABCO BD";  // Nombre de la base de datos
            // Nombre Servidor
            this._Server = "Monse\\SQLEXPRESS"; // Nombre del servidor
            this._Seguridad = true;  // Cambiar a true si usas seguridad integrada
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();

            try
            {
                // Base de la cadena de conexión
                cadena.ConnectionString = $"Server={this._Server};Database={this._Base};";

                if (_Seguridad)
                {
                    // Seguridad integrada
                    cadena.ConnectionString += "Integrated Security=True;";
                }
                else
                {
                    // Ejemplo con usuario y contraseña
                    cadena.ConnectionString += "User Id=tuUsuario;Password=tuContraseña;";
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw new Exception("Error al crear la conexión: " + ex.Message);
            }

            return cadena;
        }

        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}