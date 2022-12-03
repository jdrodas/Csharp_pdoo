namespace HerenciaFiguras
{
    class Triangulo : Figura
    {
        private int _altura, _base;

        /// <summary>
        /// Constructor predeterminado de la clase
        /// </summary>
        public Triangulo()
        {
            _centroX = 0;
            _centroY = 0;
            _altura = 0;
            _base = 0;
        }

        /// <summary>
        /// Constructor de la clase con parámetros del centro 
        /// </summary>
        /// <param name="p_centroX"></param>
        /// <param name="p_centroY"></param>
        /// <param name="p_base"></param>
        /// <param name="p_altura"></param>
        public Triangulo(int p_centroX, int p_centroY, int p_base, int p_altura)
        {
            _centroX = p_centroX;
            _centroY = p_centroY;
            _base = p_base;
            _altura = p_altura;
        }

        /// <summary>
        /// Obtiene o establece el valor de la base del triángulo
        /// </summary>
        public int Base
        {
            get { return _base; }
            set { _base = value; }
        }

        /// <summary>
        /// Obtiene o establece el valor de la altura del triángulo
        /// </summary>
        public int Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        /// <summary>
        /// Obtiene la información general sobre el triángulo
        /// </summary>
        /// <returns></returns>
        //public override string Info()
        //{
        //    string resultado = base.Info() +
        //        "\nEl triángulo tiene base " + v_base +
        //        " y altura " + v_altura + "\nEs de tipo: " + v_tipo ;

        //    return resultado;
        //}


        public override string Informacion()
        {
            string informacion = $"Este Triangulo tiene centro en ({_centroX},{_centroY})," +
                $" tiene base: {_base} y altura: {_altura}";
            return informacion;
        }


        /// <summary>
        /// Obtiene el área del triángulo
        /// </summary>
        /// <returns>frase describiendo el resultado</returns>
        public new string AreaFigura()

        {
            //Para un triangulo
            float area = (1f * _base * _altura) / 2;

            string informacionArea = $"Area: {area.ToString("0.000")}";
            return informacionArea;
        }
    }
}
