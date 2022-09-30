using Poo_PS_FabricaAbstracta;
using System;

namespace POO_PS_AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadena alimenticia de un contiente usando patrones de Software");
            Console.WriteLine("El patrón utilizado es Abstract Factory\n\n");

            Console.WriteLine("\nCreando el continente asiático:");
            MundoAnimal miMundo = new MundoAnimal("Asia");
            Console.WriteLine(miMundo.ResultadoCadenaAlimenticia());

            Console.WriteLine("\nCreando el continente americano:");
            miMundo = new MundoAnimal("America");
            Console.WriteLine(miMundo.ResultadoCadenaAlimenticia());

            Console.WriteLine("\nCreando el continente africano:");
            miMundo = new MundoAnimal("Africa");
            Console.WriteLine(miMundo.ResultadoCadenaAlimenticia());

            Console.WriteLine("\nCreando el continente Oceanía:");
            miMundo = new MundoAnimal("Oceania");
            Console.WriteLine(miMundo.ResultadoCadenaAlimenticia());

            //Sin usar patrones, así se logra que un tigre se coma una cabra
            Cabra unaCabra = new Cabra()
            {
                Nombre = "Clarabella",
                Especie = "hibrido cabra/vaca"
            };

            Tigre unTigre = new Tigre()
            {
                Nombre = "Florencio",
                Especie = "Tigre de las montañas"
            };

            Console.WriteLine("\nLa cadena alimenticia sin restricciones");
            Console.WriteLine(unaCabra.Alimentarse());
            Console.WriteLine(unTigre.Cazar(unaCabra));

        }
    }
}
