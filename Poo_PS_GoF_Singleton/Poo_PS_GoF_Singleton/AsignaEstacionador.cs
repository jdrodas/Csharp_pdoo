using System;

namespace Poo_PS_GoF_Singleton
{
    public class AsignaEstacionador
    {
        //Se utiliza el simbolo "?" después del tipo de dato para indicar al compilador
        //que esa variable puede ser nula
        //Para .NET 5 o superior
        private static AsignaEstacionador? estacionador;
        private static Random? aleatorio;
        private readonly string espacio;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public AsignaEstacionador()
        {
            aleatorio = new Random(DateTime.Now.Millisecond);
            string[] letras = { "A", "B", "C", "D", "E", "F", "G", "H" };

            espacio = letras[aleatorio.Next(letras.Length)] +
                aleatorio.Next(10);
        }

        /// <summary>
        /// Obtiene la instancia utilizando el patrón Singleton
        /// </summary>
        /// <returns>instancia de la clase</returns>
        public static AsignaEstacionador ObtieneEstacionador()
        {
            //Si no hay instancia creada, se hace una nueva instancia
            if (estacionador == null)
                estacionador = new AsignaEstacionador();

            return estacionador;
        }

        /// <summary>
        /// Obtiene el valor del espacio de parqueo
        /// </summary>
        public string GetEspacio()
        {
            return espacio; 
        }
    }
}
