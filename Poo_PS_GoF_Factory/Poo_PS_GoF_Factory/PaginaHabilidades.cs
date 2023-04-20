namespace Poo_PS_GoF_Factory
{
    public class PaginaHabilidades: Pagina
    {
        public override string Informacion()
        {
            string informacion = $"Esta es una página de habilidades";
            return informacion;
        }
    }
}
