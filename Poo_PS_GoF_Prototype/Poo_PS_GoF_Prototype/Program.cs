using System;

namespace Poo_PS_GoF_Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para la gestión de Colores\n");

            //Creamos una instancia de nuestro Gestor de Colores
            GestorColores paletaColores = new GestorColores();

            //Vamos a agregar colores
            paletaColores["rojo"] = new Color(255, 0, 0);
            paletaColores["azul"] = new Color(0, 0, 255);
            paletaColores["verde"] = new Color(0, 255, 0);

            paletaColores["morado"] = new Color(128, 0, 255);
            paletaColores["Cafe Popó"] = new Color(128, 64, 0);

            //Aqui visualizamos los colores creados
            Console.WriteLine(paletaColores["rojo"].ToString());
            Console.WriteLine(paletaColores["azul"].ToString());
            Console.WriteLine(paletaColores["verde"].ToString());

            //Aqui visualizamos colores clonados
            Console.WriteLine("\n\nAqui vemos los colore clonados:");
            //Aqui clonamos un color
            Console.WriteLine("Clonando el color rojo...");
            Color? otroRojo = paletaColores["rojo"].Clonar() as Color;
            Console.WriteLine(otroRojo!.ToString());

            Console.WriteLine("Clonando el color morado...");
            Color? otroMorado = paletaColores["morado"].Clonar() as Color;
            Console.WriteLine(otroMorado!.ToString());

            Console.WriteLine("Clonando el color café popó...");
            Color? cafeDesagradable = paletaColores["Cafe Popó"].Clonar() as Color;
            Console.WriteLine(cafeDesagradable!.ToString());


            //Aqui un color de la manera tradicional
            Console.WriteLine("\nComparando los objetos cuando son copiados tradicionalmente...");
            Color amarilloTradicional = new Color(255, 255, 0);
            amarilloTradicional.Nombre = "Amarillo Tradicional";
            Console.WriteLine(amarilloTradicional.ToString());

            Color otroAmarillo = amarilloTradicional;
            Console.WriteLine(otroAmarillo.ToString());

            if (amarilloTradicional == otroAmarillo)
                Console.WriteLine("Los amarillos son iguales");
            else
                Console.WriteLine("Los amarillos NO son iguales");

            Console.WriteLine("\nComparando los objetos cuando son clonados ...");


            if (otroRojo == paletaColores["rojo"])
                Console.WriteLine("Los rojos son iguales");
            else
                Console.WriteLine("Los rojos NO son iguales");
        }
    }
}
