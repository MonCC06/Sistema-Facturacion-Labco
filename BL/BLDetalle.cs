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

        public static string ActualizarCL(string cTexto, int nOpcion, int IDDetalle, ETDetalle de)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.ActualizarDetalle(cTexto, nOpcion, IDDetalle, de);
        }

        public static string EliminarDE(int IDDetalle)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.EliminaDetalle(IDDetalle);
        }
    }
}
