using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_GoF_Observer
{
    public class Dolar : Divisa
    {
        public Dolar(string abreviatura, double valor)
        {
            this.abreviatura = abreviatura;
            this.valor = valor;
        }        
    }
}
