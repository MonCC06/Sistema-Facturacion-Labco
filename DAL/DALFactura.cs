using ET;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALFactura
    {
        public DataTable ListadoFactura(string cTexto)
        {
            // Este método devuelve un DataTable con un listado de facturas que coinciden con un texto específico.
            // Utiliza un procedimiento almacenado llamado "USP_Listado_Factura" y pasa un parámetro @cTexto.
            // Realiza una conexión a la base de datos, ejecuta el procedimiento almacenado y carga los resultados en un DataTable.
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand Comando = new SqlCommand("USP_Listado_Factura", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto; // Agrega el parámetro de búsqueda
                SQLCon.Open(); // Abre la conexión a la base de datos
                Resultado = Comando.ExecuteReader(); // Ejecuta el procedimiento y obtiene un DataReader con los resultados
                Tabla.Load(Resultado); // Carga los resultados en un DataTable

                return Tabla; // Devuelve el DataTable con las facturas encontradas
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

        public string GuardarFactura(int nOpcion, ETFactura fa)
        {
            // Este método guarda la información de una factura en la base de datos.
            // Utiliza un procedimiento almacenado llamado "USP_Guardar_Factura" y recibe los datos de la factura encapsulados en un objeto ETFactura.
            // Según el valor de nOpcion, puede insertar o actualizar un registro de factura.
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand comando = new SqlCommand("USP_Guardar_Factura", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion; // Parámetro para especificar la operación (insertar o actualizar)
                comando.Parameters.Add("@IDFactura", SqlDbType.Int).Value = fa.IDFactura;
                comando.Parameters.Add("@IDTrabajador", SqlDbType.VarChar).Value = fa.IDTrabajador;
                comando.Parameters.Add("@IDCliente", SqlDbType.VarChar).Value = fa.IDCliente;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = fa.Estado;
                comando.Parameters.Add("@Total", SqlDbType.VarChar).Value = fa.Total;
                comando.Parameters.Add("@SubTotal", SqlDbType.VarChar).Value = fa.Subtotal;
                comando.Parameters.Add("@Iva", SqlDbType.VarChar).Value = fa.Iva;
                comando.Parameters.Add("@Descuento", SqlDbType.VarChar).Value = fa.Descuento;
                comando.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = fa.Fecha;

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

        public string EliminaFactura(int IDFactura)
        {
            // Este método elimina una factura de la base de datos.
            // Utiliza un procedimiento almacenado llamado "USP_Eliminar_Factura" y recibe el ID de la factura a eliminar.
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand comando = new SqlCommand("USP_Eliminar_Factura", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdFactura", SqlDbType.Int).Value = IDFactura; // Parámetro con el ID de la factura a eliminar

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

        public string ActualizarFactura(string cTexto, int nOpcion, int IDFactura, ETFactura fa)
        {
            // Este método actualiza la información de una factura en la base de datos.
            // Primero, busca una factura específica usando el texto proporcionado (cTexto).
            // Si encuentra la factura, elimina la factura actual y guarda los nuevos datos de la factura.
            // Utiliza los métodos ListadoFactura, EliminaFactura y GuardarFactura para realizar estas operaciones.
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion(); // Obtiene la instancia de conexión a la base de datos
                SqlCommand Comando = new SqlCommand("USP_Listado_Factura", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto; // Parámetro con el texto de búsqueda
                SqlCon.Open(); // Abre la conexión a la base de datos
                SqlDataReader reader = Comando.ExecuteReader(); // Ejecuta el procedimiento y obtiene un DataReader con los resultados

                if (reader.Read()) // Verifica si se encontraron resultados
                {
                    string FacturaEncontrada = Convert.ToString(reader[cTexto]);
                    if (FacturaEncontrada != cTexto)
                    {
                        Rpta = "Los datos ingresados no coinciden"; // Verifica si los datos coinciden
                    }
                    else
                    {
                        string RptaEliminar = EliminaFactura(IDFactura); // Intenta eliminar la factura actual
                        if (RptaEliminar != "OK")
                        {
                            Rpta = RptaEliminar; // Si no se puede eliminar, guarda el error
                        }
                        else
                        {
                            string RptaAgregar = GuardarFactura(nOpcion, fa); // Guarda los nuevos datos de la factura
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
