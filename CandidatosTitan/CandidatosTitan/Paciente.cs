using System;


namespace CandidatosTitan
{
    class Paciente
    {
        //atributos
        protected int visual, temperatura, oxigeno;
        protected string especie;

        //constructor de clase
        public Paciente()
        {
            visual = 0;
            temperatura = 0;
            oxigeno = 0;
            especie = "Homo Sapiens";
        }

        //aqui colocamos propiedades para los atributos
        public int Visual
        {
            get { return visual; }
            set {
                    if(value>=75 && value<=150)
                        visual = value;
                }
        }

        public int Temperatura
        {
            get { return temperatura; }
            set
            {
                if (value >= 20 && value <= 37)
                    temperatura = value;
            }
        }

        public int Oxigeno
        {
            get { return oxigeno; }
            set
            {
                if (value >= 5 && value <= 20)
                    oxigeno = value;
            }
        }

        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        public virtual string InfoPersona()
        {
            string resultado = "Visual: " + visual + 
                               ", Oxigeno: " + oxigeno +
                               ", Temperatura: " + temperatura +
                               ", Especie: " + especie;
            return resultado;
        }
    }
}
