﻿using System;
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

            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Cliente",SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value=cTexto;
                SqlCon.Open();
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
                if(SqlCon.State==ConnectionState.Open)SqlCon.Close();
            }
        }

        public string GuardarCliente(int nOpcion, ETCliente cl)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Guardar_Cliente", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion;
                comando.Parameters.Add("@IDCliente", SqlDbType.Int).Value = cl.IDCliente;
                comando.Parameters.Add("@cNombre_cl", SqlDbType.VarChar).Value = cl.Nombre;
                comando.Parameters.Add("@cCedula_cl", SqlDbType.VarChar).Value = cl.Cedula;
                comando.Parameters.Add("@cCorreo_cl", SqlDbType.VarChar).Value = cl.Correo;
                comando.Parameters.Add("@cTelefono_cl", SqlDbType.VarChar).Value = cl.Telefono;
                comando.Parameters.Add("@Estado", SqlDbType.Bit).Value = cl.Estado;


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

        public string EliminaCliente(int IDCliente)
        {

            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();


            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("USP_Eliminar_Cliente", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IDCliente", SqlDbType.Int).Value = IDCliente;

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

        public string ActualizarCliente(string cTexto,int nOpcion, int IDCliente, ETCliente cl)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            
            try
            {
                SqlCon = Conexion.GetInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_Cliente", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                SqlDataReader reader = Comando.ExecuteReader();

                if (reader.Read()) 
                {
                    string ClienteEncontrado = Convert.ToString(reader[cTexto]);
                    if (ClienteEncontrado != cTexto)
                    {
                        Rpta = "Los datos ingresados no coinciden";
                    }
                    else 
                    {
                        string RptaEliminar = EliminaCliente(IDCliente);
                        if (RptaEliminar != "OK")
                        {
                            Rpta = RptaEliminar;
                        }
                        else
                        {
                            string RptaAgregar = GuardarCliente(nOpcion, cl);
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
