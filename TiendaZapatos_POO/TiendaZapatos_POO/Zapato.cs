using System;

namespace TiendaZapatos_POO
{
    class Zapato
    {
        //atributos
        private int talla;
        private string color, estilo;

        //Constructor
        public Zapato()
        {
            talla = 0;
            color = "sin color";
            estilo = "horrible";
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        public int Talla
        {
            get { return talla; }
            set
            {
                if (value >= 34 && value <= 45)
                    talla = value;
            }
        }
    }
}
