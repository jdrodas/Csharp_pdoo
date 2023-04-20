namespace Poo_PS_GoF_Factory
{
    public class DocumentoHojaDeVida : Documento
    {
        public override void CrearPaginas()
        {
            LasPaginas.Add(new PaginaHabilidades() { Titulo = "Habilidades de Fulanito" });
            LasPaginas.Add(new PaginaExperiencia() { Titulo = "Experiencia laboral de Fulanito" });
            LasPaginas.Add(new PaginaFormacion() { Titulo = "Los cursos que ha hecho Fulanito" });
        }
    }
}
