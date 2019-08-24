using System;
using System.Text;

namespace CandidatosTitan
{
    class ControlSimulacion
    {
        private Candidato[] losCandidatos;

        public ControlSimulacion()
        {
            losCandidatos = new Candidato[500];
            InicializaArreglo();
        }

        private void InicializaArreglo()
        {
            Random aleatorio = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < losCandidatos.Length; i++)
            {
                losCandidatos[i] = new Candidato(
                    aleatorio.Next(75, 151),
                    aleatorio.Next(20, 38),
                    aleatorio.Next(5, 21),
                    aleatorio.Next(5, 31));

                losCandidatos[i].ValidaViabilidad();
            }
        }

        public void IniciaSimulacion()
        {
            InicializaArreglo();
        }

        public string ObtieneInfoViables()
        {
            StringBuilder resultado = new StringBuilder();

            int totalViables = 0;
            for (int i = 0; i < losCandidatos.Length; i++)
            {
                if (losCandidatos[i].Viable)
                { 
                    resultado.Append("Candidato No. " + (i + 1) + ": " +
                        losCandidatos[i].InfoPersona() + Environment.NewLine);

                    totalViables++;
                }
            }

            if (totalViables == 0)
                return "Esta simulación fracasó! No hay candidatos viables";
            else
            { 
                resultado.Append("Total viables: " + totalViables + Environment.NewLine);
                return resultado.ToString();
            }
        }
    }
}
