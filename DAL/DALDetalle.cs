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

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();


            try
            {
                SQLCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Detalle", SQLCon);
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

        public string GuardarDetalle(int nOpcion, ETDetalle de)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_Detalle", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@IDDetalle", SqlDbType.Int).Value = de.IDDetalle;
                comando.Parameters.Add("@IDServicio", SqlDbType.Int).Value = de.IDServicio;
                comando.Parameters.Add("@IDProducto", SqlDbType.Int).Value = de.IDProducto;
                comando.Parameters.Add("@nMonto", SqlDbType.Decimal).Value = de.Monto;
                comando.Parameters.Add("@nCantidad", SqlDbType.Int).Value = de.Cantidad;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = de.Estado;



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

        public string EliminaDetalle(int IDDetalle)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_Detalle", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IDDetalle", SqlDbType.Int).Value = IDDetalle;

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

        public string ActualizarDetalle(string cTexto, int nOpcion, int IDDetalle, ETDetalle de)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Detalle", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                SqlDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    string DetalleEncontrado = Convert.ToString(reader[cTexto]);
                    if (DetalleEncontrado != cTexto)
                    {
                        Rpta = "Los datos ingresados no coinciden";
                    }
                    else
                    {
                        string RptaEliminar = EliminaDetalle(IDDetalle);
                        if (RptaEliminar != "OK")
                        {
                            Rpta = RptaEliminar;
                        }
                        else
                        {
                            string RptaAgregar = GuardarDetalle(nOpcion, de);
                        }
                    }
                }
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
