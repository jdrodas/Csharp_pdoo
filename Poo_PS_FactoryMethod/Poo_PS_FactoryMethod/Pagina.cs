using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_FactoryMethod
{
    abstract public class Pagina
    {
        protected string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public abstract string Informacion();
    }
}
