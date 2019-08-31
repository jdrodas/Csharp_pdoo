using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricadorArepas
{
    class CreadorArepas
    {
        //los atributos
        private int totalAsadas, totalCongeladas, totalProcesadas;
        private Arepa[] misArepas;

        //el constructor de la clase
        public CreadorArepas()
        {
            totalAsadas = 0;
            totalCongeladas = 0;
            totalProcesadas = 0;

            misArepas = new Arepa[100];
        }

        //las propiedades para los atributos
        public int TotalAsadas
        {
            get { return totalAsadas; }
        }

        public int TotalCongeladas
        {
            get { return totalCongeladas; }
        }

        public int TotalProcesadas
        {
            get { return totalProcesadas; }
        }

        public void InicializaArepas()
        {
            //Cada ejecución de la simulacion comienza con los totales en cero
            totalAsadas = 0;
            totalCongeladas = 0;
            totalProcesadas = 0;

            Random aleatorio = new Random(DateTime.Now.Millisecond);

            int tipo=0; // 0: Congelada, 1: Asada, 2: Procesada
            int datoMolino = 0; // Hay 10 molinos
            int datoDiasCaducidad = 0; //Entre 15 y 30 días
            int datoTemperatura = 0;  // 60 y 90
            int datoCongelacion = 0; // dias entre 20 y 60

            for (int i = 0; i < misArepas.Length; i++)
            {
                tipo = aleatorio.Next(3);
                datoMolino = aleatorio.Next(1,11);
                datoDiasCaducidad = aleatorio.Next(15, 31);

                switch(tipo)
                {
                    //Para cuando es de tipo Congelada
                    case 0:
                        datoCongelacion = aleatorio.Next(20, 61);
                        misArepas[i] = new ArepaCongelada(datoMolino, 
                            datoDiasCaducidad, 
                            datoCongelacion);
                        totalCongeladas++;
                        break;

                    case 1:
                        datoTemperatura = aleatorio.Next(60, 91);
                        misArepas[i] = new ArepaAsada(datoTemperatura, 
                            datoDiasCaducidad, 
                            datoMolino);
                        totalAsadas++;
                        break;

                    case 2:
                        datoCongelacion = aleatorio.Next(20, 61);
                        datoTemperatura = aleatorio.Next(60, 91);
                        misArepas[i] = new ArepaProcesada(datoCongelacion, 
                            datoTemperatura, 
                            datoMolino, 
                            datoDiasCaducidad);
                        totalProcesadas++;
                        break;
                }
            }
        }

        public string ObtieneTotalInfo()
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < misArepas.Length; i++)
            {
                resultado.Append("Arepa # " + (i + 1) +
                                 Environment.NewLine +
                                 misArepas[i].ObtieneInformacion() + 
                                 Environment.NewLine);
            }

            resultado.Append("Total Arepas congeladas: " + totalCongeladas + Environment.NewLine);
            resultado.Append("Total Arepas asadas: " + totalAsadas + Environment.NewLine);
            resultado.Append("Total Arepas procesadas: " + totalProcesadas + Environment.NewLine);

            return resultado.ToString();
        }


    }
}
