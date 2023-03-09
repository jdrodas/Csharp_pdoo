using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaComercio
{
    public class Cooperativa
    {
        //Zona de atributos
        private double valorComision;
        private double comisionObtenida;

        private double precioLana;
        private double precioLeche;

        private double cantidadKgsLana;
        private double cantidadLtsLeche;
        private double gananciaGranjero;

        private int cantidadOvejas;
        private Oveja[] lasOvejas;

        public Cooperativa(int cantidadOvejas)
        {
            this.cantidadOvejas = cantidadOvejas;
            valorComision = 0.05f;
            comisionObtenida = 0;
            precioLana = 1200;
            precioLeche = 1750;
            cantidadKgsLana = 0;
            cantidadLtsLeche = 0;
            gananciaGranjero = 0;

            lasOvejas = new Oveja[cantidadOvejas];

            //Aqui se inicializa el arreglo de Ovejas
            InicializaLasOvejas();
        }

        private void InicializaLasOvejas()
        {
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
        }

        public void ContabilizaProduccion()
        {
            cantidadKgsLana = 0;
            cantidadLtsLeche = 0;

            foreach (Oveja unaOveja in  lasOvejas)
            {
                if (unaOveja.GetEsApta() && unaOveja.GetSexo() == "macho")
                    cantidadKgsLana += unaOveja.GetProduccion();

                if (unaOveja.GetEsApta() && unaOveja.GetSexo() == "hembra")
                    cantidadLtsLeche += unaOveja.GetProduccion();
            }
        }

        public void CalculaComision()
        {
            gananciaGranjero = precioLana * cantidadKgsLana +
                                precioLeche * cantidadLtsLeche;

            comisionObtenida = gananciaGranjero * valorComision;
        }

        public override string ToString()
        {
            string informacion = $"Esta cooperativa cobra {(valorComision*100).ToString(".00")}% de comisión\n" +
                $"Se paga el Kg de lana a ${precioLana} y el litro de lecha a ${precioLeche} ";

            return informacion;
        }

        private int CalculaCantidadOvejasAptas()
        {
            int cantidadOvejasAptas = 0;

            foreach (Oveja unaOveja in lasOvejas)
                if (unaOveja.GetEsApta())
                    cantidadOvejasAptas++;

            return cantidadOvejasAptas;
        }

        public string VisualizaResultadoComercio()
        {
            int cantidadOvejasAptas = CalculaCantidadOvejasAptas();
            float porcentajeAptas = ((float)cantidadOvejasAptas / cantidadOvejas) * 100;
            
            string resultadoComercio = $"Del total de {cantidadOvejas} ovejas, " +
                $"solo {cantidadOvejasAptas} fueron aptas, " +
                $"equivalente al {porcentajeAptas.ToString(".00")}%";

            resultadoComercio += $"\nLa producción consistió en {cantidadKgsLana.ToString(".00")} Kgs de lana " +
                $"y {cantidadLtsLeche.ToString(".00")} Lts de leche";

            resultadoComercio += $"\n\nEl granjero obtuvo ganancias por ${(gananciaGranjero-comisionObtenida).ToString(".00")} y " +
                $"la cooperativa obtuvo ${comisionObtenida.ToString(".00")} de comisión";

            return resultadoComercio;
        }
    }
}
