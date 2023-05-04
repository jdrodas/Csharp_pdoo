namespace Poo_PS_GoF_Iterator
{
    public class Album : IColeccionAbstracta
    {
        List<Lamina> lasLaminas;
        public string? nombre;
        public Iterador CrearIterador()
        {
            return new Iterador(this);
        }

        public Album()
        {
            lasLaminas = new List<Lamina>();
            nombre = string.Empty;
        }

        public string Nombre
        {
            get { return nombre!; }
            set { nombre = value; }
        }

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