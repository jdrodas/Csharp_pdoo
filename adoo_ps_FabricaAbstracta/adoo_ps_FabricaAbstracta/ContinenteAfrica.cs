using System;

namespace adoo_ps_FabricaAbstracta
{
    class ContinenteAfrica:Continente
    {
        public override Herbivoro CrearHerbivoro()
        {
            Herbivoro animalito = new Gacela();
            return animalito;
        }

        public override Carnivoro CrearCarnivoro()
        {
            Carnivoro animalote = new Leon();
            return animalote;
        }
    }
}
