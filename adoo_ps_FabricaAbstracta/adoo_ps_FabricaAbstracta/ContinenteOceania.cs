using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoo_ps_FabricaAbstracta
{
    class ContinenteOceania : Continente
    {
        public override Herbivoro CrearHerbivoro()
        {
            Herbivoro animalito = new Koala();
            return animalito;
        }

        public override Carnivoro CrearCarnivoro()
        {
            Carnivoro animalote = new Dingo();
            return animalote;
        }
    }
}
