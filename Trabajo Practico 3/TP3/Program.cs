using System;
using System.Collections.Generic;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre de la cadeteria: ");
            string nom = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de Cadetes: ");
            int cant = Convert.ToInt32(Console.ReadLine());

            List<Cadete> cadetes = new List<Cadete>();

            for(int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese la cantidad de pedidos del cadete " + (i+1));
                int cantPed = Convert.ToInt32(Console.ReadLine());

                Cadete nuevoCadete = new Cadete();
                nuevoCadete = Helper.cadeteAleatorio(cantPed);
                cadetes.Add(nuevoCadete);
            }

            Cadeteria nuevaCadeteria = new Cadeteria(nom, cadetes);
            nuevaCadeteria.informeEntregas();
            nuevaCadeteria.mayorEntregas();

        }
    }
}
