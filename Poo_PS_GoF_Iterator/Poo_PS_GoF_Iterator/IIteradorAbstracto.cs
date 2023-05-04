namespace Poo_PS_GoF_Iterator
{
    public interface IIteradorAbstracto
    {
        public Lamina Primera();
        public Lamina Siguiente();
        public bool EstaTerminado { get; }
        public Lamina LaminaActual { get; }
    }
}
