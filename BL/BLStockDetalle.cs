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

            DALStockDetalle Datos = new DALStockDetalle();
            return Datos.ListadoSd(cTexto);
        }

        public static string GuardarSD(int nOpcion, ETStockDetalle sd)
        {

            DALStockDetalle Datos = new DALStockDetalle();
            return Datos.GuardarSd(nOpcion, sd);
        }

        public static string ActualizarSD(string cTexto, int nOpcion, int IDProducto, ETStockDetalle sd)
        {

            DALStockDetalle Datos = new DALStockDetalle();
            return Datos.ActualizarSd(cTexto, nOpcion, IDProducto, sd);
        }

        public static string EliminarSD(int IDProducto)
        {

            DALStockDetalle Datos = new DALStockDetalle();
            return Datos.EliminarSd(IDProducto);
        }
    }
}
