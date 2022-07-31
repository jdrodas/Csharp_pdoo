namespace MonitoreoQuebradas
{
    public class Quebrada
    {

        //Definición de Atributos
        private string nombre;
        private int caudal;
        private bool estadoCritico;

        //Definición de Constructor de la clase
        public Quebrada()
        {
            nombre = "";
            caudal = 0;
            estadoCritico = false;
        }

        //Definición de Metodos

        /// <summary>
        /// Obtiene o establece el nombre de la quebrada
        /// </summary>

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Obtiene o establece el caudal de la quebrada
        /// </summary>
        public int Caudal
        {
            get { return caudal; }
            set
            {
                caudal = value;
                //Si el caudal es superior a 80, la quebrada está en estado crítico
                if (caudal > 80)
                    estadoCritico = true;
                else
                    estadoCritico = false;
            }
        }
        /// <summary>
        /// Obtiene el valor del estado critico de la quebrada
        /// </summary>

        public string EstadoCritico
        {
            get
            {
                if (estadoCritico)
                    return "SI";
                else
                    return "NO";
            }
        }

        /// <summary>
        /// Obtiene toda la información de la quebrada
        /// </summary>
        /// <returns>string con los valores de los atributos de la quebrada</returns>
        public string GetInfo()
        {
            string informacion = $"Nombre: {nombre} -" +
                                 $"Caudal: {caudal} -" +
                                 $"Estado Crítico? {EstadoCritico}";
            return informacion;
        }
    }
}

