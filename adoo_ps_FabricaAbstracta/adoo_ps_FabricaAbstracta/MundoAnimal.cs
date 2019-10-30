using System;
using System.Text;

namespace adoo_ps_FabricaAbstracta
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
            
            resultado.Append(unHerbivoro.Alimentarse());
            resultado.Append(unCarnivoro.Cazar(unHerbivoro));

            return resultado.ToString();
        }

        private Continente SeleccionaContinente(string nombreContinente)
        {
            //Definimos predeterminadamente, injustificadamente, Africa como el continente inicial
            //Cambia si hay otro valor diferente
            Continente resultado = new ContinenteAfrica();
            resultado.Nombre = "Africa";

            if (nombreContinente == "Africa")
            {
                resultado = new ContinenteAfrica();
                resultado.Nombre = "Africa";
            }

            if (nombreContinente == "Asia")
            {
                resultado = new ContinenteAsia();
                resultado.Nombre = "Asia";
            }

            if (nombreContinente == "Oceanía")
            {
                resultado = new ContinenteOceania();
                resultado.Nombre = "Oceanía";
            }

            return resultado;
        }

    }
}
