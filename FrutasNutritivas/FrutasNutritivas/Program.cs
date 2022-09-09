using System;
using FrutasNutritivas.Logica;

namespace FrutasNutritivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalFrutas = 1000;

            Console.WriteLine("Programa para la valoración nutricional de frutas");
            Console.WriteLine($"Se evaluan {totalFrutas} frutas entre frescas y secas");

            //aqui inicializamos el proceso
            Gestor GestorFrutas = new Gestor(new Fruta[totalFrutas]);

            //Aqui totalizamos las frutas obtenidas
            GestorFrutas.TotalizaFrutas();

            //Finalmente visualizamos resultados
            Console.WriteLine("\nVisualizamos resultado de la simulación...");
            Console.WriteLine(GestorFrutas.ObtieneDetalleFrutasSaludables());
            Console.WriteLine(GestorFrutas.ToString());
        }
    }
}
