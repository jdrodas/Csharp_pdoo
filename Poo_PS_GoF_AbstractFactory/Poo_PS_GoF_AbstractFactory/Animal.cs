namespace Poo_PS_GoF_AbstractFactory
{
    public abstract class Animal
    {
        //atributos
        protected string nombre;
        protected string especie;

        public Animal()
        {
            nombre = "";
            especie = "";
        }

        //propiedades definidas abstractas
        abstract public string Nombre
        {
            get;set;
        }

        abstract public string Especie
        {
            get; set;
        }
    }
}
