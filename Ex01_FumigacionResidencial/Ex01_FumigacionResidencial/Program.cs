using LogicaFumigacion;
using System;

namespace Ex01_FumigacionResidencial
{
    public class Program
    {
        static public void Main(string[] args)
        {
            Console.WriteLine("Programa para simular la fumigación de hogares");

            int cantidadHogares = 0;
            bool datoCorrecto = false;

            do
            {
                try
                {
                    Console.Write("\nIngresa la cantidad de hogares: ");
                    cantidadHogares = int.Parse(Console.ReadLine()!);

                    if (cantidadHogares > 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("La cantidad debe ser un numero mayor que 0. Intenta nuevamente");

                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no está en el formato esperado. Intenta nuevamente!");
                    Console.WriteLine(elError.Message);
                }
            } while (!datoCorrecto);

            //Aqui creamos la instancia del Conjunto residencial
            ConjuntoResidencial casasDelaMontaña = new ConjuntoResidencial(cantidadHogares);

            Console.WriteLine("Resultados de la fumigación");

            for (int i = 0; i < casasDelaMontaña.GetLosHogares().Length; i++)
            {
                Console.WriteLine($"\nHogar No. {i + 1}" +
                    $"\n {casasDelaMontaña.GetLosHogares()[i].ToString()}");
            }

            Console.WriteLine($"\nEl porcentaje de hogares fumigados fue " +
                $"{casasDelaMontaña.ObtienePorcentajeHogaresFumigados().ToString("00.00")}%");

            Console.WriteLine($"\nLos totales por fumigaciones disponibles son");

            foreach (FumigacionDisponible unaFumigacion in casasDelaMontaña.GetFumigacionesAccesibles())
            {
                Console.WriteLine(unaFumigacion.ToString());
            }

            Console.WriteLine($"\nResultado del Producto-Plaga más utilizado:\n " +
                $"{casasDelaMontaña.ObtieneProductoPlagaMasUtilizado()}");

            Console.WriteLine($"\nResultado del Producto-Plaga más utilizado: ");

            List<FumigacionDisponible> lasFumigaciones = 
                casasDelaMontaña.ObtieneProductoPlagaMasUtilizado(casasDelaMontaña.GetFumigacionesAccesibles());

            foreach (FumigacionDisponible unaFumigacion in lasFumigaciones)
            {
                Console.WriteLine(unaFumigacion.ToString());
            }

            Console.WriteLine($"En total fueron {lasFumigaciones.Count}");
        }
    }
}
