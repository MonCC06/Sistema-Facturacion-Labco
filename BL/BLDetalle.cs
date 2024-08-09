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

            DALDetalle Datos = new DALDetalle();
            return Datos.GuardarCA(nOpcion, ca);
        }

        public static string ActualizarCL(int IDCliente)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.ActualizarCL(IDCliente);
        }

        public static string EliminaCL(int IDCliente)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.EliminaCL(IDCliente);
        }
    }
}
