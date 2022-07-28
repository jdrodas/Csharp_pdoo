using System;


namespace MonitoreoQuebradas
{
    public class Quebrada
    {
        //Zona de atrrributos
        private string nombre;
        private int caudal;
        private bool estadoCritico;

        //Zona de Constructor de la clase
        public Quebrada()
        {
            nombre = "";
            caudal = 0;
            estadoCritico = false;
        }
        
        //Zona de propiedades
        
        /// <summary>
        /// Obtiene o establece el valor del nombre de la quebrada
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        /// <summary>
        /// Obtiene o establece el valor del caudal de la quebrada
        /// </summary>
        public int Caudal
        {
            get { return caudal; }
            set
            {
                caudal = value;

                if (caudal > 80)
                    estadoCritico = true;
                else
                    estadoCritico = false;
            }
        }

        /// <summary>
        /// Obtiene el valor del atributo de estado crítico de la quebrada
        /// </summary>
        public bool EstadoCritico
        {
            get { return estadoCritico; }
            
        }

        /// <summary>
        /// Obtiene la información general de la quebrada
        /// </summary>
        /// <returns>La información de la quebrada</returns>
        public string GetInfo()
        {
            string informacion = $"Nombre: {nombre}, Caudal: {caudal}%, estado crítico: {estadoCritico}";
            return informacion;
        }
    }
}
