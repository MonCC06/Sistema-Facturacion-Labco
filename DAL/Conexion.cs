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

        //Atributos
        private string _Base;
        private string _Server;
        private bool _Seguridad;
        private static Conexion Con = null;

        //Constructor de la BD
        private Conexion()
        {
            //Nombre de la BD
            this._Base = "";  ///el nombre de la base de datos
            //Nombre Servidor
            this._Server = "EL LINK DEL DISPOSITIVO DE LA BASE DE DATOS"; //Insertar base de datos//
            this._Seguridad = true;

        }

        public SqlConnection CrearConexion()
        {

            SqlConnection cadena = new SqlConnection();

            try
            {
                cadena.ConnectionString = "Server=" + this._Server + ";Database=" + this._Base + ";";

                if (_Seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrate Security=SSPI";
                }
                else
                {
                    
                    //Aca se completaria en caso de ser con usuario y contrasena de SQL
                }

            }
            catch (Exception ex)
            {

                cadena = null;
                throw ex;

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

