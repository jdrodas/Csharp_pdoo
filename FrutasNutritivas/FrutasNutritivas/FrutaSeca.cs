using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrutasNutritivas
{
    class FrutaSeca : Fruta
    {
        //atributos
        private int nivelSodio;

        //constructor de la clase
        public FrutaSeca() : base()
        {
            nivelSodio = 0; //valor arbitrario que no afecta positivamente el calculo del atributo saludable
        }

        public FrutaSeca(int azucar, float fibra, float proteina, string tipo, int nivelSodio) : base(azucar, fibra, proteina, tipo)
        {
            NivelSodio = nivelSodio;
            ValidaSaludable();
        }

        //Propiedad para el atributo
        public int NivelSodio
        {
            get { return nivelSodio; }
            set
            {
                if (value >= 2 && value <= 30)
                    nivelSodio = value;
                else
                    nivelSodio = 0;
            }

        }

        public override void ValidaSaludable()
        {
            //invocamos el método de la clase padre para validar si con los atributos básicos,
            //la fruta es saludable
            base.ValidaSaludable();

            //ahora le agregamos a ese resultado si es saludable con el valor de nivelSodio
            if (nivelSodio <= 10 && saludable == true)
                saludable = true;
            else
                saludable = false;
        }

        public override string InfoNutricional()
        {
            string resultado = "Fruta tipo: " + tipo + base.InfoNutricional() + ". Nivel de sodio: " + nivelSodio;

            if (saludable)
                resultado += ". Es saludable!";
            else
                resultado += ". No se coma esa vaina!";

            return resultado;
        }
    }
}
