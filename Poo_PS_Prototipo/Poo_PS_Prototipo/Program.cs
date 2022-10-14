using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Prototipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para la gestión de Colores\n");

            //Creamos una instancia de nuestro Gestor de Colores
            GestorColores paletaColores = new GestorColores();

            //Vamos a agregar colores
            paletaColores["rojo"] = new Color(255, 0, 0);
            paletaColores["azul"] = new Color(0,0,255);
            paletaColores["verde"] = new Color(0,255,0);

            paletaColores["morado"] = new Color(128,0,255);
            paletaColores["Cafe Popó"] = new Color(128, 64, 0);

            //Aqui visualizamos los colores creados
            Console.WriteLine(paletaColores["rojo"].ToString());
            Console.WriteLine(paletaColores["azul"].ToString());
            Console.WriteLine(paletaColores["verde"].ToString());

            //Aqui visualizamos colores clonados
            Console.WriteLine("\n\nAqui vemos los colore clonados:");
            //Aqui clonamos un color
            Color otroRojo = paletaColores["rojo"].Clonar() as Color;
            Console.WriteLine(otroRojo.ToString());

            Color otroMorado = paletaColores["morado"].Clonar() as Color;
            Console.WriteLine(otroMorado.ToString());

            Color cafeDesagradable = paletaColores["Cafe Popó"].Clonar() as Color;
            Console.WriteLine(cafeDesagradable.ToString());


            //Aqui un color de la manera tradicioal
            Color amarilloTradicional = new Color(255,255,0);
            amarilloTradicional.Nombre = "Amarillo Tradicional";
            Console.WriteLine(amarilloTradicional.ToString());

            Color otroAmarillo = amarilloTradicional;
            Console.WriteLine(otroAmarillo.ToString());

            if (amarilloTradicional == otroAmarillo)
                Console.WriteLine("Los amarillos son iguales");
            else
                Console.WriteLine("Los amarillos no son iguales");

        }
    }
}
