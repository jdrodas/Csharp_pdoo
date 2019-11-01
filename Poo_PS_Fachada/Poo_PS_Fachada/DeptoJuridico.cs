using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Fachada
{
    class DeptoJuridico
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
