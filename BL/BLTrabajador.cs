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
    public class BLTrabajador
    {
        public static DataTable ListadoTR(string cTexto)
        {

            DALTrabajador Datos = new DALTrabajador();
            return Datos.ListadoTR(cTexto);
        }

        public static string GuardarSE(int nOpcion, ETTrabajador tr)
        {

            DALTrabajador Datos = new DALTrabajador();
            return Datos.GuardarTR(nOpcion, tr);
        }

        public static string ActualizarSE(int IDServicio)
        {

            DALTrabajador Datos = new DALTrabajador();
            return Datos.ActualizarSE(IDServicio);
        }

        public static string EliminaSE(int IDServicio)
        {

            DALTrabajador Datos = new DALTrabajador(); ;
            return Datos.EliminaSE(IDServicio);
        }
    }
}
