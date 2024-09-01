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
    internal class BLServicio
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

        public static string ActualizarSE(int IDServicio)
        {

            DALServicio Datos = new DALServicio();
            return Datos.ActualizarServicio(IDServicio);
        }

        public static string EliminaSE(int IDServicio)
        {

            DALServicio Datos = new DALServicio(); ;
            return Datos.EliminarServicio(IDServicio);
        }

    }
}
