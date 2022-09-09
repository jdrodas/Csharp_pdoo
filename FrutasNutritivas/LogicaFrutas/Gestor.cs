using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrutasNutritivas.Logica
{
    public class Gestor
    {
        private Fruta[] lasFrutas;
        private int totalFrescasSaludables, totalSecasSaludables;
        private int totalSecas, totalFrescas;
        private float porcentajeSecasSaludables, porcentajeFrescasSaludables;

        public Gestor()
        {
            lasFrutas = new Fruta[1000];

            totalSecas = 0;
            totalFrescas = 0;
            totalFrescasSaludables = 0;
            totalSecasSaludables = 0;
            porcentajeSecasSaludables=0;
            porcentajeFrescasSaludables = 0;

            InicializaFrutas();
        }

        public Gestor(Fruta[] arregloFrutas)
        {
            this.lasFrutas = arregloFrutas;

            totalSecas = 0;
            totalFrescas = 0;
            totalFrescasSaludables = 0;
            totalSecasSaludables = 0;
            porcentajeSecasSaludables = 0;
            porcentajeFrescasSaludables = 0;

            InicializaFrutas();
        }

        public void InicializaFrutas()
        {
            //aqui declaramos el objeto aleatorio para la asignación de los valores de los atributos
            Random aleatorio = new Random();

            //inicializamos el arreglo de frutas
            //0: Fruta Fresca
            //1: Fruta Seca
            for (int i = 0; i < lasFrutas.Length; i++)
            {
                switch (aleatorio.Next(2))
                {
                    //Fruta Fresca
                    case 0:
                        lasFrutas[i] = new FrutaFresca()
                        {
                            Tipo = "Fresca",
                            Azucar = aleatorio.Next(5, 61),
                            Fibra = (float)aleatorio.Next(25, 127) / 10,
                            Proteina = (float)aleatorio.Next(3, 51) / 10,
                            DiasCosechado = aleatorio.Next(0, 22)
                        };
                        break;

                    case 1:
                        lasFrutas[i] = new FrutaSeca()
                        {
                            Tipo = "Seca",
                            Azucar = aleatorio.Next(5, 61),
                            Fibra = (float)aleatorio.Next(25, 127) / 10,
                            Proteina = (float)aleatorio.Next(3, 51) / 10,
                            NivelSodio = aleatorio.Next(2, 31)
                        };
                        break;

                }
                lasFrutas[i].ValidaSaludable();
            }
        }

        public void TotalizaFrutas()
        {
            totalSecas = 0;
            totalFrescas = 0;
            totalFrescasSaludables = 0;
            totalSecasSaludables = 0;

            //Frutas Frescas
            for (int i = 0; i < lasFrutas.Length; i++)
            {
                if (lasFrutas[i].Tipo == "Fresca")
                {
                    totalFrescas++;
                    if (lasFrutas[i].Saludable)
                        totalFrescasSaludables++;
                }
            }

            //Frutas Secas
            for (int i = 0; i < lasFrutas.Length; i++)
            {
                if (lasFrutas[i].Tipo == "Seca")
                {
                    totalSecas++;
                    if (lasFrutas[i].Saludable)
                        totalSecasSaludables++;
                }
            }

            porcentajeSecasSaludables = ((float)totalSecasSaludables / totalSecas) * 100;
            porcentajeFrescasSaludables = ((float)totalFrescasSaludables / totalFrescas) * 100;
        }

        public string ObtieneDetalleFrutasSaludables()
        {
            StringBuilder detalle = new StringBuilder();
            for (int i = 0; i < lasFrutas.Length; i++)
            {
                if (lasFrutas[i].Saludable)
                    detalle.Append($"\nFruta No. {(i+1)} \n{lasFrutas[i].ToString()}\n");
            }

            return detalle.ToString();
        }

        public override string ToString()
        {
            string informacion = "\n *** Totales *** \n" +
                                 $"{totalFrescas} fueron frutas frescas, y solo {totalFrescasSaludables}, {porcentajeFrescasSaludables.ToString("0.00")}% fueron saludables\n" +
                                 $"{totalSecas} fueron frutas secas, y solo {totalSecasSaludables}, {porcentajeSecasSaludables.ToString("0.00")}% fueron saludables\n";

            return informacion;
        }
    }
}
