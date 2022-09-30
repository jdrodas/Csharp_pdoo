namespace Poo_PS_FabricaAbstracta
{
    public abstract class Carnivoro : Animal
    {
        //propiedades
        public override string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public override string Especie
        {
            get { return especie; }
            set { especie = value; }
        }

        //Metodos
        abstract public string Cazar(Herbivoro presa);
    }
}

