using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FactoryMethod
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