using System;

namespace ex01_VentaConsolas
{
    class Pedido
    {
        //atributos de la clase
        private string ciudad, consola;
        private DateTime fecha;

        //Constructor de la clase
        public Pedido()
        {
            ciudad = "";
            consola = "";
            fecha = new DateTime();
        }

        //propiedades para los atributos
        public String Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        public String Consola
        {
            get { return consola; }
            set { consola = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
