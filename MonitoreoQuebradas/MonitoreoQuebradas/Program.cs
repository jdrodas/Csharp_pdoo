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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitoreoQuebradas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Monitoreo de quebradas en Medellín\n");

            Console.WriteLine("Se vigilarán las siguientes quebradas:");

            string[] nombresQuebradas = { "La Presidenta", "La Iguaná", "La Picacha", "Santa Elena", "La Hueso" };

            foreach (string unNombre in nombresQuebradas)
                Console.WriteLine($"-{unNombre}");

            //Aqui declaramos un arreglo de quebradas con tantas posiciones como nombres tengamoss definidos
            Quebrada[] lasQuebradas = new Quebrada[nombresQuebradas.Length];

            //Aqui inicializamos el arreglo, inicializando cada posición con una instancia de la clase quebrada
            //Luego, a cada posición le podemos asignar el atributo de nombre a través de la propiedad
            for (int i = 0; i < lasQuebradas.Length; i++)
            {
                lasQuebradas[i] = new Quebrada();
                lasQuebradas[i].Nombre = nombresQuebradas[i];
            }

            //Aqui visualizamos la información de cada posición usando el método GetInfo()

            Console.WriteLine("\n\nInformación detallada de cada quebrada: \n");

            foreach (Quebrada unaQuebrada in lasQuebradas)
                Console.WriteLine(unaQuebrada.GetInfo());
        }
    }
}
