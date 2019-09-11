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
        }

        public int NivelEnergia
        {
            get { return nivelEnergia; }
        }

        public override void EvaluaEntusiasmo()
        {
            if (batallasGanadas >= 30 && nivelEnergia >= 60)
                esEntusiasta = true;
        }
    }
}
