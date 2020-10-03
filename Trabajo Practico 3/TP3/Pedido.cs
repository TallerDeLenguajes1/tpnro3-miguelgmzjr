using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    class Pedido
    {
        private int nro;
        private string obs;
        private string estado;
        public Cliente cliente;


        public int Nro { get => nro; set => nro = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Estado { get => estado; set => estado = value; }


        public Pedido(int nro, string obs, string estado) //CONSTRUCTOR DE PEDIDO
        {
            this.Nro = nro;
            this.Obs = obs;
            this.Estado = estado;
            Cliente nuevoCliente = new Cliente();
            nuevoCliente = Helper.clienteAleatorio();
            cliente = nuevoCliente;
        }

        public Pedido()
        {

        }

    }
}
