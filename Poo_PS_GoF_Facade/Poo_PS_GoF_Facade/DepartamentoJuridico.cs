
namespace Poo_PS_GoF_Facade
{
    public class DepartamentoJuridico
    {
        public void AsignaEstadoSolicitud(Cliente unCliente)
        {
            if (unCliente.ValorPrestamo <= unCliente.MontoMaximo)
                unCliente.EstadoSolicitud = true;
            else
                unCliente.EstadoSolicitud = false;
        }
    }
}
