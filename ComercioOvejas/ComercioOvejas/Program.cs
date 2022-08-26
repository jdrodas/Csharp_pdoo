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
    mínimo de 1200 ml de los cuales 800 ml deben ser para alimentación 
    de las crías. Rango de producción lechera entre 0.75 kg y 3.5 kg. 
    Densidad de la leche: 1.046 mg/ml.  

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
            Console.WriteLine("Se simularán 1000 ovejas para identificar su producción");

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
                    lasOvejas[i] = new Oveja();
                    lasOvejas[i].Edad = aleatorio.Next(0,100);
                    lasOvejas[i].Peso = aleatorio.Next(20,100);
                    lasOvejas[i].Sexo = elSexo;
                    lasOvejas[i].CantidadLana = aleatorio.Next(1,10);
                }
                else
                {
                    lasOvejas[i] = new OvejaLechera()
                    {
                        Edad = aleatorio.Next(0, 100),
                        Peso = aleatorio.Next(20, 100),
                        Sexo = elSexo,
                        CantidadLana = 0,
                        LitrosLeche = aleatorio.Next(1, 10)
                    };
                }
            }

            //Aqui visualizamos el arreglo de ovejas
            int contadorOvejas = 1;
            foreach (Oveja unaOveja in lasOvejas)
            {
                Console.WriteLine($"Oveja No. {contadorOvejas}\n{unaOveja.ToString()}");
                contadorOvejas++;
            }
        }
    }
}