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
            return Datos.ListadoTrabajador(cTexto);
        }

        public static string GuardarTR(int nOpcion, ETTrabajador tr)
        {

            DALTrabajador Datos = new DALTrabajador();
            return Datos.GuardarTrabajador(nOpcion, tr);
        }

        public static string ActualizarTR(int IDServicio)
        {

            DALTrabajador Datos = new DALTrabajador();
            return Datos.ActualizarTrabajador(IDServicio);
        }

        public static string EliminaTR(int IDServicio)
        {

            DALTrabajador Datos = new DALTrabajador(); ;
            return Datos.EliminaTrabajador(IDServicio);
        }
    }
}
