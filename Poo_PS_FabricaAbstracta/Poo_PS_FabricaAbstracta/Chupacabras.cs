using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FabricaAbstracta
{
    internal class Chupacabras : Carnivoro
    {
        //Constructor de la clase
        public Chupacabras()
        {
            nombre = "Cholo";
            especie = "Chupacabras criptido";
        }

        public override string Cazar(Herbivoro presa)
        {
            string resultado = $"Este carnivoro de la especie {especie} " +
                $"llamado {nombre} se alimenta desangrando {presa.Especie} " +
                $"que se llama {presa.Nombre} \n";

            return resultado;
        }
    }
}
