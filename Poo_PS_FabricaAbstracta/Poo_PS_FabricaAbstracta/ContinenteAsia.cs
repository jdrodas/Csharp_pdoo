using System;

namespace Poo_PS_FabricaAbstracta
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
