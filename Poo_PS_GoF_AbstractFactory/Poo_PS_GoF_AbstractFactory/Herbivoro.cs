namespace Poo_PS_GoF_AbstractFactory
{
    public abstract class Herbivoro : Animal
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
        abstract public string Alimentarse();
    }
}
