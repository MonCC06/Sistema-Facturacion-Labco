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
    public class DALServicio
    {
        public DataTable ListadoServicio(string cTexto)
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();


            try
            {
                SQLCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Servicio", SQLCon);
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

        public string GuardarServicio(int nOpcion, ETServicio se)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_Servicio", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@IDServicio", SqlDbType.Int).Value = se.IDServicio;
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = se.Descripcion;
                comando.Parameters.Add("@Monto", SqlDbType.VarChar).Value = se.Monto;
               

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

        public string EliminaCliente(int IdCliente)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_Cliente", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = IdCliente;

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
