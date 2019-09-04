using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrutasNutritivas
{
    class FrutaFresca : Fruta
    {
        //atributos
        private int diasCosechado;

        //constructor de la clase
        public FrutaFresca() : base()
        {
            diasCosechado = -1; //valor arbitrario que no afecta positivamente el calculo del atributo saludable
        }

        public FrutaFresca(int azucar, float fibra, float proteina, string tipo, int diasCosechado) : base(azucar, fibra, proteina, tipo)
        {
            DiasCosechado = diasCosechado;
            ValidaSaludable();
        }

        //Propiedad para el atributo
        public int DiasCosechado
        {
            get { return diasCosechado; }
            set {
                if (value >= 0 && value <= 21)
                    diasCosechado = value;
                else
                    diasCosechado = -1;
            }

        }

        public override void ValidaSaludable()
        {
            //invocamos el método de la clase padre para validar si con los atributos básicos,
            //la fruta es saludable
            base.ValidaSaludable();

            //ahora le agregamos a ese resultado si es saludable con el valor de diasCosechado
            if (diasCosechado <= 7 && saludable == true)
                saludable = true;
            else
                saludable = false;
        }

        public override string InfoNutricional()
        {
            string resultado = "Fruta tipo: " + tipo + base.InfoNutricional() + ". Dias cosechados: " + diasCosechado;

            if (saludable)
                resultado += ". Es saludable!";
            else
                resultado += ". No se coma esa vaina!";

            return resultado;
        }
    }
}
