using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    class Cadeteria
    {
        private string nombreCadeteria;
        private List<Cadete> ListadoCadetes = new List<Cadete>();

        public Cadeteria(string nombreCadeteria, List<Cadete> listadoCadetes)
        {
            this.nombreCadeteria = nombreCadeteria;
            ListadoCadetes = listadoCadetes;
        }

        public Cadeteria()
        {

        }


        public void informeEntregas()
        {
            Console.WriteLine("\nInforme de Entregas: ");

            foreach(var item in ListadoCadetes)
            {
                item.informe();
            }
        }



        public void mayorEntregas()
        {
            int mayor = 0;
            int entregasRealizadas = 0;
            int promedio;
            int totalCadetes = 0;
            Cadete cadeteAux = new Cadete();

            foreach(var item in ListadoCadetes)
            {
                if(item.entregas() > mayor)
                {
                    mayor = item.entregas();
                    cadeteAux = item;
                }
                entregasRealizadas = entregasRealizadas + item.entregas();
                totalCadetes++;
            }
            promedio = entregasRealizadas / totalCadetes;

            Console.WriteLine("\n\nCadete con mas Pedidos Entregados: ");
            Console.WriteLine("ID: " + cadeteAux.Id1);
            Console.WriteLine("Nombre: " + cadeteAux.Nombre1);
            Console.WriteLine("Direccion: " + cadeteAux.Direccion1);
            Console.WriteLine("Telefono: " + cadeteAux.Telefono1);
            Console.WriteLine("Pedidos Entregados: " + mayor);
            Console.WriteLine("Promedio de Pedidos Entregados: " + promedio + "%");

        }
    }
}
