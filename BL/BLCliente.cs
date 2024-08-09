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
            return Datos.ListadoCL(cTexto);
        }

        public static string GuardarCL (int nOpcion, ETCliente cl)
        {

            DALCliente Datos = new DALCliente();
            return Datos.GuardarCA(nOpcion, cl);
        }

        public static string ActualizarCL(int IDCliente)
        {

            DALCliente Datos = new DALCliente();
            return Datos.ActualizarCL(IDCliente);
        }

        public static string EliminaCL(int IDCliente)
        {

            DALCliente Datos = new DALCliente();
            return Datos.EliminaCL(IDCliente);
        }


    }
}
