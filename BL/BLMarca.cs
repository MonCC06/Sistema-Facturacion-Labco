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
    public class BLMarca
    {
        public static DataTable ListadoMA(string cTexto)
        {

            DALMarca Datos = new DALMarca();
            return Datos.ListadoMarca(cTexto);
        }

        public static string GuardarMA(int nOpcion, ETMarca ma)
        {

            DALMarca Datos = new DALMarca();
            return Datos.GuardarMarca(nOpcion, ma);
        }

        public static string ActualizarMA(string cTexto, int nOpcion, int IDMarca, ETMarca ma)
        {

            DALMarca Datos = new DALMarca();
            return Datos.ActualizarMarca(cTexto, nOpcion, IDMarca, ma);
        }

        public static string EliminarMA(int IDMarca)
        {

            DALMarca Datos = new DALMarca();
            return Datos.EliminarMarca(IDMarca);
        }
    }
}
