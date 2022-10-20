using System;

namespace Poo_PS_GoF_AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadena alimenticia de un contiente usando patrones de Software");
            Console.WriteLine("El patrón utilizado es Abstract Factory");

            Console.WriteLine("\nCreando el continente asiático:");
            ReinoAnimal miMundo = new ReinoAnimal("Asia");
            Console.WriteLine(miMundo.ResultadoCadenaAlimenticia());

            Console.WriteLine("\nCreando el continente americano:");
            miMundo = new ReinoAnimal("America");
            Console.WriteLine(miMundo.ResultadoCadenaAlimenticia());

            Console.WriteLine("\nCreando el continente africano:");
            miMundo = new ReinoAnimal("Africa");
            Console.WriteLine(miMundo.ResultadoCadenaAlimenticia());

            Console.WriteLine("\nCreando el continente Oceanía:");
            miMundo = new ReinoAnimal("Oceania");
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
