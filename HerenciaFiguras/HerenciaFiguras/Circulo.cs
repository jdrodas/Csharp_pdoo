using System;


namespace HerenciaFiguras
{
    class Circulo : Figura
    {
        private int radio;

        public Circulo()
        {
            radio = 0;
        }

        public Circulo(int p_radio)
        {
            radio = p_radio;
        }

        public int Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public override string Info()
        {
            string resultado = base.Info() +
                "\nEl circulo tiene radio " + radio +
                "\n" + ObtieneArea();

            return resultado;
        }

        public new string ObtieneArea()
        {
            double area = Math.PI * Math.Pow(radio, 2);
            string mensaje = "El area del circulo es " + area.ToString("0.0000"); ;

            return mensaje;
        }
    }
}
