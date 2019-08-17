using System;


namespace HerenciaFiguras
{
    class Figura
    {
        //Atributos de la clase
        protected int centroX, centroY;

        //Constructor de la clase
        public Figura()
        {
            centroX = 0;
            centroY = 0;
        }

        /// <summary>
        /// Obtiene o establece el componente en X del centro de la figura
        /// </summary>
        public int CentroX
        {
            get { return centroX; }
            set { centroX = value; }
        }

        /// <summary>
        /// Obtiene o establece el componente en X del centro de la figura
        /// </summary>
        public int CentroY
        {
            get { return centroY; }
            set { centroY = value; }
        }

        /// <summary>
        /// Obtiene información sobre la figura
        /// </summary>
        /// <returns>Información sobre los párametros de la figura</returns>
        public virtual string Info()
        {
            string resultado = "La figura tiene centro en (" + centroX + "," + centroY + ")";

            return resultado;
        }

        /// <summary>
        /// Obtiene la información sobre el área de la figura
        /// </summary>
        /// <returns></returns>
        public string ObtieneArea()
        {
            string mensaje = "No hay información suficiente para calcular el área";
            return mensaje;
        }
    }
}
