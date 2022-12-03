namespace HerenciaFiguras
{
    public class Figura
    {
        //Atributos
        protected int _centroX, _centroY;

        /// <summary>
        /// Constructor Predeterminado de la clase
        /// </summary>
        public Figura()
        {
            _centroX = 0;
            _centroY = 0;
        }

        /// <summary>
        /// Sobrecarga del constructor con parametros
        /// </summary>
        /// <param name="centroX">Componente x del centro</param>
        /// <param name="centroY">Componente y del centro</param>
        public Figura(int centroX, int centroY)
        {
            this._centroX = centroX;
            this._centroY = centroY;
        }

        /// <summary>
        /// Obtiene o establece el componente en X del centro de la figura
        /// </summary>
        public int CentroX
        {
            get { return _centroX; }
            set { _centroX = value; }
        }

        /// <summary>
        /// Obtiene o establece el componente en X del centro de la figura
        /// </summary>
        public int CentroY
        {
            get { return _centroY; }
            set { _centroY = value; }
        }

        /// <summary>
        /// Obtiene la información detallada de la figura
        /// </summary>
        /// <returns>la información</returns>
        public virtual string Informacion()
        {
            string informacion = $"Esta figura tiene centro en ({_centroX},{_centroY})";
            return informacion;
        }

        /// <summary>
        /// Obtiene la información sobre el área de la figura
        /// </summary>
        /// <returns></returns>
        public string AreaFigura()
        {
            return ("Información insuficiente para calcular el area");
        }
    }
}
