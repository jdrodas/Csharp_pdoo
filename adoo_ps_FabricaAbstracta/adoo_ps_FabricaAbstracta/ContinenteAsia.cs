using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoo_ps_FabricaAbstracta
{
    class ContinenteAsia:Continente
    {
        public override Herbivoro CrearHerbivoro()
        {
            Herbivoro animalito = new Ardilla();
            return animalito;
        }

        public override Carnivoro CrearCarnivoro()
        {
            Carnivoro animalote = new Comadreja();
            return animalote;
        }
    }
}
