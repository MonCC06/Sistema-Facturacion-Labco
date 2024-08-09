using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLDetalle
    {
        public static DataTable ListadoDE(string cTexto)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.ListadoDE(cTexto);
        }

        public static string GuardarDE(int nOpcion, ETDetalle de)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.GuardarDE (nOpcion, de);
        }

        public static string ActualizarCL(int IDDetalle)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.ActualizarDE(IDDetalle);
        }

        public static string EliminarDE(int IDDetalle)
        {

            DALDetalle Datos = new DALDetalle();
            return Datos.EliminaDE(IDDetalle);
        }
    }
}
