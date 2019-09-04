using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrutasNutritivas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para la valoración nutricional de frutas");
            Console.WriteLine("Se evaluan 500 frutas frescas y 500 frutas secas");

            //aqui inicializamos nuestros arreglos
            FrutaFresca[] misFrescas = new FrutaFresca[500];
            FrutaSeca[] misSecas = new FrutaSeca[500];

            //aqui declaramos el objeto aleatorio para la asignación de los valores de los atributos
            Random aleatorio = new Random();

            //inicializamos las frutas frescas
            for (int i = 0; i < misFrescas.Length; i++)
            {
                misFrescas[i] = new FrutaFresca();
                misFrescas[i].Tipo = "Fresca";
                misFrescas[i].Azucar = aleatorio.Next(5, 61);
                misFrescas[i].Fibra = (float)aleatorio.Next(25, 127) / 10;
                misFrescas[i].Proteina = (float)aleatorio.Next(3, 51) / 10;
                misFrescas[i].DiasCosechado = aleatorio.Next(0, 22);
                misFrescas[i].ValidaSaludable();
            }

            //inicializamos las frutas secas
            for (int i = 0; i < misSecas.Length; i++)
            {
                misSecas[i] = new FrutaSeca(aleatorio.Next(5, 61),
                                            ((float)aleatorio.Next(25, 127) / 10),
                                            ((float)aleatorio.Next(3, 51) / 10),
                                            "Seca",
                                            aleatorio.Next(2, 31));
            }

            //Finalmente visualizamos resultados
            Console.WriteLine("Visualizamos información nutricional de las frutas...\n");

            int totalFrescasSaludables = 0, totalSecasSaludables = 0;

            Console.WriteLine("Frutas Frescas saludables");
            for (int i = 0; i < misFrescas.Length; i++)
            {
                if (misFrescas[i].Saludable)
                {
                    Console.WriteLine("No. {0}: {1}", (i + 1), misFrescas[i].InfoNutricional());
                    totalFrescasSaludables++;
                }
                    
            }

            Console.WriteLine("Frutas Secas saludables");
            for (int i = 0; i < misSecas.Length; i++)
            {
                if (misSecas[i].Saludable)
                {
                    Console.WriteLine("No. {0}: {1}", (i + 1), misSecas[i].InfoNutricional());
                    totalSecasSaludables++;
                }                
            }

            Console.WriteLine("\n\nTotal saludables: Frescas {0} y Secas {1}", totalFrescasSaludables, totalSecasSaludables);
        }
    }
}
