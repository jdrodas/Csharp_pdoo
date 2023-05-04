namespace Poo_PS_GoF_Iterator
{
    public class Iterador : IIteradorAbstracto
    {
        private Album unaColeccion;
        private int actual;
        private int incremento;

        public Iterador(Album laColeccion)
        {
            this.unaColeccion = laColeccion;
            actual = 0;
            incremento = 1;
        }

        public Lamina Primera()
        {
            actual = 0;
            return unaColeccion[actual] as Lamina;
        }

        public Lamina Siguiente()
        {
            actual += incremento;
            if (!EstaTerminado)
                return unaColeccion[actual] as Lamina;
            else
                return null;
        }

        public int Incremento
        {
            get { return incremento; }
            set { incremento = value; }
        }

        public Lamina LaminaActual
        {
            get { return unaColeccion[actual] as Lamina; }
        }

        public bool EstaTerminado
        {
            get
            {
                if (actual >= unaColeccion.Cantidad)
                    return true;
                else
                    return false;
            }
        }
    }
}