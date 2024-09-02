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
    public class DALVehiculo
    {
        public DataTable ListadoVe(string cTexto)
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();


            try
            {
                SQLCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Vehiculo", SQLCon);
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

        public string GuardarVe(int nOpcion, ETVehiculo ve)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_Vehiculo", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@IDVehiculo", SqlDbType.Int).Value = ve.IDVehiculo;
                comando.Parameters.Add("@IDCliente", SqlDbType.Int).Value = ve.IDCliente;
                comando.Parameters.Add("@IDMarca", SqlDbType.Int).Value = ve.IDMarca;
                comando.Parameters.Add("@cModelo", SqlDbType.VarChar).Value = ve.Modelo;
                comando.Parameters.Add("@cAnno", SqlDbType.VarChar).Value = ve.Anno;
                comando.Parameters.Add("@cVIN", SqlDbType.VarChar).Value = ve.VIN;
                comando.Parameters.Add("@cPlaca", SqlDbType.VarChar).Value = ve.Placa;
                comando.Parameters.Add("@TipodeDistancia", SqlDbType.Bit).Value = ve.TipodeDistancia;
                comando.Parameters.Add("@DistanciaRecorrida", SqlDbType.Decimal).Value = ve.DistanciaRecorrida;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = ve.Estado;



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

        public string EliminaVe(int IDVehiculo)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_Vehiculo", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IDVehiculo", SqlDbType.Int).Value = IDVehiculo;

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

        public string ActualizarVe(string cTexto, int nOpcion, int IDVehiculo, ETVehiculo ve)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Vehiculo", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                SqlDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    string VehiculoEncontrado = Convert.ToString(reader[cTexto]);
                    if (VehiculoEncontrado != cTexto)
                    {
                        Rpta = "Los datos ingresados no coinciden";
                    }
                    else
                    {
                        string RptaEliminar = EliminaVe(IDVehiculo);
                        if (RptaEliminar != "OK")
                        {
                            Rpta = RptaEliminar;
                        }
                        else
                        {
                            string RptaAgregar = GuardarVe(nOpcion, ve);
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
