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
    public class DALProducto
    {
        public DataTable ListadoProducto(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Producto", SQLCon);
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


        public string GuardarProducto(int nOpcion, ETProducto pr)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_Producto", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@IDProducto", SqlDbType.Int).Value = pr.IDProducto;
                comando.Parameters.Add("@cDescripcion_pr", SqlDbType.VarChar).Value = pr.Descripcion    ;
                comando.Parameters.Add("@nPrecio", SqlDbType.Decimal).Value = pr.Precio;
                comando.Parameters.Add("@nStockMin", SqlDbType.Decimal).Value = pr.StockMin;
                comando.Parameters.Add("@nStockMax", SqlDbType.Decimal).Value = pr.StockMax;
                comando.Parameters.Add("@nEstado", SqlDbType.Bit).Value = pr.Estado;


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

        public string EliminaProducto(int IDProducto)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_Producto", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IDProducto", SqlDbType.Int).Value = IDProducto;

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

        public string ActualizarProducto(string cTexto, int nOpcion, int IDProducto, ETProducto pr)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Producto", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                SqlDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    string ProductoEncontrado = Convert.ToString(reader[cTexto]);
                    if (ProductoEncontrado != cTexto)
                    {
                        Rpta = "Los datos ingresados no coinciden";
                    }
                    else
                    {
                        string RptaEliminar = EliminaProducto(IDProducto);
                        if (RptaEliminar != "OK")
                        {
                            Rpta = RptaEliminar;
                        }
                        else
                        {
                            string RptaAgregar = GuardarProducto(nOpcion, pr);
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
