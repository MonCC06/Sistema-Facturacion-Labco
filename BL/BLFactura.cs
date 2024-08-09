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
            return Datos.ListadoFA(cTexto);
        }

        public static string GuardarFA(int nOpcion, ETFactura fa)
        {

            DALFactura Datos = new DALFactura();
            return Datos.GuardarFA(nOpcion, fa);
        }

        public static string ActualizarFA(int IDFactura)
        {

            DALFactura Datos = new DALFactura();
            return Datos.ActualizarFA(IDFactura);
        }

        public static string EliminarFA(int IDFactura)
        {

            DALFactura Datos = new DALFactura();
            return Datos.EliminaRFA(IDFactura);
        }
    }
}
