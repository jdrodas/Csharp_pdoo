using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_GoF_Observer
{
    internal class Euro : Divisa
    {
        public Euro(string abreviatura, double valor)
        {
            this.abreviatura = abreviatura;
            this.valor = valor;
        }
    }
}