using System;
using System.Text;

namespace Poo_PS_Fachada
{
    class EntidadCrediticia
    {
        //atributos de la clase
        private Cliente elCliente;
        private DeptoCredito elDeptoCredito;
        private DeptoMontos elDeptoMontos;
        private DeptoJuridico elDeptoJuridico;

        //El Constructor de la clase
        public EntidadCrediticia()
        {
            elCliente = new Cliente();
            elDeptoCredito = new DeptoCredito();
            elDeptoMontos = new DeptoMontos();
            elDeptoJuridico = new DeptoJuridico();
        }

        /// <summary>
        /// Función para Ingresar los datos del cliente
        /// </summary>
        /// <param name="nombre">Nombre del cliente</param>
        /// <param name="valorPrestamo">Cuanta plata va a gastar</param>
        /// <param name="valorCesantias">Con que lo va a pagar si se quiebra</param>
        /// <param name="puntajeDataCredito">Como ha sido su historia crediticia</param>
        public void AsignaInfoCliente(string nombre, float valorPrestamo,
            float valorCesantias, int puntajeDataCredito)
        {
            elCliente.Nombre = nombre;
            elCliente.ValorPrestamo = valorPrestamo;
            elCliente.ValorCesantias = valorCesantias;
            elCliente.PuntajeDataCredito = puntajeDataCredito;
        }

        public bool ValidaInfoCliente()
        {
            bool resultado;

            if (elCliente.ValorPrestamo <= 0 ||
                elCliente.ValorCesantias <= 0 ||
                elCliente.PuntajeDataCredito <= 0)
                resultado = false;
            else
                resultado = true;

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

            resultado.Append("El cliente " + elCliente.Nombre + " ha solicitado un crédito por un valor de " + 
                elCliente.ValorPrestamo + Environment.NewLine);

            resultado.Append(Environment.NewLine + "El Departamento de Créditos dice que el puntaje de datacredito " + elCliente.PuntajeDataCredito +
                " le da una reputación crediticia de " + elCliente.ReputacionCredito + Environment.NewLine);

            resultado.Append(Environment.NewLine + "El Departamento de Montos dice que el valor de cesantías " + 
                elCliente.ValorCesantias +
                " en conjunto con la reputación crediticia " + elCliente.ReputacionCredito + ", le permite un monto máximo de " +
                elCliente.MontoMaximo.ToString("0.00") + Environment.NewLine);

            resultado.Append(Environment.NewLine + "El Departamento juridico dice que la solicitud está: ");

            if (elCliente.EstadoSolicitud)
                resultado.Append("APROBADA! :-) ");
            else
                resultado.Append("RECHAZADA! :_( ");

            return resultado.ToString();
        }

    }
}
