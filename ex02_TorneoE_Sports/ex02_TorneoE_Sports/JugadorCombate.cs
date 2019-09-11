using System;

namespace ex02_TorneoE_Sports
{
    class JugadorCombate : Jugador
    {
        //Atributos de la clase
        private int batallasGanadas, nivelEnergia;

        //Constructor de la clase
        public JugadorCombate() : base()
        {
            batallasGanadas = 0;
            nivelEnergia = 0;
        }

        public JugadorCombate(int batallasGanadas, int nivelEnergia, string facultad, string torneo) : base(facultad, torneo)
        {
            this.batallasGanadas = batallasGanadas;
            this.nivelEnergia = nivelEnergia;
        }

        //propiedades
        public int BatallasGanadas
        {
            get { return batallasGanadas; }
            set
            {
                if (value >= 0 && value <= 100)
                    batallasGanadas = value;
                else
                    batallasGanadas = 0;
            }
        }

        public int NivelEnergia
        {
            get { return nivelEnergia; }
            set
            {
                if (value >= 0 && value <= 100)
                    nivelEnergia = value;
                else
                    nivelEnergia = 0;
            }
        }

        public override void EvaluaEntusiasmo()
        {
            if (batallasGanadas >= 30 && nivelEnergia >= 60)
                esEntusiasta = true;
        }
    }
}
