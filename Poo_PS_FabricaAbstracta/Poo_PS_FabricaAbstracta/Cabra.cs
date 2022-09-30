using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FabricaAbstracta
{
    public class Cabra : Herbivoro
    {
        public Cabra()
        {
            nombre = "Marianito";
            especie = "cabra de la sabana";
        }

        public override string Alimentarse()
        {
            string resultado = $"Este herbívoro de la especie {especie} " +
                $"llamado {nombre} se alimenta de lamiendo las piedras.\n";
            return resultado;
        }
    }
}
