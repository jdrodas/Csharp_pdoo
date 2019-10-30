
namespace adoo_ps_FabricaAbstracta
{
    abstract class Herbivoro
    {
        //atributos de la clase
        protected string nombre;
        protected string especie;

        //propiedades para los atributos
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Especie
        {
            get { return especie; }
        }

        abstract public string Alimentarse();
    }
}
