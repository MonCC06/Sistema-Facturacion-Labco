using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class DALDetalle
    {
        public DataTable ListadoDetalle(string cTexto)
        {
            // Este método devuelve un DataTable que contiene un listado de detalles que coinciden con un texto específico.
            // Utiliza un procedimiento almacenado llamado "USP_Listado_Detalle" y pasa un parámetro @cTexto.
            // Realiza una conexión a la base de datos, ejecuta el procedimiento almacenado y carga los resultados en un DataTable.
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand Comando = new SqlCommand("USP_Listado_Detalle", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto; // Agrega el parámetro de búsqueda
                SQLCon.Open(); // Abre la conexión a la base de datos
                Resultado = Comando.ExecuteReader(); // Ejecuta el procedimiento y obtiene un DataReader con los resultados
                Tabla.Load(Resultado); // Carga los resultados en un DataTable

                return Tabla; // Devuelve el DataTable con los detalles encontrados
            }
            catch (Exception ex)
            {
                throw ex; // Lanza la excepción en caso de error
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close(); // Cierra la conexión si está abierta
            }
        }

        public string GuardarDetalle(int nOpcion, ETDetalle de)
        {
            // Este método guarda la información de un detalle en la base de datos.
            // Utiliza un procedimiento almacenado llamado "USP_Guardar_Detalle" y recibe los datos del detalle encapsulados en un objeto ETDetalle.
            // Según el valor de nOpcion, puede insertar o actualizar un registro de detalle.
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand comando = new SqlCommand("USP_Guardar_Detalle", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion; // Parámetro para especificar la operación (insertar o actualizar)
                comando.Parameters.Add("@IDDetalle", SqlDbType.Int).Value = de.IDDetalle;
                comando.Parameters.Add("@IDServicio", SqlDbType.Int).Value = de.IDServicio;
                comando.Parameters.Add("@IDProducto", SqlDbType.Int).Value = de.IDProducto;
                comando.Parameters.Add("@nMonto", SqlDbType.Decimal).Value = de.Monto;
                comando.Parameters.Add("@nCantidad", SqlDbType.Int).Value = de.Cantidad;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = de.Estado;

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

        public string EliminaDetalle(int IDDetalle)
        {
            // Este método elimina un detalle de la base de datos.
            // Utiliza un procedimiento almacenado llamado "USP_Eliminar_Detalle" y recibe el ID del detalle a eliminar.
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand comando = new SqlCommand("USP_Eliminar_Detalle", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IDDetalle", SqlDbType.Int).Value = IDDetalle; // Parámetro con el ID del detalle a eliminar

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

        public string ActualizarDetalle(string cTexto, int nOpcion, int IDDetalle, ETDetalle de)
        {
            // Este método actualiza la información de un detalle en la base de datos.
            // Primero, busca un detalle específico usando el texto proporcionado (cTexto).
            // Si encuentra el detalle, elimina el detalle actual y guarda los nuevos datos del detalle.
            // Utiliza los métodos ListadoDetalle, EliminaDetalle y GuardarDetalle para realizar estas operaciones.
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand Comando = new SqlCommand("USP_Listado_Detalle", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto; // Parámetro con el texto de búsqueda
                SqlCon.Open(); // Abre la conexión a la base de datos
                SqlDataReader reader = Comando.ExecuteReader(); // Ejecuta el procedimiento y obtiene un DataReader con los resultados

                if (reader.Read()) // Verifica si se encontraron resultados
                {
                    string DetalleEncontrado = Convert.ToString(reader[cTexto]);
                    if (DetalleEncontrado != cTexto)
                    {
                        Rpta = "Los datos ingresados no coinciden"; // Verifica si los datos coinciden
                    }
                    else
                    {
                        string RptaEliminar = EliminaDetalle(IDDetalle); // Intenta eliminar el detalle actual
                        if (RptaEliminar != "OK")
                        {
                            Rpta = RptaEliminar; // Si no se puede eliminar, guarda el error
                        }
                        else
                        {
                            string RptaAgregar = GuardarDetalle(nOpcion, de); // Guarda los nuevos datos del detalle
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
