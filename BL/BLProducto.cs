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
    public class BLProducto
    {
        public static DataTable ListadoPR(string cTexto)
        {

            DALProducto Datos = new DALProducto();
            return Datos.ListadoProducto(cTexto);
        }

        public static string GuardarPR(int nOpcion, ETProducto pr)
        {

            DALProducto Datos = new DALProducto();
            return Datos.GuardarProducto(nOpcion, pr);
        }

        public static string ActualizarPR (string cTexto, int nOpcion, int IDProducto, ETProducto pr)
        {

            DALProducto Datos = new DALProducto();
            return Datos.ActualizarProducto(cTexto, nOpcion, IDProducto, pr);
        }

        public static string EliminaPR(int IDProducto)
        {

            DALProducto Datos = new DALProducto(); ;
            return Datos.EliminaProducto(IDProducto);
        }

    }
}
