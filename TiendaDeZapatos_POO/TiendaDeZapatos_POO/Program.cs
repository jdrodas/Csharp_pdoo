using System;

namespace TiendaDeZapatos_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicación para simular la venta de 100 zapatos");
            Console.WriteLine("Los estilos disponibles son:");

            string[] losEstilos = {
                "Tenis",
                "Botas",
                "Crocs Metaleras",
                "Mocasines",
                "Sandalia Gladiadora" };

            foreach (string unEstilo in losEstilos)
                Console.WriteLine($"- {unEstilo}");

            Console.WriteLine("\nLos Colores Disponibles son:");

            string[] losColores =
            {
                "Verde Selva",
                "Azul Petróleo",
                "Rojo Sangre",
                "Café derrumbe de montaña"
            };

            foreach (string unColor in losColores)
                Console.WriteLine($"- {unColor}");

            Console.WriteLine("\nLas tallas disponibles son:");
            int[] lasTallas = { 28, 30, 32, 34, 36, 38, 40, 42, 44 };

            foreach (int unaTalla in lasTallas)
                Console.WriteLine($"- {unaTalla}");

            Zapato[] losZapatos = new Zapato[100];
            Random aleatorio = new Random();

            for (int i = 0; i < losZapatos.Length; i++)
            {
                losZapatos[i] = new Zapato();

                losZapatos[i].Talla = lasTallas[aleatorio.Next(lasTallas.Length)];
                losZapatos[i].Color = losColores[aleatorio.Next(losColores.Length)];
                losZapatos[i].Estilo = losEstilos[aleatorio.Next(losEstilos.Length)];
            }

            Console.WriteLine("La tienda quedó surtida con estos zapatos:");

            int contador = 1;

            foreach (Zapato unZapato in losZapatos)
            {
                Console.WriteLine($"No. {contador}, Talla: {unZapato.Talla}," +
                    $"Color: {unZapato.Color}, Estilo: {unZapato.Estilo}");
                contador++;
            }
        }
    }
}
