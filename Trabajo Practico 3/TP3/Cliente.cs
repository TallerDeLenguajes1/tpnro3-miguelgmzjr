using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    class Cliente
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;
 
        public Cliente()
        {

        }

        public Cliente(int id, string nombre, string direccion, string telefono)
        {
            this.Id1 = id;
            this.Nombre1 = nombre;
            this.Direccion1 = direccion;
            this.Telefono1 = telefono;
        }

        public int Id1 { get => id; set => id = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string Direccion1 { get => direccion; set => direccion = value; }
        public string Telefono1 { get => telefono; set => telefono = value; }
    }
}
