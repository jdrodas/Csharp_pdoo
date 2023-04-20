namespace Poo_PS_GoF_Factory
{
    public class PaginaPrologo : Pagina
    {
        public override string Informacion()
        {
            string informacion = $"Esta es una página de prólogo";
            return informacion;
        }
    }
}