using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    internal class ETMarca
    {
        private int _IDMarca;
        private string _Name;
        private bool _Estado;

        public int IDMarca { get => _IDMarca; set => _IDMarca = value; }
        public string Name { get => _Name; set => _Name = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}
