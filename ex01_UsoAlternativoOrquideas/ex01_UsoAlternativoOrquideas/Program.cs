/*
Programa:       ex01_UsoAlternativoOrquideas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com
Propósito:
----------

Examen 01: Clases y Objetos, Herencia, Polimorfismo



Feria de Flores –Usos alternativos de las orquídeas
****************************************************

Medellín se encuentra nuevamente en Feria de las Flores y uno 
de los eventos principales es el concurso de orquídeas. En 
esta oportunidad, los floricultores están explorando usos 
alternativos de estas flores más allá de sus cualidades 
decorativas.

Colombia es favorecido por la diversidad de estas flores, las 
cuales se presentan en las seis regiones delpaís (Andina, 
Pacífico,Caribe, Orinoquía, Amazonía y Territorios Insulares)
con períodos de floración entrelos meses de febrero a abril y 
septiembre a octubre.

Recientemente  se  ha  identificado  que  algunas  orquídeas 
presentan  sabores  y  olores  que  pueden  abrir oportunidades  
a  otros  mercados.  En  esta  feria,  se  presentan  empresarios  
que  cultivan  orquídeaspara comer y para perfumar.

Los  empresarios  han  decidido  aprovechar el  concurso  para  
preguntarle  a  los  visitantes  cuales  son  las variedades
que son más aceptadas dentro de las opciones presentadas. Se tomaron
1.000 encuestas en las que los visitantes se comieron la orquídea,
la olieron o hicieron ambas acciones.

Finalizado el evento, los empresarios quieren conocer cuáles fueron 
las más exitosaspor región, mes de floración y utilización.

Realice un programa en C#.NET –aplicación de Consola que permita 
simular evaluación de 1.000 orquídeas, las cuales tienen una región 
de origen y un mes de floración. Algunas de las orquídeas serán solo 
para comer, otras solo para perfumar y otras para ambas.

Puede utilizar clases  abstractas e  interfaces  para  definir la 
jerarquía  de herencia  requerida,  si considera que lo necesita.

Todas las orquídeas tendrán un método “InformacionOrquidea” el cual 
oodría ser sobrescrito y tendrá  como  propósito  visualizar toda  
la  información  de  la  orquídea:  RegiónOrigen,  Mes Floración, 
Utilización.

En   la   clase   principal,   implemente dos métodos denominados 
“UsoExitosoPorRegion”y “MesFloracionPorRegion” cada  uno  recibe el  
arreglo de  orquídeas  y  el  nombre  de la  región y devuelve  
respectivamente  cual  es  el  uso  y  el  mes  de floración  más  
frecuente. En  caso  de presentarse algún empate, se devuelve el primer 
valor encontrado. 

El programa debe visualizar la tabla de resultados visualizando para 
cada región, la cantidad total de orquídeas, el mes de floración más
frecuentey el uso más exitoso.

*/

using System;

namespace ex01_UsoAlternativoOrquideas
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Definición de posibles valores para los atributos de la orquidea
            string[] regionesOrigen = { "Andina", "Pacífica", "Caribe", "Orinoquía", "Amazonía", "Territorio Insular" };
            string[] mesesFloracion = { "Febrero", "Marzo", "Abril", "Septiembre", "Octubre" };
            string[] posiblesUtilizaciones = { "Comida", "Perfume", "Comida y Perfume" };

            Console.WriteLine("*** Programa para simular la utilización de 1.000 orquídeas ***");
            
            Console.WriteLine("\nSe generarán orquideas de las siguienes regiones:");
            foreach (string origen in regionesOrigen)
                Console.WriteLine($" - {origen}");

            Console.WriteLine("\nEn los siguientes meses de floración:");
            foreach (string mes in mesesFloracion)
                Console.WriteLine($" - {mes}");

            Console.WriteLine("\nPara las siguientes utilizaciones:");
            foreach (string utilizacion in posiblesUtilizaciones)
                Console.WriteLine($" - {utilizacion}");

            Console.Write("\nGenerando 1000 orquídeas... ");

            Orquidea[] lasOrquideas = new Orquidea[1000];
            Random aleatorio = new Random();

            for (int i = 0; i < lasOrquideas.Length; i++)
            {
                lasOrquideas[i] = new Orquidea()
                {
                    Origen = regionesOrigen[aleatorio.Next(regionesOrigen.Length)],
                    MesFloracion = mesesFloracion[aleatorio.Next(mesesFloracion.Length)],
                    Utilizacion = posiblesUtilizaciones[aleatorio.Next(posiblesUtilizaciones.Length)]
                };
            }

            Console.WriteLine("Listo!");

            //Console.WriteLine("\n\nOrquídeas generadas:");
            //VisualizaDetalleOrquideas(lasOrquideas);

            //Aqui calculamos el mes de floración más exitoso

            //MesFloracionPorRegion
            string[] mesFloracionExitosoPorRegion = MesFloracionPorRegion(lasOrquideas, regionesOrigen, mesesFloracion);

            //UsoExitosoPorRegion
            string[] usoPreferidoPorRegion = UsoExitosoPorRegion(lasOrquideas, regionesOrigen, posiblesUtilizaciones);

            //Aqui visualizamos resultados
            Console.WriteLine("\nResultados de la utilización preferida");
            Console.WriteLine("****************************************\n");

            for (int i = 0; i < regionesOrigen.Length; i++)
                Console.WriteLine($"Región: {regionesOrigen[i]} \n" +
                    $"Mes Floración: {mesFloracionExitosoPorRegion[i]} \n" +
                    $"Uso Preferido: {usoPreferidoPorRegion[i]}\n");

        }

        /// <summary>
        /// Obtiene Los nombres de los meses más exitosos de floración para cada región
        /// </summary>
        /// <param name="lasOrquideas">Colección de Orquideas</param>
        /// <param name="regionesOrigen">Las regiones de las orquideas</param>
        /// <param name="mesesFloracion">los meses de floración</param>
        /// <returns>Arreglo con los nombres del mes más exitoso por cada región</returns>
        public static string[] MesFloracionPorRegion(Orquidea[] lasOrquideas, string[] regionesOrigen, string[] mesesFloracion)
        {
            string[] mesesPorRegion = new string[regionesOrigen.Length];

            //Invocamos la función que totaliza los meses por region
            //Utilización de la matriz:
            //  Dimensión: 0, indice: i. variable: region origen
            //  Dimensión: 1, indice: j. variable: mes
            //  Valor: Total orquideas con la combinación region/mes
            int[,] totalizacionMesRegion = TotalizaMesFloracionPorRegion(lasOrquideas, regionesOrigen, mesesFloracion);

            //Recorremos la matriz de totalización identificando para cada mes cual fue el de mayor valor
            int cantidadOrquideasDelMesPreferido = 0;
            int[] indicesDelMes = new int[regionesOrigen.Length];

            for (int i = 0; i < regionesOrigen.Length; i++)
            {
                //Para cada región, seleccionamos arbitrariamente el primer mes como el preferido
                indicesDelMes[i] = 0;
                cantidadOrquideasDelMesPreferido = totalizacionMesRegion[i, 0];
                
                //Aqui recorremos el resto de la matriz buscando si hay otros meses con valor mayor
                for (int j = 1; j < mesesFloracion.Length; j++)
                {
                    if (totalizacionMesRegion[i, j] > cantidadOrquideasDelMesPreferido)
                    {
                        indicesDelMes[i] = j;
                        cantidadOrquideasDelMesPreferido = totalizacionMesRegion[i, j];
                    }
                }
            }

            //Luego obtenemos el nombre del mes según el aareglo de meses de floracion
            for (int i = 0; i < regionesOrigen.Length; i++)
                mesesPorRegion[i] = mesesFloracion[indicesDelMes[i]];


            //Finalmente, devolvemos el resultado
            return mesesPorRegion;
        }

        /// <summary>
        /// Obtiene las utilizaciones más exitosas de la flor para cada región
        /// </summary>
        /// <param name="lasOrquideas">Colección de Orquideas</param>
        /// <param name="regionesOrigen">Las regiones de las orquideas</param>
        /// <param name="posiblesUtilizaciones">los posibles usos de la floración</param>
        /// <returns>Arreglo con la utilización más exitos por cada región</returns>
        public static string[] UsoExitosoPorRegion(Orquidea[] lasOrquideas, string[] regionesOrigen, string[] posiblesUtilizaciones)
        {
            string[] usosPorRegion = new string[regionesOrigen.Length];

            //Invocamos la función que totaliza posibles utilizaciones por region
            //Utilización de la matriz:
            //  Dimensión: 0, indice: i. variable: region origen
            //  Dimensión: 1, indice: j. variable: posibles utilizaciones
            //  Valor: Total orquideas con la combinación region/posibles utilizaciones
            int[,] totalizacionUsoRegion = TotalizaUtilizacionPorRegion(lasOrquideas, regionesOrigen, posiblesUtilizaciones);

            //Recorremos la matriz de totalización identificando para cada mes cual fue el de mayor valor
            int cantidadDeOrquideasDelUsoPreferido = 0;
            int[] indicesDelUso = new int[regionesOrigen.Length];

            for (int i = 0; i < regionesOrigen.Length; i++)
            {
                //Para cada región, seleccionamos arbitrariamente el primer mes como el preferido
                indicesDelUso[i] = 0;
                cantidadDeOrquideasDelUsoPreferido = totalizacionUsoRegion[i, 0];

                //Aqui recorremos el resto de la matriz buscando si hay otros meses con valor mayor
                for (int j = 1; j < posiblesUtilizaciones.Length; j++)
                {
                    if (totalizacionUsoRegion[i, j] > cantidadDeOrquideasDelUsoPreferido)
                    {
                        indicesDelUso[i] = j;
                        cantidadDeOrquideasDelUsoPreferido = totalizacionUsoRegion[i, j];
                    }
                }
            }

            //Luego obtenemos el nombre del mes según el aareglo de meses de floracion
            for (int i = 0; i < regionesOrigen.Length; i++)
                usosPorRegion[i] = posiblesUtilizaciones[indicesDelUso[i]];


            //Finalmente, devolvemos el resultado
            return usosPorRegion;
        }

        /// <summary>
        /// Totaliza la colección de orquideas por mes de floración de acuerdo a la región
        /// </summary>
        /// <param name="lasOrquideas">Colección de Orquideas</param>
        /// <param name="regionesOrigen">Las regiones de las orquideas</param>
        /// <param name="mesesFloracion">los meses de floración</param>
        /// <returns>matriz con la totalización de orquideas por mes según la región</returns>
        public static int[,] TotalizaMesFloracionPorRegion(Orquidea[] lasOrquideas, string[] regionesOrigen, string[] mesesFloracion)
        {
            int[,] totalesMesesRegion = new int[regionesOrigen.Length,mesesFloracion.Length];

            //Aqui inicializamos el arreglo
            for (int i = 0; i < regionesOrigen.Length; i++)
                for (int j = 0; j < mesesFloracion.Length; j++)
                    totalesMesesRegion[i, j] = 0;

            //Aqui empezamos el proceso de totalización
            //Utilización de la matriz:
            //  Dimensión: 0, indice: i. variable: region origen
            //  Dimensión: 1, indice: j. variable: mes
            //  Valor: Total orquideas con la combinación region/mes
            for (int i = 0; i < regionesOrigen.Length; i++)
                for (int j = 0; j < mesesFloracion.Length; j++)
                    for (int k = 0; k < lasOrquideas.Length; k++)
                        if (lasOrquideas[k].Origen == regionesOrigen[i] &&
                            lasOrquideas[k].MesFloracion == mesesFloracion[j])
                            totalesMesesRegion[i, j]++;

            //Aqui visualizamos resultados -- Depuración
            //Console.WriteLine("*** Totales por región y mes:\n");
            //for (int i = 0; i < regionesOrigen.Length; i++)
            //    for (int j = 0; j < mesesFloracion.Length; j++)
            //    {
            //        Console.WriteLine($"Region: {regionesOrigen[i]}, mes: {mesesFloracion[j]}, Valor Obtenido: {totalesMesesRegion[i, j]}");
            //    }

            //Console.ReadKey();

            return totalesMesesRegion;
        }

        /// <summary>
        /// Totaliza la colección de orquideas por mes de floración de acuerdo a la región
        /// </summary>
        /// <param name="lasOrquideas">Colección de Orquideas</param>
        /// <param name="regionesOrigen">Las regiones de las orquideas</param>
        /// <param name="posiblesUtilizaciones">Las posibles utilizaciones</param>
        /// <returns>matriz con la totalización de orquideas por posible utilización según la región</returns>
        public static int[,] TotalizaUtilizacionPorRegion(Orquidea[] lasOrquideas, string[] regionesOrigen, string[] posiblesUtilizaciones)
        {
            int[,] totalesUtilizacionPorRegion = new int[regionesOrigen.Length, posiblesUtilizaciones.Length];

            //Aqui inicializamos el arreglo
            for (int i = 0; i < regionesOrigen.Length; i++)
                for (int j = 0; j < posiblesUtilizaciones.Length; j++)
                    totalesUtilizacionPorRegion[i, j] = 0;

            //Aqui empezamos el proceso de totalización
            //Utilización de la matriz:
            //  Dimensión: 0, indice: i. variable: region origen
            //  Dimensión: 1, indice: j. variable: posibles utilizaciones
            //  Valor: Total orquideas con la combinación region/posible utilizacion
            for (int i = 0; i < regionesOrigen.Length; i++)
                for (int j = 0; j < posiblesUtilizaciones.Length; j++)
                    for (int k = 0; k < lasOrquideas.Length; k++)
                        if (lasOrquideas[k].Origen == regionesOrigen[i] &&
                            lasOrquideas[k].Utilizacion == posiblesUtilizaciones[j])
                            totalesUtilizacionPorRegion[i, j]++;

            //Aqui visualizamos resultados -- Depuración

            //Console.WriteLine("*** Totales por región y Utilizacion:\n");
            //for (int i = 0; i < regionesOrigen.Length; i++)
            //    for (int j = 0; j < posiblesUtilizaciones.Length; j++)
            //    {
            //        Console.WriteLine($"Region: {regionesOrigen[i]}, Utilización: {posiblesUtilizaciones[j]}, Valor Obtenido: {totalesUtilizacionPorRegion[i, j]}");
            //    }

            //Console.ReadKey();

            return totalesUtilizacionPorRegion;
        }

        /// <summary>
        /// Visualiza en Consola el detalle de cada orquidea
        /// </summary>
        /// <param name="lasOrquideas">Arreglo de Orquideas</param>
        public static void VisualizaDetalleOrquideas(Orquidea[] lasOrquideas)
        {
            int j = 1;
            foreach (Orquidea unaOrquidea in lasOrquideas)
            {
                Console.WriteLine($"No. {j}: \n" + unaOrquidea.InformacionOrquidea());
                j++;
            }
        }
    }
}
