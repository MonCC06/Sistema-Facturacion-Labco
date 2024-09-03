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
    public class BLServicio
    {
        public static DataTable ListadoSE(string cTexto)
        {

            DALServicio Datos = new DALServicio();
            return Datos.ListadoServicio(cTexto);
        }

        public static string GuardarSE(int nOpcion, ETServicio se)
        {

            DALServicio Datos = new DALServicio();
            return Datos.GuardarServicio(nOpcion, se);
        }

        public static string ActualizarSE(string cTexto, int nOpcion, int IDServicio, ETServicio se)
        {

            DALServicio Datos = new DALServicio();
            return Datos.ActualizarServicio(cTexto, nOpcion, IDServicio, se);
        }

        public static string EliminaSE(int IDServicio)
        {

            DALServicio Datos = new DALServicio(); ;
            return Datos.EliminarServicio(IDServicio);
        }

    }
}
