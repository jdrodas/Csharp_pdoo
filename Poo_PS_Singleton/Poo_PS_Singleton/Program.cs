using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar el patrón GoF Singleton\n\n");

            //Creamos dos instancias de la clase sin invocar el constructor
            AsignaEstacionador espacio1 = AsignaEstacionador.ObtieneEspacioParqueo();
            AsignaEstacionador espacio2 = AsignaEstacionador.ObtieneEspacioParqueo();

            //Creamos dos instancias de la clase invocando directamente el constructor
            //AsignaEstacionador espacio1 = new AsignaEstacionador();
            //AsignaEstacionador espacio2 = new AsignaEstacionador();

            if (espacio1 == espacio2)
            {
                Console.WriteLine("Los espacios de parqueo son los mismos. Unica instancia!");
                Console.WriteLine($"El espacio asignado en espacio1 es {espacio1.Espacio}");
                Console.WriteLine($"El espacio asignado en espacio2 es {espacio2.Espacio}");
            }
            else
            {
                Console.WriteLine("Son espacios de parqueo diferentes!");
                Console.WriteLine($"El espacio asignado en espacio1 es {espacio1.Espacio}");
                Console.WriteLine($"El espacio asignado en espacio2 es {espacio2.Espacio}");
            }
        }
    }
}
