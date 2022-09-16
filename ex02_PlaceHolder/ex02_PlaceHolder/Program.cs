using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02_PlaceHolder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular cuantos kilos de pescado de cada tipo fueron recolectados, y mediante cuál método");
            Console.WriteLine("Los tipos de pescado son Sabaleta, Tilapia, Trucha y Mojarra");
            Console.WriteLine("Los métodos de pesca son Atarraya, Chinchorro, Arpón y Red de Arrastre");



            //Aquí mostramos los tipos de pescado y los métodos de pesca que se van a emplear para la recolección
            string[] tiposPescado = { "Sabaleta", "Tilapia", "Trucha", "Mojarra" };

            Console.WriteLine("\n Tipos de pescado:  ");
            for (int i = 0; i < tiposPescado.Length; i++)
            {
                Console.Write($"El tipo de pescado No. {i + 1} es: {tiposPescado[i]} \n");

            }

            string[] metodosPesca = { "Atarraya", "Chinchorro", "Arpón", "RedArrastre" };

            Console.WriteLine("\n Tipos de metodo de Pesca:  ");
            for (int i = 0; i < metodosPesca.Length; i++)
            {
                Console.Write($"El tipo de método No. {i + 1} es: {metodosPesca[i]} \n");

            }


            //Aquí preguntamos cuantos kilogramos por cada especie y mediante cuál método fueron recolectados
            Console.WriteLine("");

            float[,] kilogramos = new float[tiposPescado.Length, metodosPesca.Length];

            try
            {
                for (int pescado = 0; pescado < tiposPescado.Length; pescado++)
                {
                    for (int metodo = 0; metodo < metodosPesca.Length; metodo++)
                    {
                        Console.Write($"Ingresa los Kilogramas para {tiposPescado[pescado]} en el método {metodosPesca[metodo]}: ");
                        kilogramos[pescado, metodo] = float.Parse(Console.ReadLine());

                    }
                    Console.WriteLine();

                }

                //Aquí calculamos el total de pescados que fueron recolectados por especie
                float[] kilogramosPorEspecie = TotalizaPescaEspecie(kilogramos);

                //Aquí visualizamos el total de pescados recolectados por especie
                Console.WriteLine("\n Las especies de pescados son:");
                for (int pescado = 0; pescado < tiposPescado.Length; pescado++)
                {
                    Console.WriteLine($"{tiposPescado[pescado]}");

                    for (int metodo = 0; metodo < metodosPesca.Length; metodo++)
                    {
                        Console.WriteLine($"Método: {metodosPesca[metodo]}, Total de kilogramos: {kilogramos[pescado, metodo]}");
                    }

                    Console.WriteLine($"El total de kilogramos de {tiposPescado[pescado]} fue de: {kilogramosPorEspecie[pescado]} kilogramos\n");
                }



                //Aquí calculamos el total de pescados que fueron recolectados por cada método
                float[] kilogramosPorMetodo = TotalizaPescaMetodos(kilogramos);

                //Aquí visualizamos el total de pesados recolectados por método
                Console.WriteLine("\n Los métodos de pesca son:");
                for (int metodo = 0; metodo < metodosPesca.Length; metodo++)
                {
                    Console.WriteLine($"{metodosPesca[metodo]}");

                    for (int pescado = 0; pescado < tiposPescado.Length; pescado++)
                    {
                        Console.WriteLine($"Pescado: {tiposPescado[pescado]}, Total de kilogramos: {kilogramos[pescado, metodo]}");
                    }

                    Console.WriteLine($"El total de kilogramos por medio de {metodosPesca[metodo]} fue de: {kilogramosPorMetodo[metodo]} kilogramos\n");
                }

                //Aquí visualizamos si se superó el tope máximo de pescados por especie
                Console.WriteLine("\n Las especies de pescados son:");
                for (int pescado = 0; pescado < tiposPescado.Length; pescado++)
                {
                    Console.WriteLine($"{tiposPescado[pescado]}");
                    Console.WriteLine($"El total de kilogramos de {tiposPescado[pescado]} fue de: {kilogramosPorEspecie[pescado]} kilogramos");

                    if (kilogramosPorEspecie[pescado] > 200)
                    {
                        Console.WriteLine("El tope máximo fue superado, se realizó una pesca excesiva, lo cual puede poner en riesgo la especie\n");
                    }
                    else
                    {
                        Console.WriteLine("Los kilogramos son menores a 200, estás bajo el tope máximo\n");
                    }
                }
            }
            catch (FormatException elError)
            {
                Console.WriteLine(elError.Message);
                Console.WriteLine("Debes ingresar únicamente datos numéricos positivos, intenta nuevamente!\n");

            }
        }


        //Función que calcula el total de pescados por especie
        static float[] TotalizaPescaEspecie(float[,] kilogramos)
        {
            //La dimensión 0 del arreglo corresponde a las especies
            //La dimensión 1 del arreglo corresponde a los métodos
            float[] kilosEspecie = new float[kilogramos.GetLength(0)];

            for (int pescado = 0; pescado < kilogramos.GetLength(0); pescado++)
            {
                kilosEspecie[pescado] = 0; // Inicializamos la acumulacion

                for (int metodo = 0; metodo < kilogramos.GetLength(1); metodo++)
                    kilosEspecie[pescado] += kilogramos[pescado, metodo];

            }
            return kilosEspecie;
        }


        //Función que calcula el total de pescados por método de pesca
        static float[] TotalizaPescaMetodos(float[,] kilogramos)
        {
            //La dimensión 0 del arreglo corresponde a las especies
            //La dimensión 1 del arreglo corresponde a los métodos
            float[] kilosMetodo = new float[kilogramos.GetLength(1)];

            for (int metodo = 0; metodo < kilogramos.GetLength(1); metodo++)
            {
                kilosMetodo[metodo] = 0; // Inicializamos la acumulacion

                for (int pescado = 0; pescado < kilogramos.GetLength(0); pescado++)
                    kilosMetodo[metodo] += kilogramos[pescado, metodo];

            }
            return kilosMetodo;
        }
    }
}
