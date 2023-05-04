namespace Poo_PS_GoF_Iterator
{
    public class Album : IColeccionAbstracta
    {
        List<Lamina> lasLaminas = new List<Lamina>();
        public Iterador CrearIterador()
        {
            return new Iterador(this);
        }

        public string? Nombre {get; set;}

        public int Cantidad
        {
            get { return lasLaminas.Count; }
        }
        public Lamina this[int index]
        {
            get { return lasLaminas[index]; }
            set { lasLaminas.Add(value); }
        }
    }
}
