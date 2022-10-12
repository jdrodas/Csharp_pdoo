using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FactoryMethod
{
    internal class DocumentoLibro : Documento
    {
        public override void CrearPaginas()
        {
            //Paginas que debería tener libro:
            LasPaginas.Add(new PaginaIndice() { Titulo = "El indice" });
            LasPaginas.Add(new PaginaPrologo() { Titulo = "El Prólogo" });
            LasPaginas.Add(new PaginaCapitulo() { Titulo = "EL capitulo inicial y aburrido" });
            LasPaginas.Add(new PaginaCapitulo() { Titulo = "EL capitulo donde todo pasa" });
            LasPaginas.Add(new PaginaCapitulo() { Titulo = "El capítulo donde nos decepcionamos con el final" });
            LasPaginas.Add(new PaginaEpilogo() { Titulo = "La parte rescatable del libro!" });
        }
    }
}
