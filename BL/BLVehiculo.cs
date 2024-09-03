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
    public class BLVehiculo
    {
        public static DataTable ListadoVE(string cTexto)
        {

            DALVehiculo Datos = new DALVehiculo();
            return Datos.ListadoVe(cTexto);
        }

        public static string GuardarVE(int nOpcion, ETVehiculo ve)
        {

            DALVehiculo Datos = new DALVehiculo();
            return Datos.GuardarVe(nOpcion, ve);
        }

        public static string ActualizarVE(string cTexto, int nOpcion, int IDVehiculo, ETVehiculo ve)
        {

            DALVehiculo Datos = new DALVehiculo();
            return Datos.ActualizarVe(cTexto, nOpcion, IDVehiculo, ve);
        }

        public static string EliminaVE(int IDVehiculo)
        {

            DALVehiculo Datos = new DALVehiculo(); ;
            return Datos.EliminaVe(IDVehiculo);
        }
    }
}
