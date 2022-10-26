
using System.Text;

namespace Poo_PS_GoF_Facade
{
    public class EntidadCrediticia
    {
        //atributos de la clase
        private Cliente elCliente;
        private DepartamentoCredito elDeptoCredito;
        private DepartamentoMontos elDeptoMontos;
        private DepartamentoJuridico elDeptoJuridico;

        //El Constructor de la clase
        public EntidadCrediticia(string nombre, float valorPrestamo,
        float valorCesantias, int puntajeDataCredito)
        {
            elCliente = new Cliente(nombre, valorPrestamo,valorCesantias, puntajeDataCredito);
            elDeptoCredito = new DepartamentoCredito();
            elDeptoMontos = new DepartamentoMontos();
            elDeptoJuridico = new DepartamentoJuridico();
        }
        
        public bool ValidaInfoCliente()
        {
            bool resultado = false;

            if (elCliente.Nombre is null ||
                elCliente.ValorPrestamo <= 0 ||
                elCliente.ValorCesantias <= 0 ||
                elCliente.PuntajeDataCredito <= 0)
            {
                resultado = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(elCliente.Nombre) &&
                                elCliente.ValorPrestamo > 0 &&
                                elCliente.ValorCesantias > 0 &&
                                elCliente.PuntajeDataCredito > 0)
                    resultado = true;

                else
                    resultado = false;
            }
            return resultado;
        }

        public void EstudiaCredito()
        {
            //Evaluamos la reputación crediticia
            elDeptoCredito.AsignaReputacion(elCliente);

            //Calculamos el monto maximo del préstamo
            elDeptoMontos.AsignaMontoMaximo(elCliente);

            //Finalmente, evaluamos si la solicitud se puede aprobar
            elDeptoJuridico.AsignaEstadoSolicitud(elCliente);
        }

        public string ObtieneResultadoValidacion()
        {
            StringBuilder resultado = new StringBuilder();

            resultado.Append($"El cliente {elCliente.Nombre} ha solicitado un crédito " +
                $"por un valor de {elCliente.ValorPrestamo.ToString("C")}" + Environment.NewLine);

            resultado.Append(Environment.NewLine + $"El Departamento de Créditos dice que " +
                $"el puntaje de datacredito {elCliente.PuntajeDataCredito} le da una reputación" +
                $" crediticia de {elCliente.ReputacionCredito}" + Environment.NewLine);

            resultado.Append(Environment.NewLine + $"El Departamento de Montos dice que " +
                $"el valor de cesantías {elCliente.ValorCesantias.ToString("C")} en conjunto con " +
                $"la reputación crediticia {elCliente.ReputacionCredito}, le permite " +
                $"un monto máximo de {elCliente.MontoMaximo.ToString("C")}" + Environment.NewLine);

            resultado.Append(Environment.NewLine + "El Departamento juridico dice que la solicitud está: ");

            if (elCliente.EstadoSolicitud)
                resultado.Append("APROBADA! :-) ");
            else
                resultado.Append("RECHAZADA! :_( ");

            return resultado.ToString();
        }
    }
}