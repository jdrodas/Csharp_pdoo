using System;

namespace ex02_TorneoE_Sports
{
    class JugadorPlatformer : Jugador
    {
        //Atributos de la clase
        private int nivelesAlcanzados, cantidadRecompensas;

        //Constructor de la clase
        public JugadorPlatformer() : base()
        {
            nivelesAlcanzados = 0;
            cantidadRecompensas = 0;
        }

        public JugadorPlatformer(int nivelesAlcanzados, int cantidadRecompensas, string facultad, string torneo) : base(facultad, torneo)
        {
            this.nivelesAlcanzados = nivelesAlcanzados;
            this.cantidadRecompensas = cantidadRecompensas;
        }

        //propiedades
        public int NivelesAlcanzados
        {
            get { return nivelesAlcanzados; }
            set
            {
                if (value >= 0 && value <= 24)
                    nivelesAlcanzados = value;
                else
                    nivelesAlcanzados = 0;
            }
        }

        public int CantidadRecompensas
        {
            get { return cantidadRecompensas; }
            set
            {
                if (value >= 0 && value <= 1000)
                    cantidadRecompensas = value;
                else
                    cantidadRecompensas = 0;
            }
        }

        public override void EvaluaEntusiasmo()
        {
            if (nivelesAlcanzados >= 10 && cantidadRecompensas >= 300)
                esEntusiasta = true;
        }
    }
}
