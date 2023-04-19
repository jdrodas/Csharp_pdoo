namespace Poo_PS_GoF_Builder
{
    public class ConstructorMotocicleta : ConstructorVehiculo
    {
        //Constructor de la clase
        public ConstructorMotocicleta()
        {
            elVehiculo = new Vehiculo("Motocicleta");
        }

        public override void ConstruirChasis()
        {
            elVehiculo!["chasis"] = "Chasis de motocicleta";
        }

        public override void ConstruirMotor()
        {
            elVehiculo!["motor"] = "1000 cc V8";
        }

        public override void ConstruirPuertas()
        {
            elVehiculo!["puertas"] = "sin puertas";
        }

        public override void ConstruirRuedas()
        {
            elVehiculo!["ruedas"] = "2 ruedas Michelin";
        }

        public override void InvocarConstructorPartes()
        {
            ConstruirChasis();
            ConstruirMotor();
            ConstruirPuertas();
            ConstruirRuedas();
        }
    }
}