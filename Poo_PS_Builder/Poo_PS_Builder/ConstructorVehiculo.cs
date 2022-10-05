using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Builder
{
    public abstract class ConstructorVehiculo
    {
        //Atributos
        protected Vehiculo elVehiculo;

        //propiedad que retorna el atributo
        public Vehiculo ElVehiculo
        {
            get { return elVehiculo; }
        }

        public abstract void ConstruirChasis();
        public abstract void ConstruirMotor();
        public abstract void ConstruirRuedas();
        public abstract void ConstruirPuertas();

        public abstract void InvocarConstructorPartes();
    }
}
