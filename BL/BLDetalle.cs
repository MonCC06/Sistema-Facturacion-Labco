using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    internal class BLDetalle
    {
        public static DataTable ListadoDE(string cTexto)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.ListadoCL(cTexto);
        }

        public static string GuardarCL(int nOpcion, ETCliente ca)
        {

            DALCliente Datos = new DALCliente();
            return Datos.GuardarCA(nOpcion, ca);
        }

        public static string ActualizarCL(int IDCliente)
        {

            DALCliente Datos = new DAL_Cliente();
            return Datos.ActualizarCL(IDCliente);
        }

        public static string EliminaCL(int IDCliente)
        {

            DALCliente Datos = new DAL_Cliente();
            return Datos.EliminaCL(IDCliente);
        }
    }
}
