using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    internal class ETTrabajador
    {
        private int _IDTrabajador;
        private string _Nombre;
        private string _Cedula;
        private string _Correo;
        private string _Telefono;

        public int IDTrabajador { get => _IDTrabajador; set => _IDTrabajador = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
    }
}
