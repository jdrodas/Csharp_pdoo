namespace adoo_ps_FabricaAbstracta
{
    abstract class Carnivoro
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

        //Métodos de la clase
        public abstract string Cazar(Herbivoro presa);
    }
}
