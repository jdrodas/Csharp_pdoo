using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FabricaAbstracta
{
    public class ContinenteOceania : Continente
    {
        public override Herbivoro CrearHerbivoro()
        {
            Herbivoro animalTragado = new Koala();
            return animalTragado;
        }

        public override Carnivoro CrearCarnivoro()
        {
            Carnivoro animalTragon = new Dingo();
            return animalTragon;
        }
    }
}
