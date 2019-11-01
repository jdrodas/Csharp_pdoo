using System;
using System.Text;

namespace Poo_PS_FabricaAbstracta
{
    class MundoAnimal
    {
        //Los atributos de la clase
        private Continente unContinente;
        private Herbivoro unHerbivoro;
        private Carnivoro unCarnivoro;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public MundoAnimal(string nombreContinente, string nombreCarnivoro, string nombreHerbivoro)
        {
            unContinente = SeleccionaContinente(nombreContinente);
            
            unHerbivoro = unContinente.CrearHerbivoro();
            unHerbivoro.Nombre = nombreHerbivoro;

            unCarnivoro = unContinente.CrearCarnivoro();
            unCarnivoro.Nombre = nombreCarnivoro;
        }

        public string ResultadoCadenaAlimenticia()
        {
            StringBuilder resultado = new StringBuilder();

            resultado.Append("En el continente " + unContinente.Nombre + 
                " ocurre lo siguiente:" + Environment.NewLine);
            
            resultado.Append(Environment.NewLine + unHerbivoro.Alimentarse());
            resultado.Append(Environment.NewLine + unCarnivoro.Cazar(unHerbivoro));

            return resultado.ToString();
        }

        private Continente SeleccionaContinente(string nombreContinente)
        {
            Continente resultado;

            switch (nombreContinente)
            {
                case "Africa":
                    resultado = new ContinenteAfrica();
                    resultado.Nombre = "Africa";
                    break;

                case "Asia":
                    resultado = new ContinenteAsia();
                    resultado.Nombre = "Asia";
                    break;

                case "Oceanía":
                    resultado = new ContinenteOceania();
                    resultado.Nombre = "Oceanía";
                    break;

                // De manera predeterminada, injustificada y arbitraria, asignamos el continente Africa
                default:
                    resultado = new ContinenteAfrica();
                    resultado.Nombre = "Africa";
                    break;
            }

            return resultado;
        }

    }
}
