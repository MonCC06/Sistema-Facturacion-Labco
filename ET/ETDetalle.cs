using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ETDetalle
    {
        private int _IDDetalle;
        private int _IDServicio;
        private int _IDProducto;
        private float _Monto;
        private int _Cantidad;
        private bool _Estado;


        public int IDDetalle { get => _IDDetalle; set => _IDDetalle = value; }
        public int IDServicio { get => _IDServicio; set => _IDServicio = value; }
        public int IDProducto { get => _IDProducto; set => _IDProducto = value; }
        public float Monto { get => _Monto; set => _Monto = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}
