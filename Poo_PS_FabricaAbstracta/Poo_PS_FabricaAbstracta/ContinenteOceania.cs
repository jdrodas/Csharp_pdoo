using System;

namespace Poo_PS_FabricaAbstracta
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
