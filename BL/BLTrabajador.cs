﻿using System;
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

        public static string ActualizarTR(string cTexto, int nOpcion, int IDTrabajador, ETTrabajador tr)
        {

            DALTrabajador Datos = new DALTrabajador();
            return Datos.ActualizarTrabajador(cTexto, nOpcion, IDTrabajador, tr);
        }

        public static string EliminaTR(int IDTrabajador)
        {

            DALTrabajador Datos = new DALTrabajador(); ;
            return Datos.EliminaTrabajador(IDTrabajador);
        }
    }
}
