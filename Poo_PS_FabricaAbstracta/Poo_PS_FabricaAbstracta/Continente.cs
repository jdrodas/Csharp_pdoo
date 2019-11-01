using System;

namespace Poo_PS_FabricaAbstracta
{
    abstract class Continente
    {
        protected string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public abstract Herbivoro CrearHerbivoro();
        public abstract Carnivoro CrearCarnivoro();
    }
}
