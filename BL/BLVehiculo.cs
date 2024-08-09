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
    internal class BLVehiculo
    {
        public static DataTable ListadoVE(string cTexto)
        {

            DALVehiculo Datos = new DALVehiculo();
            return Datos.ListadoVE(cTexto);
        }

        public static string GuardarVE(int nOpcion, ETVehiculo ve)
        {

            DALVehiculo Datos = new DALVehiculo();
            return Datos.GuardarVE (nOpcion, ve);
        }

        public static string ActualizarVE(int IDVehiculo)
        {

            DALVehiculo Datos = new DALVehiculo();
            return Datos.ActualizarVE(IDVehiculo);
        }

        public static string EliminaVE(int IDVehiculo)
        {

            DALVehiculo Datos = new DALVehiculo(); ;
            return Datos.EliminaVE(IDVehiculo);
        }
    }
}
