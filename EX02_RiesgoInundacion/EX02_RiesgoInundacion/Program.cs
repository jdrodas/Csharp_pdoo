using System;
using LogicaInundacion;

namespace EX02_RiesgoInundacion
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para Simular el monitoreo de zonas en riesgo de inundación");
            Console.WriteLine("Se valorarán riesgos por inundación urbana, costera y fluvial");

            int cantidadZonas=0;
            bool datoCorrecto=false;

            do
            {
                try
                {
                    Console.Write("\nIngresa la cantidad de zonas a monitorear: ");
                    cantidadZonas = int.Parse(Console.ReadLine()!);

                    if (cantidadZonas <= 0)
                        Console.WriteLine("La cantidad de zonas debe ser un entero positivo. Intenta nuevamente");
                    else
                        datoCorrecto = true;
                }
                catch (FormatException unError)
                {
                    Console.WriteLine("El dato ingresado no es numérico. Intenta nuevamente");
                    Console.WriteLine(unError.Message);
                }
            }
            while (!datoCorrecto);

            Console.Write($"\n\nGenerando simulación de inundación para {cantidadZonas} zonas... ");

            GestionRiesgo gestor = new GestionRiesgo(cantidadZonas);

            Console.WriteLine("Finalizado!");

            //Aqui visualizamos resultados
            Console.WriteLine("\n\n **** Resultados Obtenidos de la simulación *** ");

            Console.WriteLine(gestor.ObtieneInformacionZonas());

            Console.WriteLine($"Porcentaje zonas en riesgo: " +
                $"{gestor.ObtienePorcentajeZonasEnRiesgo().ToString(".00")}%");

            Console.WriteLine("\nEl porcentaje de zonas en riesgo por tipo de zona es:");
            Console.WriteLine(gestor.ObtienePorcentajeZonasEnRiesgoPorTipoZona());

            Console.WriteLine("\nEl porcentaje de zonas en riesgo por tipo de riesgo es:");
            Console.WriteLine(gestor.ObtienePorcentajeZonasEnRiesgoPorTipoRiesgo());


        }
    }
}