namespace Poo_PS_GoF_Iterator
{
    public interface IIteradorAbstracto
    {
        Lamina Primera();
        Lamina Siguiente();
        bool EstaTerminado { get; }
        Lamina LaminaActual { get; }
    }
}
