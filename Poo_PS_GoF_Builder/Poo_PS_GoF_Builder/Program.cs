using System;

namespace Poo_PS_GoF_Builder
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Programa para demostrar el uso del patron GoF - Builder");

            ConstructorVehiculo elConstructor;
            Tienda laTienda;

            //Aqui construimos una moto
            Console.WriteLine("\nInvocamos el constructor de la motocicleta");
            elConstructor = new ConstructorMotocicleta();
            laTienda = new(elConstructor);
            Console.WriteLine(elConstructor.ElVehiculo!.Visualizar());

            //Aqui construimos un automovil
            Console.WriteLine("\nInvocamos el constructor del automovil");
            elConstructor = new ConstructorAutomovil();
            laTienda = new(elConstructor);
            Console.WriteLine(elConstructor.ElVehiculo!.Visualizar());

            //Aqui construimos una patineta
            Console.WriteLine("\nInvocamos el constructor de la patineta");
            elConstructor = new ConstructorPatineta();
            laTienda = new(elConstructor);
            Console.WriteLine(elConstructor.ElVehiculo!.Visualizar());

            //Aqui construimos unn vehigulo eléctrico
            Console.WriteLine("\nInvocamos el constructor del vehiculo eléctrico híbrido");
            elConstructor = new ConstructorHibrido();
            laTienda = new(elConstructor);
            Console.WriteLine(elConstructor.ElVehiculo!.Visualizar());
        }
    }
}