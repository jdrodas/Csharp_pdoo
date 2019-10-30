using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoo_ps_FabricaAbstracta
{
    class Comadreja:Carnivoro
    {
        //Constructor de la clase
        public Comadreja()
        {
            nombre = "Carnivoro de Asia";
            especie = "Comadreja de vientre amarillo";
        }

        public override string Cazar(Herbivoro presa)
        {
            string resultado = "Este carnívoro de la especie " + especie + " llamado " +
                    nombre + " se alimenta cazando " + presa.Especie + " que se llama " +
                    presa.Nombre + Environment.NewLine;

            return resultado;
        }
    }
}
