namespace Poo_PS_Builder
{
    public class ConstructorPatineta : ConstructorVehiculo
    {
        //Constructor de la clase
        public ConstructorPatineta()
        {
            elVehiculo = new Vehiculo("Patineta Pulsar");
        }

        public override void ConstruirChasis()
        {
            elVehiculo["chasis"] = "Chasis de patineta china";
        }

        public override void ConstruirMotor()
        {
            elVehiculo["motor"] = "No tiene motor, a pata!";
        }

        public override void ConstruirPuertas()
        {
            elVehiculo["puertas"] = "Sin puertas, siente la brisa... y la lluvia!";
        }

        public override void ConstruirRuedas()
        {
            elVehiculo["ruedas"] = "2 ruedas que no se pinchan!";
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
