
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
            Console.WriteLine("Programa para demostrar conceptos de OO");
            Console.WriteLine("Herencia - Encapsulación - Polimorfismo\n");

            //Aqui creamos la instancia de la figura invocando el constructor predeterminado
            Figura miFigura = new Figura();

            miFigura.CentroX = 13;
            miFigura.CentroY = -12;

            //Aqui creamos la instancia de la figura invocando el constructor con parámetros
            Figura otraFigura = new Figura(23, 100);

            Console.WriteLine($"Información de una Figura: \n{miFigura.Informacion()}\n");
            Console.WriteLine($"Información de otra Figura: \n{otraFigura.Informacion()}");

            //Aqui hacemos un circulo
            Console.WriteLine("\n\nAhora para un circulo...\n");

            //Aqui creamos la instancia del circulo invocando el constructor con parámetros
            Circulo miCirculo = new Circulo(3, 4, 10);

            //Aqui invoco el método Información del círculo que utiliza parametros por referencia
            string datoInformacion = "";
            miCirculo.Informacion(ref datoInformacion);
            Console.WriteLine($"Información: \n{datoInformacion}");
            Console.WriteLine($"Area: {miCirculo.AreaFigura()}");

            //Aqui hacemos un triangulo
            Console.WriteLine("\n\nAhora para un triangulo...");

            Triangulo miTriangulo = new Triangulo(-20, -12, 6, 8);

            Console.WriteLine("Información: \n" + miTriangulo.Informacion());
            Console.WriteLine(miTriangulo.AreaFigura());
        }
    }
}
