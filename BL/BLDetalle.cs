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
    public class BLDetalle
    {
        public static DataTable ListadoDE(string cTexto)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.ListadoDetalle(cTexto);
        }

        public static string GuardarDE(int nOpcion, ETDetalle de)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.GuardarDetalle(nOpcion, de);
        }

        public static DataTable ActualizarCL(int IDDetalle)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.ActualizarDetalle(IDDetalle);
        }

        public static string EliminarDE(int IDDetalle)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.EliminaDetalle(IDDetalle);
        }
    }
}
