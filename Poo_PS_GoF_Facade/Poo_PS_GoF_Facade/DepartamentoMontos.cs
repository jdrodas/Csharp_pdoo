namespace Poo_PS_GoF_Facade
{
    public class DepartamentoMontos
    {
        public void AsignaMontoMaximo(Cliente unCliente)
        {
            switch (unCliente.ReputacionCredito)
            {
                case "A":
                    unCliente.MontoMaximo = 2f * unCliente.ValorCesantias;
                    break;

                case "B":
                    unCliente.MontoMaximo = 1.5f * unCliente.ValorCesantias;
                    break;

                case "C":
                    unCliente.MontoMaximo = 1f * unCliente.ValorCesantias;
                    break;

                case "D":
                    unCliente.MontoMaximo = 0f;
                    break;
            }
        }
    }
}