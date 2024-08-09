using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ETMarca
    {
        private int _IDMarca;
        private string _Nombre;
        private bool _Estado;

        public int IDMarca { get => _IDMarca; set => _IDMarca = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}
