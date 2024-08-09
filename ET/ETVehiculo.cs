using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ETVehiculo
    {
        private int _IDVehiculo;
        private int _IDCliente;
        private int _IDMarca;
        private string _Modelo;
        private string _Anno;
        private string _VIN;
        private string _Placa;
        private bool _TipodeDistancia;
        private float _DistaciaRecorrida;

        public int IDVehiculo { get => _IDVehiculo; set => _IDVehiculo = value; }
        public int IDCliente { get => _IDCliente; set => _IDCliente = value; }
        public int IDMarca { get => _IDMarca; set => _IDMarca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Anno { get => _Anno; set => _Anno = value; }
        public string VIN { get => _VIN; set => _VIN = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public bool TipodeDistancia { get => _TipodeDistancia; set => _TipodeDistancia = value; }
        public float DistaciaRecorrida { get => _DistaciaRecorrida; set => _DistaciaRecorrida = value; }
    }
}
