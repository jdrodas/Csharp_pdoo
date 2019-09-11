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
        }

        public int CantidadRecompensas
        {
            get { return cantidadRecompensas; }
        }

        public override void EvaluaEntusiasmo()
        {
            if (nivelesAlcanzados >= 10 && cantidadRecompensas >= 300)
                esEntusiasta = true;
        }
    }
}
