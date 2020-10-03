using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    class Cadete
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;
        private List<Pedido> listaPedidos = new List<Pedido>();

        public int Id1 { get => id; set => id = value; }
        public string Nombre1 { get => nombre; set => nombre = value; }
        public string Direccion1 { get => direccion; set => direccion = value; }
        public string Telefono1 { get => telefono; set => telefono = value; }
        internal List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

        public Cadete()
        {

        }

        public Cadete(int id, string nombre, string direccion, string telefono, List<Pedido> listaPedidos)
        {
            this.Id1 = id;
            this.Nombre1 = nombre;
            this.Direccion1 = direccion;
            this.Telefono1 = telefono;
            this.ListaPedidos = listaPedidos;
        }

        public int entregas()
        {
            int cont = 0;

            foreach(var item in ListaPedidos){
                if(String.Compare(item.Estado,"Entregado") == 0)
                {
                    cont++;
                }
            }
            return cont;
        }


        public void informe()
        {
            int cantEntregas = entregas();

            Console.WriteLine("Nombre del Cadete: " + this.Nombre1);
            Console.WriteLine("Cantidad de Pedidos Entregados: " + cantEntregas);
            Console.WriteLine("Monto a Cobrar: " + cantEntregas * 100);

        }
    }

  
}
