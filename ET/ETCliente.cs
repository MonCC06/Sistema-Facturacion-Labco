using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ETCliente
    {
        private int _IDCliente;
        private string _Nombre;
        private string _Cedula;
        private string _Correo;
        private string _Telefono;
        private bool _Estado;

        public int IDCliente { get => _IDCliente; set => _IDCliente = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}
