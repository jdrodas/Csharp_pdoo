﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FabricaAbstracta
{
    public class ContinenteAfrica : Continente
    {
        public override Herbivoro CrearHerbivoro()
        {
            Herbivoro animalTragon = new Gacela();
            return animalTragon;
        }

        public override Carnivoro CrearCarnivoro()
        {
            Carnivoro animalTragado = new Leon();
            return animalTragado;
        }
    }
}
