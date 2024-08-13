using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ETStockDetalle
    {
        private int _IDProducto;
        private float _StockActual;
        private bool _Estado;

        public int IDProducto { get => _IDProducto; set => _IDProducto = value; }
        public float StockActual { get => _StockActual; set => _StockActual = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
    }
}
