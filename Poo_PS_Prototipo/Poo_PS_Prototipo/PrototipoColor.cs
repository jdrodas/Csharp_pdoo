using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Prototipo
{
    public abstract class PrototipoColor
    {
        public abstract PrototipoColor Clonar();

        public string Nombre { get; set; }
    }
}
