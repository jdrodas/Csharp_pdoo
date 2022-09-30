namespace Poo_PS_FabricaAbstracta
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

        //propiedades
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
