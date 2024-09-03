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
    public class DALTrabajador
    {

        public DataTable ListadoTR(string cTexto)
        {

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();


            try
            {
                SQLCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Trabajador", SQLCon);
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

        public string GuardarTR(int nOpcion, ETTrabajador tr)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try 
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_Trabajador", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@cNombre_tr", SqlDbType.VarChar).Value = tr.Nombre;
                comando.Parameters.Add("@cCedula_tr", SqlDbType.VarChar).Value = tr.Cedula;
                comando.Parameters.Add("@cCorreo_tr", SqlDbType.VarChar).Value = tr.Correo;
                comando.Parameters.Add("@cTelefono_tr", SqlDbType.VarChar).Value = tr.Telefono;


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

        public string EliminaTR(int IDTrabajador)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_Trabajador", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdTrabajador", SqlDbType.Int).Value = IDTrabajador;

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

        public string ActualizarTrabajador(string cTexto, int nOpcion, int IDTrabajador, ETTrabajador tr)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Trabajador", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                SqlDataReader reader = Comando.ExecuteReader();

                if (reader.Read())
                {
                    string TrabajadorEncontrado = Convert.ToString(reader[cTexto]);
                    if (TrabajadorEncontrado != cTexto)
                    {
                        Rpta = "Los datos ingresados no coinciden";
                    }
                    else
                    {
                        string RptaEliminar = EliminaTR(IDTrabajador);
                        if (RptaEliminar != "OK")
                        {
                            Rpta = RptaEliminar;
                        }
                        else
                        {
                            string RptaAgregar = GuardarTR(nOpcion, tr);
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
