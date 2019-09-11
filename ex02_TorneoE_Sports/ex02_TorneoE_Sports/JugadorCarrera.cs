using System;

namespace ex02_TorneoE_Sports
{
    class JugadorCarrera : Jugador
    {
        //Atributos de la clase
        private int carrerasGanadas, kmsRecorridos;

        //Constructor de la clase
        public JugadorCarrera() : base()
        {
            carrerasGanadas = 0;
            kmsRecorridos = 0;
        }

        public JugadorCarrera(int carrerasGanadas, int kmsRecorridos, string facultad, string torneo) : base(facultad, torneo)
        {
            this.carrerasGanadas = carrerasGanadas;
            this.kmsRecorridos = kmsRecorridos;
        }

        //propiedades
        public int CarrerasGanadas
        {
            get { return carrerasGanadas; }
        }

        public int KmsRecorridos
        {
            get { return kmsRecorridos; }
        }

        public override void EvaluaEntusiasmo()
        {
            if (carrerasGanadas >= 8 && kmsRecorridos >= 200)
                esEntusiasta = true;
        }
    }
}
