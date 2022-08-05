using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaGomita_OO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para simular un pedido de 1000 gomitas\n");

            string[] losSabores = {
                    "Mamoncillo",
                    "Borojó",
                    "Pitaya",
                    "Empanada de pollo",
                    "Chontaduro",
                    "Kiwi"};

            string[] lasFormas = {
                "Gusanito",
                "Osito",
                "Moritas",
                "Robot Steam Punk"
            };

            string[] losColores = {
                "Naranjado Zapote",
                "Morado celestial",
                "Azul Pitufo",
                "Verde duende",
                "Cobre Oxidado",
                "Amarillo minion",
                "Rojo red bull",
                "Verde vive 100"};

            //Aqui visualizamos los valores atributos
            Console.WriteLine("Sabores disponibles:");

            foreach (string unSabor in losSabores)
                Console.WriteLine($"\t-{unSabor}");

            Console.WriteLine("Formas disponibles:");

            foreach (string unaForma in lasFormas)
                Console.WriteLine($"\t-{unaForma}");

            Console.WriteLine("Colores disponibles:");

            foreach (string unColor in losColores)
                Console.WriteLine($"\t-{unColor}");

            //Aqui definimos el arreglo de objetos tipo Gomita
            Gomita[] elPedido = new Gomita[1000];

            Random aleatorio = new Random();

            //Aqui inicializamos cada posición del arreglo
            for (int i = 0; i < elPedido.Length; i++)
            {
                elPedido[i] = new Gomita();
                elPedido[i].Color = losColores[aleatorio.Next(losColores.Length)];
                elPedido[i].Forma = lasFormas[aleatorio.Next(lasFormas.Length)];
                elPedido[i].Sabor = losSabores[aleatorio.Next(losSabores.Length)];
            }

            //Visualizamos el contenido del arreglo
            Console.WriteLine("\n\nGomitas que se incluyen en el pedido:");
            for (int i = 0; i < elPedido.Length; i++)
                Console.WriteLine($"No. {i+1}: {elPedido[i].ObtieneInformacion()}");

            Console.WriteLine("\n\nTotal Gomitas por Color:");
            int[] totalColores = TotalizaPorColor(elPedido, losColores);

            for (int i = 0; i < losColores.Length; i++)
                Console.WriteLine($"Color: {losColores[i]}, total: {totalColores[i]}");

            //int[] totalesForma = TotalizaPorAtributo(elPedido, lasFormas, "forma");

        }


        //public static int[] TotalizaPorAtributo(
        //                Gomita[] arregloPedido,
        //                string[] arregloAtributo,
        //                string nombreAtributo)
        //{
        //    int[] resultado = new int[arregloAtributo.Length];

        //    if (nombreAtributo == "forma")
        //    {
                
        //    }

        //    return resultado;
        //}

        public static int[] TotalizaPorColor(Gomita[] arregloPedido, string[] arregloColores)
        {
            int[] resultado = new int[arregloColores.Length];

            //Garantizamos que todos los totales comienzan en 0
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            //Aqui recorremos el arreglo de colores
            for (int i = 0; i < arregloColores.Length; i++)
            {
                //Aqui recorremos el arreglo de gomitas
                for (int j = 0; j < arregloPedido.Length; j++)
                {
                    if (arregloPedido[j].Color == arregloColores[i])
                        resultado[i]++;
                }
            }

            return resultado;
        }
    }
}
