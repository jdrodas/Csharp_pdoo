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
using LogicaComercio;

namespace ComercioOvejas
{
    public class Program
    {
        static void Main(string[] args)
        {
            int cantidadOvejas = 750;
            int precioLeche = 2300;
            int precioLana = 950;
            float valorComision = 0.0623f;
            
            Console.WriteLine("Comercio de OOOvejas");
            Console.WriteLine($"Se simularán {cantidadOvejas} ovejas para identificar su producción\n");

            //Aqui creamos una instancia de la clase Cooperativa
            Cooperativa miCooperativa = new Cooperativa(new Oveja[cantidadOvejas], precioLeche, precioLana, valorComision);

            //Recibimos las ovejas en la cooperativa
            miCooperativa.RecepcionOvejas();

            //Identificamos las ovejas aptas
            miCooperativa.IdentificaOvejasAptas();

            //Calculamos la producción de las ovejas aptas
            miCooperativa.CalculaProduccion();

            ////Aqui calculamos precios de venta y comisiones
            miCooperativa.CalculaComisionVenta();
            miCooperativa.CalculaPagoGranjero();

            //Aqui visualizamos  los resultados de la producción
            Console.WriteLine(miCooperativa.ToString());

        }
    }
}