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
            return Datos.ListadoPR(cTexto);
        }

        public static string GuardarPR(int nOpcion, ETProducto pr)
        {

            DALProducto Datos = new DALProducto();
            return Datos.GuardarPR(nOpcion, pr);
        }

        public static string ActualizarPR (int IDProducto)
        {

            DALProducto Datos = new DALProducto();
            return Datos.ActualizarPR(IDProducto);
        }

        public static string EliminaPR(int IDProducto)
        {

            DALProducto Datos = new DALProducto(); ;
            return Datos.EliminaPR(IDProducto);
        }

    }
}
