using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo_PS_Singleton
{
    public class AsignaEstacionador
    {
        //La instancia que se estará proporcionando cada vez que se invoque la clase
        //Atributo de la clase
        static AsignaEstacionador estacionador;
        private string espacio;

        //Constructor de la clase
        protected AsignaEstacionador()
        {
            Random aleatorio = new Random(DateTime.Now.Millisecond);
            string[] letras = { "Q", "Z", "H", "M", "A", "L", "G", "N", "X", "E"};

            espacio = letras[aleatorio.Next(letras.Length)] + 
                aleatorio.Next(10);
        }

        public static AsignaEstacionador ObtieneEspacioParqueo()
        {
            //Si no hay instancia creada, se hace una nueva instancia
            if(estacionador == null)
                estacionador = new AsignaEstacionador();

            return estacionador;
        }

        public string Espacio
        {
            get { return espacio; }
        }
    }
}
