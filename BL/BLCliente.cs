using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BL
{
    public class BLCliente
    {
        public static DataTable ListadoCL (string cTexto)
        {

            DALCliente Datos = new DALCliente();
            return Datos.ListadoCliente(cTexto);
        }

        public static string GuardarCL (int nOpcion, ETCliente cl)
        {
            DALCliente Datos = new DALCliente();
            return Datos.GuardarCliente(nOpcion, cl);
        }

        public static string ActualizarCL(string cTexto,int nOpcion, int IDCliente, ETCliente cl)
        {
            DALCliente Datos = new DALCliente();
            return Datos.ActualizarCliente(cTexto, IDCliente, nOpcion, cl);
        }

        public static string EliminaCL(int IDCliente)
        {

            DALCliente Datos = new DALCliente();
            return Datos.EliminaCliente(IDCliente);
        }


    }
}
