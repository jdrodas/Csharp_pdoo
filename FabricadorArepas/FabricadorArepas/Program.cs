using System;

namespace FabricadorArepas
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Aqui probamos que podemos crear una instancia de ArepaAsada
            //ArepaAsada miCarboncito = new ArepaAsada();
            //miCarboncito.SetTipoDeMasa("Chocolo");
            //miCarboncito.SetTemperaturaCoccion(20);
            //miCarboncito.SetNumeroMolino(1);
            //miCarboncito.SetDiasCaducidad(5);
            //miCarboncito.SetTipoArepa("Asada");

            //Console.WriteLine($"\n{miCarboncito.ObtieneInformacion()}");

            //Aqui probamos que podemos crear una instancia de ArepaProcesada
            //ArepaProcesada unaArepa = new ArepaProcesada(
            //    "Yuca",
            //    "Procesada",
            //    7,
            //    3,
            //    45,
            //    28);

            //Console.WriteLine($"\n{unaArepa.ObtieneInformacion()}");


            Console.WriteLine("Programa para gestionar la fabricación de arepas");
            Console.WriteLine("Se producirán cierta cantidad de arepas\n");

            int cantidadArepas=0;
            bool cantidadArepasCorrecta = false;

            do
            {
                try
                {
                    Console.Write("\nCuantas arepas quieres en este lote? ");
                    cantidadArepas = int.Parse(Console.ReadLine()!);

                    if (cantidadArepas <= 0)
                        Console.WriteLine("El dato ingresado debe ser entero positivo. Intenta nuevamente.");
                    else
                        cantidadArepasCorrecta = true;

                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato ingresado no representa una cantidad. Intenta nuevamente.");
                    Console.WriteLine(elError.Message);
                }
            }
            while (cantidadArepasCorrecta == false);


            //Creamos la fabrica de arepa
            Fabrica fabricaDeArepas = new Fabrica(cantidadArepas);

            Console.WriteLine("\nAsi está compuesto el lote de arepas:\n");

            int contadorArepas = 1;

            foreach (Arepa unaArepa in fabricaDeArepas.GetLasArepas())
            {
                Console.WriteLine($"No. {contadorArepas}\n{unaArepa.ObtieneInformacion()}\n");
                contadorArepas++;
            }

            Console.WriteLine($"\nDe este lote, hay {fabricaDeArepas.ObtieneArepasVencidas()} arepas que se tienen que comer hoy!");
        }
    }
}