using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    class Helper
    {
        public static int cadeteID = 1;
        public static int clienteID = 1;
        public static int nro = 1;
        static Random aleatorio = new Random();

        public static string[] Nombres = { "Miguel", "Juan", "Carlos", "Angel", "Diego" };
        public static string[] Apellidos = { "Gomez", "Santillan", "Gonzalez", "Contreras", "Paez" };
        public static string[] Estado = { "Entregado", "Pendiente" };


        public static Cliente clienteAleatorio()
        {
            Cliente nuevoCliente = new Cliente(clienteID, Nombres[aleatorio.Next(0,5)] + " " + Apellidos[aleatorio.Next(0,5)], "Direccion Casa", "381123456");
            clienteID++;
            return nuevoCliente;
        }




        public static Pedido pedidoAleatorio()
        {
            Pedido nuevoPedido = new Pedido(nro, "Observaciones", Estado[aleatorio.Next(0,2)]);
            nro++;
            return nuevoPedido;
        }





        public static Cadete cadeteAleatorio(int cantPedidos)
        {
            List<Pedido> pedidos = new List<Pedido>();

            for (int i = 0; i < cantPedidos; i++)
            {
                Pedido ped = new Pedido();
                ped = pedidoAleatorio();
                pedidos.Add(ped);
            }

            Cadete cadete = new Cadete(cadeteID, Nombres[aleatorio.Next(5)] + " " + Apellidos[aleatorio.Next(5)], "Direccion Casa", "381123456", pedidos);
            cadeteID++;
            return cadete;
        }
    }
}
