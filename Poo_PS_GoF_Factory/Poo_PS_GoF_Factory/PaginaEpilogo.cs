namespace Poo_PS_GoF_Factory
{
    public class PaginaEpilogo : Pagina
    {
        public override string Informacion()
        {
            string informacion = $"Esta es una página de epilogo";
            return informacion;
        }
    }
}