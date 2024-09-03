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
                SqlCommand Comando = new SqlCommand("USP_Listado_tra", SQLCon);
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
            using (SqlConnection SqlCon = Conexion.GetInstancia().CrearConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand("USP_Guardar_Tra", SqlCon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                    comando.Parameters.Add("@IDTrabajador", SqlDbType.Int).Value = tr.IDTrabajador;
                    comando.Parameters.Add("@Nombre_tra", SqlDbType.VarChar, 50).Value = tr.Nombre;
                    comando.Parameters.Add("@Cedula_tra", SqlDbType.VarChar, 50).Value = tr.Cedula;
                    comando.Parameters.Add("@Correo_tra", SqlDbType.VarChar, 50).Value = tr.Correo;
                    comando.Parameters.Add("@Telefono_tra", SqlDbType.VarChar, 50).Value = tr.Telefono;

                    SqlCon.Open();
                    int result = comando.ExecuteNonQuery();
                    Rpta = result >= 1 ? "OK" : "No se logró registrar el dato";
                }
                catch (Exception ex)
                {
                    Rpta = "Error: " + ex.Message;
                }
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
                comando.Parameters.Add("@IDTrabajador", SqlDbType.Int).Value = IDTrabajador;

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
                SqlCommand Comando = new SqlCommand("USP_Listado_tra", SqlCon);
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
