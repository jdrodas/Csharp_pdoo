using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FabricaAbstracta
{
    public class Tigre : Carnivoro
    {
        //Constructor de la clase
        public Tigre()
        {
            nombre = "Joaquin el tigre";
            especie = "Tigre de Bengala";
        }

        public override string Cazar(Herbivoro presa)
        {
            string resultado = $"Este carnivoro de la especie {especie} " +
                $"llamado {nombre} se alimenta cazando {presa.Especie} " +
                $"que se llama {presa.Nombre} \n";

            return resultado;
        }
    }
}
