namespace Poo_PS_GoF_Iterator
{
    public class Iterador : IIteradorAbstracto
    {
        Album unaColeccion;
        int actual = 0;
        int incremento = 1;

        public Iterador(Album laColeccion)
        {
            this.unaColeccion = laColeccion;
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
