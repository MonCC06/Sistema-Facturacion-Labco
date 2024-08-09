using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLFactura
    {
        public static DataTable ListadoFA(string cTexto)
        {

            DALFactura Datos = new DALFactura();
            return Datos.ListadoFA(cTexto);
        }

        public static string GuardarFA(int nOpcion, ETFactura fa)
        {

            DALFactura Datos = new DALFactura();
            return Datos.GuardarFA(nOpcion, fa);
        }

        public static string ActualizarCL(int IDDetalle)
        {

            DALFactura Datos = new DALFactura();
            return Datos.ActualizarDE(IDDetalle);
        }

        public static string EliminarDE(int IDDetalle)
        {

            DALFactura Datos = new DALFactura();
            return Datos.EliminaDE(IDDetalle);
        }
    }
}
