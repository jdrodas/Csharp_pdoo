namespace Poo_PS_GoF_ChainOfResponsibility
{
    public class Pedido
    {
        //atributos de la clase
        private string aprobador;
        private int valor;

        //constructor de la clase
        public Pedido()
        {
            aprobador = "sin aprobación";
            valor = 0;
        }

        //Propiedades para los atributos
        public string Aprobador
        {
            get { return aprobador; }
            set { aprobador = value; }
        }

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}