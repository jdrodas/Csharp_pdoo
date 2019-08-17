
/*
Programa:       HerenciaFiguras
Contacto:       Juan Dario Rodas - jdrodas@hotmail.com

Propósito:
----------

Demostrar los conceptos de programación orientada a objetos: 
Herencia, Polimorfismo por sobrecarga y por sobreescritura.

 */

using System;

namespace HerenciaFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar el concepto de herencia de clases");
            Console.WriteLine("Jerarquía de figuras geométricas cerradas");

            Figura miFigura = new Figura();

            Console.Write("Ingresa la coordenada X del centro de la figura: ");
            miFigura.CentroX = int.Parse(Console.ReadLine());

            Console.Write("Ingresa la coordenada Y del centro de la figura: ");
            miFigura.CentroY = int.Parse(Console.ReadLine());

            Console.WriteLine("La figura tiene centro en las coordenadas ({0},{1})",
                miFigura.CentroX, miFigura.CentroY);

            Console.WriteLine("\n\nAhora para un triangulo...");

            Triangulo miTria = new Triangulo();

            Console.WriteLine("Antes de inicializar, El triangulo tiene centro en las coordenadas ({0},{1})",
                miTria.CentroX, miTria.CentroY);

            Console.Write("Ingresa la coordenada X del centro del triangulo: ");
            miTria.CentroX = int.Parse(Console.ReadLine());

            Console.Write("Ingresa la coordenada Y del centro del triangulo: ");
            miTria.CentroY = int.Parse(Console.ReadLine());

            Console.WriteLine("El triangulo tiene centro en las coordenadas ({0},{1})",
                miTria.CentroX, miTria.CentroY);


            Console.WriteLine("\n\nAhora para otro triangulo...");
            int x, y, a, b;
            string t;
            
            Console.Write("Ingresa la coordenada X del centro del triangulo: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Ingresa la coordenada Y del centro del triangulo: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Ingresa la base del triangulo: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Ingresa la altura del triangulo: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el tipo del triangulo: ");
            t = Console.ReadLine();

            Triangulo otroTri = new Triangulo(t,a,b,x,y);

            Console.WriteLine(otroTri.Info());
            Console.WriteLine(otroTri.ObtieneArea());

            Console.WriteLine("\n\nAhora para un circulo...");

            Circulo miCi = new Circulo();

            Console.Write("Ingresa la coordenada X del centro del circulo: ");
            miCi.CentroX = int.Parse(Console.ReadLine());

            Console.Write("Ingresa la coordenada Y del centro del circulo: ");
            miCi.CentroY = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el valor del radio del circulo: ");
            miCi.Radio = int.Parse(Console.ReadLine());

            Console.WriteLine(miCi.Info());
        }
    }
}
