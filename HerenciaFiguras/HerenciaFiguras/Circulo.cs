using System;

namespace HerenciaFiguras
{
    public class Circulo : Figura
    {
        private int _radio;

        //Constructor predeterminado de la clase
        public Circulo()
        {
            _radio = 0;
            _centroX = 0;
            _centroY = 0;
        }

        /// <summary>
        /// Constructor sobrecargado con parámetro radio
        /// </summary>
        /// <param name="p_radio"></param>
        public Circulo(int p_radio)
        {
            _radio = p_radio;
            _centroX = 0;
            _centroY = 0;
        }

        /// <summary>
        /// Constructor sobrecargado con todos los parámetros
        /// </summary>
        /// <param name="radio">Valor del radio</param>
        /// <param name="centroX">Valor componente X del centro</param>
        /// <param name="centroY">Valor componente X del centro</param>
        /// <param name=""></param>
        public Circulo(int radio, int centroX, int centroY)
        {
            _radio = radio;
            _centroX = centroX;
            _centroY = centroY;
        }

        /// <summary>
        /// Obtiene o establece el valor del atributo radio
        /// </summary>
        public int Radio
        {
            get { return _radio; }
            set { _radio = value; }
        }

        /// <summary>
        /// Obtiene la información detallada del circulo
        /// </summary>
        /// <returns>la información</returns>
        public override string Informacion()
        {
            string informacion = $"Este Circulo tiene centro en ({_centroX},{_centroY})" +
                $" y tiene radio {_radio}";
            return informacion;
        }

        /// <summary>
        /// Obtiene la información detallada del circulo
        /// </summary>
        public void Informacion(ref string informacion)
        {
            informacion = base.Informacion() +
            $"\nEsta figura es un círculo con radio {_radio}";
        }

        /// <summary>
        /// Obtiene información sobre el área de la figura
        /// </summary>
        /// <returns>Datos sobre el area de la figura</returns>
        public new string AreaFigura()
        {
            //Para un circulo
            double area = Math.PI * Math.Pow(_radio, 2);
            string informacionArea = $"Area: {area.ToString("0.000")}";

            return informacionArea;
        }
    }
}
