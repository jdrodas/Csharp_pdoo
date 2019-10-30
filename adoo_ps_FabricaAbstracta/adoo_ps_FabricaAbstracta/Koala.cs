using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoo_ps_FabricaAbstracta
{
    class Koala: Herbivoro
    {
        public Koala()
        {
            nombre = "Herbivoro de Oceanía";
            especie = "Koala";
        }

        public override string Alimentarse()
        {
            string resultado = "Este herbívoro de la especie " + especie + " llamado " +
                nombre + " se alimenta de hojas de eucalipto" + Environment.NewLine;

            return resultado;
        }
    }
}
