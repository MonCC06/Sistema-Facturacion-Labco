using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ETFactura
    {
        private int _IDFactura;
        private int _IDDetelle;
        private int _IDTrabajador;
        private int _IDCliente;
        private bool _Estado;
        private float _Total;
        private float _Subtotal;
        private float _Iva;
        private float _Descuento;
        private DateTime _Fecha;

        public int IDFactura { get => _IDFactura; set => _IDFactura = value; }
        public int IDDetalle { get => _IDDetelle; set => _IDDetelle = value; }
        public int IDTrabajador { get => _IDTrabajador; set => _IDTrabajador = value; }
        public int IDCliente { get => _IDCliente; set => _IDCliente = value; }
        public bool Estado { get => _Estado; set => _Estado = value; }
        public float Total { get => _Total; set => _Total = value; }
        public float Subtotal { get => _Subtotal; set => _Subtotal = value; }
        public float Iva { get => _Iva; set => _Iva = value; }
        public float Descuento { get => _Descuento; set => _Descuento = value; }
        public DateTime Fecha { get => _Fecha; set => _Fecha = value; }
    }
}
