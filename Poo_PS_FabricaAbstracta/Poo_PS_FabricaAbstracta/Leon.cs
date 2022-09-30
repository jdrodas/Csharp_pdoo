using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FabricaAbstracta
{
    public class Leon:Carnivoro
    {
        //Constructor de la clase
        public Leon()
        {
            nombre = "Mufasa";
            especie = "León";
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
