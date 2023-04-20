namespace Poo_PS_GoF_ChainOfResponsibility
{
    public class Pedido
    {
        //atributos de la clase
        private string aprobador;
        private int valor;
        private string descripcion;

        //constructor de la clase
        public Pedido()
        {
            aprobador = string.Empty;
            descripcion = string.Empty;
            valor = 0;
        }

        //Propiedades para los atributos
        public string Aprobador
        {
            get { return aprobador; }
            set { aprobador = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}