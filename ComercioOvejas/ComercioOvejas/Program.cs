using System;

namespace ComercioOvejas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para simular el comercio de Ovejas");

            int cantidadOvejas = 100;

            //Aqui declaramos el arreglo de Ovejas
            Oveja[] lasOvejas = new Oveja[cantidadOvejas];

            Random aleatorio = new Random();
            string[] losSexos = { "macho", "hembra" };
            string elSexo;
            int elPeso, laEdad;
            double laCantidadLeche;

            for (int i = 0; i < lasOvejas.Length; i++)
            {
                elSexo = losSexos[aleatorio.Next(losSexos.Length)];
                elPeso = aleatorio.Next(1, 181);
                laEdad = aleatorio.Next(1, 145);

                //0: Oveja Lechera, 1: Oveja Lanuda
                switch (aleatorio.Next(2))
                {
                    case 0:
                        laCantidadLeche = aleatorio.NextDouble() * 3.5f; 
                        lasOvejas[i] = new OvejaLechera(elSexo, elPeso, laEdad, laCantidadLeche);
                        break;

                    case 1:
                        lasOvejas[i] = new OvejaLanuda(elSexo, elPeso, laEdad);
                        break;

                }
            }

            //Aqui visualizamos las ovejas aptas:
            int contadorOvejasAptas = 0;
            int totalOvejas = 1;

            foreach (Oveja unaOveja in lasOvejas)
            {
                if (unaOveja.GetEsApta())
                {
                    Console.WriteLine($"No. {totalOvejas} - {unaOveja.ToString()}");
                    contadorOvejasAptas++;
                }
                totalOvejas++;
            }

            Console.WriteLine($"De las {cantidadOvejas} Ovejas, {contadorOvejasAptas} son aptas");
        }
    }
}