using System;

namespace HerenciaFiguras
{
    class Triangulo : Figura
    {
        //Atributos de la clase
        private string v_tipo;
        private int v_base;
        private float v_altura;

        /// <summary>
        /// Constructor básico de la clase Triángulo
        /// </summary>
        public Triangulo()
        {
            v_tipo = "";
            v_base = 0;
            v_altura = 0;
            centroX = 10;
            centroY = 10;
        }

        /// <summary>
        /// Constructor de la clase con parámetros del centro
        /// </summary>
        /// <param name="p_cx"> Parámetro x</param>
        /// <param name="p_cy"> Parámetro y</param>
        public Triangulo(int p_cx, int p_cy)
        {
            v_tipo = "";
            v_base = 0;
            v_altura = 0;
            centroX = p_cx;
            centroY = p_cy;
        }
        /// <summary>
        /// Constructor con datos de tipo, centro, altura y base
        /// </summary>
        /// <param name="p_tipo">tipo de triangulo</param>
        /// <param name="p_altura">altura del triangulo</param>
        /// <param name="p_base">base del triangulo</param>
        /// <param name="p_cx">coordenada x del centro</param>
        /// <param name="p_cy">coordenada y del centro</param>
        public Triangulo(string p_tipo, int p_altura, int p_base, int p_cx, int p_cy)
        {
            v_tipo = p_tipo;
            v_base = p_base;
            v_altura = p_altura;
            centroX = p_cx;
            centroY = p_cy;
        }

        /// <summary>
        /// Obtiene o establece el componente en tipo de triángulo
        /// </summary>
        public string V_tipo
        {
            get { return v_tipo; }
            set { v_tipo = value; }
        }

        /// <summary>
        /// Obtiene o establece el valor de la base del triángulo
        /// </summary>
        public int V_base
        {
            get { return v_base; }
            set { v_base = value; }
        }

        /// <summary>
        /// Obtiene o establece el valor de la altura del triángulo
        /// </summary>
        public float V_altura
        {
            get { return v_altura; }
            set { v_altura = value; }
        }

        /// <summary>
        /// Obtiene la información general sobre el triángulo
        /// </summary>
        /// <returns></returns>
        public override string Info()
        {
            string resultado = base.Info() +
                "\nEl triángulo tiene base " + v_base +
                " y altura " + v_altura + "\nEs de tipo: " + v_tipo ;

            return resultado;
        }

        /// <summary>
        /// Obtiene el área del triángulo
        /// </summary>
        /// <returns>frase describiendo el resultado</returns>
        public new string ObtieneArea()
        {
            float area = (1f * v_base * v_altura) / 2;

            string mensaje = "El area del triángulo es " + area.ToString("0.00");
            return mensaje;
        }
    }
}
