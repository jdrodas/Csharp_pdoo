using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FabricaAbstracta
{
    public class Vaca : Herbivoro
    {
        public Vaca()
        {
            nombre = "Lola la vaca";
            especie = "Vaca lechera";
        }

        public override string Alimentarse()
        {
            string resultado = $"Este herbívoro de la especie {especie} " +
                $"llamado {nombre} se alimenta de pasto.\n";
            return resultado;
        }
    }
}
