using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ComercioOvejas
{
    public class OvejaLechera : Oveja
    {
        private double litrosLeche;

        public OvejaLechera() : base()
        {
            litrosLeche = 0;
        }

        public OvejaLechera(string sexo, int peso, int edad, double litrosLeche)
        {
            this.sexo = sexo;
            this.peso = peso;
            this.edad = edad;
            this.litrosLeche = litrosLeche;

            EvaluaSiEsApta();
        }

        public double GetLitrosLeche()
        {
            return litrosLeche;
        }

        public void SetLitrosLeche(double litrosLeche)
        {
            this.litrosLeche = litrosLeche;
        }

        public override void EvaluaSiEsApta()
        {
            double cantidadLecheKilos = litrosLeche / 1.046f;
            
            if (edad >= 24 && edad <= 84 && peso >= 35 && sexo == "hembra"
                && cantidadLecheKilos >= 0.75f)
                esApta = true;
        }

        public override string ToString()
        {
            string resultado = $"Oveja {sexo}, peso: {peso}, edad: {edad}, " +
                $"cantidad de Leche: {litrosLeche.ToString("00.00")} Lts. ";

            if (esApta)
                resultado += "Es Apta";
            else
                resultado += "No es Apta";
            return resultado;
        }
    }
}
