using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ETTrabajador
    {
        private bool _Estado;
        private int _IDTrabajador;
        private string _Nombre;
        private string _Apellido;
        private string _Cedula;
        private string _Telefono;
        private string _Correo;

        public bool Estado { get => _Estado; set => _Estado = value; }
        public int IDTrabajador { get => _IDTrabajador; set => _IDTrabajador = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
    }
}