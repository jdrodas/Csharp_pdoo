using System;

namespace Poo_PS_Adaptador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar el patrón GoF Adaptador");

            string[] nombreCompuestos = { "agua", 
                                          "benzeno", 
                                          "etanol", 
                                          "cloruro de magnesio" };

            Compuesto[] losCompuestos = new CompuestoEnriquecido[nombreCompuestos.Length];

            for (int i = 0; i < losCompuestos.Length; i++)
            {
                losCompuestos[i] = new CompuestoEnriquecido(nombreCompuestos[i]);
                Console.WriteLine($"\n{losCompuestos[i].InformacionCompuesto()}");
            }
        }
    }
}
