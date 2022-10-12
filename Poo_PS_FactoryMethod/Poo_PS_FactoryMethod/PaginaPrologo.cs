using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FactoryMethod
{
    public class PaginaPrologo : Pagina
    {
        public override string Informacion()
        {
            string informacion = $"Esta es una página de prólogo";
            return informacion;
        }
    }
}