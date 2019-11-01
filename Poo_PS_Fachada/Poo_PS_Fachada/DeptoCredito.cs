using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Fachada
{
    class DeptoCredito
    {
        //Asigna reputación basado en el puntaje de DataCredito
        public void AsignaReputacion(Cliente unCliente)
        {
            if (unCliente.PuntajeDataCredito > 800)
                unCliente.ReputacionCredito = "A";

            if (unCliente.PuntajeDataCredito > 600 && unCliente.PuntajeDataCredito <=800)
                unCliente.ReputacionCredito = "B";

            if (unCliente.PuntajeDataCredito > 400 && unCliente.PuntajeDataCredito <= 600)
                unCliente.ReputacionCredito = "C";

            if (unCliente.PuntajeDataCredito <= 400)
                unCliente.ReputacionCredito = "D";
        }
    }
}
