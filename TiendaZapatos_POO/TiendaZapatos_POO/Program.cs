using System;

namespace TiendaZapatos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para abastecer una tienda de zapatos");
            Console.WriteLine("Llenaremos el inventario de la tienda con 1000 zapatos");
            Console.WriteLine("Cada zapato tiene tres atributos: color, talla, estilo");

            string[] colores = { "verde", "negro", "violeta", "amarillo", "naranja" };
            string[] estilos = {
                                 "Crocs",
                                 "Sandalia Gladiadora",
                                 "Botas",
                                 "Tenis",
                                 "Alpargatas",
                                 "Sandalia Tres puntadas"};

            Zapato[] inventario = new Zapato[1000];

            Random aleatorio = new Random();

            for (int i = 0; i < inventario.Length; i++)
            {
                inventario[i] = new Zapato();
                inventario[i].Color = colores[aleatorio.Next(colores.Length)];
                inventario[i].Estilo = estilos[aleatorio.Next(estilos.Length)];
                inventario[i].Talla = aleatorio.Next(34, 46);
            }

            Console.WriteLine("\nInventario generado... visualizando los primeros 10 zapatos:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Zapato No. {0}, estilo: {1}, color: {2}, talla: {3}",
                    i + 1,
                    inventario[i].Estilo,
                    inventario[i].Color,
                    inventario[i].Talla);
            }

            //string estiloModa = ObtieneEstiloModa(inventario, estilos);
            int tallaModa = 0, cantTallaModa = 0;
            ObtieneTallaModa(inventario, ref tallaModa, ref cantTallaModa);

            string colorModa = "";
            int cantColorModa = 0;

            ObtieneColorModa(inventario, colores, ref colorModa, ref cantColorModa);

            string estiloModa = "";
            int cantEstiloModa = 0;

            ObtieneEstiloModa(inventario, estilos, ref estiloModa, ref cantEstiloModa);

            Console.WriteLine("\nLa talla más frecuente fue {0} con una cantidad de {1} zapatos", tallaModa, cantTallaModa);
            Console.WriteLine("El color más frecuente fue {0} con una cantidad de {1} zapatos", colorModa, cantColorModa);
            Console.WriteLine("El estilo más frecuente fue {0} con una cantidad de {1} zapatos", estiloModa, cantEstiloModa);
        }

        /// <summary>
        /// Calcula cual es el estilo que más zapatos abastecieron a la tienda y cuantos pares fueron
        /// </summary>
        /// <param name="arregloZapatos">El inventario de zapatos</param>
        /// <param name="arregloEstilos">Los estilos definidos</param>
        /// <param name="p_colorModa">referencia al estilo de moda</param>
        /// <param name="p_cantidad">referencia a la cantidad de zapatos del estilo de moda</param>
        static void ObtieneEstiloModa(Zapato[] arregloZapatos, string[] arregloEstilos, ref string p_estiloModa, ref int p_cantidad)
        {
            //declaramos un arreglo para almacenar las cantidades por colores y lo inicializamos en cero
            int[] contadorEstilos = new int[arregloEstilos.Length];
            for (int i = 0; i < contadorEstilos.Length; i++)
                contadorEstilos[i] = 0;

            //aqui incrementamos cada contador en la medida que aparezca un valor de color
            for (int i = 0; i < arregloZapatos.Length; i++)
            {
                for (int j = 0; j < arregloEstilos.Length; j++)
                {
                    if (arregloZapatos[i].Estilo == arregloEstilos[j])
                        contadorEstilos[j]++;
                }
            }

            //Aqui identificamos cual es el color con más frecuencia
            int maxFrecuencia = contadorEstilos[0];
            int posicion = 0;

            for (int i = 1; i < contadorEstilos.Length; i++)
            {
                if (contadorEstilos[i] > maxFrecuencia)
                {
                    maxFrecuencia = contadorEstilos[i];
                    posicion = i;
                }
            }

            //aqui finalmente devolvemos los resultados
            //aqui devolvemos los valores de la talla más frecuente y cual es su frecuencia
            //Aqui estamos devolviendo los resultados aprovechando que los parámetros del método son por referencia
            p_estiloModa = arregloEstilos[posicion];
            p_cantidad = maxFrecuencia;
        }

        /// <summary>
        /// Calcula cual es el color que más zapatos abastecieron a la tienda y cuantos pares fueron
        /// </summary>
        /// <param name="arregloZapatos">El inventario de zapatos</param>
        /// <param name="arregloColores">Los colores definidos</param>
        /// <param name="p_colorModa">referencia al color de moda</param>
        /// <param name="p_cantidad">referencia a la cantidad de zapatos del color de moda</param>
        static void ObtieneColorModa(Zapato[] arregloZapatos, string[] arregloColores, ref string p_colorModa, ref int p_cantidad)
        {

            //declaramos un arreglo para almacenar las cantidades por colores y lo inicializamos en cero
            int[] contadorColores = new int[arregloColores.Length];
            for (int i = 0; i < contadorColores.Length; i++)
                contadorColores[i] = 0;

            //aqui incrementamos cada contador en la medida que aparezca un valor de color
            for (int i = 0; i < arregloZapatos.Length; i++)
            {
                for (int j = 0; j < arregloColores.Length; j++)
                {
                    if (arregloZapatos[i].Color == arregloColores[j])
                        contadorColores[j]++;
                }
            }

            //Aqui identificamos cual es el color con más frecuencia
            int maxFrecuencia = contadorColores[0];
            int posicion = 0;

            for (int i = 1; i < contadorColores.Length; i++)
            {
                if (contadorColores[i] > maxFrecuencia)
                {
                    maxFrecuencia = contadorColores[i];
                    posicion = i;
                }
            }

            //aqui finalmente devolvemos los resultados
            //aqui devolvemos los valores de la talla más frecuente y cual es su frecuencia
            //Aqui estamos devolviendo los resultados aprovechando que los parámetros del método son por referencia
            p_colorModa = arregloColores[posicion];
            p_cantidad = maxFrecuencia;
        }

        /// <summary>
        /// Calcula cual es la talla que más zapatos se abastecieron a la tienda y cuantos pares  fueron
        /// </summary>
        /// <param name="arregloZapatos">El inventario de zapatos</param>
        /// <param name="p_talla">Referencia a la talla de moda</param>
        /// <param name="p_cantidad">referencia a la cantidad de zapatos de la talla de moda</param>
        static void ObtieneTallaModa(Zapato[] arregloZapatos, ref int p_talla, ref int p_cantidad)
        {
            //aqui viene la magia

            //encontramos mínimo y máximo
            int tallaMinima = arregloZapatos[0].Talla;
            int tallaMaxima = arregloZapatos[0].Talla;

            for (int i = 1; i < arregloZapatos.Length; i++)
            {
                //aqui pregunto por el máximo
                if (arregloZapatos[i].Talla > tallaMaxima)
                    tallaMaxima = arregloZapatos[i].Talla;

                //aqui pregunto por el mínimo
                if (arregloZapatos[i].Talla < tallaMinima)
                    tallaMinima = arregloZapatos[i].Talla;
            }

            int cantidadTallas = (tallaMaxima - tallaMinima) + 1;

            int[] contadorTallas = new int[cantidadTallas];

            for (int i = 0; i < contadorTallas.Length; i++)
                contadorTallas[i] = 0;

            //aqui incrementamos cada contador en la medida que aparezca un valor de talla
            for (int i = 0; i < arregloZapatos.Length; i++)
                contadorTallas[(arregloZapatos[i].Talla - tallaMinima)]++;

            //aqui encontramos que posición corresponde a la que tiene la máxima frecuencia
            int maxFrecuencia = contadorTallas[0];
            int posicion = 0;

            for (int i = 1; i < contadorTallas.Length; i++)
            {
                if (contadorTallas[i] > maxFrecuencia)
                {
                    maxFrecuencia = contadorTallas[i];
                    posicion = i;
                }
            }

            //aqui devolvemos los valores de la talla más frecuente y cual es su frecuencia
            //Aqui estamos devolviendo los resultados aprovechando que los parámetros del método son por referencia
            p_talla = tallaMinima + posicion;
            p_cantidad = maxFrecuencia;
        }
    }
}
