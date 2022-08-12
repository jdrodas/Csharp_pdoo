using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricadorArepas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa para gestionar arepas de una fábrica");
            Console.WriteLine("Se producirán 1.000 arepas");

            /*            
            //Probamos las clases que implementamos
            ArepaAsada miCarboncito = new ArepaAsada();
            miCarboncito.TipoDeMasa = "Chocolo";
            miCarboncito.TemperaturaCoccion = 20;
            miCarboncito.NumeroMolino = 3;
            miCarboncito.DiasCaducidad = 2;

            Console.WriteLine(miCarboncito.ObtieneInformacion() + "\n");

            Arepa unaArepa = new ArepaProcesada(
                "Yuca",
                35,
                2,
                87,
                9,
                "Procesada"
                );

            Console.WriteLine(unaArepa.ObtieneInformacion() + "\n");
            */

            //Aqui hacemos el arreglo de 1.000 arepas
            Arepa[] lasArepas = new Arepa[1000];

            //Aqui inicializamos el arreglo del tipo de masa
            string[] tiposMasa = { "Chocolo", "Yuca", "Maiz", "Quinua", "Arroz" };
            InicializaLoteArepas(lasArepas, tiposMasa);

            VisualizaLoteArepas(lasArepas);

            //Aqui vemos totales
            int[] totalesMasa = TotalesPorMasa(lasArepas, tiposMasa);

            Console.WriteLine("\n\nLos totales por masa son:");
            for (int k = 0; k < tiposMasa.Length; k++)
            {
                Console.WriteLine($"Masa: {tiposMasa[k]}, total: {totalesMasa[k]}");
            }
        }

        public static void InicializaLoteArepas(Arepa[] arregloArepas, string[] arregloMasas)
        {
            //Variables del proceso
            Random aleatorio = new Random();

            int tipoDeArepa; // 0: Congelada, 1: Asada, 2: Procesada
            int numeroMolino; // Toma valores entre 1 y 7
            int diasCaducidad; // Toma Valores entre 1 y 30 días            

            for (int i = 0; i < arregloArepas.Length; i++)
            {
                tipoDeArepa = aleatorio.Next(3);
                numeroMolino = aleatorio.Next(1, 8);
                diasCaducidad = aleatorio.Next(1, 31);

                switch (tipoDeArepa)
                {
                    case 0:
                        arregloArepas[i] = new ArepaCongelada(
                            arregloMasas[aleatorio.Next(arregloMasas.Length)],
                            diasCaducidad,
                            numeroMolino,
                            aleatorio.Next(30, 91), //Dias de Congelado
                            "Congelada");
                        break;

                    case 1:
                        arregloArepas[i] = new ArepaAsada(
                            arregloMasas[aleatorio.Next(arregloMasas.Length)],
                            diasCaducidad,
                            numeroMolino,
                            aleatorio.Next(20, 101), // Temperatura de Coccion
                            "Asada");
                        break;

                    case 2:
                        arregloArepas[i] = new ArepaProcesada(
                           arregloMasas[aleatorio.Next(arregloMasas.Length)],
                            diasCaducidad,
                            numeroMolino,
                            aleatorio.Next(20, 101), // Temperatura de Coccion
                            aleatorio.Next(30, 91), //Dias de Congelado
                            "Procesada");
                        break;
                }
            }
        }

        public static int[] TotalesPorMasa(Arepa[] arregloArepas, string[] arregloMasas)
        {
            int[] resultado = new int[arregloMasas.Length];

            //Inicializo el arreglo
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            //Aqui contamos
            for (int i = 0; i < arregloArepas.Length; i++)
                for (int j = 0; j < arregloMasas.Length; j++)
                    if (arregloArepas[i].TipoDeMasa == arregloMasas[j])
                        resultado[j]++;

            return resultado;
        }

        public static void VisualizaLoteArepas(Arepa[] arregloArepas)
        {
            //foreach (Arepa unaArepa in arregloArepas)
            //{
            //    Console.WriteLine(unaArepa.ObtieneInformacion() + "\n");
            //}

            for (int i = 0; i < arregloArepas.Length; i++)
            {
                Console.WriteLine($"Arepa No {(i + 1)} " +
                    $"- Del tipo {arregloArepas[i].TipoArepa} " +
                    $"- De masa {arregloArepas[i].TipoDeMasa}");
            }

        }
    }
}
