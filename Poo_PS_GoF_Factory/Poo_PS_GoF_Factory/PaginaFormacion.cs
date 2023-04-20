namespace Poo_PS_GoF_Factory
{
    internal class PaginaFormacion : Pagina
    {
        public override string Informacion()
        {
            string informacion = $"Esta es una página de la formación";
            return informacion;
        }
    }
}