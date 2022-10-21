namespace Poo_PS_GoF_Builder
{
    public class Tienda
    {
        public Tienda(ConstructorVehiculo unConstructor)
        {
            unConstructor.InvocarConstructorPartes();
        }
    }
}
