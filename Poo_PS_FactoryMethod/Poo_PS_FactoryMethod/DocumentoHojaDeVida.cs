using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FactoryMethod
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
