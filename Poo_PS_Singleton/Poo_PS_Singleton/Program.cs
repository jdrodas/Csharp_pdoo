using System;
using System.Threading;

namespace Poo_PS_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar el patrón GoF Singleton");

            //Creamos dos instancias de la clase sin invocar el constructor
            AsignaEstacionador espacio1 = AsignaEstacionador.ObtieneEspacioParqueo();
            Thread.Sleep(1000); //Esperamos un segundo...
            AsignaEstacionador espacio2 = AsignaEstacionador.ObtieneEspacioParqueo();

            //Comparamos las instancias para validar que son iguales
            Console.WriteLine("\nComparamos las instancia espacio1 y espacio2...");
            if (espacio1 == espacio2)
            {
                Console.WriteLine("Los espacios de parqueo son los mismos. Unica instancia!");
                Console.WriteLine($"El espacio asignado en espacio1 es {espacio1.Espacio}");
                Console.WriteLine($"El espacio asignado en espacio2 es {espacio2.Espacio}");
            }
            else
            {
                Console.WriteLine("Son espacios de parqueo diferentes. Diferentes instancias!");
                Console.WriteLine($"El espacio asignado en espacio1 es {espacio1.Espacio}");
                Console.WriteLine($"El espacio asignado en espacio2 es {espacio2.Espacio}");
            }

            //Creamos dos instancias de la clase invocando directamente el constructor
            AsignaEstacionador espacio3 = new AsignaEstacionador();
            Thread.Sleep(1000); //Esperamos un segundo...
            AsignaEstacionador espacio4 = new AsignaEstacionador();

            //Comparamos las instancias para validar que NO son iguales
            Console.WriteLine("\nComparamos las instancia espacio3 y espacio4...");
            if (espacio3 == espacio4)
            {
                Console.WriteLine("Los espacios de parqueo son los mismos. Unica instancia!");
                Console.WriteLine($"El espacio asignado en espacio3 es {espacio3.Espacio}");
                Console.WriteLine($"El espacio asignado en espacio4 es {espacio4.Espacio}");
            }
            else
            {
                Console.WriteLine("Son espacios de parqueo diferentes!");
                Console.WriteLine($"El espacio asignado en espacio3 es {espacio3.Espacio}");
                Console.WriteLine($"El espacio asignado en espacio4 es {espacio4.Espacio}");
            }

            Console.WriteLine("\n\n\n");
        }
    }
}
