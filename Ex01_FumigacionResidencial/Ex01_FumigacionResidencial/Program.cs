using System;

namespace Ex01_FumigacionResidencial
{
    public class program
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

            Console.WriteLine($"El porcentaje de hogares fumigados fue " +
                $"{casasDelaMontaña.ObtienePorcentajeHogaresFumigados().ToString("00.00")}%");


            //Fumigacion fumigacionHongos = new Fumigacion("Hongos", "Fungicida");
            //Fumigacion fumigacionRoedores = new Fumigacion("Roedores", "Anticoagulantes");
            //Fumigacion fumigacionInsectos = new Fumigacion("Insectos", "Desinfectantes");

            //Console.WriteLine("Algunos métodos de fumigación disponibles son");
            //Console.WriteLine(fumigacionInsectos.ToString());
            //Console.WriteLine(fumigacionHongos.ToString());
            //Console.WriteLine(fumigacionRoedores.ToString());

            //Hogar miCasita = new Hogar(fumigacionHongos);

            //Console.WriteLine("\nAlgunos hogares fumigados");
            //Console.WriteLine(miCasita.ToString());

            //Hogar otraCasita = new Hogar();


            //Console.WriteLine("\nAlgunos hogares NO fumigados");
            //Console.WriteLine(otraCasita.ToString());

        }
    }
}
