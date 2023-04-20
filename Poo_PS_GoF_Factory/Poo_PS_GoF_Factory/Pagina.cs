namespace Poo_PS_GoF_Factory
{
    abstract public class Pagina
    {
        protected string? titulo;

        public string? Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public abstract string Informacion();
    }
}
