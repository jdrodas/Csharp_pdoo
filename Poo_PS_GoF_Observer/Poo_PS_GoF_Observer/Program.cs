using System;

namespace Poo_PS_GoF_Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Patrón GoF Observer - Variación ForEx");

            //Aqui creamos inversionistas
            Inversionista[] losInversionistas = new Inversionista[]
            {
                new Inversionista("Mariana"),
                new Inversionista("Juan Esteban"),
                new Inversionista("David"),
                new Inversionista("Pascual"),
                new Inversionista("Jeronimo C"),
                new Inversionista("Jorge"),
                new Inversionista("Juan Guillermo"),
                new Inversionista("Santiago"),
                new Inversionista("Jose Santiago"),
                new Inversionista("Ana Maria"),
                new Inversionista("Miguel"),
                new Inversionista("Maria Camila"),
                new Inversionista("Jeronimo M"),
                new Inversionista("Mateo"),
                new Inversionista("Sofia")
            };

            //Aqui creamos la divisa con el valor inicial
            Dolar dolarEnColombia = new Dolar("USD", 5000);
            Euro euroEnColombia = new Euro("EUR", 5120);

            //Aqui asignamos los inversionistas a las divisas
            AsignaInversionistasDivisa(dolarEnColombia, losInversionistas);
            AsignaInversionistasDivisa(euroEnColombia, losInversionistas);


            Console.WriteLine("\n\nCambiamos el valor del dolar y vemos a quienes se le notifica");
            dolarEnColombia.Valor = 4860;

            Console.WriteLine("\n\nCambiamos el valor del Euro y vemos a quienes se le notifica");
            euroEnColombia.Valor = 4950;


        }

        static void AsignaInversionistasDivisa(Divisa unaDivisa, Inversionista[] losInversionistas)
        {
            List<int> posicionInversionista = new List<int>();

            Random aleatorio = new Random();
            int posicion;

            int totalInversionistas = 1;
            while(totalInversionistas <=5)
            {
                posicion = aleatorio.Next(losInversionistas.Length);

                if (posicionInversionista.IndexOf(posicion) == -1)
                {
                    posicionInversionista.Add(posicion);
                    totalInversionistas++;
                }
            }

            foreach (int inversionistaSeleccionado in posicionInversionista)
                unaDivisa.AsociarInversionista(losInversionistas[inversionistaSeleccionado]);
        }
    }
}