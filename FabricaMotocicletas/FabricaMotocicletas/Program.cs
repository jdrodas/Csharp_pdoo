/*
EL siguiente enunciado fue generado por ChatGPT cuando se le hizo la siguiente pregunta:

    Por favor genera un enunciado de un problema de programación orientada a objetos en el que
    se demuestre la utilización de los conceptos de herencia, polimorfismo por sobrecarga,
    clases abstractas e interfaces.

La respuesta fue:

    Supongamos que tienes una fábrica de motos que produce diferentes tipos de motocicletas como 
    deportivas, crucero y todoterreno. Cada tipo de motocicleta tiene propiedades como la velocidad 
    máxima, la capacidad del tanque de combustible y la potencia del motor. Para implementar esto en 
    una aplicación de programación orientada a objetos, podrías crear una clase abstracta llamada 
    “Motocicleta” que define las propiedades y métodos comunes a todas las motocicletas. Luego, puedes 
    crear clases hijas para cada tipo de motocicleta específico (por ejemplo, “Deportiva”, “Crucero” y 
    “Todoterreno”) que heredan las propiedades y métodos de la clase “Motocicleta”. Cada clase hija puede 
    tener sus propias propiedades y métodos únicos.
 
    Para implementar la encapsulación, puedes hacer que las propiedades de cada tipo de motocicleta sean 
    privadas y proporcionar métodos públicos para acceder y modificar estas propiedades. Por ejemplo, 
    puedes tener un método “setVelocidadMaxima()” que establece la velocidad máxima de una motocicleta.
 
    Para implementar el polimorfismo por sobrecarga, puedes tener varios métodos con el mismo nombre pero 
    diferentes parámetros en la clase “Motocicleta”. Por ejemplo, puedes tener un método “acelerar()” que 
    acepta diferentes parámetros dependiendo del tipo de motocicleta.
 
    Para implementar el polimorfismo por sobrescritura, puedes anular los métodos definidos en la clase 
    “Motocicleta” en las clases hijas para proporcionar una implementación específica para cada tipo de 
    motocicleta. Por ejemplo, puedes anular el método “acelerar()” en la clase “Deportiva” para 
    proporcionar una implementación específica para acelerar una motocicleta deportiva.
 
    Para implementar las interfaces, puedes definir una interfaz llamada “Vendible” que define un método 
    “vender()” y hacer que cada clase hija implemente esta interfaz. Esto asegura que cada tipo de 
    motocicleta tenga un método “vender()” definido.
 
*/

using System;

namespace FabricaMotocicletas
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para demostrar la utilización de una clase Motocicleta");

            MotocicletaDeportiva miMoto = new MotocicletaDeportiva(150,
                "Cuatro tiempos",
                450,
                true,
                750,
                14000000,
                "Moto deportiva razor night",
                10.5f
                );

            Console.WriteLine($"la velocidad actual de la moto es {miMoto.GetVelocidadActual()}");

            miMoto.Acelerar();
            miMoto.Acelerar();
            miMoto.Acelerar();

            Console.WriteLine($"la velocidad actual de la moto es {miMoto.GetVelocidadActual()}");

            miMoto.Frenar();
            miMoto.Frenar();

            Console.WriteLine($"la velocidad actual de la moto es {miMoto.GetVelocidadActual()}");

        }
    }
}
