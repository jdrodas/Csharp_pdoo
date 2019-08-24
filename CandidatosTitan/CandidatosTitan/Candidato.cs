using System;

namespace CandidatosTitan
{
    class Candidato : Paciente
    {
        private int vuelo;
        private bool viable;

        public Candidato()
        {
            vuelo = 0;
            viable = false;
        }

        public Candidato(int p_visual, int p_temperatura, int p_oxigeno, int p_vuelo)
        {
            visual = p_visual;
            oxigeno = p_oxigeno;
            temperatura = p_temperatura;
            vuelo = p_vuelo;
        }

        public bool Viable
        {
            get { return viable; }
        }

        public int Vuelo
        {
            get { return vuelo; }
            set
            {
                if (value >= 5 && value <= 30)
                    vuelo = value;
            }
        }

        public override string InfoPersona()
        {
            string resultado = base.InfoPersona() +
                               ", Vuelo: " + vuelo;

            if (viable)
                resultado += ", Viable: SI";
            else
                resultado += ", Viable: NO.";

            return resultado;
        }

        public void ValidaViabilidad()
        {
            //cambiamos la especie si los atributos base están en los rangos esperados
            if (visual >= 140 && oxigeno <= 7 && temperatura <= 23)
                especie = "Homo Titanus";

            //aqui evaluamos si es viable
            if (especie == "Homo Titanus" && vuelo >= 15)
                viable = true;
        }
    }
}
