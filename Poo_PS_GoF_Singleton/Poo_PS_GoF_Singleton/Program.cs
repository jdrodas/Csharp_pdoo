using System;
using System.Threading;

namespace Poo_PS_GoF_Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Se utiliza el simbolo "?" después del tipo de dato para indicar al compilador
            //Que esa variable puede ser nula
            //Para .NET 5 o superior

            Console.WriteLine("Programa para demostrar el patrón GoF Singleton");

            //Creamos dos instancias de la clase sin invocar el constructor
            AsignaEstacionador? espacio1 = AsignaEstacionador.ObtieneEstacionador();
            Thread.Sleep(1000); //Esperamos un segundo...
            AsignaEstacionador? espacio2 = AsignaEstacionador.ObtieneEstacionador();

            //Comparamos las instancias para validar que son iguales
            Console.WriteLine("\nComparamos las instancia espacio1 y espacio2...");
            if (espacio1.Equals(espacio2))
            {
                Console.WriteLine("Los espacios de parqueo son los mismos. Unica instancia!");
                Console.WriteLine($"El espacio asignado en espacio1 es {espacio1.GetEspacio()}");
                Console.WriteLine($"El espacio asignado en espacio2 es {espacio2.GetEspacio()}");
            }
            else
            {
                Console.WriteLine("Son espacios de parqueo diferentes. Diferentes instancias!");
                Console.WriteLine($"El espacio asignado en espacio1 es {espacio1.GetEspacio()}");
                Console.WriteLine($"El espacio asignado en espacio2 es {espacio2.GetEspacio()}");
            }

            //Creamos dos instancias de la clase invocando directamente el constructor
            AsignaEstacionador? espacio3 = new AsignaEstacionador();
            Thread.Sleep(1000); //Esperamos un segundo...
            AsignaEstacionador? espacio4 = new AsignaEstacionador();

            //Comparamos las instancias para validar que NO son iguales
            Console.WriteLine("\nComparamos las instancia espacio3 y espacio4...");
            if (espacio3.Equals(espacio4))
            {
                Console.WriteLine("Los espacios de parqueo son los mismos. Unica instancia!");
                Console.WriteLine($"El espacio asignado en espacio3 es {espacio3.GetEspacio()}");
                Console.WriteLine($"El espacio asignado en espacio4 es {espacio4.GetEspacio()}");
            }
            else
            {
                Console.WriteLine("Son espacios de parqueo diferentes!");
                Console.WriteLine($"El espacio asignado en espacio3 es {espacio3.GetEspacio()}");
                Console.WriteLine($"El espacio asignado en espacio4 es {espacio4.GetEspacio()}");
            }
        }
    }
}