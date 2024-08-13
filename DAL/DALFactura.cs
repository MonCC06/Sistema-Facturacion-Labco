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

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();


            try
            {
                SQLCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Factura", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SQLCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);


                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SQLCon.State == ConnectionState.Open) SQLCon.Close();
            }
        }

        public string GuardarFactura(int nOpcion, ETFactura fa)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_Factura", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@IDFactura", SqlDbType.Int).Value = fa.IDFactura;
                comando.Parameters.Add("@IDTrabajador", SqlDbType.VarChar).Value = fa.IDTrabajador;
                comando.Parameters.Add("@IDCliente", SqlDbType.VarChar).Value = fa.IDCliente;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = fa.Estado;
                comando.Parameters.Add("@Total", SqlDbType.VarChar).Value = fa.Total;
                comando.Parameters.Add("@SubTotal", SqlDbType.VarChar).Value = fa.Subtotal;
                comando.Parameters.Add("@Iva", SqlDbType.VarChar).Value = fa.Iva;
                comando.Parameters.Add("@Descuento", SqlDbType.VarChar).Value = fa.Descuento;
                comando.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = fa.Fecha;



                SqlCon.Open();
                Rpta = comando.ExecuteNonQuery() >= 1 ? "OK" : "No se logro registrar el dato";


            }

            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string EliminaFactura(int IDFactura)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_Factura", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdFactura", SqlDbType.Int).Value = IDFactura;

                SqlCon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se logro eliminar el dato";


            }

            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
