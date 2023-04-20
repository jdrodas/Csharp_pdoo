namespace Poo_PS_GoF_Factory
{
    public class PaginaExperiencia : Pagina   
    {
        public override string Informacion()
        {
            string informacion = $"Esta es una página de experiencias";
            return informacion;
        }
    }
}
