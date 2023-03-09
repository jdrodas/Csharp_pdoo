using System;
using LogicaComercio;

namespace ComercioOvejas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para simular el comercio de Ovejas");

            int cantidadOvejas =0;
            bool datoCorrecto = false;
            do
            {
                try
                {
                    Console.Write("Ingresa la cantidad de Ovejas a procesar en la Cooperativa: ");
                    cantidadOvejas = int.Parse(Console.ReadLine()!);

                    if (cantidadOvejas > 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("La cantidad de ovejas debe ser un entero positivo. Intenta nuevamente");
                }
                catch (FormatException)
                {
                    Console.WriteLine("El dato ingresado no tiene el formato requerido. Intenta nuevamente");
                }
            }
            while (!datoCorrecto);

            Console.WriteLine("\n Llevando las ovejas a la cooperativa...");

            Cooperativa miCoop = new Cooperativa(cantidadOvejas);

            //Calculamos la producción
            miCoop.ContabilizaProduccion();

            //Calculamos la Comision
            miCoop.CalculaComision();

            Console.WriteLine(miCoop.ToString());
            Console.WriteLine("\n" + miCoop.VisualizaResultadoComercio());

            ////Aqui declaramos el arreglo de Ovejas


            ////Aqui visualizamos las ovejas aptas:
            //int contadorOvejasAptas = 0;
            //int totalOvejas = 1;



            //Console.WriteLine($"De las {cantidadOvejas} Ovejas, {contadorOvejasAptas} son aptas");
        }
    }
}