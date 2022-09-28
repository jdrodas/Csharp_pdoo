using System;

namespace Poo_PS_Singleton
{
    public class AsignaEstacionador
    {
        //Atributo de la clase
        static AsignaEstacionador estacionador;
        static Random aleatorio;
        private string espacio;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public AsignaEstacionador()
        {
            aleatorio = new Random(DateTime.Now.Millisecond);
            string[] letras = { "A", "B", "C", "D", "E", "F", "G", "H"};

            espacio = letras[aleatorio.Next(letras.Length)] + 
                aleatorio.Next(10);
        }

        /// <summary>
        /// Obtiene la instancia utilizando el patrón Singleton
        /// </summary>
        /// <returns>instancia de la clase</returns>
        public static AsignaEstacionador ObtieneEspacioParqueo()
        {
            //Si no hay instancia creada, se hace una nueva instancia
            if(estacionador == null)
                estacionador = new AsignaEstacionador();

            return estacionador;
        }

        /// <summary>
        /// Obtiene el valor del espacio de parqueo
        /// </summary>
        public string Espacio
        {
            get { return espacio; }
        }
    }
}
