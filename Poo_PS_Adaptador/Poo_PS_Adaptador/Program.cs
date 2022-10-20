using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Adaptador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar el patrón GoF Adaptador");

            //Console.WriteLine("Información para el agua:");
            ////Aqui se hace lo que Ana María responda
            //Compuesto elAgua = new CompuestoEnriquecido("agua");
            //Console.WriteLine($"\n{elAgua.InformacionCompuesto()}");

            //Compuesto elVodka = new CompuestoEnriquecido("vodka");
            //Console.WriteLine($"\n{elVodka.InformacionCompuesto()}");

            string[] nombreCompuestos = { "agua", "benzeno", "etanol", "cloruro de magnesio" };

            Compuesto[] losCompuestos = new CompuestoEnriquecido[nombreCompuestos.Length];

            for (int i = 0; i < losCompuestos.Length; i++)
            {
                losCompuestos[i] = new CompuestoEnriquecido(nombreCompuestos[i]);
                Console.WriteLine($"\n{losCompuestos[i].InformacionCompuesto()}");
            }
        }
    }
}
