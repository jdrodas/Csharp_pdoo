/*
Programa:       MonitoreoQuebradas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Problema Propuesto:
-------------------

Monitoreo de Quebradas en Medellín

Por condiciones del cambio climático, nuevamente se presenta en la ciudad una temporada de lluvias
que sobrepasa las capacidades hídricas de las quebradas afluentes del río Medellín, generando 
situaciones de desbordamiento y afectación a la ciudadanía que vive en las cercanías.

Ante esta situación, la alcaldía de la ciudad han decidido implementar un sistema de monitoreo y 
alertas tempranas para garantizar que se puede notificar oportunamente a la población y así evitar 
desastres de grandes proporciones.

Para ello, se han instalado dispositivos de monitoreo de caudal en las principales quebradas de 
la ciudad: 
•	La Presidenta
•	La Iguaná
•	La Picacha
•	Santa Elena
•	La Hueso

Se ha definido que si una de estas quebradas tiene un caudal superior al 80% se considerará en 
estado crítico y si tres quebradas o más tienen este estado, la ciudad estará en condición de 
emergencia.

Para probar este modelo se desea hacer una aplicación que, recibiendo la información de caudal 
de cada una de las quebradas, esté en capacidad de generar las respectivas alertas de estado 
crítico y condición de emergencia.

Requerimientos:
•	Se pide que se modele este problema utilizando un Objeto “Quebrada” en cuya definición se 
    tengan los atributos de nombre, caudal y estado crítico.
•	Al momento de inicializar el objeto “Quebrada”, el valor del caudal se asigna como un número 
    entero entre 0 y 100. Si el valor asignado es superior al 80% se establece el estado como crítico.
•	Se debe implementar una función denominada “ValoraCondicionEmergencia” que devuelve un valor 
    booleano si se presenta las condiciones indicadas en el enunciado.
•	Se debe visualizar los resultados para cada quebrada y si hay la condición emergencia para 
    la ciudad.
•	Se debe implementar el control de excepciones y las validaciones para que los valores numéricos 
    ingresados por el usuario cumplan los rangos especificados.
•	Se debe implementar un proyecto de pruebas unitarias que permita evaluar escenarios de ejecución 
    correcta para la función “ValoraCondicionEmergencia”

 */

using System;

namespace MonitoreoQuebradas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa para monitorear Quebradas");

            string[] nombresQuebradas = { "La Picacha",
                                          "La Presidenta",
                                          "Santa Elena",
                                          "La Hueso",
                                          "La Iguaná" };

            Console.WriteLine("Se vigilarán las siguientes quebradas:");

            foreach (string nombreCharquito in nombresQuebradas)
                Console.WriteLine($"- {nombreCharquito}");

            //Aqui definimos el arreglo de quebradas
            Quebrada[] lasQuebradas = new Quebrada[nombresQuebradas.Length];

            //Aqui inicializamos el arreglo y asignamos el nombre de cada quebrada
            for (int i = 0; i < lasQuebradas.Length; i++)
            {
                lasQuebradas[i] = new Quebrada();
                lasQuebradas[i].Nombre = nombresQuebradas[i];
            }

            int contadorQuebradas = 0;
            while (contadorQuebradas < lasQuebradas.Length)
            {
                try
                {
                    Console.Write($"\nIngresa el caudal para la quebrada {lasQuebradas[contadorQuebradas].Nombre}: ");
                    lasQuebradas[contadorQuebradas].Caudal = int.Parse(Console.ReadLine());

                    if (lasQuebradas[contadorQuebradas].Caudal >= 0 && lasQuebradas[contadorQuebradas].Caudal <= 100)
                        contadorQuebradas++;
                    else
                        Console.WriteLine("El dato de caudal debe estar entre [0;100]. Intenta nuevamente!");
                }
                catch (FormatException elError)
                {
                    Console.WriteLine("El dato de caudal debe ser número entero. Intenta nuevamente!");
                    Console.WriteLine($"Error: {elError.Message}");
                }
            }

            //Aqui visualizamos la información ingresada
            Console.WriteLine("\n\nLos datos de las quebradas son:");

            foreach (Quebrada unaQuebrada in lasQuebradas)
                Console.WriteLine($"- {unaQuebrada.GetInfo()}");

            //Aqui evaluamos si hay condición de emergencia
            if (EvaluaCondicionEmergencia(lasQuebradas))
            {
                Console.WriteLine("\n*** ALERTAAAAAA *****");
                Console.WriteLine("Tres o más quebradas están en estado crítico!");
            }
            else
            {
                Console.WriteLine("\nTodavía no hay alerta. Favor estar atento!");
            }
        }

        /// <summary>
        /// Identifica si se presenta condición de emergencia en la ciudad
        /// </summary>
        /// <param name="arregloQuebradas">Las quebradas que son monitoreadas</param>
        /// <returns>Hay o no condición de emergencia</returns>
        public static bool EvaluaCondicionEmergencia(Quebrada[] arregloQuebradas)
        {
            //Condición de emergencia se da cuando tres o más quebradas
            //Están en estado crítico
            bool resultado = false;

            // Identificamos cuantas quebradas están en estado crítico
            int totalCriticas = TotalQuebradasCriticas(arregloQuebradas);

            if (totalCriticas >= 3)
                resultado = true;

            return resultado;
        }

        /// <summary>
        /// Cuenta cuantas de las quebradas están en estado crítico
        /// </summary>
        /// <param name="arregloQuebradas">Las quebradas</param>
        /// <returns>Total Quebradas criticas</returns>
        public static int TotalQuebradasCriticas(Quebrada[] arregloQuebradas)
        {
            int totalCriticas = 0;

            foreach (Quebrada unaQuebrada in arregloQuebradas)
                if (unaQuebrada.EstadoCritico == "SI")
                    totalCriticas++;

            return totalCriticas;
        }
    }
}