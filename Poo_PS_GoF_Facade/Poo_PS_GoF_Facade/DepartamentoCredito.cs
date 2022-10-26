namespace Poo_PS_GoF_Facade
{
    public class DepartamentoCredito
    {
        public void AsignaReputacion(Cliente unCliente)
        {
            if (unCliente.PuntajeDataCredito > 800)
                unCliente.ReputacionCredito = "A";

            if (unCliente.PuntajeDataCredito > 600 && unCliente.PuntajeDataCredito <= 800)
                unCliente.ReputacionCredito = "B";

            if (unCliente.PuntajeDataCredito > 400 && unCliente.PuntajeDataCredito <= 600)
                unCliente.ReputacionCredito = "C";

            if (unCliente.PuntajeDataCredito <= 400)
                unCliente.ReputacionCredito = "D";
        }
    }
}
