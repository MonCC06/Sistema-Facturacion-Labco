using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using System.Globalization;

namespace DAL
{
    public class DALCliente
    {
        public DataTable ListadoCliente(string cTexto)
        {
            // Este método devuelve un DataTable que contiene el listado de clientes que coinciden con un texto específico.
            // Utiliza un procedimiento almacenado llamado "USP_Listado_Cliente" y pasa un parámetro @cTexto.
            // Realiza una conexión a la base de datos, ejecuta el procedimiento almacenado y carga los resultados en un DataTable.
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand Comando = new SqlCommand("USP_Listado_cli", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto; // Agrega el parámetro de búsqueda
                SqlCon.Open(); // Abre la conexión a la base de datos
                Resultado = Comando.ExecuteReader(); // Ejecuta el procedimiento y obtiene un DataReader con los resultados
                Tabla.Load(Resultado); // Carga los resultados en un DataTable

                return Tabla; // Devuelve el DataTable con los clientes encontrados
            }
            catch (Exception ex)
            {
                throw ex; // Lanza la excepción en caso de error
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); // Cierra la conexión si está abierta
            }
        }

        public string GuardarCliente(int nOpcion, ETCliente cl)
        {
            // Este método guarda la información de un cliente en la base de datos.
            // Utiliza un procedimiento almacenado llamado "USP_Guardar_Cliente" y recibe los datos del cliente encapsulados en un objeto ETCliente.
            // Según el valor de nOpcion, puede insertar o actualizar un registro de cliente.
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand comando = new SqlCommand("USP_Guardar_Cli", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion; // Parámetro para especificar la operación (insertar o actualizar)
                comando.Parameters.Add("@IDCliente", SqlDbType.Int).Value = cl.IDCliente;
                comando.Parameters.Add("@Nombre_cli", SqlDbType.VarChar).Value = cl.Nombre;
                comando.Parameters.Add("@Cedula_cli", SqlDbType.VarChar).Value = cl.Cedula;
                comando.Parameters.Add("@Correo_cli", SqlDbType.VarChar).Value = cl.Correo;
                comando.Parameters.Add("@Telefono_cli", SqlDbType.VarChar).Value = cl.Telefono;
               

                SqlCon.Open(); // Abre la conexión a la base de datos
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se logró registrar el dato"; // Ejecuta el procedimiento y verifica el resultado

            }
            catch (Exception ex)
            {
                Rpta = ex.Message; // Captura y guarda el mensaje de error
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); // Cierra la conexión si está abierta
            }
            return Rpta; // Devuelve el resultado de la operación
        }

        public string EliminaCliente(int IDCliente)
        {
            // Este método elimina un cliente de la base de datos.
            // Utiliza un procedimiento almacenado llamado "USP_Eliminar_Cliente" y recibe el ID del cliente a eliminar.
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand comando = new SqlCommand("USP_Eliminar_Cliente", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IDCliente", SqlDbType.Int).Value = IDCliente; // Parámetro con el ID del cliente a eliminar

                SqlCon.Open(); // Abre la conexión a la base de datos
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se logró eliminar el dato"; // Ejecuta el procedimiento y verifica el resultado

            }
            catch (Exception ex)
            {
                Rpta = ex.Message; // Captura y guarda el mensaje de error
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); // Cierra la conexión si está abierta
            }
            return Rpta; // Devuelve el resultado de la operación
        }

        public string ActualizarCliente(string cTexto, int nOpcion, int IDCliente, ETCliente cl)
        {
            // Este método actualiza la información de un cliente en la base de datos.
            // Primero, busca un cliente específico usando el texto proporcionado (cTexto).
            // Si encuentra el cliente, elimina al cliente actual y guarda los nuevos datos del cliente.
            // Utiliza los métodos ListadoCliente, EliminaCliente y GuardarCliente para realizar estas operaciones.
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand Comando = new SqlCommand("USP_Listado_cli", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto; // Parámetro con el texto de búsqueda
                SqlCon.Open(); // Abre la conexión a la base de datos
                SqlDataReader reader = Comando.ExecuteReader(); // Ejecuta el procedimiento y obtiene un DataReader con los resultados

                if (reader.Read()) // Verifica si se encontraron resultados
                {
                    string ClienteEncontrado = Convert.ToString(reader[cTexto]);
                    if (ClienteEncontrado != cTexto)
                    {
                        Rpta = "Los datos ingresados no coinciden"; // Verifica si los datos coinciden
                    }
                    else
                    {
                        string RptaEliminar = EliminaCliente(IDCliente); // Intenta eliminar el cliente actual
                        if (RptaEliminar != "OK")
                        {
                            Rpta = RptaEliminar; // Si no se puede eliminar, guarda el error
                        }
                        else
                        {
                            string RptaAgregar = GuardarCliente(nOpcion, cl); // Guarda los nuevos datos del cliente
                            Rpta = RptaAgregar; // Devuelve el resultado de la operación de guardado
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Rpta = ex.Message; // Captura y guarda el mensaje de error
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); // Cierra la conexión si está abierta
            }
            return Rpta; // Devuelve el resultado de la operación
        }

    }
}