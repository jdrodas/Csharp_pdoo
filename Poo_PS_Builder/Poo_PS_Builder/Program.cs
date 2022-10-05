using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para demostrar el uso del patron GoF - Builder");

            ConstructorVehiculo elConstructor;
            Tienda laTienda;

            //Aqui construimos una moto
            Console.WriteLine("\nInvocamos el constructor de la motocicleta");
            elConstructor = new ConstructorMotocicleta();
            laTienda = new Tienda(elConstructor);
            Console.WriteLine(elConstructor.ElVehiculo.Visualizar());

            //Aqui construimos un automovil
            Console.WriteLine("\nInvocamos el constructor del automovil");
            elConstructor = new ConstructorAutomovil();
            laTienda = new Tienda(elConstructor);
            Console.WriteLine(elConstructor.ElVehiculo.Visualizar());

            //Aqui construimos una patineta
            Console.WriteLine("\nInvocamos el constructor de la patineta");
            elConstructor = new ConstructorPatineta();
            laTienda = new Tienda(elConstructor);
            Console.WriteLine(elConstructor.ElVehiculo.Visualizar());


        }
    }
}
