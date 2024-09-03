using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ETProducto
    {
        private int _IDProducto;
        private string _Descripcion;
        private float _Precio;
        private int _StockActual;
        private bool _Estado;

        public int IDProducto { get => _IDProducto; set => _IDProducto = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public float Precio { get => _Precio; set => _Precio = value; }
        public int StockActual { get => _StockActual; set => _StockActual = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}
