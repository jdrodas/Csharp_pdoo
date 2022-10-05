using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Builder
{
    public class Tienda
    {
        public Tienda(ConstructorVehiculo unConstructor)
        {
            //unConstructor.ConstruirChasis();
            //unConstructor.ConstruirMotor();
            //unConstructor.ConstruirRuedas();
            //unConstructor.ConstruirPuertas();

            unConstructor.InvocarConstructorPartes();
        }
    }
}
