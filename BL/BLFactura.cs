using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;

namespace BL
{
    public class BLFactura
    {
        public static DataTable ListadoFA(string cTexto)
        {

            DALFactura Datos = new DALFactura();
            return Datos.ListadoFactura(cTexto);
        }

        public static string GuardarFA(int nOpcion, ETFactura fa)
        {

            DALFactura Datos = new DALFactura();
            return Datos.GuardarFactura(nOpcion, fa);
        }

        public static string ActualizarFA(string cTexto, int nOpcion, int IDFactura, ETFactura fa)
        {

            DALFactura Datos = new DALFactura();
            return Datos.ActualizarFactura(cTexto, nOpcion, IDFactura, fa);
        }

        public static string EliminarFA(int IDFactura)
        {

            DALFactura Datos = new DALFactura();
            return Datos.EliminaFactura(IDFactura);
        }
    }
}
