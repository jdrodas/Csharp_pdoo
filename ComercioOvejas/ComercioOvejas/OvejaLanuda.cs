using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ComercioOvejas
{
    public class OvejaLanuda : Oveja
    {
        private double cantidadLana;

        public OvejaLanuda() : base()
        {
            cantidadLana = 0;
        }

        public OvejaLanuda(string sexo, int peso, int edad)
        {
            this.sexo = sexo;
            this.edad = edad;
            this.peso = peso;

            EvaluaSiEsApta();
        }

        public double GetCantidadLana()
        {
            return cantidadLana;
        }

        public override void EvaluaSiEsApta()
        {
            if (peso >= 35)
                cantidadLana = peso * 0.2f;
            else
                cantidadLana = 0;

            if(edad>=24 && edad<=84 && peso>=35 && sexo == "macho")
                esApta = true;
        }

        public override string ToString()
        {
            string resultado = $"Oveja {sexo}, peso: {peso}, edad: {edad}, " +
                $"cantidad de lana: {cantidadLana.ToString("00.00")} Kgs. ";

            if (esApta)
                resultado += "Es Apta";
            else
                resultado += "No es Apta";
            return resultado;
        }
    }
}
