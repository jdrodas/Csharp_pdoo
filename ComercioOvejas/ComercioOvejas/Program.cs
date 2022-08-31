/*
Programa:       ComercioOvejas
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------

Comercio de Ovejas

Granjeros Europeos han decidido organizarse en una cooperativa 
para comercializar productos basados en sus rebaños de ovejas. 

Han identificado potencial de mercado para la lana y la leche de 
sus animales, pero los mercados tienen unas reglas estrictas sobre 
el manejo y sostenibilidad de la producción.

En términos generales, las ovejas hembra se destinarán a la 
producción de leche y las ovejas macho se destinarán a la producción 
de lana. 

•	Se ha determinado que la edad aceptable para que una oveja sea 
    considerada apta, debe estar entre los 24 y 84 meses. La edad máxima 
    de una oveja es 12 años (144 meses)
•	Se ha determinado que el peso mínimo de la oveja para ser considerada 
    apta debe ser de 35 kg. El peso máximo de una oveja es de 180 kg. 
    Solo se aprovechará el 20% del peso de la oveja como cantidad de lana 
    producida.
•	Se ha determinado que la producción lechera de las hembras debe ser 
    mínimo de 1.200 lts de los cuales 0.8 lts deben ser para alimentación 
    de las crías. Rango de producción lechera entre 2 lts y 6 lts. 

La cooperativa definió precios de venta de $1500 por litro de leche y $800 
por Kg de lana. La cooperativa cobrará 5% de comisión por gestionar la 
comercialización del producto.

Se desea hacer una aplicación que simule la llegada de un granjero con 100 
ovejas e identifique que porcentaje de sus ovejas son aptas para producción 
lechera y producción de lana. De sus ovejas aptas, cuanto produce de lana y 
cuanto de leche. Cuanto recibe por venta de lana y leche. Cuanto recibe la 
cooperativa por la venta de los productos.
 */



using System;

namespace ComercioOvejas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comercio de OOOvejas");
            Console.WriteLine("Se simularán 1000 ovejas para identificar su producción\n");

            Oveja[] lasOvejas= new Oveja[1000];
            Random aleatorio = new Random();

            string[] losSexos = { "Macho", "Hembra" };
            string elSexo = "";

            //Aqui inicializamos el arreglo de Ovejas
            for (int i = 0; i < lasOvejas.Length; i++)
            {
                elSexo = losSexos[aleatorio.Next(losSexos.Length)];

                if (elSexo == "Macho")
                {
                    lasOvejas[i] = new OvejaLanuda()
                    {
                        Edad = aleatorio.Next(0, 100),
                        Peso = aleatorio.Next(20, 100),
                        Sexo = elSexo,
                        CantidadLana = aleatorio.Next(1, 10)
                    };
                }
                else
                {
                    lasOvejas[i] = new OvejaLechera()
                    {
                        Edad = aleatorio.Next(0, 100),
                        Peso = aleatorio.Next(20, 100),
                        Sexo = elSexo,
                        LitrosLeche = aleatorio.Next(1, 6)
                    };
                }
            }

            //Aqui visualizamos El total por tipo de ovejas
            int totalOvejasLanudas = 0, totalOvejasLecheras = 0;
            int totalOvejasLanudasAptas = 0, totalOvejasLecherasAptas = 0;
            float porcentajeLanudasAptas, porcentajeLecherasAptas;

            foreach (Oveja unaOveja in lasOvejas)
            {
                if (unaOveja.EsApta)
                    if (unaOveja.Sexo == "Macho")
                        totalOvejasLanudasAptas++;
                    else
                        totalOvejasLecherasAptas++;

                if (unaOveja.Sexo == "Hembra")
                    totalOvejasLecheras++;
                else
                    totalOvejasLanudas++;
            }

            porcentajeLanudasAptas = ((float)totalOvejasLanudasAptas/ totalOvejasLanudas)*100;
            porcentajeLecherasAptas = ((float)totalOvejasLecherasAptas / totalOvejasLecheras) *100;

            Console.WriteLine($"Del total de {totalOvejasLanudas} ovejas lanudas, el {porcentajeLanudasAptas.ToString("0.00")}% son aptas");
            Console.WriteLine($"Del total de {totalOvejasLecheras} ovejas lecheras, el {porcentajeLecherasAptas.ToString("0.00")}% son aptas\n");

            //Aqui totalizamos producción:
            int totalLecheProducida = 0, totalLanaProducida = 0;

            for (int i = 0; i < lasOvejas.Length; i++)
            {
                if (lasOvejas[i].EsApta)
                    if (lasOvejas[i].Sexo == "Macho")
                        totalLanaProducida += lasOvejas[i].Produccion();
                    else
                        totalLecheProducida += lasOvejas[i].Produccion();
            }

            Console.WriteLine($"La producción total de leche es {totalLecheProducida} Lts");
            Console.WriteLine($"La producción total de lana es {totalLanaProducida} Kgs\n");

            //Aqui calculamos precios de venta y comisiones
            float valorVentaLeche = 0, valorVentaLana=0;
            float comisionVentaLeche = 0, comisionVentaLana = 0;

            comisionVentaLana = totalLanaProducida * 800 * 0.05f;
            comisionVentaLeche = totalLecheProducida * 1500 * 0.05f;

            valorVentaLeche = (totalLecheProducida * 1500) - comisionVentaLeche;
            valorVentaLana = (totalLanaProducida * 800) - comisionVentaLana;

            Console.WriteLine($"El granjero obtuvo ${valorVentaLana} por lana y ${valorVentaLeche} de leche");
            Console.WriteLine($"La Cooperativa ganó ${comisionVentaLana} por lana y ${comisionVentaLeche} por leche\n");
        }
    }
}