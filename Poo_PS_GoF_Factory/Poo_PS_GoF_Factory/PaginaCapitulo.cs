namespace Poo_PS_GoF_Factory
{
    public class PaginaCapitulo : Pagina
    {
        public override string Informacion()
        {
            string informacion = $"Esta es una página de capitulo";
            return informacion;
        }
    }
}
