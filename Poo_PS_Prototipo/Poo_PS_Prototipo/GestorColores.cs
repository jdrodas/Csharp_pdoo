using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Prototipo
{
    public class GestorColores
    {
        private Dictionary<string, PrototipoColor> losColores;

        public GestorColores()
        {
            losColores = new Dictionary<string, PrototipoColor>();
        }

        //Propiedad para acceder y asignar valores al diccionario
        public PrototipoColor this[string llave]
        {
            get { return losColores[llave]; }
            set 
            { 
                losColores.Add(llave, value);
                losColores[llave].Nombre = llave;
            }
        }
    }
}
