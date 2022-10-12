using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FactoryMethod
{
    abstract public class Documento
    {
        private List<Pagina> lasPaginas;
        private string nombre;

        public Documento()
        {
            nombre = "";
            lasPaginas = new List<Pagina>();
            CrearPaginas();
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //Obtiene la colección de Paginas de libro
        public List<Pagina> LasPaginas
        {
            get { return lasPaginas; }
        }

        /// <summary>
        /// Factory Method del patrón para construir las páginas del documento
        /// </summary>
        abstract public void CrearPaginas();
    }
}
