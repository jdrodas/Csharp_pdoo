namespace Poo_PS_GoF_Builder
{
    public class ConstructorAutomovil : ConstructorVehiculo
    {
        //Constructor de la clase
        public ConstructorAutomovil()
        {
            elVehiculo = new Vehiculo("Automovil");
        }

        public override void ConstruirChasis()
        {
            elVehiculo!["chasis"] = "Chasis de automovil sedan";
        }

        public override void ConstruirMotor()
        {
            elVehiculo!["motor"] = "1500 cc";
        }

        public override void ConstruirPuertas()
        {
            elVehiculo!["puertas"] = "4 puertas";
        }

        public override void ConstruirRuedas()
        {
            elVehiculo!["ruedas"] = "4 ruedas rin deportivo";
        }

        public void ConstruirExtintor()
        {
            elVehiculo!["extintor"] = "Extintor de propósito general";
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
