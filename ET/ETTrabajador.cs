using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    internal class ETTrabajador
    {
        private bool _estado;
        private int _IdTrabajador;
        private string _nombre;
        private string _apellido;
        private string _cedula;
        private string _telefono;
        private string _correo;
        public bool Estado
        {
            get => _estado;
            set => _estado = value;
        }
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }
        public string Cedula
        {
            get => _cedula;
            set => _cedula = value;
        }
        public string Telefono
        {
            get => _telefono;
            set => _telefono = value;
        }
        public string Correo
        {
            get => _correo;
            set => _correo = value;
        }
        public int IdTrabajador { get => _IdTrabajador; set => _IdTrabajador = value; }
    }
}