using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_GoF_Builder
{
    internal class ConstructorHibrido : ConstructorVehiculo
    {
        //Constructor de la clase
        public ConstructorHibrido()
        {
            elVehiculo = new Vehiculo("Automovil");
        }

        public override void ConstruirChasis()
        {
            elVehiculo!["chasis"] = "Chasis reforzado multimotor";
        }

        public override void ConstruirMotor()
        {
            elVehiculo!["motor gasolina"] = "1500 cc";
            elVehiculo!["motor eléctrico"] = "200 KVh";
        }

        public override void ConstruirPuertas()
        {
            elVehiculo!["puertas"] = "4 puertas";
        }

        public override void ConstruirRuedas()
        {
            elVehiculo!["ruedas"] = "4 ruedas de alto desempeño";
        }

        public void ConstruirExtintor()
        {
            elVehiculo!["extintor"] = "Extintor multipropósito";
        }

        public override void InvocarConstructorPartes()
        {
            ConstruirExtintor();
            ConstruirChasis();
            ConstruirMotor();
            ConstruirPuertas();
            ConstruirRuedas();
        }
    }
}