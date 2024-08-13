using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ETServicio
    {
        private int _IDServicio;
        private string _Descripcion;
        private float _Monto;
        private bool _Estado;

        public int IDServicio { get => _IDServicio; set => _IDServicio = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public float Monto { get => _Monto; set => _Monto = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}
