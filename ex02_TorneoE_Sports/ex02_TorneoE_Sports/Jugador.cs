using System;

namespace ex02_TorneoE_Sports
{
    abstract class Jugador
    {
        //atributos de la clase
        protected string facultad, torneo;
        protected bool esEntusiasta;

        //constructor de la clase
        public Jugador()
        {
            facultad = "";
            torneo = "";
            esEntusiasta = false;
        }

        public Jugador(string facultad, string torneo)
        {
            this.facultad = facultad;
            this.torneo = torneo;
            esEntusiasta = false;
        }

        //propiedades
        public string Facultad
        {
            get { return facultad; }
        }

        public string Torneo
        {
            get { return torneo; }
        }

        public bool EsEntusiasta
        {
            get { return esEntusiasta; }
        }

        //metodos virtuales que serán sobrescritos
        public abstract void EvaluaEntusiasmo();
    }
}
