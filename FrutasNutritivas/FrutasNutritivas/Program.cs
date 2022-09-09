using System;
using FrutasNutritivas.Logica;

namespace FrutasNutritivas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para la valoración nutricional de frutas");
            Console.WriteLine("Se evaluan 1000 frutas entre frescas y secas");

            //aqui inicializamos nuestros arreglos
            int totalFrutas = 1000;
            Fruta[] misFrutas = new Fruta[totalFrutas];

            //aqui declaramos el objeto aleatorio para la asignación de los valores de los atributos
            Random aleatorio = new Random();

            //inicializamos el arreglo de frutas
            //0: Fruta Fresca
            //1: Fruta Seca
            for (int i = 0; i < misFrutas.Length; i++)
            {
                switch (aleatorio.Next(2))
                {
                    //Fruta Fresca
                    case 0:
                        misFrutas[i] = new FrutaFresca()
                        {
                            Tipo = "Fresca",
                            Azucar = aleatorio.Next(5, 61),
                            Fibra = (float)aleatorio.Next(25, 127) / 10,
                            Proteina = (float)aleatorio.Next(3, 51) / 10,
                            DiasCosechado = aleatorio.Next(0, 22)
                        };
                        break;

                    case 1:
                        misFrutas[i] = new FrutaSeca()
                        {
                            Tipo = "Seca",
                            Azucar = aleatorio.Next(5, 61),
                            Fibra = (float)aleatorio.Next(25, 127) / 10,
                            Proteina = (float)aleatorio.Next(3, 51) / 10,
                            NivelSodio = aleatorio.Next(2, 31)
                        };
                        break;

                }
                misFrutas[i].ValidaSaludable();
            }

            //Finalmente visualizamos resultados
            Console.WriteLine("\nVisualizamos información nutricional de las frutas...\n");

            int totalFrescasSaludables = 0, totalSecasSaludables = 0;
            int totalSecas=0, totalFrescas=0;

            Console.WriteLine("\n*** Frutas Frescas saludables *** \n");
            for (int i = 0; i < misFrutas.Length; i++)
            {
                if (misFrutas[i].Tipo == "Fresca")
                {
                    totalFrescas++;
                    if (misFrutas[i].Saludable)
                    {
                        totalFrescasSaludables++;
                        Console.WriteLine($"{misFrutas[i].ToString()} \n");
                    }

                }
            }

            Console.WriteLine("\n***Frutas Secas saludables ***");
            for (int i = 0; i < misFrutas.Length; i++)
            {
                if (misFrutas[i].Tipo == "Seca")
                {
                    totalSecas++;
                    if (misFrutas[i].Saludable)
                    {
                        totalSecasSaludables++;
                        Console.WriteLine($"{misFrutas[i].ToString()} \n");
                    }
                }
            }

            float porcentajeSecasSaludables = ((float)totalSecasSaludables / totalFrutas)*100;
            float porcentajeFrescasSaludables = ((float)totalFrescasSaludables / totalFrutas)*100;

            Console.WriteLine("\n\n *** Totales ***");
            Console.WriteLine($"{totalFrescas} fueron frutas frescas, y solo {porcentajeFrescasSaludables.ToString("0.00")}% fueron saludables");
            Console.WriteLine($"{totalSecas} fueron frutas secas, y solo {porcentajeSecasSaludables.ToString("0.00")}% fueron saludables");
        }
    }
}
