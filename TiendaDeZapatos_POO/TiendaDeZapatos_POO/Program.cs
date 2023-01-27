using System;

namespace TiendaDeZapatos_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicación para simular la venta de zapatos");

            //Aqui pedimos cuantos zapatos tendrá la tienda
            int cantidadZapatos =0;
            bool datoCorrecto = false;

            do
            {
                try
                {
                    Console.Write("\nIngresa la cantidad de zapatos que tendrá la tienda: ");
                    cantidadZapatos = int.Parse(Console.ReadLine()!);

                    if (cantidadZapatos > 0)
                        datoCorrecto = true;
                    else
                        Console.WriteLine("El dato ingresado no representa una cantidad válida. Intenta nuevamente!");
                }
                catch (FormatException errorDato)
                {
                    Console.WriteLine("El dato ingresado no está en el formato correcto. Intenta nuevamente!");
                    Console.WriteLine($"{errorDato.Message}");                    
                }
            }
            while (!datoCorrecto);


            //Aqui creo una instancia de la clase tienda
            Tienda miTiendita = new Tienda(cantidadZapatos);

            //Aqui leo los estilos disponibles
            Console.WriteLine("Los estilos disponibles son:");

            foreach (string unEstilo in miTiendita.GetEstilos())
                Console.WriteLine($"- {unEstilo}");

            //Aqui leo los colores
            Console.WriteLine("\nLos Colores Disponibles son:");

            foreach (string unColor in miTiendita.GetColores())
                Console.WriteLine($"- {unColor}");

            //Aqui leo las tallas
            Console.WriteLine("\nLas tallas disponibles son:");

            foreach (int unaTalla in miTiendita.GetTallas())
                Console.WriteLine($"- {unaTalla}");

            Console.WriteLine("La tienda quedó surtida con estos zapatos:");

            int contador = 1;
            Zapato[] losZapatos = miTiendita.LosZapatos;

            foreach (Zapato unZapato in losZapatos)
            {
                Console.WriteLine($"No. {contador}, Talla: {unZapato.GetTalla()}," +
                    $"Color: {unZapato.GetColor()}, Estilo: {unZapato.GetEstilo()}");
                contador++;
            }

            int valorModa;
            string estiloModa;

            // Obtenemos los resultados a través de los argumentos, declarándolos de salida (out)
            miTiendita.ObtieneEstiloModa(out valorModa, out estiloModa);

            Console.WriteLine($"\nEl estilo de moda es {estiloModa} con {valorModa} pares de zapatos");
        }
    }
}
