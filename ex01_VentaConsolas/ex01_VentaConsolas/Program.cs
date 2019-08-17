/*
Programa:       ex01_VentaConsolas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com
Propósito:
----------

Examen 01: Clases y Objetos, Arreglos, Funciones


Venta de consolas de videojuegos
*********************************

La cadena comercial “La parada del juego”, está considerando la implementación de talleres de soporte y 
reparación para consolas de videojuegos basado en los niveles de venta de las tres consolas 
principales (Sony PlayStation, Microsoft Xbox, Nintendo Switch) en cinco ciudades principales del país.
Se desea conocer información sobre el nivel de participación de ventas basado en los pedidos realizados 
entre las fechas 01/01/2018 y 31/12/2018.

Para cumplir este cometido, La Empresa te ha comisionado la construcción de una aplicación de consola en 
C#.NET que pueda simular el procesamiento de 1000 pedidos para obtener la participación porcentual del 
mercado discriminado por consola, ciudad, y mes de venta.

Al comienzo de la ejecución, la aplicación solicitará el nombre de las 5 ciudades para las cuales se 
pretende generar el informe.Con esta información, se inicializará un arreglo de objetos tipo Pedido.

Para inicializar el arreglo, cada elemento tendrá una asignación aleatoria en sus atributos:

•	Una Consola entre las tres posibles.
•	Una Ciudad entre las cinco posibles, según los valores ingresados.
•	Una fecha entre 01/01/2018 y 31/12/2018.

La aplicación luego de inicializar los 1000 elementos visualizará las participaciones por cada uno de los 
criterios, totalizando para cada valor en su atributo con su correspondiente porcentaje:

•	Participación porcentual por consola.
•	Participación porcentual por ciudad.
•	Participación porcentual por mes de venta.

Requerimientos de implementación

En el proyecto a implementar, se debe tener las siguientes clases con los siguientes método:

Clase Pedido:
Almacenará la información del pedido utilizando los atributos y propiedades especificados.
El constructor de la clase asignará valores predeterminados que no afecten el algoritmo de cálculo del problema.

Clase Program:
Adicional al método Main() se deben implementar los métodos:

            float[] CalculaPorcentajeConsolas(Pedido[] losPedidos, string[] consolas)
            float[] CalculaPorcentajeCiudades(Pedido[] losPedidos, string[] ciudades)
            float[] CalculaPorcentajeMeses(Pedido[] losPedidos)

Éstos son responsables de obtener los porcentajes de participación según el criterio. Tenga presente que todos 
estos métodos son estáticos para poder ser invocados en el método Main()

En el método Main() es donde debe declararse, inicializarse y consultarse el arreglo de Pedidos de acuerdo a la 
cantidad especificada en el enunciado.


Sugerencias:
•	Para el cálculo aleatorio de fechas, parta de la fecha inicial y adicione una cantidad aleatoria de días 
en el rango existente entre las fechas indicadas. Puede utilizar el método AddDays de la clase DateTime.

•	Para obtener el mes de una fecha, puede utilizar la propiedad Month, que devuelve un entero que representa el 
mes en el rango[1:12].

*/

using System;

namespace ex01_VentaConsolas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para la simulación de venta de Consolas de videojuegos");
            Console.WriteLine("Se simulará la venta de 1000 pedidos con información de fecha, ciudad y consola");
            Console.WriteLine("Las fechas van entre 01/01/2018 y 31/12/2018");
            Console.WriteLine("Las consolas serán PlayStation, XBox y Switch");
            Console.WriteLine("Las ubicaciones serán en 5 ciudades");

            //arreglo con el nombre de las consolas
            string[] consolas = { "PlayStation", "XBox", "Switch" };

            //Aqui capturamos la información de las ciudades
            string[] ciudades = new string[5];

            Console.WriteLine("\n\nIngreso de ciudades para la venta:");

            for (int i = 0; i < ciudades.Length; i++)
            {
                Console.Write("Ingresa el nombre de la ciudad No. {0}: ", i + 1);
                ciudades[i] = Console.ReadLine();
            }

            Console.Write("\n\nInicializando los elementos de la simulación... ");

            //aqui inicializamos el arreglo de 1000 pedidos
            Random aleatorio = new Random();

            Pedido[] losPedidos = new Pedido[1000];

            for (int i = 0; i < losPedidos.Length; i++)
            {
                losPedidos[i] = new Pedido();
                losPedidos[i].Ciudad = ciudades[aleatorio.Next(ciudades.Length)];
                losPedidos[i].Consola = consolas[aleatorio.Next(consolas.Length)];
                losPedidos[i].Fecha = new DateTime(2018, 1, 1).AddDays(aleatorio.Next(365)); //fecha inicio + aleatorio de 365 días
            }

            Console.WriteLine("Finalizado!");

            //Aqui visualizamos los resultados.
            float[] porcConsolas = CalculaPorcentajeConsolas(losPedidos, consolas);
            float[] porcCiudades = CalculaPorcentajeCiudades(losPedidos, ciudades);
            float[] porcMeses = CalculaPorcentajeMeses(losPedidos);

            float sumaPorcentajes = 0;

            //Viendo resultados por consola
            Console.WriteLine("\n\nParticipaciones por Consola:");
            for (int i = 0; i < consolas.Length; i++)
            {
                Console.WriteLine("Consola: {0}, participación: {1} %", consolas[i], porcConsolas[i]);
                sumaPorcentajes += porcConsolas[i];
            }
            Console.WriteLine("Suma porcentajes: {0} %", sumaPorcentajes);

            //Viendo resultados por Ciudad
            sumaPorcentajes = 0;

            Console.WriteLine("\n\nParticipaciones por Ciudad:");
            for (int i = 0; i < ciudades.Length; i++)
            {
                Console.WriteLine("Ciudad: {0}, participación: {1} %", ciudades[i], porcCiudades[i]);
                sumaPorcentajes += porcCiudades[i];
            }
            Console.WriteLine("Suma porcentajes: {0} %", sumaPorcentajes);


            //Viendo resultados por Mes
            sumaPorcentajes = 0;

            Console.WriteLine("\n\nParticipaciones por mes de venta:");
            for (int i = 0; i < porcMeses.Length; i++)
            {
                Console.WriteLine("Mes: {0}, participación: {1} %", i + 1, porcMeses[i]);
                sumaPorcentajes += porcMeses[i];
            }

            Console.WriteLine("Suma porcentajes: {0} % \n\n", sumaPorcentajes);
        }

        /// <summary>
        /// Obtiene los porcentajes de participacion de las consolas en el arreglo de pedidos
        /// </summary>
        /// <param name="losPedidos">El arreglo de pedidos</param>
        /// <param name="consolas">El arreglo de consolas</param>
        /// <returns></returns>
        static float[] CalculaPorcentajeConsolas(Pedido[] losPedidos, string[] consolas)
        {
            //Aqui declaramos un arreglo para almacenar el resultado
            float[] resultado = new float[consolas.Length];
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            //Aqui recorremos el arreglo de pedidos y contabilizamos según el atributo de consolas
            for (int i = 0; i < losPedidos.Length; i++)
                for (int j = 0; j < consolas.Length; j++)
                    if (losPedidos[i].Consola == consolas[j])
                        resultado[j]++;

            //Finalmente dividimos por el total de pedidos
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] *= (100f / losPedidos.Length); //es un porcentaje

            return resultado;
        }

        /// <summary>
        /// Obtiene los porcentajes de participacion de las ciudades en el arreglo de pedidos
        /// </summary>
        /// <param name="losPedidos">El arreglo de pedidos</param>
        /// <param name="ciudades">El arreglo de ciudades</param>
        /// <returns></returns>
        static float[] CalculaPorcentajeCiudades(Pedido[] losPedidos, string[] ciudades)
        {
            //Aqui declaramos un arreglo para almacenar el resultado
            float[] resultado = new float[ciudades.Length];
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            //Aqui recorremos el arreglo de pedidos y contabilizamos según el atributo de consolas
            for (int i = 0; i < losPedidos.Length; i++)
                for (int j = 0; j < ciudades.Length; j++)
                    if (losPedidos[i].Ciudad == ciudades[j])
                        resultado[j]++;

            //Finalmente dividimos por el total de pedidos
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] *= (100f / losPedidos.Length); //es un porcentaje

            return resultado;
        }

        /// <summary>
        /// Obtiene los porcentajes de participacion de los meses en el arreglo de pedidos
        /// </summary>
        /// <param name="losPedidos"></param>
        /// <returns></returns>
        static float[] CalculaPorcentajeMeses(Pedido[] losPedidos)
        {
            float[] resultado = new float[12]; // Son 12 meses
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] = 0;

            int numeroMes;

            //aqui recorremos el arreglo de pedidos y contabilizamos según el atributo del mes de la fecha compra
            for (int i = 0; i < losPedidos.Length; i++)
            {
                numeroMes = losPedidos[i].Fecha.Month; // Obtenemos el mes, que va de 1 a 12
                resultado[numeroMes - 1]++; //lo ubicamos en el arreglo, que va de 0 a 11
            }

            //Finalmente dividimos por el total de pedidos
            for (int i = 0; i < resultado.Length; i++)
                resultado[i] *= (100f / losPedidos.Length); //es un porcentaje

            return resultado;
        }
    }
}
