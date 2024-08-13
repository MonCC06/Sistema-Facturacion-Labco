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
    internal class BLStockDetalle
    {
        public static DataTable ListadoSD(string cTexto)
        {

            DALCliente Datos = new DALCliente();
            return Datos.ListadoSD(cTexto);
        }

        public static string GuardarSD(int nOpcion, ETStockDetalle sd)
        {

            DALCliente Datos = new DALCliente();
            return Datos.GuardarSD(nOpcion, sd);
        }

        public static string ActualizarSD(int IDProducto)
        {

            DALCliente Datos = new DALCliente();
            return Datos.ActualizarSD(IDProducto);
        }

        public static string EliminarSD(int IDProducto)
        {

            DALCliente Datos = new DALCliente();
            return Datos.EliminarSD(IDProducto);
        }
    }
}
