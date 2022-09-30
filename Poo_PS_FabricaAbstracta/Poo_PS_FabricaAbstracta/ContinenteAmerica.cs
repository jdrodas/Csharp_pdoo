using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FabricaAbstracta
{
    public class ContinenteAmerica : Continente
    {
        public override Carnivoro CrearCarnivoro()
        {
            Carnivoro animalTragon = new Chupacabras();
            return animalTragon;
        }

        public override Herbivoro CrearHerbivoro()
        {
            Herbivoro animalTragado = new Cabra();
            return animalTragado;
        }
    }
}
